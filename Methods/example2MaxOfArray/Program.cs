void FillArray(int [] arrayName)
{
    int lenght = arrayName.Length;
    int index=0;
    while (index < lenght)
    {
    arrayName[index] = new Random().Next(1,10);
    index++;
    }

}

void PrintArray(int [] arname)
{
   int position = arname.Length;
   int count = 0;
    while (count<position)
    {
        Console.WriteLine (arname[count]);
        count ++;
    }
}

int FindNumber (int [] ar, int find)
{
    int index = ar.Length;
    int i= 0;
    int pos = -1;
    while (i<index)
    {
        if (ar[i]==find)
        {
            pos =i;
            break;
        }
        else i++;
    }
    return pos;
}
int[] array= new int [10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine (FindNumber (array, 6));