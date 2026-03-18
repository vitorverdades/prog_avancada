class Program
{
    static void Main(string[] args)
    {
        ContaNormal contaNormal = new ContaNormal("001", "Chamon Chamada");
        ContaEspecial contaEspecial = new ContaEspecial("002", "Chama Chamon", 500.0);

        contaNormal.Depositar(1000.0);
        contaEspecial.Depositar(800.0);

        contaNormal.Sacar(300.0);
        contaNormal.Sacar(800.0);

        contaEspecial.Sacar(500.0);
        contaEspecial.Sacar(1000.0);

        Console.WriteLine("\nExtrato Conta Normal:");
        foreach (string linha in contaNormal.Extrato)
        {
            Console.WriteLine(linha);
        }

        Console.WriteLine("\nExtrato Conta Especial:");
        foreach (string linha in contaEspecial.Extrato)
        {
            Console.WriteLine(linha);
        }
    }
}
