public class DiaDosNamorados : ICartaoWeb
{
    private string nomeDestinatario;

    public DiaDosNamorados(string nome)
    {
        nomeDestinatario = nome;
    }

    public void ExibirMensagem()
    {
        Console.WriteLine($"Feliz Dia dos Namorados, {nomeDestinatario}! 💕 Te amo muito!");
    }
}

public class Natal : ICartaoWeb
{
    private string nomeDestinatario;

    public Natal(string nome)
    {
        nomeDestinatario = nome;
    }

    public void ExibirMensagem()
    {
        Console.WriteLine($"Feliz Natal, {nomeDestinatario}! 🎄 Que Deus te abençoe!");
    }
}

public class Aniversario : ICartaoWeb
{
    private string nomeDestinatario;

    public Aniversario(string nome)
    {
        nomeDestinatario = nome;
    }

    public void ExibirMensagem()
    {
        Console.WriteLine($"Feliz Aniversário, {nomeDestinatario}! 🎉 Parabéns! 🎂");
    }
}
