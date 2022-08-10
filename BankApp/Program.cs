// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using AccountManagerLibrary;
Account sarvesh = new Account();
AccountManager a = new AccountManager();

Console.WriteLine(sarvesh.openAcc);
//sarvesh.openAcc++;
a.OpenAcc(sarvesh.openAcc);
//a.CloseAcc(sarvesh.closeAcc);
//a.CloseAcc(sarvesh.closeAcc);






public class Account
{
    public int accno { get; set; }
    public string name { get; set; }
    public string openDate { get; set; }
    public string closeDate { get; set; }
    public double salary { get; set; }
    public int pinNumber { get; set; }
    public bool isActive { get; set; }

    public int openAcc = 0;
    public int closeacc = 0;


    //public Account()
    //{
    //    this.openAcc++;
    //    this.closeAcc++;

    //}
}

public class SavingsAcc : Account
{
    public string gender { get; set; }
}

public class CurrentAcc: Account
{
    public string companyName { get; set; }
}
