using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABELENDÁRIO
{
    class Cliente
    {
        private string _user;
        public string usuario
        {
            get => _user;
            set => _user = value;
        }
        private string _senha;
        public string senha
        {
            get => _senha;
            set => _senha = value;
        }
        public Cliente(string Usuario, string Nome)
        {
            usuario = Usuario;
            senha = Nome;
        }
    }
}
