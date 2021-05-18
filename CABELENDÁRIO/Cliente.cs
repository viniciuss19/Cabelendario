using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABELENDÁRIO
{
    class Cliente
    {
        private string _nome;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        private string _senha;
        public string Senha
        {
            get => _senha;
            set => _senha = value;
        }
        private string _cpf;
        public string Cpf
        {
            get => _cpf;
            set => _cpf = value;
        }
        public Cliente(string nome, string senha, string cpf)
        {
            nome = Nome;
            senha = Senha;
            cpf = Cpf;
        }
        public Cliente(string nome, string cpf)
        {
            nome = Nome;
            cpf = Cpf;
        }
       
    }
}
