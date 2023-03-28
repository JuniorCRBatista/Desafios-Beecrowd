using System;
class Program
{
    static void Main(string[] args)
    {
        int x, digitos;
        int i, n;
        while (int.TryParse(Console.ReadLine(), out x))
        {
            n = 1;
            digitos = 1;
            while (n % x != 0)
            {
                n = (10 * n + 1) % x;
                digitos++;
            }
            Console.WriteLine(digitos);
        }
    }
}