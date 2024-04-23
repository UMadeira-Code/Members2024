using Members.Core.Data;

namespace Members.App.Extensions
{
    internal static class TreeNodeExtensions
    {
        public static T? GetSemantic<T>( this TreeNode node ) where T : Item
        {
            return node?.Tag as T;
        }
    }
}
