namespace Members.Core.Repositories
{
    public interface IFactory
    {
        T?  Create<T>( params object?[]? args );
    }
}
