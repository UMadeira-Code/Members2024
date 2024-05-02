namespace Members.Core.Observables
{
    public class Observable : IObservable, IDisposable
    {
        public event EventHandler? Notify;

        protected void InvokeNotify( EventArgs? args = null )
        {
            Notify?.Invoke( this, args ?? EventArgs.Empty );
        }

        public void Dispose() => Notify = null;
    }
}
