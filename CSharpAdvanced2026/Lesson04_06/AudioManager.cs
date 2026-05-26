namespace Lesson04;

public class Singelton<T> where T : new()
{
    private static T instance;

    private Singelton()
    {
    }

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new T();
            }

            return instance;
        }
    }
}