using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class RandomProxy
{
    StreamWriter log;
    Dictionary<string, int> DicOfLogin = new Dictionary<string, int>();
    Random random = new Random(1579);
    public RandomProxy(StreamWriter log)
    {
        this.log = log;
    }

    public void Register(string login, int age)
    {
        if (DicOfLogin.ContainsKey(login))
        {
            throw new ArgumentException($"User {login}: login is already registered");
        }
        else
        {
            DicOfLogin.Add(login, age);
            log.WriteLine($"User {login}: login registered");
        }
    }

    public int Next(string login)
    {
        int number;
        int temp;
        if (!DicOfLogin.ContainsKey(login))
        {
            throw new ArgumentException($"User {login}: login is not registered");
        }
        else if (DicOfLogin.TryGetValue(login, out temp) && temp > 20)
        {
            number = random.Next(0, int.MaxValue);
            log.WriteLine($"User {login}: generate number {number}");
            return number;
        }
        else
        {
            number = random.Next(0, 1000);
            log.WriteLine($"User {login}: generate number {number}");
            return number;
        }

    }

    public int Next(string login, int maxValue)
    {
        int temp;
        if (!DicOfLogin.ContainsKey(login))
        {
            throw new ArgumentException($"User {login}: login is not registered");
        }
        else if (DicOfLogin.TryGetValue(login, out temp) && temp < 20 && maxValue > 1000)
        {
            throw new ArgumentOutOfRangeException($"User {login}: random bounds out of range");
        }
        else
        {
            int num = random.Next(0, maxValue);
            log.WriteLine($"User {login}: generate number {num}");
            return num;
        }

    }

    public int Next(string login, int minValue, int maxValue)
    {
        int temp;
        if (!DicOfLogin.ContainsKey(login))
        {
            throw new ArgumentException($"User {login}: login is not registered");
        }
        else if (DicOfLogin.TryGetValue(login, out temp) && temp < 20 && (maxValue-minValue) > 1000)
        {
            throw new ArgumentOutOfRangeException($"User {login}: random bounds out of range");
        }
        else
        {
            int num = random.Next(minValue, maxValue);
            log.WriteLine($"User {login}: generate number number");
            return num;
        }
    }
}
