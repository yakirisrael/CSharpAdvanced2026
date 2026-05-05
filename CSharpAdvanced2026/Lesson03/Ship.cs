namespace Lesson03;

public class Ship : Vehicle
{
    public Ship() : base(3, Surface.Water)
    {
    }

    public override void Drive()
    {
        Console.WriteLine("Driving Ship");
    }
}