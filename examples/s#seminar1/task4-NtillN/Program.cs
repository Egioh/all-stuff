Console.Write("Введите  число : ");
int n = int.Parse(Console.ReadLine());
int count = n-n*2;
while (count<n+1)
{
    Console.WriteLine(count);
    count++;
}