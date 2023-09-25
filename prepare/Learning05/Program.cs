using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        string name = ReturnName();
        int num = ReturnNumber();
        DisplayId(name, num);
        DsiplaySquare(num);

    }

    static string ReturnName()
    {
        Console.WriteLine("enter Name here:");
        string name = Console.ReadLine();
        return name;
    }

    static int ReturnNumber()
    {
        Console.WriteLine("enter Number here:");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static void DsiplaySquare(int a)
    {
        Console.WriteLine(a^2);
    }

    static void DisplayId(string b, int c)
    {
        Console.WriteLine($"Your Name is {0}, Your number ID is {2}", b, c);
    }
}