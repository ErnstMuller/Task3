﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите четырёхзначное число");
        string n = Console.ReadLine();
        char[] symbol = n.ToCharArray();
        string x = string.Concat(symbol[1], symbol[0], symbol[3], symbol[2]);
        Console.WriteLine(x);
        Console.ReadKey();
    }
}

