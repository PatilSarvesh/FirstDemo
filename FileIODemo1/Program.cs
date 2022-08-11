// See https://aka.ms/new-console-template for more information


//collect person name and store in file
using System.IO;


StreamReader reader = new StreamReader("D://nameslist.txt");
//string name = reader.ReadLine();    
string allName = reader.ReadToEnd();
reader.Close();
Console.WriteLine(allName);


static void SaveData()
{
    StreamWriter write = null;
    try
    {

        Console.WriteLine("ENter Person Name");

        string pName = Console.ReadLine();

        StreamWriter writer = new StreamWriter("D://nameslist.txt", true);
        writer.WriteLine(pName);
    }
    //catch
    //{
    //    write.Close();
    //}
    finally
    {
        write.Close();
    }
}