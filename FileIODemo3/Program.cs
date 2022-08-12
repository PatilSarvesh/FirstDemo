// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DriveInfo[] drives = DriveInfo.GetDrives();
foreach(var d in drives)
{
    Console.WriteLine(d.Name);
    Console.WriteLine(d.AvailableFreeSpace);
}