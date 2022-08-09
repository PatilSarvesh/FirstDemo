// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int a = 10; //Scalar Variable

//Store 10 int's
Console.Write("Enter Array Size: ");
int n = int.Parse(Console.ReadLine());
int[] b = new int[n];

for (int i = 0; i < b.Length; i++)
{   
    Console.Write($"Enter Number {i+1} : ");
    b[i] = int.Parse(Console.ReadLine());
}
int sum = 0;

for (int i = 0; i < b.Length; i++)
{
    sum += b[i];
        
}
Console.WriteLine($"Sum = {sum} ");


foreach (int i in b)
{
    Console.WriteLine($"Numbers : {i}");
}


double avg = b.Average();
sum = b.Sum();
int min = b.Min();
int max = b.Max();  

Array.Sort(b);

int[] b2= new int[b.Length];
Array.Copy(b, b2, b.Length);

string[] words = new string[3] { "one", "two", "three" };
string[] words1 = new string[] { "one", "two", "three" };
string[] words2 = { "one", "two", "three" };


//Multi Dimension Array  [row, col]

int[,] twod= new int[2, 3];

//Jagged Arrays  (Array of Arrays)
int[][]  Scores = new int[3][]; //first only declare no of Rows 

Scores[0] = new int[3];         //then declare no of columns for each rows
Scores[1] = new int[4];
Scores[2] = new int[6];

