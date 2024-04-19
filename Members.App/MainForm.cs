using Members.Core.Repositories;
using Members.Shared.Data.Entities;
using System.Diagnostics;

namespace Members.App
{
    public partial class MainForm : Form
    {
        public MainForm( IUnitOfWork unitOfWork )
        {
            UnitOfWork = unitOfWork;
            InitializeComponent();

            LoadData();
        }

        IUnitOfWork UnitOfWork { get; }

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

    }
}
