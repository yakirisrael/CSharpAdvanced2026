namespace Lesson03;

public abstract class Weapon : IWeapon
{
    protected float baseDamage;


    public abstract void Attack();

    public abstract void Equip();

    public abstract void Unequip();
}