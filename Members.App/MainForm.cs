using Members.App.Commands;
using Members.Core.Commands;
using Members.Core.Observables;
using Members.Core.Repositories;
using Members.Models.Commands;
using Members.Shared.Data.Entities;
using System;
using System.Diagnostics;

namespace Members.App
{
    public partial class MainForm : Form
    {
        public MainForm( IUnitOfWork unitOfWork, IExecutor executor )
        {
            UnitOfWork = unitOfWork;
            Executor   = executor;

            InitializeComponent();
            InitializeCommands( executor );

            LoadData();
        }

        IUnitOfWork UnitOfWork { get; }
        IExecutor   Executor   { get; }

        private void InitializeCommands( IExecutor executor )
        {
            undoToolStripButton.Enabled = false;
            redoToolStripButton.Enabled = false;

            undoToolStripButton.Click += ( s, a ) => executor.Undo();
            redoToolStripButton.Click += ( s, a ) => executor.Redo();

            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;

            undoToolStripMenuItem.Click += ( s, a ) => executor.Undo();
            redoToolStripMenuItem.Click += ( s, a ) => executor.Redo();

            var observable = executor as IObservable;
            if ( observable != null )
            {
                observable.Notify += ( s, a ) => undoToolStripButton.Enabled = executor.HasUndo;
                observable.Notify += ( s, a ) => redoToolStripButton.Enabled = executor.HasRedo;

                observable.Notify += ( s, a ) => undoToolStripMenuItem.Enabled = executor.HasUndo;
                observable.Notify += ( s, a ) => redoToolStripMenuItem.Enabled = executor.HasRedo;
            }
        }

        private void OnExit( object sender, EventArgs e )
        {
            Application.Exit();
        }

        private void OnSave( object sender, EventArgs e )
        {
            UnitOfWork?.SaveChanges();
        }

        private void LoadData()
        {
            foreach ( var person in UnitOfWork.GetRepository<Person>().GetAll() )
            {
                AddMemberNode( peopleTreeView.Nodes, person );
            }

            foreach ( var group in UnitOfWork.GetRepository<Group>().GetAll() )
            {
                UnitOfWork.GetRepository<Group>().Ensure( group, g => g.Members );

                var node = AddMemberNode(groupsTreeView.Nodes, group);
                foreach ( var person in group.Members )
                {
                    AddMemberNode( node.Nodes, person );
                }
            }
        }

        private TreeNode AddMemberNode( TreeNodeCollection nodes, Member member )
        {
            var node = nodes.Add(member.Name);
            node.ImageKey = node.SelectedImageKey = member.GetType().Name;
            node.Tag = member;

            member.Notify += ( s, a ) => node.Text = member.Name;

            return node;
        }

        private void OnAddPerson( object sender, EventArgs e )
        {
            var dialog = new PromptForm( "Create Person", "Name:" );

            if ( dialog.ShowDialog( this ) == DialogResult.OK )
            {
                var person = UnitOfWork?.GetRepository<Person>()?.Create();
                Debug.Assert( person != null, "person != null" );

                person.Name = dialog.Value;
                UnitOfWork?.GetRepository<Person>()?.Insert( person );

                var node = AddMemberNode( peopleTreeView.Nodes, person );

                Executor.Execute( new MacroCommand( 
                    new CreateCommand( person ), 
                    new InsertTreeNodeCommand( peopleTreeView.Nodes, node ) ) );
            }
        }

        private void OnAddGroup( object sender, EventArgs e )
        {
            var dialog = new PromptForm( "Create Group", "Name:" );

            if ( dialog.ShowDialog( this ) == DialogResult.OK )
            {
                var group = UnitOfWork?.GetRepository<Group>()?.Create();
                Debug.Assert( group != null, "group != null" );

                group.Name = dialog.Value;
                UnitOfWork?.GetRepository<Group>()?.Insert( group );

                var node = AddMemberNode( groupsTreeView.Nodes, group );

                Executor.Execute( new MacroCommand(
                    new CreateCommand( group),
                    new InsertTreeNodeCommand( groupsTreeView.Nodes, node ) ) );
            }
        }

        private TreeNode? SelectedNode { get; set; }

        private void OnSelectNode( object sender, TreeViewEventArgs e )
        {
            if ( SelectedNode == e.Node ) return;
            SelectedNode = e.Node;

              editToolStripButton.Enabled = SelectedNode != null;
            deleteToolStripButton.Enabled = SelectedNode != null;
        }

        private void OnEdit( object sender, EventArgs e )
        {
            var member = SelectedNode?.Tag as Member;
            if ( member == null ) return;

            var dialog = new PromptForm( "Edit Name", "Name", member.Name );
            if ( dialog.ShowDialog( this ) == DialogResult.OK )
            {
                Executor.Execute( new RenameMemberCommand( member, dialog.Value ) );
            }
        }

        private void OnJoinGroup( object sender, EventArgs e )
        {
            var person = peopleTreeView.SelectedNode?.Tag as Person;
            if ( person == null ) return;

            var group  = groupsTreeView.SelectedNode?.Tag as Group;
            if ( group == null ) return;

            var node = AddMemberNode( groupsTreeView.SelectedNode.Nodes, person );

            Executor.Execute( new MacroCommand(
                new JoinGroupCommand( group, person ),
                new InsertTreeNodeCommand( groupsTreeView.SelectedNode.Nodes, node ) ) );
        }

        private void OnLeaveGroup( object sender, EventArgs e )
        {
            var person = groupsTreeView.SelectedNode?.Tag as Person;
            if ( person == null ) return;

            var group = groupsTreeView.SelectedNode?.Parent.Tag as Group;
            Debug.Assert( group != null, "group != null" );

            Executor.Execute( new MacroCommand(
                new RemoveTreeNodeCommand( groupsTreeView.SelectedNode ),
                new LeaveGroupCommand( group, person ) ) );   
        }
    }
}
