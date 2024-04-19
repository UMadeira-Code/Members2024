using Members.Core.Commands;
using Members.Shared.Data.Entities;

namespace Members.App.Commands
{
    internal class InsertTreeNodeCommand : ICommand
    {
        public InsertTreeNodeCommand( TreeNodeCollection nodes, Member member )
        {
            Nodes = nodes;

            Node = new TreeNode( member.Name );
            Node.ImageKey = Node.SelectedImageKey = member.GetType().Name;
        }

        public TreeNodeCollection Nodes { get; set; }
        public TreeNode           Node  { get; set; }

        public void Do()   => Nodes.Add( Node );
        public void Undo() => Nodes.Remove( Node );
        public void Redo() => Do();
        public void Cancel() {}
    }
}
