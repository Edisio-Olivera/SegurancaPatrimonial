using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SegurancaPatrimonial.DTO;
using SegurancaPatrimonial.DAL;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SegurancaPatrimonial.BLL
{
    class EquipamentoTipoBLL
    {
        ConexaoDAL conexao = new ConexaoDAL();
        MySqlCommand cmd = new MySqlCommand();

		public List<EquipamentoTipoDTO> PopularComboboxTipoEquipamento()
		{
			cmd.CommandText = "SELECT modelo FROM tb_equipamento_modelo";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
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

		public Int32 SelecionarIdTipoEquipamento(EquipamentoTipoDTO t)
		{
			cmd.CommandText = "SELECT codigo FROM tb_equipamento_tipo " +
				"WHERE tipo = '" + t.Tipo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				t.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return t.Id;
		}
	}
}
