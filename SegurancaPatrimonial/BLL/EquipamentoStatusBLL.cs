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
    class EquipamentoStatusBLL
    {
        ConexaoDAL conexao = new ConexaoDAL();
        OleDbCommand cmd = new OleDbCommand();

        public Int32 SelecionarIdEquipamentoStatus(EquipamentoStatusDTO es)
        {
			cmd.CommandText = "SELECT id FROM tb_equipamento_status " +
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
