using System;

class Linguist : Editor
{
    public string BanWord;

    private Linguist(string name, int salary, string bannedWord) : base(name, salary)
    {
        BanWord = bannedWord;
    }

    public new string EditHeader(string header)
    {
        header = header.Insert(header.Length,$" {Name}");
        string scrim = header.Replace(BanWord,"");
        return scrim;
    }

    public static Linguist Parse(string line)
    {
        int pay;
        string [] mas = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (mas.Length != 3 || !int.TryParse(mas[1], out pay) || pay < 0)
        {
            throw new ArgumentException("Incorrect input");
        }
        return new Linguist(mas[0], pay, mas[2]);
    }
}