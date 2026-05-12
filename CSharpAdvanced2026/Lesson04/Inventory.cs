namespace Lesson04;

public class Inventory
{
    const int defaultCapacity = 100;
    private Item[] items;

    public Inventory(int capacity)
    {
        items = new Item[capacity];
    }

    public Inventory()
    {
        items = new Item[defaultCapacity];
    }

    public int Capacity
    {
        get
        {
            return items.Length;
        }
    }

    public int Count {
        get
        {
            int count = 0;
            foreach (Item it in items)
            {
                if (it != null) count++;
            }
            return count;
        }

    }

    private bool IsValid(int index)
    {
        // In array the Length is the capacity
        return !(index < 0 || index >= items.Length);

    }

    public Item this[int index]
    {
        get
        {
            if (IsValid(index))
                return items[index];
            
            return null;
        }
        set
        {
            if (IsValid(index))
                items[index] = value;
            else
            {
               throw new IndexOutOfRangeException(); 
            }
        }
    }
}