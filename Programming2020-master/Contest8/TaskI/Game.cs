using System;

public delegate void AtackHeroOnPosition(Mob hero, int position);
public class Game
{
    public AtackHeroOnPosition attackHero;
    public int CastlePosition { get; set; }
    public int CountOfMonsters { get; set; }
    private Hero Hero;
    private Boss Boss;
    public Game(int castlePosition, int countOfMonster, Hero hero, Boss boss)
    {
        CastlePosition = castlePosition;
        CountOfMonsters = countOfMonster;
        Hero = hero;
        Boss = boss;
    }
    public void Play()
    {
        if (CountOfMonsters > 0) 
        {
            for (int i = 1; i <= CastlePosition; i++)
            {
                attackHero(Hero, i);
                if (Hero.HP <= 0)
                {
                    Console.WriteLine("You Lose! Game over!");
                    break;
                }
            }
        }
        if (Hero.HP > 0)
        {
            Boss.AttackMob(Hero);
            if (Hero.IsHpMoreThen75())
            {
                Console.WriteLine("You win! Princess released!");
            }
            else if (Hero.HP > 0)
            {
                Console.WriteLine("Thank you, Mario! But our princess is in another castle... You lose!");
            }
            else
            {
                Console.WriteLine("You Lose! Game over!");
            }
        }
    }
}
