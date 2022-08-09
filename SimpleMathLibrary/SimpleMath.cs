// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using SimpleMathLibrary;
using SimplaMathDataLayer;
/// <summary>
/// USe this class for Calculating Simple Maths Operations
/// </summary>

public class SimpleMath
{
    /// <summary>
    /// Finds the sum of two nmbers, atleast one number should be Positive
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    /// <exception cref="InvalidEvenNumberException"></exception>
    /// <exception cref="InvalidPositiveNonZeroNumberException"></exception>
    public int Sum(int a,int b)
    {
        
        if(a%2 !=0 && b % 2 != 0)
        {
               throw new InvalidEvenNumberException("Enter atleast one even Number: ");
          
        }
        if(a <= 0 && b<= 0)
        {
            throw new InvalidPositiveNonZeroNumberException("Enter atleast one possitive non zero Number");
        }
        int sum = a + b;
        DBRepo dBRepo = new DBRepo();
        dBRepo.SaveData(a, b, sum);
        return sum;
    }
    //public int Sub(int a,int b)
    //{
    //    return a - b;
    //}
    //public int Mul(int a,int b)
    //{
    //    return a * b;
    //}
    //public int Div(int a,int b)
    //{
    //    return a / b;
    //}
}
