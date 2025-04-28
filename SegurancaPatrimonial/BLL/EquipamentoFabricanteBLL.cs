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
    class EquipamentoFabricanteBLL
    {
        ConexaoDAL conexao = new ConexaoDAL();
        OleDbCommand cmd = new OleDbCommand();

		public List<EquipamentoFabricanteDTO> PopularComboboxFabricante()
		{
			cmd.CommandText = "SELECT nome FROM tb_equipamento_fabricante";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
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

		public Int32 SelecionarIdFabricante(EquipamentoFabricanteDTO ef)
		{
			cmd.CommandText = "SELECT id FROM tb_equipamento_fabricante " +
				"WHERE nome = '" + ef.Nome + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				ef.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return ef.Id;
		}
	}
}
