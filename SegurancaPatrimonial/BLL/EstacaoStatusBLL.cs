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
    class EstacaoStatusBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		OleDbCommand cmd = new OleDbCommand();

		public List<EstacaoStatusDTO> PopularComboboxStatusEstacao()
		{
			cmd.CommandText = "SELECT tipo FROM tb_estacao_status";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<EstacaoStatusDTO> status = new List<EstacaoStatusDTO>();

			while (leitor.Read())
			{
				EstacaoStatusDTO est = new EstacaoStatusDTO();
				est.Status = leitor.GetString(0);
				status.Add(est);
			}

			conexao.desconectar();
			cmd.Dispose();

			return status;
		}

		public Int32 SelecionarIdTipoStatus(EstacaoStatusDTO es)
		{
			cmd.CommandText = "SELECT id FROM tb_estacao_status " +
				"WHERE status = '" + es.Status + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				es.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return es.Id;
		}
	}
}

