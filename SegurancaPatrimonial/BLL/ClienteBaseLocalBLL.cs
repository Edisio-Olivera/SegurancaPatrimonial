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
    class ClienteBaseLocalBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		MySqlCommand cmd = new MySqlCommand();

		ClienteBaseDTO basDto = new ClienteBaseDTO();
		ClienteBaseBLL basBll = new ClienteBaseBLL();

		Int32 qtdIdClienteBaseLocal;

		public void CriarNovoBaseLocal(ClienteBaseLocalDTO l)
		{
			this.ContarIdBaseLocal();

			if (qtdIdClienteBaseLocal == 0)
			{
				l.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) FROM tb_cliente_base_local";

				try
				{
					cmd.Connection = conexao.conectar();
					MySqlDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					l.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (MySqlException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarIdBaseLocal()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente_base_local";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdClienteBaseLocal = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdClienteBaseLocal;
		}

		public void SalvarBaseLocal(ClienteBaseLocalDTO l)
		{
			basDto.Base = l.Base;
			basBll.SelecionarCodigoBaseCliente(basDto);

			cmd.CommandText = "INSERT INTO tb_cliente_base_local (" +
				"id, " +
				"codigo, " +
				"codBase, " +
				"nome, " +
				"iata) " +
				"VALUES (" +
				l.Id + ", '" +
				l.Codigo + "', '" +
				basDto.Codigo + "', '" +
				l.Local + "', '" +
				l.Iata + "')";

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void EditarBaseLocal(ClienteBaseLocalDTO l)
		{
			basDto.Base = l.Base;
			basBll.SelecionarCodigoBaseCliente(basDto);

			cmd.CommandText = "UPDATE tb_cliente_base_local SET " +
				"codBase = '" + basDto.Codigo + "', " +
				"nome = '" + l.Local + "', " +
				"iata = '" + l.Iata + "' " +
				"WHERE codigo = '" + l.Codigo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void ExcluirBaseLocal(ClienteBaseLocalDTO l)
		{
			cmd.CommandText = "DELETE FROM  tb_cliente_base_local WHERE codigo = '" + l.Codigo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public List<ClienteBaseLocalDTO> SelecionarBaseLocal(ClienteBaseLocalDTO l)
		{
			cmd.CommandText = "SELECT " +
				"l.id, " +
				"l.codigo, " +
				"c.nome, " +
				"b.nome, " +
				"l.nome, " +
				"l.iata " +
				"FROM tb_cliente_base_local l " +
				"INNER JOIN tb_cliente_base b ON l.codBase = b.codigo " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"WHERE l.codigo = '" + l.Codigo + "'";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<ClienteBaseLocalDTO> locall = new List<ClienteBaseLocalDTO>(6);

			leitor.Read();

			locall.Add(new ClienteBaseLocalDTO());

			locall[0].Id = leitor.GetInt32(0);
			locall[0].Codigo = leitor.GetString(1);
			locall[0].Cliente = leitor.GetString(2);
			locall[0].Base = leitor.GetString(3);
			locall[0].Local = leitor.GetString(4);
			locall[0].Iata = leitor.GetString(5);

			conexao.desconectar();
			cmd.Dispose();

			return locall;
		}

		public List<ClienteBaseLocalDTO> ListarBaseLocal(ClienteBaseLocalDTO l)
		{
			cmd.CommandText = "SELECT " +
				"l.id, " +
				"l.codigo, " +
				"c.nome, " +
				"b.nome, " +
				"l.nome, " +
				"l.iata " +
				"FROM tb_cliente_base_local l " +
				"INNER JOIN tb_cliente_base b ON l.codBase = b.codigo " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"ORDER BY l.codigo ASC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<ClienteBaseLocalDTO> locall = new List<ClienteBaseLocalDTO>(6);

            while (leitor.Read())
            {
				ClienteBaseLocalDTO loc = new ClienteBaseLocalDTO();

				loc.Id = leitor.GetInt32(0);
				loc.Codigo = leitor.GetString(1);
				loc.Cliente = leitor.GetString(2);
				loc.Base = leitor.GetString(3);
				loc.Local = leitor.GetString(4);
				loc.Iata = leitor.GetString(5);

				locall.Add(loc);
			}			

			conexao.desconectar();
			cmd.Dispose();

			return locall;
		}

		public List<ClienteBaseLocalDTO> PopularComboboxBaseLocal(ClienteBaseLocalDTO l)
		{
			basDto.Base = l.Base;
			basBll.SelecionarCodigoBaseCliente(basDto);

			cmd.CommandText = "SELECT nome FROM tb_cliente_base_local " +
				"WHERE codBase = '" + basDto.Codigo + "'";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<ClienteBaseLocalDTO> locall = new List<ClienteBaseLocalDTO>();

			while (leitor.Read())
			{
				ClienteBaseLocalDTO loc = new ClienteBaseLocalDTO();
				loc.Local = leitor.GetString(0);
				locall.Add(loc);
			}

			conexao.desconectar();
			cmd.Dispose();

			return locall;
		}

		public string SelecionarCodigoBaseLocal(ClienteBaseLocalDTO l)
		{
			cmd.CommandText = "SELECT codigo FROM tb_cliente_base_local " +
				"WHERE nome = '" + l.Local + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				l.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return l.Codigo;
		}
	}
}
