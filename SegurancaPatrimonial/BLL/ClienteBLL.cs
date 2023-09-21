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
    class ClienteBLL
    {
        ConexaoDAL conexao = new ConexaoDAL();
        MySqlCommand cmd = new MySqlCommand();

		Int32 qtdIdCliente;

		public void CriarNovoCliente(ClienteDTO c)
		{
			this.ContarIdCliente();

			if (qtdIdCliente == 0)
			{
				c.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) FROM tb_cliente";

				try
				{
					cmd.Connection = conexao.conectar();
					MySqlDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					c.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (MySqlException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarIdCliente()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdCliente = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdCliente;
		}

		public void SalvarCliente(ClienteDTO c)
		{
			cmd.CommandText = "INSERT INTO tb_cliente (" +
				"id, " +
				"codigo, " +
				"nome) " +
				"VALUES (" +
				c.Id + ", '" +
				c.Codigo + "', '" +
				c.NomeFantasia + "')";

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

		public void EditarCliente(ClienteDTO c)
		{
			cmd.CommandText = "UPDATE tb_cliente SET " +
				"nome = '" + c.NomeFantasia + "', " +
				"WHERE codigo = '" + c.Codigo + "'";

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

		public void ExcluirCliente(ClienteDTO c)
		{
			cmd.CommandText = "DELETE FROM  tb_cliente WHERE codigo = '" + c.Codigo + "'";

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

		public List<ClienteDTO> SelecionarCliente(ClienteDTO c)
		{
			cmd.CommandText = "SELECT " +
				"id, " +
				"codigo, " +
				"nomeFantasia " +
				"FROM tb_cliente " +
				"WHERE codigo = '" + c.Codigo + "'";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<ClienteDTO> cliente = new List<ClienteDTO>(3);

			leitor.Read();

			cliente.Add(new ClienteDTO());

			cliente[0].Id = leitor.GetInt32(0);
			cliente[0].Codigo = leitor.GetString(1);
			cliente[0].NomeFantasia = leitor.GetString(2);

			conexao.desconectar();
			cmd.Dispose();

			return cliente;
		}

		public List<ClienteDTO> ListarCliente(ClienteDTO c)
		{
			cmd.CommandText = "SELECT " +
				"id, " +
				"codigo, " +
				"nomeFantasia " +
				"FROM tb_cliente " +
				"ORDER BY codigo ASC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<ClienteDTO> cliente = new List<ClienteDTO>(3);

			while (leitor.Read())
			{
				ClienteDTO cli = new ClienteDTO();

				cli.Id = leitor.GetInt32(0);
				cli.Codigo = leitor.GetString(1);
				cli.NomeFantasia = leitor.GetString(2);

				cliente.Add(cli);
			}

			conexao.desconectar();
			cmd.Dispose();

			return cliente;
		}

		public List<ClienteDTO> PopularComboboxCliente(ClienteDTO c)
		{
			cmd.CommandText = "SELECT nomeFantasia FROM tb_cliente ";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<ClienteDTO> cliente = new List<ClienteDTO>();

			while (leitor.Read())
			{
				ClienteDTO cli = new ClienteDTO();
				cli.NomeFantasia = leitor.GetString(0);
				cliente.Add(cli);
			}

			conexao.desconectar();
			cmd.Dispose();

			return cliente;
		}

		public string SelecionarCodigoCliente(ClienteDTO c)
		{
			cmd.CommandText = "SELECT codigo FROM tb_cliente " +
				"WHERE nomeFantasia = '" + c.NomeFantasia + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				c.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return c.Codigo;
		}
	}
}
