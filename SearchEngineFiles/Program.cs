using DrivesFinderClassLibrary;
using FIleFinderInDriverClassLibrary;
using DirectoryFinderInDriveClassLibrary;
using DirectoryAndFileLoopClassLibrary;
namespace SearchEngineFiles
{
    public class Program
    {
        public static void Main()
        {
            
            Console.WriteLine("Hello Welcome to our File Search Engine");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Available Drives in our System");

            IDriveFinder driveFinder = new DrivesFinder();
            List<string> drives= driveFinder.GetDrives();
            foreach(string drive in drives)
            {
                Console.WriteLine(drive);
                ISubLoopDirectoryAndFiles sub = new SubLoopDirectoryAndFiles();
                sub.SubDirectoryandFiles(drive);
            }

            Console.WriteLine("-----------------------");
            //Console.WriteLine("Enter File Name to search");
            //string FilesToSearch = Console.ReadLine();
            //Console.WriteLine($"Searching the File {FilesToSearch} started");

            //Console.WriteLine("Available Files in D");
            //IFileFinder fileFinder = new FileFinder();
            //List<string> files = fileFinder.GetFiles(@"D:/");
            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //Console.WriteLine("Available Folders in D");
            //IDirectoryFinder directoryFinder = new DirectoryFinder();
            //List<string> dirs = directoryFinder.GetDirectories(@"D:/");
            //foreach(string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //    IFileFinder fileFinder = new FileFinder();
            //    List<string> files = fileFinder.GetFiles(dir);
            //    foreach (string file in files)
            //    {
            //        Console.WriteLine("     "+file);
            //    }
            //    directoryFinder.GetDirectories(dir);
            //}






        }

        

    }
}
