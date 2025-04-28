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
    class TipoInfraBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		OleDbCommand cmd = new OleDbCommand();

		public List<TipoInfraDTO> PopularComboboxTipoInfra()
		{
			cmd.CommandText = "SELECT tipo FROM tb_tipo_infra";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<TipoInfraDTO> tipo = new List<TipoInfraDTO>();

			while (leitor.Read())
			{
				TipoInfraDTO tip = new TipoInfraDTO();
				tip.Tipo = leitor.GetString(0);
				tipo.Add(tip);
			}

			conexao.desconectar();
			cmd.Dispose();

			return tipo;
		}

		public Int32 SelecionarIdTipoInfra(TipoInfraDTO t)
		{
			cmd.CommandText = "SELECT id FROM tb_tipo_infra " +
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
