// See https://aka.ms/new-console-template for more information

// Interface has all abstract methods
//Inheritance or IS A relation -- Generalization (Class inherits from a class)
//Inheritance or IS A relation -- Realization (Class inherits from a Interface)

Console.WriteLine("Hello, World!");

Shape s1 = new Shape { H = 10, W = 20};

s1.Draw();
Console.WriteLine(s1.CalcArea());

Rectangle r1 = new Rectangle { W = 10, H = 6 };
r1.Draw();
Console.WriteLine(r1.CalcArea());

Shape t1 = new Triangle { W = 10, H = 12 };
t1.Draw();
Console.WriteLine(t1.CalcArea());

Shape s2 = new Triangle(); // Base class ref variable can hold derived class obj 

class Shape
{
    public int W { get; set; }
    public int H { get; set; }  

    public virtual void Draw() // virtual keyword is used to make it as Dynamic poly
    {
        Console.WriteLine("Drawing Shape");
    }
    public int CalcArea()
    {
        return H * W;
    }
}

class Rectangle : Shape //Inheritance or IS A relation -- Generalization (Class inherits from a class)
{
     override public void Draw()
    {
        Console.WriteLine("Rectangle ");
    }
}

class Triangle : Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    }
    public int CalcArea()
    {
        int x = base.CalcArea();  // base == super (JAVA)
        return x/2;
    }
}

