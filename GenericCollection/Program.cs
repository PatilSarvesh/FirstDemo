
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

List<int> numbers = new List<int>();

numbers.Add(10);
numbers.Add(102);
numbers.Add(103);

for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(numbers[i]);
}

foreach (int i in numbers)
{
    Console.WriteLine(i);
}

Console.WriteLine(numbers[2]);

numbers.Insert(10, 100); //Avoid this insert method insted use Add
numbers.RemoveAt(10);
numbers.Sort();


Queue<int > queue = new Queue<int>();   
queue.Enqueue(10); //Add
queue.Dequeue();    //Read and delet
queue.Peek();  //Only Read


Stack<int> stack =new Stack<int>();

stack.Push(10);  // Add
stack.Pop();  // Read and Delete
stack.Peek(); //Read

HashSet<int> hs = new HashSet<int>(); // Used to store unique data
hs.Add(10);
hs.Add(10);

Dictionary<int, string> hs2 = new Dictionary<int, string>();
hs2.Add(111, "Pass");
hs2.Add(222, "Fail");

string r = hs2[222];