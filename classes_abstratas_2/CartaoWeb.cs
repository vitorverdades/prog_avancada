using System;

namespace Cartoes
{
    public abstract class CartaoWeb
    {
        private string _destinatario;

        public CartaoWeb(string destinatario)
        {
            _destinatario = destinatario;
        }

        public string Destinatario
        {
            get { return _destinatario; }
        }

        public abstract void ExibirMensagem();
    }
}
