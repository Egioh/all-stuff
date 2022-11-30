// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("какое количествоцифр планируется к вводу?");

int numberOfnumbers = int.Parse(Console.ReadLine());
int[] array = new int [numberOfnumbers];

void NumberOfPositiveNumbers (int[] Array) 
{
    int sum =0;
    for (int i=0;i<Array.Length; i++)
    {
        Console.WriteLine ("Введите число");
        Array[i]= int.Parse(Console.ReadLine());
        if (Array[i]>0) sum++;
    }
    Console.WriteLine($"всего введено {sum} чисел больше 0");
}

NumberOfPositiveNumbers(array);