int readUserData (string text)
{
    Console.WriteLine (text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void fillArrayRandomNumbers(int[] array)
{
    for (int i=0; i<array.Length; i++)
    array[i]= new Random().Next(0,100);
}

void PrintArray (int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
    Console.Write($"{array[i]} ");
    }
}

int[] Array = new int[readUserData("введите размкр массива")];
fillArrayRandomNumbers(Array);
PrintArray (Array);