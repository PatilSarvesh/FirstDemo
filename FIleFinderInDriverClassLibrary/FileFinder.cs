using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIleFinderInDriverClassLibrary
{
    public class FileFinder : IFileFinder
    {
        public List<string> GetFiles(string drive)
        {
            List<string> files = new List<string>();

            foreach (var file in Directory.GetFiles(drive))
            {
                files.Add(file);
            }
            return files;
        }
    }
}
