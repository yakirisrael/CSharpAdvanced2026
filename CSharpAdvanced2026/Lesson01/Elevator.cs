namespace Lesson01;

public class Elevator
{
    private int currentFloor;
    protected int maxFloor;
    protected int startingFloor;
    public Elevator(int maxFloor, int startingFloor)
    {
        this.maxFloor = maxFloor;
        this.startingFloor = this.currentFloor = startingFloor;
    }
    public void MoveToFloor(int floor)
    {
        this.currentFloor = floor;
        DisplayCurrentFloor();
    }
    public void DisplayCurrentFloor()
    {
        Console.WriteLine(this.currentFloor);
    }
    
}