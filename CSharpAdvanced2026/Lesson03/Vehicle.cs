namespace Lesson03;


public enum Surface
{
    Land,
    Air,
    Water
}

public abstract class Vehicle
{
    protected int numWheels;
    protected Surface surfaceType;
    protected string model;


    public Vehicle(int numWheels, Surface surfaceType)
    {
    }

    public abstract void Drive();
}