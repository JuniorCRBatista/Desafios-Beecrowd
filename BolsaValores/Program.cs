using System;
public class Program
{
    public static void Main()
    {
        int dias, taxa;
        int[] bolsa;
        string[] line = Console.ReadLine().Split(' ');
        dias = int.Parse(line[0]);
        taxa = int.Parse(line[1]);
        bolsa = new int[dias];
        line = Console.ReadLine().Split(' ');
        for (int i = 0; i < dias; i++)
        {
            bolsa[i] = int.Parse(line[i]);
        }
        Console.WriteLine(LucroMaximo(bolsa, dias, taxa));
    }
    public static int LucroMaximo(int[] bolsa, int dias, int taxa)
    {
        int lucroAtual, lucroFinal, lucroMaximo;
        int i;
        lucroMaximo = 0;
        lucroAtual = lucroFinal = bolsa[0];
        for (i = 1; i < dias; ++i)
        {
            if ((lucroAtual > bolsa[i] && (lucroAtual - bolsa[i] >= taxa)) || bolsa[i] < lucroFinal)
            {
                if (lucroAtual - lucroFinal - taxa > 0)
                    lucroMaximo += (int)(lucroAtual - lucroFinal - taxa);
                lucroAtual = lucroFinal = bolsa[i];
            }
            if (bolsa[i] > lucroAtual)
                lucroAtual = bolsa[i];
        }
        if (lucroAtual - lucroFinal - taxa > 0)
            lucroMaximo += (int)(lucroAtual - lucroFinal - taxa);
        return lucroMaximo;
    }
}
