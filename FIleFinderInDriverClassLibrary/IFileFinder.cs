using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIleFinderInDriverClassLibrary
{
    public interface IFileFinder
    {
        List<string> GetFiles(string drive);
    }
}
