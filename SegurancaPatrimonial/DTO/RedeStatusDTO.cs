using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurancaPatrimonial.DTO
{
    class RedeStatusDTO
    {
        private Int32 _id;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
