using System;

namespace Zoologico
{
    public abstract class Animal
    {
        private string _nome;
        private DateTime _dataNascimento;
        private float _peso;
        private float _capEstomago;

        public string Nome => _nome;
        public float Peso => _peso;

        public Animal(string nome, DateTime dataNascimento,
                      float peso, float capEstomago)
        {
            _nome = nome;
            _dataNascimento = dataNascimento;
            _peso = peso;
            _capEstomago = capEstomago;
        }

        public int Idade()
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - _dataNascimento.Year;
            if (_dataNascimento.Date > hoje.AddYears(-idade)) idade--;
            return idade;
        }

        public bool Comer(float qtd)
        {
            if (qtd <= 0) return false;
            if (qtd > _capEstomago) return false;

            _peso += qtd * 0.2f;
            return true;
        }

        public abstract void EmitirSom();
    }
}
