using System;

public abstract class Mob
{
    public int HP { get; set; }
    public int Attack { get; set; }
    public Mob(int hp, int attack)
    {
        Attack = attack;
        HP = hp;
    }

    public void AttackMob(Mob other)
    {
        while (other.HP > 0 && HP > 0)
        {
            Console.WriteLine(other.ToString() + " attacked " + ToString());
            Console.WriteLine(ToString() + " attacked " + other.ToString());
            HP -= other.Attack;
            other.HP -= Attack;
        }
    }
}