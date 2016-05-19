namespace Arrays
{
    using System;
    using System.Linq;

    public class ArraysMain
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string line = Console.ReadLine();

            while (!line.Equals("stop"))
            {
                string command = line.Split(' ')[0];
                int[] args = new int[2];

                if (command.Equals("add") ||
                    command.Equals("substract") ||
                    command.Equals("multiply"))
                {
                    string[] stringParams = line.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(stringParams[0]);
                    args[1] = int.Parse(stringParams[1]);

                }

                PerformAction(array, command, args);

                PrintArray(array);
                Console.WriteLine();

                line = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
			long lastElement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
			array[0] = lastElement;
			return array;
        }

        private static void ArrayShiftLeft(long[] array)
        {
			long firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
			array[array.Length - 1] = firstElement;
			return array;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
