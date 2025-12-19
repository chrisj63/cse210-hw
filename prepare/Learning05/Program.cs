using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Square sq1 = new Square("Purple", 12);
        Console.WriteLine($"The color of the square is: {sq1.GetColor()} and the area is: {sq1.GetArea()} square feet.");
        Console.WriteLine();
        Square sq2 = new Square("Brown", 11);
        Console.WriteLine($"The color of the square is: {sq2.GetColor()} and the area is: {sq2.GetArea()} square inches.");
        Console.WriteLine();
        Circle c1 = new Circle("Blue", 5);
        Console.WriteLine($"The color circle is: {c1.GetColor()} and the area is: {c1.GetArea():F2} square meters.");
        Console.WriteLine();
        Rectangle r1 = new Rectangle("Orange", 5, 4);
        Console.WriteLine($"The color rectangle is: {r1.GetColor()} and the area is: {r1.GetArea()} square centimeters.");
        Console.WriteLine();
        Rectangle r2 = new Rectangle("Beige", 15, 3);
        Console.WriteLine($"The color rectangle is: {r2.GetColor()} and the area is: {r2.GetArea()} square yards.");
        Console.WriteLine();
    }
}