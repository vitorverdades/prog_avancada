using System;
using System.Collections.Generic;

public class ContaBancaria
{
    public string NumeroConta { get; set; }
    public string NomeTitular { get; set; }
    public double Saldo { get; set; }

    public List<string> Extrato { get; set; }

    public ContaBancaria(string numeroConta, string nomeTitular)
    {
        NumeroConta = numeroConta;
        NomeTitular = nomeTitular;
        Saldo = 0.0;
        Extrato = new List<string>();
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            string movimentacao = $"Depósito: +R${valor:F2}";
            Extrato.Add(movimentacao);
        }
        else
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
    }

    public virtual void Sacar(double valor)
    {
        if (valor > 0)
        {
            Saldo -= valor;
            string movimentacao = $"Saque: -R${valor:F2}";
            Extrato.Add(movimentacao);
        }
        else
        {
            Console.WriteLine("Valor de saque inválido.");
        }
    }
}
