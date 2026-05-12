namespace Lesson04;

public class Item
{
    public string Name { get; set; }

    override public string ToString()
    {
        return "Item = " + Name;
    }
}