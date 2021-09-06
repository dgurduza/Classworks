using System;

abstract class Editor
{
    public int Salary;
    public string Name;
    protected Editor(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    protected string EditHeader(string header)
    {
        return (header+$" {Name}");
    }

    public int CountSalary(string oldStr, string newStr)
    {
        char[] old = oldStr.ToCharArray();
        char[] str = newStr.ToCharArray();
        return Salary * Math.Abs(str.Length-old.Length);
    }
}