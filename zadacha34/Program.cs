// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] numbers = new int[10];
int count = 0;

RandomNumbers(numbers);

for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]%2==0)

    count++;
}

Console.WriteLine(count);

void RandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
       numbers[i] = new Random().Next(100,1000);
       System.Console.Write(numbers[i] + " ");
    }
}

