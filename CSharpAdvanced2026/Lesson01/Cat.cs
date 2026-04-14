namespace Lesson01;

public class Cat
{
    protected string color;

    public Cat()
    {
        Console.WriteLine("cat c'tor without paramaters");
    }

    public Cat(string color)
    {
        this.color = color;
        Console.WriteLine("cat c'tor with paramaters");
    }

    protected void voice()
    {
        Console.WriteLine("Meoh");
    }
}