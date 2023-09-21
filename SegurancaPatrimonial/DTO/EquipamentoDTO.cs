using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurancaPatrimonial.DTO
{
    class EquipamentoDTO
    {
		private Int32 _id;
		private string _codigo;
		private string _dataAquisicao;
		private string _tipoEquipamento;
		private string _fabricante;
		private string _modelo;
        private string _descricao;
		private string _enderecoIp;
		private string _mascara;
		private string _gateway;
		private string _usuario;
		private string _senha;
		private string _imagem;
		private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string DataAquisicao { get => _dataAquisicao; set => _dataAquisicao = value; }
        public string TipoEquipamento { get => _tipoEquipamento; set => _tipoEquipamento = value; }
        public string Fabricante { get => _fabricante; set => _fabricante = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public string EnderecoIp { get => _enderecoIp; set => _enderecoIp = value; }
        public string Mascara { get => _mascara; set => _mascara = value; }
        public string Gateway { get => _gateway; set => _gateway = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public string Imagem { get => _imagem; set => _imagem = value; }
        public string Status { get => _status; set => _status = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
    }
}
