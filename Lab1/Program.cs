// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lab1Library;
string employePhNo;
string employePh;

while (true)
{
    try
    {
        Console.WriteLine("Enter Number");
        employePhNo = Console.ReadLine();

        Validation v = new Validation();
        employePh = v.Val(employePhNo);

        Console.WriteLine(employePhNo);
    }

    catch (InvalidMobileNumberException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

}
