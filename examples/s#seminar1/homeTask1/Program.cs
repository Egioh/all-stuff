Console.Write("Введите первое  число : ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число : ");
int secondNumber = int.Parse(Console.ReadLine());
if (firstNumber > secondNumber) Console.Write($"{firstNumber} больше чем {secondNumber}");
if (firstNumber < secondNumber) Console.Write($"{firstNumber} меньше чем {secondNumber}");