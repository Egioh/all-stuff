﻿Console.WriteLine("Веддите координату Хa: ");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Веддите координату Ya: ");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Веддите координату Хb: ");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Веддите координату Yb: ");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("Веддите координату Za: ");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("Веддите координату Zb: ");
int zb = int.Parse(Console.ReadLine());
double A = Math.Pow((xb-xa),2);
double B = Math.Pow((yb-ya),2);
double C = Math.Pow((zb-za),2);
double distance = Math.Sqrt(A+B+C);
Console.WriteLine(distance);