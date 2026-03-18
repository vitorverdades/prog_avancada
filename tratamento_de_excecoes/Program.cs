using System;

public class SomaAteCem
{
    public static void Main(string[] args)
    {
        int soma = 0;
        int somaAntesEstourar = 0;
        int quantidade = 0;
        bool estourou = false;

        while (!estourou)
        {
            try
            {
                Console.Write("Digite um número inteiro: ");
                string linha = Console.ReadLine();          // lê como string
                int n = int.Parse(linha);                   // pode lançar FormatException

                somaAntesEstourar = soma;
                soma += n;
                quantidade++;

                if (soma > 100)
                {
                    throw new ExcecaoAcimaDeCem("A soma passou de 100!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido! Digite apenas números inteiros.");
            }
            catch (ExcecaoAcimaDeCem e)
            {
                Console.WriteLine(e.Message);
                estourou = true;
            }
        }

        if (quantidade > 0)
        {
            double media = (double)somaAntesEstourar / quantidade;
            Console.WriteLine("Soma antes de passar de 100: " + somaAntesEstourar);
            Console.WriteLine("Quantidade de números somados: " + quantidade);
            Console.WriteLine("Média: " + media);
        }
        else
        {
            Console.WriteLine("Nenhum número foi somado.");
        }

        Console.WriteLine("Fim do programa. Tecle Enter para sair.");
        Console.ReadLine();
    }
}
