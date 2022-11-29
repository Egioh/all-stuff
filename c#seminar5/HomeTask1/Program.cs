// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[12];
void FillArrayRandomNumbers(int[] Array)

{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(100, 1000);
        Console.WriteLine(Array[i]);
    }
}
void SumOfEvenNumbers (int [] Array)
{
    int sum=0;
for (int i=0;i<Array.Length;i++)
    {
        if (Array[i]%2==0) 
        {
            sum++;
        }
    }    
    Console.WriteLine (sum);
}


FillArrayRandomNumbers(array);
SumOfEvenNumbers(array);