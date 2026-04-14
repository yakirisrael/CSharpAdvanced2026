// See https://aka.ms/new-console-template for more information

using Lesson01;

int maxFloor = 10;
int startingFloor = 0;
Elevator e = new Elevator(maxFloor, startingFloor);

e.MoveToFloor(3);

Console.WriteLine("----------------------");
ShabatElevator se =  new ShabatElevator(maxFloor, startingFloor);
se.Travel();