using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurancaPatrimonial.DTO
{
    class ClienteBaseDTO
    {
        private Int32 _id;
        private string _codigo;
        private string _cliente;
        private string _base;
        private string _iata;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Cliente { get => _cliente; set => _cliente = value; }
        public string Base { get => _base; set => _base = value; }
        public string Iata { get => _iata; set => _iata = value; }
    }
}
