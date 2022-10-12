while(true)
{
    Console.WriteLine("a");
    double a = Convert.ToDouble(Console.ReadLine());
    if (a == 0)
    {
        Console.WriteLine("а не должно быть равно 0");
        continue;

    }
    else
    {
        Console.WriteLine("b");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("c");
        double c = Convert.ToDouble(Console.ReadLine());

        double D = (b * b) - 4 * a * c;

        if (D < 0)
        {
            Console.WriteLine("Нет решений");
        }
        else if (D == 0)
        {
            Console.WriteLine($"x = {-b / (2 * a)}");
        }
        else if (D > 0)
        {
            Console.WriteLine($"x1 = {-b + Math.Sqrt(D) / (2 * a)}");
            Console.WriteLine($"x2 = {-b - Math.Sqrt(D) / (2 * a)}");
        }
    }


}
