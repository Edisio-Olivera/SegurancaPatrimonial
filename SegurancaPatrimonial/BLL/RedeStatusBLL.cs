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
    class RedeStatusBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		OleDbCommand cmd = new OleDbCommand();

		public List<RedeStatusDTO> PopularComboboxRedeStatus()
		{
			cmd.CommandText = "SELECT statusRede FROM tb_rede_status";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<RedeStatusDTO> status = new List<RedeStatusDTO>();

			while (leitor.Read())
			{
				RedeStatusDTO est = new RedeStatusDTO();
				est.Status = leitor.GetString(0);
				status.Add(est);
			}

			conexao.desconectar();
			cmd.Dispose();

			return status;
		}

		public Int32 SelecionarIdStatus(RedeStatusDTO s)
		{
			cmd.CommandText = "SELECT id FROM tb_rede_status " +
				"WHERE status = '" + s.Status + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				s.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return s.Id;
		}
	}
}
