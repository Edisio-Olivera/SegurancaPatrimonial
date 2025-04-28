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
    class EstacaoTipoBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		OleDbCommand cmd = new OleDbCommand();

		public List<EstacaoTipoDTO> PopularComboboxTipoEstacao()
		{
			cmd.CommandText = "SELECT tipo FROM tb_estacao_tipo";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<EstacaoTipoDTO> tipo = new List<EstacaoTipoDTO>();

			while (leitor.Read())
			{
				EstacaoTipoDTO tip = new EstacaoTipoDTO();
				tip.Tipo = leitor.GetString(0);
				tipo.Add(tip);
			}

			conexao.desconectar();
			cmd.Dispose();

			return tipo;
		}

		public Int32 SelecionarIdTipoEstacao(EstacaoTipoDTO et)
		{
			cmd.CommandText = "SELECT id FROM tb_estacao_tipo " +
				"WHERE tipo = '" + et.Tipo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				et.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return et.Id;
		}
	}
}

