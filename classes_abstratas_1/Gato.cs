using System;

namespace Zoologico
{
    public class Gato : Mamifero
    {
        private string _raca;
        private bool _castrado;

        public Gato(string nome, DateTime dataNascimento,
                    float peso, float capEstomago,
                    bool temPelo, int tempoGestacaoDias,
                    string raca, bool castrado)
            : base(nome, dataNascimento, peso, capEstomago, temPelo, tempoGestacaoDias)
        {
            _raca = raca;
            _castrado = castrado;
        }

        public override void EmitirSom()
        {
            Console.WriteLine(Nome + " (gato) faz: miau!");
        }
    }
}
