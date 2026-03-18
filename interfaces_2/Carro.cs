public class Carro : IVeiculo
{
    public int VelocidadeAtual { get; set; }

    public void Ligar()
    {
        Console.WriteLine("Carro ligado!");
    }

    public void Desligar()
    {
        Console.WriteLine("Carro desligado!");
        VelocidadeAtual = 0;
    }

    public void Acelerar(int velocidade)
    {
        VelocidadeAtual += velocidade;
        Console.WriteLine($"Carro acelerando... Velocidade atual: {VelocidadeAtual} km/h");
    }
}
