using System;

public class Student
{
    public int Grade;
    public string NameOfStudent;
    private Student(string name, int grade)
    {
        NameOfStudent = name;
        Grade = grade;
    }

    public static Student Parse(string line)
    {
        int num;
        string[] mas = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (!int.TryParse(mas[1], out num))
        {
            throw new ArgumentException("Incorrect input mark");
        }
        char[] ch = mas[0].ToCharArray();
        if (mas[0].Length < 3 || ch[0] >= 'a')  
        {
            throw new ArgumentException("Incorrect name");
        }
        if (num < 0 || num > 10)
        {
            throw new ArgumentException("Incorrect mark");
        }
        return new Student(mas[0], num);
    }

    public override string ToString()
    {
        return $"{NameOfStudent} got a grade of {Grade}.";
    }
}