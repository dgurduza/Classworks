using System;

internal class Hipster
{
    private int money;
    private int donate;

    public Hipster(int money, int donate)
    {
        this.money = money;
        this.donate = donate;
    }

    public int GetMoney()
    {
        if (money > 0)
        {
            if(money < donate)
            {
                int n = money;
                money = 0;
                return n;
            }
            else
            {
                money -= donate;
                return donate;
            }
        }
        else
        {
            return 0;
        }
    }
}