using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DrivesFinderClassLibrary;
using DirectoryFinderInDriveClassLibrary;
using FIleFinderInDriverClassLibrary;

namespace DirectoryAndFileLoopClassLibrary
{
    public class SubLoopDirectoryAndFiles : ISubLoopDirectoryAndFiles
    {
        public void SubDirectoryandFiles(string path)
        {
           
            IDirectoryFinder directoryFinder = new DirectoryFinder();
            List<string> dirs = directoryFinder.GetDirectories(path);
            foreach (string dir in dirs)
            {
                try
                {
                    Console.WriteLine($"Directory {dir}");
                    IFileFinder fileFinder = new FileFinder();
                    List<string> files = fileFinder.GetFiles(dir);
                    foreach (string file in files)
                    {
                        Console.WriteLine($"File: {file}");
                    }
                    SubDirectoryandFiles(dir);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }

        }
    }
}
