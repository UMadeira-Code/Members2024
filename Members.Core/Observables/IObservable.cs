namespace Members.Core.Observables
{
    public interface IObservable
    {
        event EventHandler? Notify;
    }
}
