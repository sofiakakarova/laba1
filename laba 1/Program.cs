using System;
using System.Collections.Generic;
using System.Linq;

class Banana
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 1, 2, 5, 6, 7, 8, 7, 9, 10, 10 };

        int countOfPairs = CountEqualPairs(numbers);

        Console.WriteLine($"Кількість пар: {countOfPairs}");
    }

    static int CountEqualPairs(List<int> numbers)
    {
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (var number in numbers)
        {
            if (frequencyMap.ContainsKey(number))
            {
                frequencyMap[number]++;
            }
            else
            {
                frequencyMap[number] = 1;
            }
        }

        int countOfPairs = frequencyMap.Values.Sum(frequency => frequency / 2);

        return countOfPairs;
    }
}