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
        private string _codigo;
        private string _nome;
        private string _logomarca;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Logomarca { get => _logomarca; set => _logomarca = value; }
    }
}
