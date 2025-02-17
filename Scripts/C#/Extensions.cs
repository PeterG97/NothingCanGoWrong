namespace GameLogic;

public static class NodeExtensions
{
    /// <summary>
    /// Finds the first child of the specified type <typeparamref name="T"/> in the given parent node.
    /// </summary>
    /// <typeparam name="T">The type of the child node to find. This must be a subclass of <see cref="Node"/>.</typeparam>
    /// <param name="parent">The parent node in which to search for the child.</param>
    /// <returns>
    /// The first child of type <typeparamref name="T"/> found in the parent node, or <c>null</c> if no such child exists.
    /// </returns>
    public static T FindChild<T>(this Node parent) where T : Node
    {
        foreach (Node child in parent.GetChildren())
        {
            if (child is T typedChild)
            {
                return typedChild;
            }
        }

        return null;
    }
}