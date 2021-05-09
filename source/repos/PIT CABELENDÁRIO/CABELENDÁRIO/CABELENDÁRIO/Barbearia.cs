using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABELENDÁRIO
{
    class Barbearia: Usuario
    {
        private string _nomebarbearia;
        public string nomebarbearia
        {
            get => _nomebarbearia;
            set => _nomebarbearia = value;
        }
        private string _endereçobarbearia;
        public string endereçobarbearia
        {
            get => _endereçobarbearia;
            set => _endereçobarbearia = value;
        }
        private string _nomedono;
        public string nomedono
        {
            get => _nomedono;
            set => _nomedono = value;
        }
        private string _cpfdono;

        public Barbearia()
        {
        }

        public string cpfdono
        {
            get => _nomedono;
            set => _nomedono = value;

        }
        

            

        

    }
}
