void fillArrayRandomNumbers(int[] array)
{
    for (int i=0; i<array.Length; i++)
    array[i]= new Random().Next(0,2);
}

void PrintArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
    Console.Write($"{array[i]} ");
    }
}

int[] Array = new int[8];
fillArrayRandomNumbers(Array);
PrintArray (Array);
