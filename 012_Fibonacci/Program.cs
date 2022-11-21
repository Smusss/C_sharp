// фибоначчи и рекурсия

int Fibo(int n)
{
    if (n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibo(n - 1) + Fibo(n - 2);
    }
}

int num = 30;
for (int i = 1; i < num; i++)
{
    Console.WriteLine($"{Fibo(i)} ");
}