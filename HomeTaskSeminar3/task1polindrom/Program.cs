Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int temp = 0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] == number[number.Length - i - 1]) temp++;
}
if (temp == number.Length) Console.WriteLine("Число палиндром");
else Console.WriteLine("не палиндром");