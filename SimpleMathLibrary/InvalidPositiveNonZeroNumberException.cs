using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMathLibrary
{
    public class InvalidPositiveNonZeroNumberException:ApplicationException
    {
        public InvalidPositiveNonZeroNumberException(string msg = null) : base(msg)
        {

        }
    }
}
