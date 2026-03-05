using System;

namespace Zoologico
{
    public abstract class Passaro : Animal
    {
        private float _velocidadeVoo;

        public Passaro(string nome, DateTime dataNascimento,
                       float peso, float capEstomago,
                       float velocidadeVoo)
            : base(nome, dataNascimento, peso, capEstomago)
        {
            _velocidadeVoo = velocidadeVoo;
        }

        public virtual void Voar()
        {
            Console.WriteLine(Nome + " está voando a " + _velocidadeVoo + " km/h.");
        }

        public override void EmitirSom()
        {
            Console.WriteLine(Nome + " emitiu um canto de pássaro.");
        }
    }
}
