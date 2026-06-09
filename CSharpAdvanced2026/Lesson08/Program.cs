// See https://aka.ms/new-console-template for more information

/*int counter = 0;
object locker = new object();

void PrintHello(object val)
{
   // Console.WriteLine($"Thread state {Thread.CurrentThread.ThreadState}");

    int ValInt = (int)val;

    for (int i = 0; i < ValInt; i++)
    {
        //Console.WriteLine(i);
        lock (locker)
        {
            counter++;
        }

        Console.WriteLine($"Thread id = {Thread.CurrentThread.ManagedThreadId},  counter = {counter}");
        
        Thread.Sleep(1000);
    }
}

Thread t = new Thread(PrintHello);
//Console.WriteLine($"Thread state {t.ThreadState}");
t.Start(5);

//t.Join();

Thread t2 = new Thread(PrintHello);
t2.Start(5);

t.Join();
t2.Join();

Console.WriteLine($"Thread state {t.ThreadState}");
Console.WriteLine($"Thread state {t2.ThreadState}");
*/

void PrintHello(object val)
{
    Console.WriteLine(DateTime.Now);
    
    int ValInt = (int)val;

    for (int i = 0; i < ValInt; i++)
    {
        Console.WriteLine(i);
    }
}

Timer timer = new Timer(PrintHello, 10, 2000, 1000);
Console.WriteLine(DateTime.Now);

Console.ReadLine();