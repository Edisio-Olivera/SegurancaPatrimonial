using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurancaPatrimonial.DTO
{
    class ClienteDTO
    {
        private Int32 _id;
        private string _codigo;
        private string _nomeFantasia;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string NomeFantasia { get => _nomeFantasia; set => _nomeFantasia = value; }
    }
}
