Console.WriteLine("Введите число для просмотра таблицы : ");
int n = int.Parse(Console.ReadLine());
double  coub= 0;
for (int i = 1; i<=n; i++)
{
    coub = Math.Pow(i,3);
    Console.WriteLine (coub);
}
