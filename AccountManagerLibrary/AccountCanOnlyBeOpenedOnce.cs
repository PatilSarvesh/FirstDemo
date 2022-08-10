using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagerLibrary
{
    public class AccountCanOnlyBeOpenedOnce : ApplicationException
    {
        public AccountCanOnlyBeOpenedOnce(string msg = null): base(msg)
        {

        }
        
    }
}
