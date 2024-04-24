using Members.Core.Commands;

namespace Members.App.Commands
{
    internal class InsertTreeNodeCommand : ICommand
    {
        public InsertTreeNodeCommand( TreeNodeCollection nodes, TreeNode node )
        {
            Nodes = nodes;
            Node  = node;

            Node.Remove();
        }

        public TreeNodeCollection Nodes { get; set; }
        public TreeNode           Node  { get; set; }

        public void Do()   => Nodes.Add( Node );
        public void Undo() => Nodes.Remove( Node );
        public void Redo() => Do();
        public void Cancel() {}
    }
}
