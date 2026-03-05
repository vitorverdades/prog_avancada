using System;

namespace Zoologico
{
    public abstract class Mamifero : Animal
    {
        private bool _temPelo;
        private bool _amamentando;
        private int _tempoGestacaoDias;

        public Mamifero(string nome, DateTime dataNascimento,
                        float peso, float capEstomago,
                        bool temPelo, int tempoGestacaoDias)
            : base(nome, dataNascimento, peso, capEstomago)
        {
            _temPelo = temPelo;
            _tempoGestacaoDias = tempoGestacaoDias;
        }

        public void Amamentar()
        {
            _amamentando = true;
            Console.WriteLine(Nome + " está amamentando.");
        }

        public void PararAmamentar()
        {
            _amamentando = false;
            Console.WriteLine(Nome + " parou de amamentar.");
        }

        public override void EmitirSom()
        {
            Console.WriteLine(Nome + " emitiu um som de mamífero.");
        }
    }
}
