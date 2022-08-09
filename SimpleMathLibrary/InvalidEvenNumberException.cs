using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary
{
    public class InvalidEvenNumberException:ApplicationException
    {
        public InvalidEvenNumberException(string msg=null): base(msg)
        {

        }
    }
}
