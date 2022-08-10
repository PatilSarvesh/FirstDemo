

namespace AccountManagerLibrary
{
    public class AccountManager
    {
        //public int openAcc = 0;
        //public int closeAcc = 0;
        public void OpenAcc(int openAcc)
        {
            
            if (openAcc > 1)
            {
                throw new AccountCanOnlyBeOpenedOnce("Account no alredy exists ");
            }

        }
        public void CloseAcc(int closeacc)
        {
            
            Console.WriteLine("Press Y to Close");
            
            char YOrN = char.Parse(Console.ReadLine().ToLower());

            

            if (YOrN == 'y')
            {
                if (closeacc != 1)
                    throw new AccountCanOnlyBeClosedOnce("Account Can only be closed once");
                else
                    Console.WriteLine("Account Closed");
                      

            }

        }
        public void withdraw()
        {

        }
        public void deposits()
        {

        }
        public void transfer()
        {

        }
    }
}