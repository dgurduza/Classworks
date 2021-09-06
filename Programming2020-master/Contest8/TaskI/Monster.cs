using System;

public class Monster : Mob
{
    public int MonsterHP { get; set; }
    public int MonsterAttack { get; set; }
    private int MonsterPosition { get; set; }

    public Monster(int hp, int attack, int position) : base(hp, attack)
    {
        MonsterHP = hp;
        MonsterAttack = attack;
        MonsterPosition = position;
    }

    public void AttackHero(Mob hero, int position)
    {
        if (position == MonsterPosition)
        {
            Console.WriteLine($"Mario meet monster on {MonsterPosition}");
            AttackMob(hero);
        }
    }
    public override string ToString()
    {
        return $"Monster with HP = {HP} and attack = {MonsterAttack}";
    }
}