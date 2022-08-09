// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SimpleMathLibrary;

int fno, sno, sum = 0;
while (true)
{
    try
    {
        Console.WriteLine("Enter the first  number");
        fno = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Second  number");
        sno = int.Parse(Console.ReadLine());

        SimpleMath sm = new SimpleMath();
        int total = sm.Sum(fno, sno);
        //sum = fno+ sno;
        Console.WriteLine($"Sum of {fno} and {sno} is: {total}");

    }
    catch(FormatException ex)
    {
        Console.WriteLine("Enter Only Numbers");
    }
    
    catch(InvalidPositiveNonZeroNumberException ex)
    {
         Console.WriteLine(ex.Message);
    }
    catch(InvalidEvenNumberException ex)
    {
        Console.WriteLine(ex.Message);
    }

}
