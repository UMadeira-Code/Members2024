using Members.App.Commands;
using Members.Core.Commands;
using Members.Core.Observables;
using Members.Core.Repositories;
using Members.Models.Commands;
using Members.Shared.Data.Entities;
using System.Diagnostics;

namespace Members.App
{
    public partial class MainForm : Form
    {
        public MainForm( IUnitOfWork unitOfWork, ICommandManager commandManager )
        {
            UnitOfWork = unitOfWork;
            CommandManager = commandManager;

            InitializeComponent();
            InitializeCommands( commandManager );

            LoadData();
        }

        IUnitOfWork UnitOfWork { get; }
        ICommandManager CommandManager { get; }

        private void InitializeCommands( ICommandManager manager )
        {
            undoToolStripButton.Enabled = false;
            redoToolStripButton.Enabled = false;

            undoToolStripButton.Click += ( s, a ) => manager.Undo();
            redoToolStripButton.Click += ( s, a ) => manager.Redo();

            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;

            undoToolStripMenuItem.Click += ( s, a ) => manager.Undo();
            redoToolStripMenuItem.Click += ( s, a ) => manager.Redo();

            var observable = manager as IObservable;
            if ( observable != null )
            {
                observable.Notify += ( s, a ) => undoToolStripButton.Enabled = manager.HasUndo;
                observable.Notify += ( s, a ) => redoToolStripButton.Enabled = manager.HasRedo;

                observable.Notify += ( s, a ) => undoToolStripMenuItem.Enabled = manager.HasUndo;
                observable.Notify += ( s, a ) => redoToolStripMenuItem.Enabled = manager.HasRedo;
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

                AddMemberNode( peopleTreeView.Nodes, person );
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

                AddMemberNode( groupsTreeView.Nodes, group );
            }

        }

        private TreeNode? SelectedNode { get; set; }

        private void OnSelectNode( object sender, TreeViewEventArgs e )
        {
            if ( SelectedNode == e.Node ) return;

            //if ( SelectedNode != null )
            //{
            //    SelectedNode.TreeView.SelectedNode = null;
            //}
            SelectedNode = e.Node;
            //if ( SelectedNode != null )
            //{
            //    SelectedNode.TreeView.SelectedNode = SelectedNode;
            //}
            editToolStripMenuItem.Enabled = SelectedNode != null;
        }

        private void OnEdit( object sender, EventArgs e )
        {
            var member = SelectedNode?.Tag as Member;
            if ( member == null ) return;

            var dialog = new PromptForm( "Edit Name", "Name", member.Name );
            if ( dialog.ShowDialog( this ) == DialogResult.OK )
            {
                CommandManager.Execute( new RenameCommand( member, dialog.Value ) );
            }
        }

        private void OnJoinGroup( object sender, EventArgs e )
        {
            var person = peopleTreeView.SelectedNode?.Tag as Person;
            if ( person == null ) return;

            var group  = groupsTreeView.SelectedNode?.Tag as Group;
            if ( group == null ) return;

            CommandManager.Execute( new MacroCommand(
                new JoinGroupCommand( group, person ),
                new InsertTreeNodeCommand( groupsTreeView.SelectedNode.Nodes, person ) 
            ) );
        }

        private void OnLeaveGroup( object sender, EventArgs e )
        {
            var person = groupsTreeView.SelectedNode?.Tag as Person;
            if ( person == null ) return;

            var group = groupsTreeView.SelectedNode?.Parent.Tag as Group;
            Debug.Assert( group != null, "group != null" );

            CommandManager.Execute( new MacroCommand(
                new RemoveTreeNodeCommand( groupsTreeView.SelectedNode ),
                new LeaveGroupCommand( group, person ) 
            ) );   
        }
    }
}
