namespace AccountManagerLibrary
{
    public class AccountCanOnlyBeClosedOnce : ApplicationException
    {
        public AccountCanOnlyBeClosedOnce(string msg = null) : base(msg)
        {

        }
    }
}
