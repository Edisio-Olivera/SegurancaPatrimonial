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
    class ClienteBaseLocalSetorBLL
    {
        ConexaoDAL conexao = new ConexaoDAL();
        OleDbCommand cmd = new OleDbCommand();

		ClienteBaseLocalDTO locDto = new ClienteBaseLocalDTO();
		ClienteBaseLocalBLL locBll = new ClienteBaseLocalBLL();

		Int32 qtdIdClienteLocalSetor;
		Int32 qtdClienteLocalSetor;

		public void CriarNovoLocalSetor(ClienteBaseLocalSetorDTO s)
		{
			this.ContarIdLocalSetor();

			if (qtdIdClienteLocalSetor == 0)
			{
				s.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) FROM tb_cliente_base_local_setor";

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
			}
		}

		public Int32 ContarIdLocalSetor()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente_base_local_setor";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdClienteLocalSetor = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdClienteLocalSetor;
		}

		public void SalvarLocalSetor(ClienteBaseLocalSetorDTO s)
		{
			locDto.Local = s.Local;
			locBll.SelecionarCodigoBaseLocal(locDto);

			cmd.CommandText = "INSERT INTO tb_cliente_base_local_setor (" +
				"id, " +
				"codigo, " +
				"codLocal, " +
				"nome, " +
				"iata) " +
				"VALUES (" +
				s.Id + ", '" +
				s.Codigo + "', '" +
				locDto.Codigo + "', '" +
				s.Setor + "', '" +
				s.Iata + "')";

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void EditarLocalSetor(ClienteBaseLocalSetorDTO s)
		{
			locDto.Local = s.Local;
			locBll.SelecionarCodigoBaseLocal(locDto);

			cmd.CommandText = "UPDATE tb_cliente_base_local_setor SET " +
				"codLocal = '" + locDto.Codigo + "', " +
				"nome = '" + s.Setor + "', " +
				"iata = '" + s.Iata + "' " +
				"WHERE codigo = '" + s.Codigo + "'";				

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public List<ClienteBaseLocalSetorDTO> SelecionarLocalSetor(ClienteBaseLocalSetorDTO s)
		{
			this.SelecionarCodigoLocalSetor(s);

			cmd.CommandText = "SELECT " +
                "tb_cliente_base_local_setor.id, " +
                "tb_cliente_base_local_setor.codigo, " +
                "tb_cliente.nome, " +
                "tb_cliente_base.nome, " +
                "tb_cliente_base_local.nome, " +
                "tb_cliente_base_local_setor.nome, " +
                "tb_cliente_base_local_setor.iata " +
				"FROM (((tb_cliente_base_local_setor " +
                "INNER JOIN tb_cliente_base_local ON tb_cliente_base_local_setor.codLocal = tb_cliente_base_local.codigo) " +
                "INNER JOIN tb_cliente_base ON tb_cliente_base_local.codBase = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "WHERE tb_cliente_base_local_setor.codigo = '" + s.Codigo + "' ";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<ClienteBaseLocalSetorDTO> setor = new List<ClienteBaseLocalSetorDTO>(7);

			leitor.Read();

			setor.Add(new ClienteBaseLocalSetorDTO());

			setor[0].Id = leitor.GetInt32(0);
			setor[0].Codigo = leitor.GetString(1);
			setor[0].Cliente = leitor.GetString(2);
			setor[0].Base = leitor.GetString(3);
			setor[0].Local = leitor.GetString(4);
			setor[0].Setor = leitor.GetString(5);
			setor[0].Iata = leitor.GetString(6);

			conexao.desconectar();
			cmd.Dispose();

			return setor;
		}

		public List<ClienteBaseLocalSetorDTO> ListarLocalSetor(ClienteBaseLocalSetorDTO s)
		{
			cmd.CommandText = "SELECT " +
                "tb_cliente_base_local_setor.id, " +
                "tb_cliente_base_local_setor.codigo, " +
                "tb_cliente.nome, " +
                "tb_cliente_base.nome, " +
                "tb_cliente_base_local.nome, " +
                "tb_cliente_base_local_setor.nome, " +
                "tb_cliente_base_local_setor.iata " +
                "FROM (((tb_cliente_base_local_setor " +
                "INNER JOIN tb_cliente_base_local ON tb_cliente_base_local_setor.codLocal = tb_cliente_base_local.codigo) " +
                "INNER JOIN tb_cliente_base ON tb_cliente_base_local.codBase = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "ORDER BY S.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<ClienteBaseLocalSetorDTO> setor = new List<ClienteBaseLocalSetorDTO>(7);

            while (leitor.Read())
            {
				ClienteBaseLocalSetorDTO set = new ClienteBaseLocalSetorDTO();

				set.Id = leitor.GetInt32(0);
				set.Codigo = leitor.GetString(1);
				set.Cliente = leitor.GetString(2);
				set.Base = leitor.GetString(3);
				set.Local = leitor.GetString(4);
				set.Setor = leitor.GetString(5);
				set.Iata = leitor.GetString(6);

				setor.Add(set);
			}			

			conexao.desconectar();
			cmd.Dispose();

			return setor;
		}

		public string SelecionarCodigoLocalSetor(ClienteBaseLocalSetorDTO s)
        {
			locDto.Local = s.Local;
			locBll.SelecionarCodigoBaseLocal(locDto);

			cmd.CommandText = "SELECT codigo FROM tb_cliente_base_local_setor " +
				"WHERE nome = '" + s.Setor + "' " +
				"AND codLocal = '" + locDto.Codigo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				s.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return s.Codigo;
		}

		public List<ClienteBaseLocalSetorDTO> PopularComboboxLocalSetor(ClienteBaseLocalSetorDTO s)
        {
			locDto.Local = s.Local;
			locBll.SelecionarCodigoBaseLocal(locDto);

			cmd.CommandText = "SELECT nome FROM tb_cliente_base_local_setor " +
				"WHERE codLocal = '" + locDto.Codigo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<ClienteBaseLocalSetorDTO> setor = new List<ClienteBaseLocalSetorDTO>();

			while (leitor.Read())
			{
				ClienteBaseLocalSetorDTO set = new ClienteBaseLocalSetorDTO();
				set.Setor = leitor.GetString(0);
				setor.Add(set);
			}

			conexao.desconectar();
			cmd.Dispose();

			return setor;
		}

		//public Int32 ContarLocalSetor(ClienteBaseLocalSetorDTO s)
		//{
		//	cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente_base_local_setor " +
		//		"WHERE codigo = '" + s.Codigo + "'";

		//	try
		//	{
		//		cmd.Connection = conexao.conectar();
		//		OleDbDataReader leitor = cmd.ExecuteReader();

		//		leitor.Read();
		//		qtdClienteLocalSetor = leitor.GetInt32(0);

		//		conexao.desconectar();
		//		cmd.Dispose();
		//	}
		//	catch (OleDbException ex)
		//	{
		//		MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}

		//	return qtdClienteLocalSetor;
		//}
	}
}
