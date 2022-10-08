namespace Praktika7
{
    internal class Program
    {
        static void Main()
        {

            int[] myArray = { 0, 3, 4, 4, 5, 12, 14, 14, 121, 256, 256 };

            int[] newArray = new int[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (Contains(newArray, myArray[i]) == false)
                    newArray = Resize(newArray, myArray[i]);
            }

            foreach (int i in newArray)
            {
                Console.WriteLine(i);
            }
        }

        static bool Contains(int[] arr, int number)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                    return true;
            }
            return false;
        }


        static int[] Resize(int[] arr, int number)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
                newArr[i] = arr[i];

            newArr[newArr.Length - 1] = number;

            return newArr;
        }
    }
}