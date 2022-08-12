using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryFinderInDriveClassLibrary
{
    public class DirectoryFinder : IDirectoryFinder
    {
        public List<string> GetDirectories(string drive)
        {   




            List<string> directories = new List<string>();
            

            foreach (var dir in Directory.GetDirectories(drive)) 
            {
                directories.Add(dir);
            }
            return directories;

        }
    }
}
