using System;

namespace Cartoes
{
    public class Natal : CartaoWeb
    {
        public Natal(string destinatario)
            : base(destinatario)
        {
        }

        public override void ExibirMensagem()
        {
            Console.WriteLine(
                "Feliz Natal, " + Destinatario +
                "! Que seu fim de ano seja cheio de paz e alegria."
            );
        }
    }
}
