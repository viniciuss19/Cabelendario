using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABELENDÁRIO
{
    class Usuario
    {
        private string _nome;
        private int _id;
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
        public int Id 
        {
            get => _id;
            set => _id = value;
        }
    }
}
