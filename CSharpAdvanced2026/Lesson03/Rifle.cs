namespace Lesson03;

public class Rifle : Weapon
{
    public override void Attack()
    {
        Console.WriteLine("Shooting VFX");
    }

    public override void Equip()
    {
        Console.WriteLine("Equip Rifle");
    }

    public override void Unequip()
    {
        Console.WriteLine("Unequip Rifle");
    }
}