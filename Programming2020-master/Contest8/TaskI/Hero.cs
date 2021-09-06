using System;

public class Hero : Mob
{
    public int HeroHP { get; set; }
    public int HeroAttack { get; set; }
    public double Perc;
    public Hero(int hp, int attack) : base(hp, attack)
    {
        HeroHP = hp;
        Perc = hp * 0.75;
        HeroAttack = attack;
    }

    public bool IsHpMoreThen75()
    {
        if (Perc <= HP)
        {
            return true;
        }
        return false;
    }
    public override string ToString()
    {
        return $"Mario with HP = {HP} and attack = {HeroAttack}";
    }
}

