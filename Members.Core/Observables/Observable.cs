namespace Members.Core.Observables
{
    public class Observable : IObservable
    {
        public event EventHandler? Notify;

        protected void InvokeNotify( EventArgs? args = null )
        {
            Notify?.Invoke( this, args ?? EventArgs.Empty );
        }
    }
}
