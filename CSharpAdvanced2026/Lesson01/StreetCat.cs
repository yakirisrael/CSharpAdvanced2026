namespace Lesson01;

public class StreetCat : Cat
{
    public StreetCat(string color) : base(color)
    {
        Console.WriteLine("street cat c'tor with  paramaters");
    }

    public void Fight()
    {
        base.voice();

        color = "Striped";
        
        voice();
        Console.WriteLine("Fight");
    }
}