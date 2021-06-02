using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABELENDÁRIO
{
    class Barbearia
    {
        private List<Horário> _agenda = new List<Horário>();
        public List<Horário> Agenda = new List<Horário>();

        private string _nomebarbearia;
        public string NomeBarbearia
        {
            get => _nomebarbearia;
            set => _nomebarbearia = value;
        }
        private string _endereçobarbearia;
        public string EndereçoBarbearia
        {
            get => _endereçobarbearia;
            set => _endereçobarbearia = value;
        }
        private string _nomedono;
        public string NomeDono
        {
            get => _nomedono;
            set => _nomedono = value;
        }
        private string _cpfdono;

        public Barbearia(string nomebarbearia,string endereçobarbearia, string nomedono, string cpfdono, string nome, int id)
        {
            nomebarbearia = NomeBarbearia;
            endereçobarbearia = EndereçoBarbearia;
            nomedono = NomeDono;
            cpfdono = CpfDono;
        }

        public string CpfDono
        {
            get => _nomedono;
            set => _nomedono = value;

        }

       

            

        

    }
}
