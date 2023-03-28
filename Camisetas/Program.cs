using System;
using System.Collections.Generic;
class Camiseta
{
    public string Nome;
    public string Cor;
    public string Tamanho;
    public Camiseta(string n, string c, string t)
    {
        Nome = n;
        Cor = c;
        Tamanho = t;
    }
}
class Program
{
    static int comp(Camiseta a, Camiseta b)
    {
        if (a.Cor == b.Cor)
        {
            if (a.Tamanho == b.Tamanho)
            {
                return String.Compare(a.Nome, b.Nome);
            }
            return a.Tamanho.CompareTo(b.Tamanho) > 0 ? -1 : 1;
        }
        return a.Cor.CompareTo(b.Cor) < 0 ? -1 : 1;
    }
}