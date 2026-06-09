// See https://aka.ms/new-console-template for more information

int counter = 0;
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

        Console.WriteLine(counter);
        Thread.Sleep(1000);
    }
}

Thread t = new Thread(PrintHello);
//Console.WriteLine($"Thread state {t.ThreadState}");
t.Start(100);

//t.Join();

Thread t2 = new Thread(PrintHello);
t2.Start(100);


Console.ReadLine();