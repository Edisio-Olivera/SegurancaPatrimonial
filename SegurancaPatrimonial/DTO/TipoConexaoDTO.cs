using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurancaPatrimonial.DTO
{
    class TipoConexaoDTO
    {
        private Int32 _id;
        private string _tipo;

        public int Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
    }
}
