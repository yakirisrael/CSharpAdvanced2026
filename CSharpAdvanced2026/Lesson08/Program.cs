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

CancellationTokenSource cts = new CancellationTokenSource();


async Task LoadingAssets()
{
    try
    {
        Console.WriteLine(DateTime.Now);
        await Task.Delay(10000, cts.Token);
        Console.WriteLine(DateTime.Now);
    }
    catch
    {
        Console.WriteLine("Operation was canceled");
    }
}

/*
async Task PrintHello(object? val)
{
    Console.WriteLine(DateTime.Now);
    int ValInt = (int)val;

    for (int i = 0; i < ValInt; i++)
    {
        Console.WriteLine(i);
        
    }
}*/

void CancelAction(object? obj)
{
    cts.Cancel();
    Console.WriteLine(DateTime.Now);
}

Task taskLoadingAssets = Task.Run(LoadingAssets);
Timer timer = new Timer(CancelAction, 10, 5000, Timeout.Infinite);
Console.WriteLine(DateTime.Now);

taskLoadingAssets.Wait(CancellationToken.None);

Console.WriteLine("Finish Loading");
//Task task1 = Task.Run(() => PrintHello(10));
//Task task2 = Task.Run(PrintHello);



Console.ReadLine();