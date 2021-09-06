using System;

class Brigantine : Boat
{
    public bool IsAsThePort { get; set; }
    public int Price ;
    public Brigantine(int value, bool isAtThePort) : base(value, isAtThePort)
    {
        Price = value;
        IsAsThePort = isAtThePort;
    }

    public new int CountCost(int weight)
    {
        int priceof;
        if (weight <= 500)
        {
            priceof = weight * Price * Price;
        }
        else
        {
            priceof = weight * Price;
        }
        return priceof;
    }
}