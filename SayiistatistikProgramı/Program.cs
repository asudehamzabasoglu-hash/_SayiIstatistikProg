using System;
using System.Numerics;
using System.Security;

int[] numbers = new int[5];
int N = 0;

do
{
    Console.Write("Enter the numbers: ");
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[N] = number; //girilen değeri diziye kaydet
    N++;
} while (N < numbers.Length);

// toplam
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine($"Total: {sum}");

// min max
(int minNum, int maxNum) = FinfMinMax(numbers);

static (int minNum, int maxNum) FinfMinMax(int[] numbers)
{
    int min = numbers[0];
    int max = numbers[0];
    foreach (var num in numbers)
    {
        if (num < min) min = num;

        if (num > max) max = num;

    }
    return (min, max);
}

// ortalama 
double average = (double)sum / numbers.Length;
Console.WriteLine($"Your Average: {average:F2}");

Console.ReadKey();



