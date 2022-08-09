
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


B b1 = new B();

public  class A
{
    public void A1() { }
    public void A2() { }

}
public class B 
{
   private A a=new A();
    public void B1() { a.A1(); }
    public void B2() { a.A2(); }
}