using System;

namespace Zoologico
{
    public class Curio : Passaro
    {
        private bool _treinadoParaCanto;
        private int _nivelCanto;

        public Curio(string nome, DateTime dataNascimento,
                     float peso, float capEstomago,
                     float velocidadeVoo,
                     bool treinadoParaCanto, int nivelCanto)
            : base(nome, dataNascimento, peso, capEstomago, velocidadeVoo)
        {
            _treinadoParaCanto = treinadoParaCanto;
            _nivelCanto = nivelCanto;
        }

        public void Cantar()
        {
            Console.WriteLine(Nome + " (curió) está cantando. Nível: " + _nivelCanto);
        }

        public override void EmitirSom()
        {
            Cantar();
        }
    }
}
