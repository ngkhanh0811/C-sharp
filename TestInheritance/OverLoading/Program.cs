class Area
{
    static int CalculateArea (int len, int wide)
    {
        return len * wide;
    }

    static double CalculateArea(double valOne, double ValTwo)
    {
        return 0.5 * valOne * ValTwo;
    }

    static void Main(string[] args)
    {
        int length = 10;
        int breadth = 22;
        double tbase = 2.5;
        double theight = 1.5;
        Console.WriteLine("Area of Rangle: " + CalculateArea(length, breadth));
        Console.WriteLine("Area of Triangle: " + CalculateArea(tbase, theight));
    }
}