// See https://aka.ms/new-console-template for more information


using Lesson03;

/*
Vector v1 = new Vector(1, 3, 6);
Vector v2 = new Vector(1, 3, 6);

Console.WriteLine("V1 = " + v1.ToString());
Console.WriteLine("V2 = " + v2.ToString());

Console.WriteLine("V1 == V2 ? " + v1.Equals(v2));

Console.WriteLine("V1 code = " + v1.GetHashCode());
Console.WriteLine("V2 code = " + v2.GetHashCode()); */


List<Vehicle> vehicles = new ();
vehicles.Add(new Airplane());
vehicles.Add(new Ship());

foreach (var vehicle in vehicles)
{
    vehicle.Drive();
}