class Program
{
    static void Main(string[] args)
    {
        ICartaoWeb cartaoNamorados = new DiaDosNamorados("Chamon");
        ICartaoWeb cartaoNatal = new Natal("João");
        ICartaoWeb cartaoAniversario = new Aniversario("Maria");

        Console.WriteLine("=== CARTÕES WEB ===");
        cartaoNamorados.ExibirMensagem();
        cartaoNatal.ExibirMensagem();
        cartaoAniversario.ExibirMensagem();
    }
}
