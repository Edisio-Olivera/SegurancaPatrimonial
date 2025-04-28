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
    class EquipamentoBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		OleDbCommand cmd = new OleDbCommand();

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
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					e.Id = leitor.GetInt32(0) + 1;

					conexao.desconectar();
				}
				catch (OleDbException ex)
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
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdEquipamento = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdEquipamento;
		}

		public void SalvarEquipamento(EquipamentoDTO e)
		{
			modDto.TipoEquipamento = e.TipoEquipamento;
			modDto.Fabricante = e.Fabricante;
			modDto.Modelo = e.Modelo;
			modBll.SelecionarCodigoModeloEquipamento(modDto);

			staDto.Status = e.Status;
			staBll.SelecionarIdEquipamentoStatus(staDto);

			cmd.CommandText = "INSERT INTO tb_equipamento (" +
				"id, " +
				"codigo, " +
				"dataAquisicao, " +
				"codModelo, " +
				"mac, " +
				"endIp, " +
				"mascara, " +
				"gateway, " +
				"usuario, " +
				"senha, " +
				"codEstacao, " +
				"idStatus) " +
				"VALUES (" +
				e.Id + ", '" +
				e.Codigo + "', '" +
				e.DataAquisicao + "', '" +
				modDto.Codigo + "', '" +
				e.Mac + "', '" +
				e.EnderecoIp + "', '" +
				e.Mascara + "', '" +
				e.Gateway + "', '" +
				e.Usuario + "', '" +
				e.Senha + "', '" +
				e.Estacao + "', " +
				staDto.Id + ")";

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
			catch (OleDbException ex)
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
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public List<EquipamentoDTO> SelecionarEquipamento(EquipamentoDTO e)
		{
			cmd.CommandText = "SELECT " +
                "tb_equipamento.id, " +
                "tb_equipamento.codigo, " +
                "tb_equipamento.dataAquisicao, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento.mac, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento.endIp, " +
                "tb_equipamento.mascara, " +
                "tb_equipamento.gateway, " +
                "tb_equipamento.usuario, " +
                "tb_equipamento.senha, " +
                "tb_equipamento_modelo.imagem, " +
                "tb_equipamento.codEstacao, " +
                "tb_equipamento_status.status " +
				"FROM ((((tb_equipamento " +
                "INNER JOIN tb_equipamento_modelo ON tb_equipamento.codModelo = tb_equipamento_modelo.codigo) " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id) " +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "INNER JOIN tb_equipamento_status ON tb_equipamento.idStatus = tb_equipamento_status.id) " +
                "WHERE tb_equipamento.codigo = '" + e.Codigo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(16);

			leitor.Read();

			equip.Add(new EquipamentoDTO());

			equip[0].Id = leitor.GetInt32(0);
			equip[0].Codigo = leitor.GetString(1);
			equip[0].DataAquisicao = leitor.GetDateTime(2);
			equip[0].TipoEquipamento = leitor.GetString(3);
			equip[0].Fabricante = leitor.GetString(4);
			equip[0].Modelo = leitor.GetString(5);
			equip[0].Mac = leitor.GetString(6);
			equip[0].Descricao = leitor.GetString(7);
			equip[0].EnderecoIp = leitor.GetString(8);
			equip[0].Mascara = leitor.GetString(9);
			equip[0].Gateway = leitor.GetString(10);
			equip[0].Usuario = leitor.GetString(11);
			equip[0].Senha = leitor.GetString(12);
			equip[0].Imagem = leitor.GetString(13);
			equip[0].Estacao = leitor.GetString(14);
			equip[0].Status = leitor.GetString(15);

			conexao.desconectar();
			cmd.Dispose();

			return equip;
		}

		public List<EquipamentoDTO> SelecionarEquipamentoModelo(EquipamentoDTO e)
		{
			cmd.CommandText = "SELECT " +
                "tb_equipamento.id, " +
                "tb_equipamento.codigo, " +
                "tb_equipamento.dataAquisicao, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento.mac, " +                
                "tb_equipamento.endIp, " +
                "tb_equipamento.mascara, " +
                "tb_equipamento.gateway, " +
                "tb_equipamento.usuario, " +
                "tb_equipamento.senha, " +
                "tb_equipamento_modelo.imagem, " +
                "tb_equipamento.codEstacao, " +
                "tb_equipamento_status.status " +
                "FROM ((((tb_equipamento " +
                "INNER JOIN tb_equipamento_modelo ON tb_equipamento.codModelo = tb_equipamento_modelo.codigo) " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id) " +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "INNER JOIN tb_equipamento_status ON tb_equipamento.idStatus = tb_equipamento_status.id) " +
                "WHERE tb_equipamento_modelo.modelo = '" + e.Modelo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(16);

			leitor.Read();

			equip.Add(new EquipamentoDTO());

			equip[0].Id = leitor.GetInt32(0);
			equip[0].Codigo = leitor.GetString(1);
			equip[0].DataAquisicao = leitor.GetDateTime(2);
			equip[0].TipoEquipamento = leitor.GetString(3);
			equip[0].Fabricante = leitor.GetString(4);
			equip[0].Modelo = leitor.GetString(5);
            equip[0].Descricao = leitor.GetString(6);
            equip[0].Mac = leitor.GetString(7);			
			equip[0].EnderecoIp = leitor.GetString(8);
			equip[0].Mascara = leitor.GetString(9);
			equip[0].Gateway = leitor.GetString(10);
			equip[0].Usuario = leitor.GetString(11);
			equip[0].Senha = leitor.GetString(12);
			equip[0].Imagem = leitor.GetString(13);
			equip[0].Estacao = leitor.GetString(14);
			equip[0].Status = leitor.GetString(15);

			conexao.desconectar();
			cmd.Dispose();

			return equip;
		}

		public List<EquipamentoDTO> ListarEquipamento()
		{
			cmd.CommandText = "SELECT " +
                "tb_equipamento.id, " +
                "tb_equipamento.codigo, " +
                "tb_equipamento.dataAquisicao, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento.mac, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento.endIp, " +
                "tb_equipamento.mascara, " +
                "tb_equipamento.gateway, " +
                "tb_equipamento.usuario, " +
                "tb_equipamento.senha, " +
                "tb_equipamento_modelo.imagem, " +
                "tb_equipamento.codEstacao, " +
                "tb_equipamento_status.status " +
                "FROM ((((tb_equipamento " +
                "INNER JOIN tb_equipamento_modelo ON tb_equipamento.codModelo = tb_equipamento_modelo.codigo) " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id) " +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "INNER JOIN tb_equipamento_status ON tb_equipamento.idStatus = tb_equipamento_status.id) " +
                "ORDER BY tb_equipamento.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(16);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				eqp.DataAquisicao = leitor.GetDateTime(2);
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
				eqp.Mac = leitor.GetString(6);
				eqp.Descricao = leitor.GetString(7);
				eqp.EnderecoIp = leitor.GetString(8);
				eqp.Mascara = leitor.GetString(9);
				eqp.Gateway = leitor.GetString(10);
				eqp.Usuario = leitor.GetString(11);
				eqp.Senha = leitor.GetString(12);				
				eqp.Imagem = leitor.GetString(13);
				eqp.Estacao = leitor.GetString(14);
				eqp.Status = leitor.GetString(15);

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
                "tb_equipamento.id, " +
                "tb_equipamento.codigo, " +
                "tb_equipamento.dataAquisicao, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento.mac, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento.endIp, " +
                "tb_equipamento.mascara, " +
                "tb_equipamento.gateway, " +
                "tb_equipamento.usuario, " +
                "tb_equipamento.senha, " +
                "tb_equipamento_modelo.imagem, " +
                "tb_equipamento.codEstacao, " +
                "tb_equipamento_status.status " +
                "FROM ((((tb_equipamento " +
                "INNER JOIN tb_equipamento_modelo ON tb_equipamento.codModelo = tb_equipamento_modelo.codigo) " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id) " +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "INNER JOIN tb_equipamento_status ON tb_equipamento.idStatus = tb_equipamento_status.id) " +
                "WHERE tb_equipamento_modelo.idTipoEquipamento = " + tipDto.Id + " " +
                "ORDER BY tb_equipamento.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(16);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				eqp.DataAquisicao = leitor.GetDateTime(2);
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
				eqp.Mac = leitor.GetString(6);
				eqp.Descricao = leitor.GetString(7);
				eqp.EnderecoIp = leitor.GetString(8);
				eqp.Mascara = leitor.GetString(9);
				eqp.Gateway = leitor.GetString(10);
				eqp.Usuario = leitor.GetString(11);
				eqp.Senha = leitor.GetString(12);
				eqp.Imagem = leitor.GetString(13);
				eqp.Estacao = leitor.GetString(14);
				eqp.Status = leitor.GetString(15);

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
			fabBll.SelecionarIdFabricante(fabDto);

			cmd.CommandText = "SELECT " +
                "tb_equipamento.id, " +
                "tb_equipamento.codigo, " +
                "tb_equipamento.dataAquisicao, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento.mac, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento.endIp, " +
                "tb_equipamento.mascara, " +
                "tb_equipamento.gateway, " +
                "tb_equipamento.usuario, " +
                "tb_equipamento.senha, " +
                "tb_equipamento_modelo.imagem, " +
                "tb_equipamento.codEstacao, " +
                "tb_equipamento_status.status " +
                "FROM ((((tb_equipamento " +
                "INNER JOIN tb_equipamento_modelo ON tb_equipamento.codModelo = tb_equipamento_modelo.codigo) " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id) " +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "INNER JOIN tb_equipamento_status ON tb_equipamento.idStatus = tb_equipamento_status.id) " +
                "WHERE tb_equipamento_modelo.idTipoEquipamento = " + tipDto.Id + " " +
                "AND tb_equipamento_modelo.idFabricante = " + fabDto.Id + " " +
                "ORDER BY tb_equipamento.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(16);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				eqp.DataAquisicao = leitor.GetDateTime(2);
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
                eqp.Mac = leitor.GetString(6);
                eqp.Descricao = leitor.GetString(7);
                eqp.EnderecoIp = leitor.GetString(8);
				eqp.Mascara = leitor.GetString(9);
				eqp.Gateway = leitor.GetString(10);
				eqp.Usuario = leitor.GetString(11);
				eqp.Senha = leitor.GetString(12);
                eqp.Imagem = leitor.GetString(13);
                eqp.Estacao = leitor.GetString(14);
                eqp.Status = leitor.GetString(15);

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
			fabBll.SelecionarIdFabricante(fabDto);

			modDto.Modelo = e.Modelo;
			modDto.TipoEquipamento = e.TipoEquipamento;
			modDto.Fabricante = e.Fabricante;
			modBll.SelecionarCodigoModeloEquipamento(modDto);

			cmd.CommandText = "SELECT " +
                "tb_equipamento.id, " +
                "tb_equipamento.codigo, " +
                "tb_equipamento.dataAquisicao, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento.mac, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento.endIp, " +
                "tb_equipamento.mascara, " +
                "tb_equipamento.gateway, " +
                "tb_equipamento.usuario, " +
                "tb_equipamento.senha, " +
                "tb_equipamento_modelo.imagem, " +
                "tb_equipamento.codEstacao, " +
                "tb_equipamento_status.status " +
                "FROM ((((tb_equipamento " +
                "INNER JOIN tb_equipamento_modelo ON tb_equipamento.codModelo = tb_equipamento_modelo.codigo) " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id) " +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "INNER JOIN tb_equipamento_status ON tb_equipamento.idStatus = tb_equipamento_status.id) " +
                "WHERE tb_equipamento_modelo.idTipoEquipamento = " + tipDto.Id + " " +
                "AND tb_equipamento_modelo.idFabricante = " + fabDto.Id + " " +
                "AND tb_equipamento.codModelo = '" + modDto.Codigo + "' " +
                "ORDER BY tb_equipamento.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(16);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				eqp.DataAquisicao = leitor.GetDateTime(2);
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
                eqp.Mac = leitor.GetString(6);
                eqp.Descricao = leitor.GetString(7);
                eqp.EnderecoIp = leitor.GetString(8);
				eqp.Mascara = leitor.GetString(9);
				eqp.Gateway = leitor.GetString(10);
				eqp.Usuario = leitor.GetString(11);
				eqp.Senha = leitor.GetString(12);
                eqp.Imagem = leitor.GetString(13);
                eqp.Estacao = leitor.GetString(14);
                eqp.Status = leitor.GetString(15);

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
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				e.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return e.Codigo;
		}

		public List<EquipamentoDTO> SelecionarEquipamentoId(EquipamentoDTO e)
		{
			cmd.CommandText = "SELECT " +
                "tb_equipamento.id, " +
                "tb_equipamento.codigo, " +
                "tb_equipamento.dataAquisicao, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento.mac, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento.endIp, " +
                "tb_equipamento.mascara, " +
                "tb_equipamento.gateway, " +
                "tb_equipamento.usuario, " +
                "tb_equipamento.senha, " +
                "tb_equipamento_modelo.imagem, " +
                "tb_equipamento.codEstacao, " +
                "tb_equipamento_status.status " +
                "FROM ((((tb_equipamento " +
                "INNER JOIN tb_equipamento_modelo ON tb_equipamento.codModelo = tb_equipamento_modelo.codigo) " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id) " +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "INNER JOIN tb_equipamento_status ON tb_equipamento.idStatus = tb_equipamento_status.id) " +
                "WHERE tb_equipamento.id = " + e.Id;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(16);

			leitor.Read();

			equip.Add(new EquipamentoDTO());

			equip[0].Id = leitor.GetInt32(0);
			equip[0].Codigo = leitor.GetString(1);
			equip[0].DataAquisicao = leitor.GetDateTime(2);
			equip[0].TipoEquipamento = leitor.GetString(3);
			equip[0].Fabricante = leitor.GetString(4);
			equip[0].Modelo = leitor.GetString(5);
			equip[0].Mac = leitor.GetString(6);
			equip[0].Descricao = leitor.GetString(7);
			equip[0].EnderecoIp = leitor.GetString(8);
			equip[0].Mascara = leitor.GetString(9);
			equip[0].Gateway = leitor.GetString(10);
			equip[0].Usuario = leitor.GetString(11);
			equip[0].Senha = leitor.GetString(12);
			equip[0].Imagem = leitor.GetString(13);
            equip[0].Imagem = leitor.GetString(13);
            equip[0].Estacao = leitor.GetString(14);
            equip[0].Status = leitor.GetString(15);

            conexao.desconectar();
			cmd.Dispose();

			return equip;
		}

		public void InstalarEquipamentoEstacao(EquipamentoDTO e)
		{
			cmd.CommandText = "UPDATE tb_equipamento SET " +
				"codEstacao = '" + e.Estacao + "', " +
				"idStatus = 2 " + 
				"WHERE codigo = '" + e.Codigo + "'";

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
	}
}
