// Задайте массив вещественных чисел. Найдите разницу между максимальным
//  и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];
void FillAndPrintArrayRandomNumbers(double[] Array)

{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().NextDouble();
        Console.WriteLine(Array[i]);
    }
}
void DifferenceOfMaxMinArrayNumbers (double [] Array)
{
    double min =1;
    double max =0;
    double diff =0;
for (int i=0;i<Array.Length;i++)
    {
       
        if (Array[i]<min) min = Array[i];
        if (Array[i]>max) max = Array[i];
        
            diff = max-min;
        
    }    
    Console.WriteLine ($"разница между значением максимального и минимального элементов массива:{diff}");
}


FillAndPrintArrayRandomNumbers(array);
DifferenceOfMaxMinArrayNumbers(array);