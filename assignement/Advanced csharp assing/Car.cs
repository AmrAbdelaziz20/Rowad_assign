namespace Advanced_csharp_assing;
public class Car : IVehicle, IDrivable
{
    private int gasoline;

    public Car(int startingGasoline)
    {
        gasoline = startingGasoline;
    }

    public void Drive()
    {
        if (gasoline > 0)
        {
            Console.WriteLine("The car is driving.");
        }
        else
        {
            Console.WriteLine("Not enough gasoline to drive.");
        }
    }

    public bool Refuel(int amount)
    {
        gasoline += amount;
        return true;
    }

    // IDrivable implementation
    void IDrivable.Move()
    {
        Console.WriteLine("The car is moving.");
    }

    void IDrivable.Accelerate()
    {
        Console.WriteLine("The car is accelerating.");
    }
    
    // Explicit implementation for IDrivable.Drive (optional)
    void IDrivable.Drive()
    {
        Drive();  // Calls the IVehicle.Drive method
    }
}
