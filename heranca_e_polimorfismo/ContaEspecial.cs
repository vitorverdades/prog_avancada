public class ContaEspecial : ContaBancaria
{
    public double Limite { get; set; }

    public ContaEspecial(string numeroConta, string nomeTitular, double limite)
        : base(numeroConta, nomeTitular)
    {
        Limite = limite;
    }

    public override void Sacar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor de saque inválido.");
        }
        else
        {
            double saldoComLimite = Saldo + Limite;

            if (saldoComLimite >= valor)
            {
                base.Sacar(valor);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente, mesmo com o limite.");
            }
        }
    }
}
