using System;

namespace ConsoleApp7
{
    class Account
    {
        // ������� void (string, int, int)
        public delegate void GetEvent(string info);
        public event GetEvent MyAccount;
        public Account(int sum)
        {
            Sum = sum;
        }
        // ����� �� �����
        public int Sum { get; private set; }
        // ���������� ������� �� ����
        public void Put(int sum)
        {
            Sum += sum;
            MyAccount?.Invoke($"Put {sum}-{Sum}");
        }
        // �������� ������� �� �����
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
            }
            MyAccount?.Invoke($"Take {sum}-{Sum}");
        }
    }
    class Program
    {
        public static void Message(string str) => Console.WriteLine(str);
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.MyAccount += Message;
            acc.Put(20);    // ��������� �� ���� 20
            acc.Take(70);   // �������� ����� �� ����� 70
            acc.Take(180);  // �������� ����� �� ����� 180*
            Console.Read();
        }
    }
}
