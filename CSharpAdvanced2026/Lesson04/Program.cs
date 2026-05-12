// See https://aka.ms/new-console-template for more information

using Lesson04;

Inventory inv = new Inventory(); 

Inventory inv2 = new Inventory(30); 

Console.WriteLine("inv count = " + inv.Count);
Console.WriteLine("inv2 count = " + inv2.Count);

Console.WriteLine("inv Capacity = " + inv.Capacity);
Console.WriteLine("inv2 Capacity = " + inv2.Capacity);

Item t = new Item { Name = "axe" };
Item t2 = new Item { Name = "sword" };
inv[0] = t;
inv[1] = t2;
Console.WriteLine("inv count = " + inv.Count);

Console.WriteLine(inv[1]);

