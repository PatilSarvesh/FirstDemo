// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Lab1Library;
public class Validation
{
    bool result;
    public  string Val(string a)
    {
        if(a.Length != 10 )
        {
            throw new InvalidMobileNumberException("Enter 10 digit Mobile Number");
        }
        if (a[0] != '9')
        {
            throw new InvalidMobileNumberException("Number Should start with digit 9");
        }

        for(int i=0;  i< a.Length; i++)
        {
            if(Char.IsDigit(a, i) == false)
            {
                throw new InvalidMobileNumberException("Enter Only Digits");
            }
            
        }
        return a;
    }
}