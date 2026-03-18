public class ContaNormal : ContaBancaria
{
    public ContaNormal(string numeroConta, string nomeTitular)
        : base(numeroConta, nomeTitular)
    {
    }

    public override void Sacar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
        }
        else if (Saldo >= valor)
        {
            base.Sacar(valor);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}
