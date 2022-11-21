Console.WriteLine("введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a==b*b) 
{
    Console.WriteLine("первое число квадрат второго");
    if (b==a*a) Console.WriteLine("второе число квадрат первого");
}

else 
{
Console.WriteLine("никто никому не квадрат");
}