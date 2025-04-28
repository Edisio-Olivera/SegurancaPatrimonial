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
    class EquipamentoTipoBLL
    {
        ConexaoDAL conexao = new ConexaoDAL();
        OleDbCommand cmd = new OleDbCommand();

		public List<EquipamentoTipoDTO> PopularComboboxTipoEquipamento()
		{
			cmd.CommandText = "SELECT tipo FROM tb_equipamento_tipo";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<EquipamentoTipoDTO> tipo = new List<EquipamentoTipoDTO>();

			while (leitor.Read())
			{
				EquipamentoTipoDTO tip = new EquipamentoTipoDTO();
				tip.Tipo = leitor.GetString(0);
				tipo.Add(tip);
			}

			conexao.desconectar();
			cmd.Dispose();

			return tipo;
		}

		public Int32 SelecionarIdTipoEquipamento(EquipamentoTipoDTO et)
		{
			cmd.CommandText = "SELECT id FROM tb_equipamento_tipo " +
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
