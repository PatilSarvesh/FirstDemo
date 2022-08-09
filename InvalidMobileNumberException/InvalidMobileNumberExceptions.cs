using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidMobileNumberException
{
    public class InvalidMobileNumberExceptions:ApplicationException
    {
        public InvalidMobileNumberExceptions(string msg = null) : base(msg)
        {

        }
    }
}
