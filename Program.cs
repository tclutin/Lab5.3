namespace Lab5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim();
            string[] numbers = input.Split(' ');

            Console.Write("First array: ");
            PrintArray(numbers);
            ChangeElements(numbers);
        }

        private static void PrintArray(string[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i]);
                Console.Write(" ");
            }
        }

        private static int Factorial(int elementInt)
        {
            int sum = 1;
            for (int j = 1; j < elementInt + 1; j++)
            {
                sum *= j;
            }
            return sum;
        }

        private static int RoundingNumber(decimal elementDouble)
        {
            decimal result = decimal.Round(elementDouble, 2, MidpointRounding.AwayFromZero);
            result -= (int)(decimal.Round(elementDouble, 2, MidpointRounding.AwayFromZero));
            result *= 100;
            return (int)result;
        }

        private static void ChangeElements(string[] numbers)
        {
            Console.Write("\nSecond array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                int elementInt;
                decimal elementDecimal;
                if (int.TryParse(numbers[i], out elementInt))
                {
                    if (elementInt >= 0)
                    {
                        Console.Write(Factorial(elementInt));
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(elementInt);
                        Console.Write(" ");
                    }

                }
                else if (decimal.TryParse(numbers[i], out elementDecimal))
                {

                    if (numbers[i].Contains('-')) Console.Write("-");

                    elementDecimal = Math.Abs(elementDecimal);
                    Console.Write(RoundingNumber(elementDecimal));
                    Console.Write(" ");
                }
            }
        }
    }

}