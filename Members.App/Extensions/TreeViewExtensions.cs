using Members.Core.Data;

namespace Members.App.Extensions
{
    internal static class TreeViewExtensions
    {
        public static bool HasSelectedNode( this TreeView view )
        {
            return view.SelectedNode != null;
        }

        public static bool HasSelectedNodeOfType<T>( this TreeView view ) where T : Item
        {
            return view.SelectedNode?.GetSemantic<T>() != null;
        }

        public static T? GetSelectedSemantic<T>( this TreeView view ) where T : Item 
        {
            return view.SelectedNode?.GetSemantic<T>();
        }
    }
}
