Console.WriteLine("Веддите координату Х: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Веддите координату Y: ");
int y = int.Parse(Console.ReadLine());

if (x>0 && y>0) Console.WriteLine ("Точка принадлежит к первой четверти графика (положительным Х и У)");
if (x>0 && y<0) Console.WriteLine ("Точка принадлежит ко второй четверти графика (положительным Х и отрицательный У)");
if (x<0 && y<0) Console.WriteLine ("Точка принадлежит к третьей четверти графика (отрицательным  Х и У)");
if (x<0 && y>0) Console.WriteLine ("Точка принадлежит к четвертой четверти графика (отрицательный Х и  положительный У)");