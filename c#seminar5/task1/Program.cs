// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//  сумма отрицательных равна -20.

int[] array = new int[12];
void FillArrayRandomNumbers(int[] Array)

{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-9, 10);
        //Console.WriteLine(Array[i]);
    }
}

void PrintSumOfNumbers(int[] Array)
{
    int SumOfPositive = 0;
    int SumOfnegative = 0;
    
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] >= 0)
                {
                    SumOfPositive = SumOfPositive + Array[i];
                }
            else
                {
                    SumOfnegative = SumOfnegative + Array[i];
                }
        }
Console.WriteLine(SumOfPositive);
Console.WriteLine(SumOfnegative);
}
FillArrayRandomNumbers(array);
PrintSumOfNumbers(array);