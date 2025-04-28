using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurancaPatrimonial.DTO
{
    class RedeDTO
    {
        private Int32 _id;
        private string _endIp;
        private string _mascara;
        private string _gateway;
        private string _equipamento;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string EndIp { get => _endIp; set => _endIp = value; }
        public string Mascara { get => _mascara; set => _mascara = value; }
        public string Gateway { get => _gateway; set => _gateway = value; }
        public string Status { get => _status; set => _status = value; }
        public string Equipamento { get => _equipamento; set => _equipamento = value; }
    }
}
