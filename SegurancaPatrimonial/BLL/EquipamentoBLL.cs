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
    class EquipamentoBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		MySqlCommand cmd = new MySqlCommand();

		EquipamentoTipoDTO tipDto = new EquipamentoTipoDTO();
		EquipamentoTipoBLL tipBll = new EquipamentoTipoBLL();

		EquipamentoFabricanteDTO fabDto = new EquipamentoFabricanteDTO();
		EquipamentoFabricanteBLL fabBll = new EquipamentoFabricanteBLL();

		EquipamentoModeloDTO modDto = new EquipamentoModeloDTO();
		EquipamentoModeloBLL modBll = new EquipamentoModeloBLL();

		EquipamentoStatusDTO staDto = new EquipamentoStatusDTO();
		EquipamentoStatusBLL staBll = new EquipamentoStatusBLL();

		Int32 qtdIdEquipamento;

		public void CriarNovoEquipamento(EquipamentoDTO e)
		{
			this.ContarIdEquipamento();

			if (qtdIdEquipamento == 0)
			{
				e.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) FROM tb_equipamento";

				try
				{
					cmd.Connection = conexao.conectar();
					MySqlDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					e.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (MySqlException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarIdEquipamento()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_equipamento";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdEquipamento = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdEquipamento;
		}

		public void SalvarEquipamento(EquipamentoDTO e)
		{
			modDto.Modelo = e.Modelo;
			modBll.SelecionarCodigoModeloEquipamento(modDto);

			staDto.Status = e.Status;
			staBll.SelecionarIdEquipamentoStatus(staDto);

			cmd.CommandText = "INSERT INTO tb_equipamento (" +
				"id, " +
				"codigo, " +
				"dataAquisicao, " +
				"codModelo, " +
				"endIp, " +
				"mascara, " +
				"gateway, " +
				"usuario, " +
				"senha, " +
				"idStatus) " +
				"VALUES (" +
				e.Id + ", '" +
				e.Codigo + "', '" +
				e.DataAquisicao + "', '" +
				modDto.Codigo + "', '" +
				e.EnderecoIp + "', '" +
				e.Mascara + "', '" +
				e.Gateway + "', '" +
				e.Usuario + "', '" +
				e.Senha + "', " +
				staDto.Id + ")";

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

		public void EditarEquipamento(EquipamentoDTO e)
		{
			modDto.Modelo = e.Modelo;
			modBll.SelecionarCodigoModeloEquipamento(modDto);

			staDto.Status = e.Status;
			staBll.SelecionarIdEquipamentoStatus(staDto);

			cmd.CommandText = "UPDATE tb_equipamento SET " +
				"dataAquisicao = '" + e.DataAquisicao + "', " +
				"codModelo = '" + modDto.Codigo + "', " +
				"endIp = '" + e.EnderecoIp + "', " +
				"mascara = '" + e.Mascara + "', " +
				"gateway = '" + e.Gateway + "', " +
				"usuario = '" + e.Usuario + "', " +
				"senha = '" + e.Senha + "', " +
				"idStatus = '" + staDto.Id + " " +
				"WHERE codigo = '" + e.Codigo + "'";

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

		public void ExcluirEquipamento(EquipamentoDTO e)
		{
			cmd.CommandText = "DELETE FROM  tb_equipamento WHERE codigo = '" + e.Codigo + "'";

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

		public List<EquipamentoDTO> SelecionarEquipamento(EquipamentoDTO e)
		{
			cmd.CommandText = "SELECT " +
				"e.id, " +
				"e.codigo, " +
				"e.dataAquisicao, " +
				"t.tipo, " +
				"f.nome, " +
				"m.modelo, " +
				"m.descricao, " +
				"e.endIp, " +
				"e.mascara, " +
				"e.gateway, " +
				"e.usuario, " +
				"e.senha, " +
				"m.imagem, " +
				"s.sttatus " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_modelo m ON e.codModelo = m.codigo " +
				"INNER JOIN tb_equipamento_tipo t ON m.idTipoEquipamento " +
				"INNER JOIN tb_equipamento_fabricante f ON m.codFabricante = f.codigo " +
				"INNER JOIN tb_equipamento_status s ON e.idStatus = s.id " +
				"WHERE e.codigo = '" + e.Codigo + "'";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(14);

			leitor.Read();

			equip.Add(new EquipamentoDTO());

			equip[0].Id = leitor.GetInt32(0);
			equip[0].Codigo = leitor.GetString(1);
			DateTime dataAquisicao = DateTime.Parse(leitor.GetString(2));
			equip[0].DataAquisicao = dataAquisicao.ToString("dd/MM/yyyy");
			equip[0].TipoEquipamento = leitor.GetString(3);
			equip[0].Fabricante = leitor.GetString(4);
			equip[0].Modelo = leitor.GetString(5);
			equip[0].Descricao = leitor.GetString(6);
			equip[0].EnderecoIp = leitor.GetString(7);
			equip[0].Mascara = leitor.GetString(8);
			equip[0].Gateway = leitor.GetString(9);
			equip[0].Usuario = leitor.GetString(10);
			equip[0].Senha = leitor.GetString(11);
			equip[0].Status = leitor.GetString(12);
			equip[0].Imagem = leitor.GetString(13);

			conexao.desconectar();
			cmd.Dispose();

			return equip;
		}

		public List<EquipamentoDTO> ListarEquipamento()
		{
			cmd.CommandText = "SELECT " +
				"e.id, " +
				"e.codigo, " +
				"e.dataAquisicao, " +
				"t.tipo, " +
				"f.nome, " +
				"m.modelo, " +
				"m.descricao, " +
				"e.endIp, " +
				"e.mascara, " +
				"e.gateway, " +
				"e.usuario, " +
				"e.senha, " +
				"m.imagem, " +
				"s.sttatus " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_modelo m ON e.codModelo = m.codigo " +
				"INNER JOIN tb_equipamento_tipo t ON m.idTipoEquipamento " +
				"INNER JOIN tb_equipamento_fabricante f ON m.codFabricante = f.codigo " +
				"INNER JOIN tb_equipamento_status s ON e.idStatus = s.id " +
				"ORDER BY e.codigo ASC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(14);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				DateTime dataAquisicao = DateTime.Parse(leitor.GetString(2));
				eqp.DataAquisicao = dataAquisicao.ToString("dd/MM/yyyy");
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
				eqp.Descricao = leitor.GetString(6);
				eqp.EnderecoIp = leitor.GetString(7);
				eqp.Mascara = leitor.GetString(8);
				eqp.Gateway = leitor.GetString(9);
				eqp.Usuario = leitor.GetString(10);
				eqp.Senha = leitor.GetString(11);
				eqp.Status = leitor.GetString(12);
				eqp.Imagem = leitor.GetString(13);

				equip.Add(eqp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return equip;
		}

		public List<EquipamentoDTO> ListarEquipamentoTipo(EquipamentoDTO e)
		{
			tipDto.Tipo = e.TipoEquipamento;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			cmd.CommandText = "SELECT " +
				"e.id, " +
				"e.codigo, " +
				"e.dataAquisicao, " +
				"t.tipo, " +
				"f.nome, " +
				"m.modelo, " +
				"m.descricao, " +
				"e.endIp, " +
				"e.mascara, " +
				"e.gateway, " +
				"e.usuario, " +
				"e.senha, " +
				"m.imagem, " +
				"s.sttatus " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_modelo m ON e.codModelo = m.codigo " +
				"INNER JOIN tb_equipamento_tipo t ON m.idTipoEquipamento " +
				"INNER JOIN tb_equipamento_fabricante f ON m.codFabricante = f.codigo " +
				"INNER JOIN tb_equipamento_status s ON e.idStatus = s.id " +
				"WHERE m.idTipoEquipamento = " + tipDto.Id + " " +
				"ORDER BY e.codigo ASC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(14);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				DateTime dataAquisicao = DateTime.Parse(leitor.GetString(2));
				eqp.DataAquisicao = dataAquisicao.ToString("dd/MM/yyyy");
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
				eqp.Descricao = leitor.GetString(6);
				eqp.EnderecoIp = leitor.GetString(7);
				eqp.Mascara = leitor.GetString(8);
				eqp.Gateway = leitor.GetString(9);
				eqp.Usuario = leitor.GetString(10);
				eqp.Senha = leitor.GetString(11);
				eqp.Status = leitor.GetString(12);
				eqp.Imagem = leitor.GetString(13);

				equip.Add(eqp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return equip;
		}

		public List<EquipamentoDTO> ListarEquipamentoTipoFabricante(EquipamentoDTO e)
		{
			tipDto.Tipo = e.TipoEquipamento;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			fabDto.Nome = e.Fabricante;
			fabBll.SelecionarCodigoFabricante(fabDto);

			cmd.CommandText = "SELECT " +
				"e.id, " +
				"e.codigo, " +
				"e.dataAquisicao, " +
				"t.tipo, " +
				"f.nome, " +
				"m.modelo, " +
				"m.descricao, " +
				"e.endIp, " +
				"e.mascara, " +
				"e.gateway, " +
				"e.usuario, " +
				"e.senha, " +
				"m.imagem, " +
				"s.sttatus " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_modelo m ON e.codModelo = m.codigo " +
				"INNER JOIN tb_equipamento_tipo t ON m.idTipoEquipamento " +
				"INNER JOIN tb_equipamento_fabricante f ON m.codFabricante = f.codigo " +
				"INNER JOIN tb_equipamento_status s ON e.idStatus = s.id " +
				"WHERE m.idTipoEquipamento = " + tipDto.Id + " " +
				"AND m.codFabricante = '" + fabDto.Nome + "' " +
				"ORDER BY e.codigo ASC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(14);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				DateTime dataAquisicao = DateTime.Parse(leitor.GetString(2));
				eqp.DataAquisicao = dataAquisicao.ToString("dd/MM/yyyy");
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
				eqp.Descricao = leitor.GetString(6);
				eqp.EnderecoIp = leitor.GetString(7);
				eqp.Mascara = leitor.GetString(8);
				eqp.Gateway = leitor.GetString(9);
				eqp.Usuario = leitor.GetString(10);
				eqp.Senha = leitor.GetString(11);
				eqp.Status = leitor.GetString(12);
				eqp.Imagem = leitor.GetString(13);

				equip.Add(eqp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return equip;
		}

		public List<EquipamentoDTO> ListarEquipamentoTipoFabricanteModelo(EquipamentoDTO e)
		{
			tipDto.Tipo = e.TipoEquipamento;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			fabDto.Nome = e.Fabricante;
			fabBll.SelecionarCodigoFabricante(fabDto);

			modDto.Modelo = e.Modelo;
			modBll.SelecionarCodigoModeloEquipamento(modDto);

			cmd.CommandText = "SELECT " +
				"e.id, " +
				"e.codigo, " +
				"e.dataAquisicao, " +
				"t.tipo, " +
				"f.nome, " +
				"m.modelo, " +
				"m.descricao, " +
				"e.endIp, " +
				"e.mascara, " +
				"e.gateway, " +
				"e.usuario, " +
				"e.senha, " +
				"m.imagem, " +
				"s.sttatus " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_modelo m ON e.codModelo = m.codigo " +
				"INNER JOIN tb_equipamento_tipo t ON m.idTipoEquipamento " +
				"INNER JOIN tb_equipamento_fabricante f ON m.codFabricante = f.codigo " +
				"INNER JOIN tb_equipamento_status s ON e.idStatus = s.id " +
				"WHERE m.idTipoEquipamento = " + tipDto.Id + " " +
				"AND m.codFabricante = '" + fabDto.Nome + "' " +
				"AND e.codModelo = '" + modDto.Codigo + "' " +
				"ORDER BY e.codigo ASC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(14);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				DateTime dataAquisicao = DateTime.Parse(leitor.GetString(2));
				eqp.DataAquisicao = dataAquisicao.ToString("dd/MM/yyyy");
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
				eqp.Descricao = leitor.GetString(6);
				eqp.EnderecoIp = leitor.GetString(7);
				eqp.Mascara = leitor.GetString(8);
				eqp.Gateway = leitor.GetString(9);
				eqp.Usuario = leitor.GetString(10);
				eqp.Senha = leitor.GetString(11);
				eqp.Status = leitor.GetString(12);
				eqp.Imagem = leitor.GetString(13);

				equip.Add(eqp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return equip;
		}

		public string SelecionarCodigoEquipamento(EquipamentoDTO e)
		{
			cmd.CommandText = "SELECT codigo FROM tb_equipamento " +
				"WHERE endIp = '" + e.EnderecoIp + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				e.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return e.Codigo;
		}
	}
}
