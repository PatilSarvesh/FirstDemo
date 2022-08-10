// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace DelegatesDemo1
{
    delegate void MyDelegate(string message);
    class Program
    {

        public static void Main()
        {
            //step2 : Instantitae and Initialize
            MyDelegate d1 = new MyDelegate(Greeting);
            Program p1 = new Program();
            
            d1 += p1.Hello;  //subscribe //+= is append not remove
            d1 -= Greeting; //Unsubscribe
            d1 += p1.Hi;
          

            //step 3:Invoke

            //direct call
            //Greeting("direct call");

            ////indirect call Type 1
            //d1.Invoke("Indirect call Type 1");

            //indirect call Type 2
            d1("Indirect call Type 2");

        }
        static void Greeting(string msg)
        {
            Console.WriteLine($"Greeting: {msg}");
        } 
         void Hello(string msg)
        {
            Console.WriteLine($"Hello: {msg}");
        }
        void Hi(string msg)
        {
            Console.WriteLine($"Hi: {msg}");
        }
    }
}

//step1 declear the delegate
//delegate void MyDelegate(string message);

//step 2 Instantiate the delegate






