int[] array = new int[5];
void FillAndPrintArrayRandomNumbers(int[] Array)

{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(0, 100);
        Console.WriteLine(Array[i]);
    }
}
void SumOfUnevenNumbers (int [] Array)
{
    int sum=0;
for (int i=0;i<Array.Length;i++)
    {
        if (i%2==1) 
        {
            sum= sum+Array[i];
        }
    }    
    Console.WriteLine ($"сумма чисел в нечетных индексах массива:{sum}");
}


FillAndPrintArrayRandomNumbers(array);
SumOfUnevenNumbers(array);