using System;
using Cartoes;

class Program
{
    static void Main(string[] args)
    {
        CartaoWeb[] cartoes = new CartaoWeb[3];

        cartoes[0] = new DiaDosNamorados("Ana");
        cartoes[1] = new Natal("Bruno");
        cartoes[2] = new Aniversario("Carlos");

        for (int i = 0; i < cartoes.Length; i++)
        {
            cartoes[i].ExibirMensagem();
        }
    }
}
