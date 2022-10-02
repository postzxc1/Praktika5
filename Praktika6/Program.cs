namespace Praktika6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aaa = 99;
            int Flag = 0;
            double x = 0;
            Console.WriteLine("x: -4, 4");
            Console.WriteLine("------------------");
            for (double y = -4; y < 4; y += 0.5, Flag += 1)
            {
                x = y;
                if (x < 0 & Flag % 2 == 0)
                {
                    Console.WriteLine($"x:{x}     y = {Math.Abs(y)}");
                }
                else if (x < 0 & Flag % 2 == 1)
                {
                    Console.WriteLine($"x:{x}   y = {Math.Abs(y)}");
                }
                else if (Flag % 2 == 0)
                {
                    Console.WriteLine($"x:{x}      y = {Math.Abs(y)}");
                }
                else if (Flag % 2 == 1)
                {
                    Console.WriteLine($"x:{x}    y = {Math.Abs(y)}");
                }
            }
        }
    }
}