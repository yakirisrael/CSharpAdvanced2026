// See https://aka.ms/new-console-template for more information

using Lesson04;


    
Inventory<string> inv_string = new Inventory<string>();
inv_string[0] = "yan";

//Inventory<int> inv_int = new Inventory<int>(30);
//inv_int[0] = 123;

Inventory<Item> inv = new (); 

Inventory<Item> inv2 = new Inventory<Item>(30); 

//Console.WriteLine("inv count = " + inv.Count);
//Console.WriteLine("inv2 count = " + inv2.Count);

//Console.WriteLine("inv Capacity = " + inv.Capacity);
//Console.WriteLine("inv2 Capacity = " + inv2.Capacity);

Item t = new Item { Name = "axe" };
Item t2 = new Item { Name = "sword" };
inv[0] = t;
inv[1] = t2;
//Console.WriteLine("inv count = " + inv.Count);

//Console.WriteLine(inv[1]);
//Console.WriteLine(inv);

foreach (var item in inv)
{
    Console.WriteLine(item);
}

