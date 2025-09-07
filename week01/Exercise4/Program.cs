using System;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        int responseNumber = -1;

        while (responseNumber != 0)
        {
            Console.Write("Enter a number, type 0 when finished: ");
            string userList = Console.ReadLine();

            responseNumber = int.Parse(userList);

            if (responseNumber != 0)
            {
                numbers.Add(responseNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum} ");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average} ");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}