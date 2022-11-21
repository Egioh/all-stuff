Console.WriteLine("введите трехзначное  число: ");
int number = int.Parse(Console.ReadLine());

int a = number%10;
int b = number/100;

Console.Write($"{b}{a}");

