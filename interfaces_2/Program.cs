class Program
{
    static void Main(string[] args)
    {
        IVeiculo meuCarro = new Carro();
        IVeiculo minhaMoto = new Moto();

        Console.WriteLine("=== TESTANDO CARRO ===");
        meuCarro.Ligar();
        meuCarro.Acelerar(30);
        meuCarro.Acelerar(20);
        meuCarro.Desligar();

        Console.WriteLine("\n=== TESTANDO MOTO ===");
        minhaMoto.Ligar();
        minhaMoto.Acelerar(50);
        minhaMoto.Acelerar(30);
        minhaMoto.Desligar();

        Console.WriteLine("\nFim dos testes!");
    }
}