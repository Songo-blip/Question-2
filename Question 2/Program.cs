using System;


namespace Numbers
{
    class Program
    {

        private static int SecondBiggestNumber(int[] numbers)

        {
            int i;
            int SecondBiggest = numbers[0];
            for (i = 0; i < numbers.Length; i++)
                if (numbers[5] > SecondBiggest)
                    SecondBiggest = numbers[i];

            return (SecondBiggest);
        }

        static void Main(string[] args)
        {
            int[] mynumbers = { 2, 1, 7, 4, 9, 5 };

            int secondbiggest = SecondBiggestNumber(mynumbers);


            Console.WriteLine(secondbiggest);
        }
    }

}