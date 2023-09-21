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
    class EquipamentoFabricanteBLL
    {
        ConexaoDAL conexao = new ConexaoDAL();
        MySqlCommand cmd = new MySqlCommand();

		public List<EquipamentoFabricanteDTO> PopularComboboxFabricante()
		{
			cmd.CommandText = "SELECT nome FROM tb_equipamento_fabricante";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<EquipamentoFabricanteDTO> fabricante = new List<EquipamentoFabricanteDTO>();

			while (leitor.Read())
			{
				EquipamentoFabricanteDTO fab = new EquipamentoFabricanteDTO();
				fab.Nome = leitor.GetString(0);
				fabricante.Add(fab);
			}

			conexao.desconectar();
			cmd.Dispose();

			return fabricante;
		}

		public string SelecionarCodigoFabricante(EquipamentoFabricanteDTO f)
		{
			cmd.CommandText = "SELECT codigo FROM tb_equipamento_fabricante " +
				"WHERE nome = '" + f.Nome + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				f.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return f.Codigo;
		}
	}
}
