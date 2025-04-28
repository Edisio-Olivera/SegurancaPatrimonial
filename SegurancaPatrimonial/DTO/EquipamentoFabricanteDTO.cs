using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurancaPatrimonial.DTO
{
    class EquipamentoFabricanteDTO
    {
        private Int32 _id;
        private string _nome;
        private string _logomarca;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Logomarca { get => _logomarca; set => _logomarca = value; }
    }
}
