// See https://aka.ms/new-console-template for more information
using System.Diagnostics;


class Program
{

    public static void Main()
    {
        //client 1
        ProcessManager pMgr = new ProcessManager();
        //pMgr.ShowProcessList();

        //client 2

        //pMgr.ShowProcessList("S");


        //client 3
        pMgr.ShowProcessList(Program.FilterBySize);


        //Lambda: Light weight syntax for Anonymous Delegates
        //Lambda Statement
        pMgr.ShowProcessList((Process p) =>
        {
            return p.WorkingSet64 >= 100 * 1024 * 1024;
        });


        //Lambda Expression
        pMgr.ShowProcessList(p => p.WorkingSet64 >= 100 * 1024 * 1024);

        pMgr.ShowProcessList(p => true);

        pMgr.ShowProcessList(p => p.ProcessName.StartsWith("a"));

    }


    public bool Filter(Process p)
    {
        if (p.ProcessName.StartsWith("s"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool FilterBySize(Process P)
    {
        return P.WorkingSet64 >= (100*1024*1024);
    }
    
}
public delegate bool FilterByDelegate(Process p);

public class ProcessManager
{
    
    public void ShowProcessList(FilterByDelegate filter)
    {
        foreach(Process p in Process.GetProcesses())
        {
            Console.WriteLine(p.ProcessName);
        }
    }

    public void ShowProcessList(string sw)
    {
        foreach (Process p in Process.GetProcesses())
        {
            Program prg = new Program();
            if (p.ProcessName.StartsWith(sw))
                Console.WriteLine(p.ProcessName);
        }
    }
    public void ShowProcessList(long size)
    {
        foreach (Process p in Process.GetProcesses())
        {
            if (p.WorkingSet64 >= size)
                Console.WriteLine(p.ProcessName);
        }
    }

}
