using System.Collections;

namespace Lesson04;

public class ItemIterator : IEnumerator
{
    int position = -1;
    private Inventory inventory;

    public ItemIterator(Inventory inventory)
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