namespace Lesson03;

public class Airplane : Vehicle
{
    public Airplane() : base(16, Surface.Air)
    {
    }

    public override void Drive()
    {
        Console.WriteLine("Driving Airplane");
    }
}