using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DrivesFinderClassLibrary
{
    public class DrivesFinder : IDriveFinder
    {
        public List<string> GetDrives()
        {
            List<string> drives = new List<string>();

            foreach (DriveInfo drive in DriveInfo.GetDrives()) {
                drives.Add(drive.Name);
                     }
            return drives;
        }
    }
}
