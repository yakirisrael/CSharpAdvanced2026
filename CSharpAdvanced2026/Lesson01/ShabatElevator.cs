namespace Lesson01;

public class ShabatElevator : Elevator
{
    public ShabatElevator(int  maxFloor, int startFloor) 
        : base(maxFloor, startFloor)
    {
    }

    public void Travel()
    {
        for (int i = startingFloor; i <= maxFloor; i++)
            MoveToFloor(i);
    }
}