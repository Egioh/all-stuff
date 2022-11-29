int[] array = {10,9,8,7,6,5,4,3,2,1,5,6,8,9};
void PrintArray (int[] arr)
{
    int count = arr.Length;
    for (int i=0; i<count; i ++)
    Console.Write($"{arr[i]} ");
    Console.WriteLine();
}


void ArraySort (int[] ar)
{
    for (int i=0;i<ar.Length -1; i++)
    {
        int min = i;
        for (int j=i+1;j<ar.Length; j++)
        {
             if (ar[j]<ar[min]) 
             min = j; 
        }
        int temp = ar[i];
        ar[i] = ar[min];
        ar[min]=temp;
    }
}
PrintArray(array);
ArraySort (array);
PrintArray (array);