namespace praktika5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            //for (int i = 20; i < 100; i += 4)
            //{ 
            //    Console.WriteLine(i);
            //}

            // Задание 2
            //char symbol = 'E';
            //string result = "";
            //for (int i = 0; i < 6; i++)
            //{ 
            //   result += Convert.ToChar(symbol + i);
            //}
            //Console.WriteLine(result);

            // Задание 3
            int n = 6;
            int m = 9;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }

            // Задание 4
            //int value = 5;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % value == 0 || i % value == value)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // задание 5
            //int i = 5;
            //int j = 99;
            //int difference = 4;

            //for (; ;i++, j-- )
            //{
            //    if ( j - i == difference)
            //    {
            //        Console.WriteLine($"i = {i} \nj = {j}");
            //        break;  
            //    }
            //}
        }
    }
}
