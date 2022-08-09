// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


HybridCar car = new HybridCar();
PetrolEngine pe = new PetrolEngine();
DieselEngine de = new DieselEngine();
//GasEngine ge = new GasEngine();
//HydrogenEngine he = new HydrogenEngine();

//car.Engines.Add(pe);
car.Engines.Add(de);
//car.Engines.Add(ge);
//car.Engines.Add(he);
car.Go();

public interface Engine{
    void Run();
}

class PetrolEngine : Engine
{
    public void Run()
    {
        Console.WriteLine("Running with Petrol");
    }
}

class DieselEngine : Engine
    {
    public void Run()
    {
        Console.WriteLine("Running with Petrol");
    }
}
class HybridCar
{
    //public PetrolEngine PEngine { get; set; }
    //    public DieselEngine DEngine { get; set; }

    public List<Engine> Engines { get; set; } = new List<Engine>();
    public void Go(){ 
   foreach(Engine engine in Engines)
	{
       
            engine.Run();
	}
}
    class a
    {

    }
}
