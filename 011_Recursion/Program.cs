﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double Factorial(int n)
{
    if (n == 1 || n == 0)
    {
        return 1;
    }
    else
    {
       return n * Factorial(n-1);
    }
}

for (int i = 1; i < 40; i++)
{
    Console. WriteLine(Factorial(i));
}