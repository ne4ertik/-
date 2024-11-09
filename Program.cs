using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 2, 2, 1, 1, 1, 2, 2, 3, 3 };

        int majorityNumber = FindMajorityNumber(numbers);

        if (majorityNumber != -1)
        {
            Console.WriteLine("Мажоритарное число: {majorityNumber}");
        }
        else
        {
            Console.WriteLine("Мажоритарного числа нет");
        }
    }

    static int FindMajorityNumber(int[] numbers)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in numbers)
        {
            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else if (num == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }

        count = 0;
        foreach (int num in numbers)
        {
            if (num == candidate)
            {
                count++;
            }
        }

        return count > numbers.Length / 2 ? candidate : -1;
    }
}