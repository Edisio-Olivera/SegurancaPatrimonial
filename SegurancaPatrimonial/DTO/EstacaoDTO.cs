using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegurancaPatrimonial.DTO
{
    class EstacaoDTO
    {
		private Int32 _id;
		private string _codigo;
		private string _local;
		private string _setor;
		private string _descricao;
		private string _observacao;
		private Int32 _altura;
		private string _tipoConexao;
		private string _tipoCabo;
		private string _tipoInfra;
		private string _tipoFixacao;
		private Int32 _qtdCabo;
		private string _equipamento;
		private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Codigo { get => _codigo; set => _codigo = value; }
        public string Local { get => _local; set => _local = value; }
        public string Setor { get => _setor; set => _setor = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Observacao { get => _observacao; set => _observacao = value; }
        public int Altura { get => _altura; set => _altura = value; }
        public string TipoConexao { get => _tipoConexao; set => _tipoConexao = value; }
        public string TipoCabo { get => _tipoCabo; set => _tipoCabo = value; }
        public string TipoInfra { get => _tipoInfra; set => _tipoInfra = value; }
        public string TipoFixacao { get => _tipoFixacao; set => _tipoFixacao = value; }
        public int QtdCabo { get => _qtdCabo; set => _qtdCabo = value; }
        public string Equipamento { get => _equipamento; set => _equipamento = value; }
        public string Status { get => _status; set => _status = value; }
    }
}
