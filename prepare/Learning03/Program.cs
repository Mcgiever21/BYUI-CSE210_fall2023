using System;
using System.Collections.Generic;

namespace learning03;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        int top = 6;
        int bottom = 7;
        
        Fraction fraction = new Fraction();
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetFractionDecimal());
        

        Fraction fraction1 = new Fraction(top);

        Console.WriteLine("enter top integer:");
        top = int.Parse(Console.ReadLine());
        fraction1.SetTop(top);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetFractionDecimal());


        Fraction fraction2 = new Fraction(top, bottom);

        Console.WriteLine("enter top integer:");
        top = int.Parse(Console.ReadLine());
        fraction2.SetTop(top);

        Console.WriteLine("enter bottom integer:");
        bottom = int.Parse(Console.ReadLine());
        fraction2.SetBottom(bottom);

        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetFractionDecimal());

    }
}