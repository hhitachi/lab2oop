﻿﻿//var 12
using System;

class GetY{
    static double GetX1Min(){
        Console.Write("Введіть X1min: ");
        string sx1Min = Console.ReadLine();
        double x1Min = Double.Parse(sx1Min);
        return x1Min;
    }

    static double GetX1Max(){
        Console.Write("Введіть X1max: ");
        string sx1Max = Console.ReadLine();
        double x1Max = double.Parse(sx1Max);
        return x1Max;
    }

    static double GetDx1(){
        Console.Write("Введіть dX1: ");
        string sdx1 = Console.ReadLine();
        double dx1 = double.Parse(sdx1);
        return dx1;
    }

    static double GetX2Min(){
        Console.Write("Введіть X2min: ");
        string sx2Min = Console.ReadLine();
        double x2Min = Double.Parse(sx2Min);
        return x2Min;
    }
    static double GetX2Max(){
        Console.Write("Введіть X2max: ");
        string sx2Max = Console.ReadLine();
        double x2Max = double.Parse(sx2Max);
        return x2Max;
    }
    static double GetDx2(){
        Console.Write("Введіть dX2: ");
        string sdx2 = Console.ReadLine();
        double dx2 = double.Parse(sdx2);
        return dx2;
    }
    static void GetAllData(out double x1Min, out double x1Max, out double dx1, out double x2Min, out double x2Max, out double dx2){
        x1Min = GetX1Min();
        x1Max = GetX1Max();
        dx1 = GetDx1();
        x2Min = GetX2Min();
        x2Max = GetX2Max();
        dx2 = GetDx2();
    }
    static void OutPut1(double x1Min, double x2Min, double x1Max, double x2Max, double dx1, double dx2){
        double y;
        double x1 = x1Min;
        double x2;

        while (x1 <= x1Max){
            x2 = x2Min;
            while (x2 <= x2Max){
                y = Math.Round(Math.Pow(x1, 2) + Math.Exp(x2), 2) ;
                Console.WriteLine("x1 = {0}\tx2 = {1}\t\ty = {2}", x1, x2, y);
                x2 += dx2;
            }
            x1 += dx1;
        }
    }
    static void GetSum(double x1Min, double x2Min, double x1Max, double x2Max, double dx1, double dx2){
        double y = 0;
        for (double i = x1Min; i <= x1Max; i += dx1){
            if (Math.Cos(i) < 0){}
            else y += Math.Cos(i);
            for (double j = x2Min; j <= x2Max; j += dx2){
                if (Math.Cos(j) < 0){}
                else y += Math.Cos(j);
            }
        }
        Console.WriteLine("\nСума всіх додатніх косинусів проміжних значень = {0}", y);
    }
    static void AddTask(double x1Min, double x2Min, double x1Max, double x2Max, double dx1, double dx2){
        double y;
        for (double i = x1Min; i <= x1Max; i += dx1){
            for (double j = x2Min; j <= x2Max; j += dx2){
                y = (Math.Pow(Math.Cos(i), 3) + 45 + j)/(Math.Pow(i, 13) + Math.Cos(j));
                Console.WriteLine("x1 = {0}\tx2 = {1}\t\ty = {2}", i, j, y);
            }
        }
    }
    static void Main(){
        double x1Min, x1Max, dx1, x2Min, x2Max, dx2;
        GetAllData(out x1Min, out x1Max, out dx1, out x2Min, out x2Max, out dx2);

        OutPut1(x1Min, x2Min, x1Max, x2Max, dx1, dx2);
        GetSum(x1Min, x2Min, x1Max, x2Max, dx1, dx2);

        Console.WriteLine("\nПерейти до наступного завдання?(yes/no)");
        string response = Console.ReadLine();
        if (response == "yes"){
            Console.Clear();
            GetAllData(out x1Min, out x1Max, out dx1, out x2Min, out x2Max, out dx2);
            AddTask(x1Min, x2Min, x1Max, x2Max, dx1, dx2);
        } else if (response == "no"){

        } else Console.WriteLine("Incorrest value!");

        Console.ReadKey();
    }
}