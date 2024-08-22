using System;

class Program
{
    public void Area(int l, int b)
    {
        int c = l * b;
        Console.WriteLine($"The area of the rectangle is: {c}");
    }

    public void Area(float r)
    {
        float c = (r * r) * 22 / 7;
        Console.WriteLine($"The area of the circle is: {c}");
    }
    public void AreaTriangle(int l, int b)
    {
        double c = 0.5 * l * b;
        Console.WriteLine($"The area of the triangle is: {c}");
    }
    public void Area(int a)
    {
        double c = a*a;
        Console.WriteLine($"The area of the triangle is: {c}");
    }

    public static void Main(string[] args)
    {
        Program p = new Program();
        p.Area(5, 10);
        p.Area(7.0f);
        p.Area(5);
        p.AreaTriangle(5, 10);
        Console.ReadKey();
    }
}
