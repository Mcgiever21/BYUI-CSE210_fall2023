using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace figures;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> sap = new();

        Circle c = new();
        c.SetColor("blue");
        c.Setfactor(6,3);

        Rectangle r = new();
        r.SetColor("green");
        r.Setfactor(12, 4);

        Square s = new();
        s.SetColor("red");
        s.Setfactor(3,5);

        DisplayShapes(c);
        DisplayShapes(r);
        DisplayShapes(s);

        sap.Add(s);
        sap.Add(r);
        sap.Add(c);

        DisplayAll(sap);
        
    }
    public static void DisplayShapes(Shape shape)
        {
            Console.WriteLine($"{shape.GetColor()}, {shape.GetArea()}");
        }
    public static void DisplayAll(List<Shape> zap)
    {
        foreach(var i in zap)
        Console.Write($"{i.GetColor()}, {i.GetArea()}\n");
    }
}