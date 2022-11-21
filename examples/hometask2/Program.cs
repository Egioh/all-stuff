Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
int a =10;
if (number>99)
{
    while (number>1000){
    number = number/a;}
    number = number%a;
    Console.Write(number);
}
else 
{
Console.WriteLine("третьего числа нет");
}

