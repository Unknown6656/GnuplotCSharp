﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AwokeKnowing.GnuplotCSharp;
using System.Threading;

class Demo
{
    static void Main(string[] args)
    {
        GnuPlot.Plot("sin(x) + 2", "lc rgb \"magenta\" lw 5");
        Console.ReadKey();

        GnuPlot.HoldOn();
        GnuPlot.Plot("cos(x) + x");
        GnuPlot.Plot("cos(2*x)", "with points pt 3");
        Console.ReadKey();
        
        GnuPlot.HoldOff();
        GnuPlot.Plot("atan(x)");
        Console.ReadKey();

        double[] X = new double[] { -10, -8.5, -2, 1, 6, 9, 10, 14, 15, 19 };
        double[] Y = new double[] { -4, 6.5, -2, 3, -8, -5, 11, 4, -5, 10 };

        GnuPlot.Plot(X, Y);
        Console.ReadKey();

        var r = new Random();
       
        GnuPlot.HoldOn();
        for (int i = 0; i < 14; i++)
        {
            var Xr = new double[10];
            var Yr = new double[10];
            double rx=r.Next(-20,20);
            double ry = r.Next(-10, 10);
            for (int di = 0; di < 10; di++)
            {
                Xr[di] = rx+r.Next(-5, 5);
                Yr[di] = ry+r.Next(-3, 3);
            }

            GnuPlot.Plot(Xr, Yr, "title 'point style "+i+"' pt " + i);
            Thread.Sleep(800);
        }
        Console.ReadKey();

    }
}
