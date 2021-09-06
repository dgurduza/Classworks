using System;

internal class MyGiveawayHelper
{
    public int Temp = 1579;
    int Count = 0;
    public string[] Gift { get; set; }
    public string[] Persons { get; set; }
    public int Generate { get; set; }
    public MyGiveawayHelper(string[] logins, string[] prizes)
    {
        Gift = prizes;
        Persons = logins;
    }

    public bool HasPrizes
    {
        get
        {
            if (Gift.Length > Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public (string prize, string login) GetPrizeLogin()
    {
        int square = Temp * Temp;
        //int length = (int)(Math.Log10(Math.Max(Math.Abs(square), 0.5)) + 1);
        Temp = ((square % 1000000) - (square % 100))/100;
        int numOfPerson = Temp % Persons.Length;
        string winner = Persons[numOfPerson];
        string gift = Gift[Count];
        Count++;
        return (gift, winner);
    }
}