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