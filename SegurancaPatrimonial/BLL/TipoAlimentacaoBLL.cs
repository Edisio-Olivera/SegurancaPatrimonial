using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegurancaPatrimonial.DTO;
using SegurancaPatrimonial.DAL;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SegurancaPatrimonial.BLL
{
    class TipoAlimentacaoBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		OleDbCommand cmd = new OleDbCommand();

		public List<TipoAlimentacaoDTO> PopularComboboxTipoAlimentacao()
		{
			cmd.CommandText = "SELECT tipo FROM tb_tipo_alimentacao";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<TipoAlimentacaoDTO> tipo = new List<TipoAlimentacaoDTO>();

			while (leitor.Read())
			{
				TipoAlimentacaoDTO tip = new TipoAlimentacaoDTO();
				tip.Tipo = leitor.GetString(0);
				tipo.Add(tip);
			}

			conexao.desconectar();
			cmd.Dispose();

			return tipo;
		}

		public Int32 SelecionarIdTipoAlimentacao(TipoAlimentacaoDTO t)
		{
			cmd.CommandText = "SELECT id FROM tb_tipo_alimentacao " +
				"WHERE tipo = '" + t.Tipo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				t.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return t.Id;
		}
	}
}
