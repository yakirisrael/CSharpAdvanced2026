namespace Lesson05;

public class Calculator
{
    public delegate int CalcFunc(int x, int y, int z);

    public static int Pow(int x, int y, int z)
    {
        int p = (int)Math.Pow(x, y);
        return (int)Math.Pow(p, z);
    }
    
    public static int Log(int x, int y, int z)
    {
        int l = (int)Math.Log(x, y);
        return (int)Math.Log(l, z);
    }

}