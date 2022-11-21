Console.Write("Введите  число для которого хотите увидеть таблицу умножения до 10: ");
int n = int.Parse(Console.ReadLine());
int count = 1;
while (count<11)
{
    Console.WriteLine($"{n}*{count}={n*count}");
    count++;
}