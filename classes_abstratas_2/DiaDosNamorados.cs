using System;

namespace Cartoes
{
    public class DiaDosNamorados : CartaoWeb
    {
        public DiaDosNamorados(string destinatario)
            : base(destinatario)
        {
        }

        public override void ExibirMensagem()
        {
            Console.WriteLine(
                "Feliz Dia dos Namorados, " + Destinatario +
                "! Que o nosso amor cresça a cada dia."
            );
        }
    }
}
