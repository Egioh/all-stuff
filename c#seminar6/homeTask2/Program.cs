// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int RememberUserInput(string text)
{
    int input =int.Parse(Console.ReadLine());
    return input;
}

int a1 = RememberUserInput("Ведите первую координату первой прямой a1:");
int a2 = RememberUserInput("Ведите вторую координату первой прямой a2:");
int b1 = RememberUserInput("Ведите первую координату второй прямой b1:");
int b2 = RememberUserInput("Ведите вторую координату второй прямой b2:");

void CrossPoint (int a1,int a2,int b1,int b2)
{
int x = (b2-b1)/(a1-a2);
int y = (a1*(b2-b1)/(a1-a2)+b1);
Console.WriteLine ($"точка пересечения прямых x= {x} и y= {y}");
}
CrossPoint (a1,a2,b1,b2);
