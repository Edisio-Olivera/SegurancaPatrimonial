using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurancaPatrimonial.DTO
{
    class EquipamentoModeloDTO
    {
		private Int32 _id;
		private string _codigo;
		private string _tipoEquipamento;
		private string _fabricante;
		private string _modelo;
		private string _descricao;
		private string _imagem;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string TipoEquipamento { get => _tipoEquipamento; set => _tipoEquipamento = value; }
        public string Fabricante { get => _fabricante; set => _fabricante = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Imagem { get => _imagem; set => _imagem = value; }
    }
}
