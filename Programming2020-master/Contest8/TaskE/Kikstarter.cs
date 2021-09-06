using System;

class Kikstarter
{
    // Данный тип необходимо обязательно использовать
    public delegate int GetMoneyDelegate();

    GetMoneyDelegate[] getMoney;
    private int m;

    public Kikstarter(int m, Hipster[] hipsters)
    {
        this.m = m;
        if (hipsters.Length <= 0)
            throw new ArgumentException("Not enough hipsters");
        GetMoneyDelegate moneyDelegate;
        getMoney = new GetMoneyDelegate[hipsters.Length];
        for (int i = 0; i < hipsters.Length; i++)
        {
            moneyDelegate = hipsters[i].GetMoney;
            getMoney[i] = moneyDelegate;
        }
    }

    public int Run()
    {
        int i=0,sum, money=0;
        while(money<m)
        {
            sum = 0;
            for (int j = 0; j < getMoney.Length; j++)
            {
                sum += getMoney[j].Invoke();
            }
            if (sum == 0)
                throw new InvalidOperationException("Not enough money");
            money += sum;
            i++;
        }
        return i;
    }
}