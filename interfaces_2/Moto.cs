public class Moto : IVeiculo
{
    public int VelocidadeAtual { get; set; }

    public void Ligar()
    {
        Console.WriteLine("Moto ligada!");
    }

    public void Desligar()
    {
        Console.WriteLine("Moto desligada!");
        VelocidadeAtual = 0;
    }

    public void Acelerar(int velocidade)
    {
        VelocidadeAtual += velocidade;
        Console.WriteLine($"Moto acelerando... Velocidade atual: {VelocidadeAtual} km/h");
    }
}
