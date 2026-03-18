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
