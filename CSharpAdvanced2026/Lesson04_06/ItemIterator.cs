using System.Collections;

namespace Lesson04;

public class ItemIterator<J> : IEnumerator where J : class
{
    int position = -1;
    private Inventory<J> inventory;

    public ItemIterator(Inventory<J> inventory)
    {
        this.inventory = inventory;
    }

    public bool MoveNext()
    {
        position++;
        
        return position < inventory.Count;
    }

    public void Reset()
    {
        position = -1;
    }

    public object? Current
    {
        get
        {
            return inventory[position];           
        }
    }
}