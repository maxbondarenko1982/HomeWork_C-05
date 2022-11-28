// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] numbers = new int[10];
int sumnumbers = 0;

RandomNumbers(numbers);

for (int i = 1; i < numbers.Length; i+=2)

    sumnumbers = sumnumbers + numbers[i];

System.Console.WriteLine("");

System.Console.WriteLine("Сумма чисел с нечетным индексом равна: " + sumnumbers);    


void RandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
       numbers[i] = new Random().Next(1,10);
       System.Console.Write(numbers[i] + " ");
    }
}

