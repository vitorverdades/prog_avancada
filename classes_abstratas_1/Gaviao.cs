using System;

namespace Zoologico
{
    public class Gaviao : Passaro
    {
        private float _alturaMaxima;
        private bool _emCaca;

        public Gaviao(string nome, DateTime dataNascimento,
                      float peso, float capEstomago,
                      float velocidadeVoo, float alturaMaxima)
            : base(nome, dataNascimento, peso, capEstomago, velocidadeVoo)
        {
            _alturaMaxima = alturaMaxima;
        }

        public override void Voar()
        {
            Console.WriteLine(Nome + " (gavião) está voando alto.");
        }

        public void IniciarCaca()
        {
            _emCaca = true;
            Console.WriteLine(Nome + " começou a caça.");
        }

        public void EncerrarCaca()
        {
            _emCaca = false;
            Console.WriteLine(Nome + " terminou a caça.");
        }

        public override void EmitirSom()
        {
            Console.WriteLine(Nome + " (gavião) fez um grito agudo.");
        }
    }
}
