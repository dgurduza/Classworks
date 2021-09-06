using System;
using System.Linq;
using System.Text;

class Student
{
    private long _id;
    private int _testNum;

    public long Id
    {
        get => _id;
        set
        {
            if (value < 1 || value > 1000)
            {
                throw new ArgumentException("Id: Incorrect input.");
            }

            _id = value;
        }
    }

    public int TestNum
    {
        get => _testNum;
        set
        {
            if (value < 1 || value > 1000)
            {
                throw new ArgumentException("TestNum: Incorrect input.");
            }

            _testNum = value;
        }
    }

    public int Grade { get; set; }


    public Student(long id, int testNum)
    {
        Id = id;
        TestNum = testNum;
    }

    public string DoWork(int length)
    {
        if (length < 1 || length > 100)
        {
            throw new ArgumentException("DoWork(length): Incorrect input.");
        }
        var str = string.Empty;
        for (var i = 0; i < length; i++)
        {
            str += TestNum.ToString();
        }

        return str;
    }

    public override string ToString()
    {
        return $"ID :{Id},\tTestNum: {TestNum},\tmark: {Grade}";
    }
}

class Seminarian
{
    private int _pointsToTen;
    private int _hateFullTestNum;


    public int PointsToTen
    {
        get => _pointsToTen;
        set
        {
            if (value < 1 || value > 100)
            {
                throw new ArgumentException("PointsToTen: Incorrect input.");
            }

            _pointsToTen = value;
        }
    }

    public int HateFullTestNum
    {
        get => _hateFullTestNum;
        set
        {
            if (value < 1 || value > 9)
            {
                throw new ArgumentException("HateFullTestNum: Incorrect input.");
            }

            _hateFullTestNum = value;
        }
    }

    public Seminarian(int pointsToTen, int hateFullTestNum)
    {
        PointsToTen = pointsToTen;
        HateFullTestNum = hateFullTestNum;
    }

    public int CheckWork(string work)
    {
        var testNum = (int)double.Parse(work) % 10;
        var grade = testNum == HateFullTestNum ? 1 : work.Length / PointsToTen;
        return grade < 0 ? 0 : (grade > 10 ? 10 : grade);
    }

    public override string ToString()
    {
        return $"PointsToTen : {PointsToTen}\tHateFullTestNum : {HateFullTestNum}";
    }
}
class Program
{
    private static Random Random = new Random();
    static void Main(string[] args)
    {
        var students = GenerateStudents(Random.Next(1, 10));
        var seminarians = GenerateSeminarians(2);

        CheckWorks(students, seminarians);
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine($"Average: {students.Sum(student => student.Grade) / (students.Length * 1.0):F2}");
        foreach (var seminarian in seminarians)
        {
            Console.WriteLine(seminarian);
        }
    }

    private static Student[] GenerateStudents(int number)
    {
        var students = new Student[number];
        for (var studentIndex = 0; studentIndex < students.Length; studentIndex++)
        {
            try
            {
                students[studentIndex] = new Student(Random.Next(-1000, 1001), Random.Next(-10, 10));
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception.Message}");
                Console.WriteLine($"Restart creating.");
                Console.WriteLine();
                studentIndex--;
            }
        }

        return students;
    }

    private static Seminarian[] GenerateSeminarians(int number)
    {
        var seminarians = new Seminarian[number];
        for (var seminarianIndex = 0; seminarianIndex < seminarians.Length; seminarianIndex++)
        {
            try
            {
                seminarians[seminarianIndex] = new Seminarian(Random.Next(-100, 101), Random.Next(-100, 10));

            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception.Message}");
                Console.WriteLine($"Restart creating.");
                Console.WriteLine();
                seminarianIndex--;
            }
        }

        return seminarians;
    }

    private static void CheckWorks(Student[] students, Seminarian[] seminarians)
    {
        for (var index = 0; index < students.Length; index++)
        {
            try
            {
                var student = students[index];

                var grade = seminarians.Sum(seminarian => seminarian.CheckWork(student.DoWork(Random.Next(-100, 101))));

                student.Grade = (int)Math.Round(grade / 2.0);

            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception.Message}");
                Console.WriteLine($"Restart creating.");
                Console.WriteLine();
                index--;
            }
        }
    }
}
