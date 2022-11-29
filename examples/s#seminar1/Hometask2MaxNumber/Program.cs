Console.Write("Введите первое  число : ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе  число : ");
int secondNumber = int.Parse(Console.ReadLine());
Console.Write("Введите третье  число : ");
int thirdNumber = int.Parse(Console.ReadLine());

int max = firstNumber;
if (max<firstNumber) max =firstNumber;
if (max<secondNumber) max =secondNumber;
if (max<thirdNumber) max =thirdNumber;
Console.WriteLine($"наибольшее из трех чисел ={max}");
