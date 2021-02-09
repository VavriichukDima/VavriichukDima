namespace HomeWork_3
{
    using System;

    /// <summary>
    /// a.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// a.
        /// </summary>
        /// <param name="args">project.</param>
        public static void Main(string[] args)
        {
            Console.Write("New random array:");
            string tmp = Console.ReadLine();
            int n = Convert.ToInt32(tmp);
            int[] arr = new int[n];
            int evenCount = 0;
            int oddCount = 0;
            char[] evenArr = new char[n];
            char[] oddArr = new char[n];
            char[] letterArr = new char[26] { 'A', 'b', 'c', 'D', 'E', 'f', 'g', 'H', 'I', 'J', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1, 26);
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2) == 0)
                {
                    evenArr[i] = letterArr[arr[i] - 1];
                    oddArr[i] = '0';
                    if (evenArr[i] >= 'A')
                    {
                        evenCount++;
                    }
                }
                else
                {
                    evenArr[i] = '0';
                    oddArr[i] = letterArr[arr[i] - 1];
                    if (oddArr[i] >= 'A')
                    {
                        oddCount++;
                    }
                }
            }

            Console.WriteLine();
            if (evenCount > oddCount)
            {
                Console.WriteLine("Even array have more title letters than odd array");
            }
            else
            {
                Console.WriteLine("Odd array have more title letters than even array");
            }

            Console.WriteLine();
            Console.WriteLine("EvenArr:");
            for (int i = 0; i < evenArr.Length; i++)
            {
                Console.Write($"{evenArr[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine("OddArray: ");
            for (int i = 0; i < oddArr.Length; i++)
            {
               Console.Write($"{oddArr[i]} ");
            }
        }
    }
}
