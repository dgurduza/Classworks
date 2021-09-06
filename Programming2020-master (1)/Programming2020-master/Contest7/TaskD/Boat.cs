using System;

class Boat
{
    public bool IsAtThePort{get;set;}
    public int PriceOfWeight;
    public Boat(int value, bool isAtThePort)
    {
        IsAtThePort = isAtThePort;
        PriceOfWeight = value;
    }

    public int CountCost(int weight)
    {
        int price = PriceOfWeight * weight;
        return price;
    }
}


