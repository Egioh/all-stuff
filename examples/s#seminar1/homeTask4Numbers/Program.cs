Console.Write("Введите число : ");
int Number = int.Parse(Console.ReadLine());

int count = 1;

while (count < Number + 1)
{
    if (count%2 == 0) Console.WriteLine(count);
    count++;
}