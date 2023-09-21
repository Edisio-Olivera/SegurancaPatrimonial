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
    class ClienteBaseBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		MySqlCommand cmd = new MySqlCommand();

		ClienteDTO cliDto = new ClienteDTO();
		ClienteBLL cliBll = new ClienteBLL();

		Int32 qtdIdClienteBase;

		public void CriarNovoBaseCliente(ClienteBaseDTO b)
		{
			this.ContarIdBaseCliente();

			if (qtdIdClienteBase == 0)
			{
				b.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) FROM tb_cliente_base";

				try
				{
					cmd.Connection = conexao.conectar();
					MySqlDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					b.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (MySqlException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarIdBaseCliente()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente_base";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdClienteBase = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdClienteBase;
		}

		public void SalvarBaseCliente(ClienteBaseDTO b)
		{
			cliDto.NomeFantasia = b.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cmd.CommandText = "INSERT INTO tb_cliente_base (" +
				"id, " +
				"codigo, " +
				"codCliente, " +
				"nome, " +
				"iata) " +
				"VALUES (" +
				b.Id + ", '" +
				b.Codigo + "', '" +
				cliDto.Codigo + "', '" +
				b.Base + "', '" +
				b.Iata + "')";

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

		public void EditarBaseCliente(ClienteBaseDTO b)
		{
			cliDto.NomeFantasia = b.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cmd.CommandText = "UPDATE tb_cliente_base SET " +
				"codCliente = '" + cliDto.Codigo + "', " +
				"nome = '" + b.Base + "', " +
				"iata = '" + b.Iata + "' " +
				"WHERE codigo = '" + b.Codigo + "'";

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

		public void ExcluirBaseCliente(ClienteBaseDTO b)
		{
			cmd.CommandText = "DELETE FROM  tb_cliente_base WHERE codigo = '" + b.Codigo + "'";

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

		public List<ClienteBaseDTO> SelecionarBaseCliente(ClienteBaseDTO b)
		{
			cmd.CommandText = "SELECT " +
				"b.id, " +
				"b.codigo, " +
				"c.nome, " +
				"b.nome, " +
				"b.iata " +
				"FROM tb_cliente_base b " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"WHERE b.codigo = '" + b.Codigo + "'";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<ClienteBaseDTO> basse = new List<ClienteBaseDTO>(5);

			leitor.Read();

			basse.Add(new ClienteBaseDTO());

			basse[0].Id = leitor.GetInt32(0);
			basse[0].Codigo = leitor.GetString(1);
			basse[0].Cliente = leitor.GetString(2);
			basse[0].Base = leitor.GetString(3);
			basse[0].Iata = leitor.GetString(4);

			conexao.desconectar();
			cmd.Dispose();

			return basse;
		}

		public List<ClienteBaseDTO> ListarBaseCliente(ClienteBaseDTO b)
		{
			cmd.CommandText = "SELECT " +
				"b.id, " +
				"b.codigo, " +
				"c.nome, " +
				"b.nome, " +
				"b.iata " +
				"FROM tb_cliente_base_local l " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"ORDER BY b.codigo ASC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<ClienteBaseDTO> basse = new List<ClienteBaseDTO>(5);

			while (leitor.Read())
			{
				ClienteBaseDTO bas = new ClienteBaseDTO();

				bas.Id = leitor.GetInt32(0);
				bas.Codigo = leitor.GetString(1);
				bas.Cliente = leitor.GetString(2);
				bas.Base = leitor.GetString(3);
				bas.Iata = leitor.GetString(4);

				basse.Add(bas);
			}

			conexao.desconectar();
			cmd.Dispose();

			return basse;
		}

		public List<ClienteBaseDTO> PopularComboboxBaseCliente(ClienteBaseDTO b)
		{
			cliDto.NomeFantasia = b.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cmd.CommandText = "SELECT nome FROM tb_cliente_base " +
				"WHERE codCliente = '" + cliDto.Codigo + "'";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<ClienteBaseDTO> basse = new List<ClienteBaseDTO>();

			while (leitor.Read())
			{
				ClienteBaseDTO bas = new ClienteBaseDTO();
				bas.Base = leitor.GetString(0);
				basse.Add(bas);
			}

			conexao.desconectar();
			cmd.Dispose();

			return basse;
		}

		public string SelecionarCodigoBaseCliente(ClienteBaseDTO b)
		{
			cmd.CommandText = "SELECT codigo FROM tb_cliente_base " +
				"WHERE nome = '" + b.Base + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				b.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return b.Codigo;
		}
	}
}
