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
    class RedeBLL
    {
		ConexaoDAL conexao = new ConexaoDAL();
		OleDbCommand cmd = new OleDbCommand();

		EquipamentoDTO eqpDto = new EquipamentoDTO();
		EquipamentoBLL eqpBll = new EquipamentoBLL();

		RedeStatusDTO staDto = new RedeStatusDTO();
		RedeStatusBLL staBll = new RedeStatusBLL();

		Int32 qtdIdRede;

		public void CriarNovaRede(RedeDTO e)
		{
			this.ContarIdRede();

			if (qtdIdRede == 0)
			{
				e.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) FROM tb_rede";

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

		public Int32 ContarIdRede()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_rede";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdRede = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdRede;
		}

		public void SalvarRede(RedeDTO r)
		{
			//eqpDto.Modelo = r.Equipamento;
			//eqpBll.SelecionarCodigoEquipamento(eqpDto);

			staDto.Status = r.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "INSERT INTO tb_rede (" +
				"id, " +
				"endIp, " +
				"mascara, " +
				"gateway, " +
				"codEquipamento, " +
				"idStatus) " +
				"VALUES (" +
				r.Id + ", '" +
				r.EndIp + "', '" +
				r.Mascara + "', '" +
				r.Gateway + "', '" +
				r.Equipamento + "', " +
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

		public void EditarRede(RedeDTO r)
		{
			eqpDto.Modelo = r.Equipamento;
			eqpBll.SelecionarCodigoEquipamento(eqpDto);

			staDto.Status = r.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "UPDATE tb_rede SET " +
				"endIp = '" + r.EndIp + "', " +
				"mascara = '" + r.Mascara + "', " +
				"gateway = '" + r.Gateway + "', " +
				"codEquipamento = '" + eqpDto.Codigo + "', " +
				"idStatus = " + staDto.Id + " " +
				"WHERE id = " + r.Id;

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

		public void ExcluirRede(RedeDTO r)
		{
			cmd.CommandText = "DELETE FROM  tb_rede WHERE id = " + r.Id;

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

		public List<RedeDTO> SelecionarRede(RedeDTO r)
		{
			cmd.CommandText = "SELECT " +
                "tb_rede.id, " +
                "tb_rede.endIp, " +
                "tb_rede.mascara, " +
                "tb_rede.gateway, " +
                "tb_rede.codEquipamento, " +
                "tb_rede_status.statusIp " +
				"FROM tb_rede " +
                "INNER JOIN tb_rede_status ON tb_rede.idStatus = tb_rede_status.id " +
                "WHERE tb_rede.id = " + r.Id;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<RedeDTO> rede = new List<RedeDTO>(6);

			leitor.Read();

			rede.Add(new RedeDTO());

			rede[0].Id = leitor.GetInt32(0);
			rede[0].EndIp = leitor.GetString(1);
			rede[0].Mascara = leitor.GetString(2);
			rede[0].Gateway = leitor.GetString(3);
			rede[0].Equipamento = leitor.GetString(4);
			rede[0].Status = leitor.GetString(5);

			conexao.desconectar();
			cmd.Dispose();

			return rede;
		}

		public List<RedeDTO> SelecionarRedeEquipamento(RedeDTO r)
		{
			cmd.CommandText = "SELECT " +
                "tb_rede.id, " +
                "tb_rede.endIp, " +
                "tb_rede.mascara, " +
                "tb_rede.gateway, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_rede_status.statusIp " +
				"FROM (((tb_rede " +
                "INNER JOIN tb_equipamento ON tb_rede.codEquipamento = tb_equipamento.codigo) " +
                "INNER JOIN tb_equipamento_modelo ON tb_equipamento.codModelo = tb_equipamento_modelo.codigo) " +
                "INNER JOIN tb_rede_status ON tb_rede.idStatus = tb_rede_status.id) " +
                "WHERE tb_rede.id = " + r.Id + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<RedeDTO> rede = new List<RedeDTO>(6);

			leitor.Read();

			rede.Add(new RedeDTO());

			rede[0].Id = leitor.GetInt32(0);
			rede[0].EndIp = leitor.GetString(1);
			rede[0].Mascara = leitor.GetString(2);
			rede[0].Gateway = leitor.GetString(3);
			rede[0].Equipamento = leitor.GetString(4);
			rede[0].Status = leitor.GetString(5);

			conexao.desconectar();
			cmd.Dispose();

			return rede;
		}

		public List<RedeDTO> ListarRede()
		{
			cmd.CommandText = "SELECT " +
				"r.id, " +
				"r.endIp, " +
				"r.mascara, " +
				"r.gateway, " +
				"r.codEquipamento, " +
				"s.statusIp " +
				"FROM tb_rede r " +
				"INNER JOIN tb_rede_status s ON r.idStatus = s.id " +
				"ORDER BY r.id ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<RedeDTO> rede = new List<RedeDTO>(6);

			while (leitor.Read())
			{
				RedeDTO rd = new RedeDTO();

				rd.Id = leitor.GetInt32(0);
				rd.EndIp = leitor.GetString(1);
				rd.Mascara = leitor.GetString(2);
				rd.Gateway = leitor.GetString(3);
				rd.Equipamento = leitor.GetString(4);
				rd.Status = leitor.GetString(5);

				rede.Add(rd);
			}

			conexao.desconectar();
			cmd.Dispose();

			return rede;
		}

		public List<RedeDTO> ListarRedeStatus(RedeDTO r)
		{
			staDto.Status = r.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "SELECT " +
				"r.id, " +
				"r.endIp, " +
				"r.mascara, " +
				"r.gateway, " +
				"r.codEquipamento, " +
				"s.statusIp " +
				"FROM tb_rede r " +
				"INNER JOIN tb_rede_status s ON r.idStatus = s.id " +
				"WHERE r.idStatus = " + staDto.Id + " " +
				"ORDER BY r.id ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<RedeDTO> rede = new List<RedeDTO>(6);

			while (leitor.Read())
			{
				RedeDTO rd = new RedeDTO();

				rd.Id = leitor.GetInt32(0);
				rd.EndIp = leitor.GetString(1);
				rd.Mascara = leitor.GetString(2);
				rd.Gateway = leitor.GetString(3);
				rd.Equipamento = leitor.GetString(4);
				rd.Status = leitor.GetString(5);

				rede.Add(rd);
			}

			conexao.desconectar();
			cmd.Dispose();

			return rede;
		}
        /*
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
				"e.mac, " +
				"e.endIp, " +
				"e.mascara, " +
				"e.gateway, " +
				"e.usuario, " +
				"e.senha, " +
				"m.imagem, " +
				"s.sttatus " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_modelo m ON e.codModelo = m.codigo " +
				"INNER JOIN tb_equipamento_tipo t ON m.idTipoEquipamento = t.id " +
				"INNER JOIN tb_equipamento_fabricante f ON m.codFabricante = f.codigo " +
				"INNER JOIN tb_equipamento_status s ON e.idStatus = s.id " +
				"WHERE m.idTipoEquipamento = " + tipDto.Id + " " +
				"AND m.codFabricante = '" + fabDto.Nome + "' " +
				"ORDER BY e.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(15);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				eqp.DataAquisicao = leitor.GetDateTime(2).ToString("dd/MM/yyyy");
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
				eqp.Descricao = leitor.GetString(6);
				eqp.Mac = leitor.GetString(7);
				eqp.EnderecoIp = leitor.GetString(8);
				eqp.Mascara = leitor.GetString(9);
				eqp.Gateway = leitor.GetString(10);
				eqp.Usuario = leitor.GetString(11);
				eqp.Senha = leitor.GetString(12);
				eqp.Imagem = leitor.GetString(13);
				eqp.Status = leitor.GetString(14);

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
				"e.mac, " +
				"e.endIp, " +
				"e.mascara, " +
				"e.gateway, " +
				"e.usuario, " +
				"e.senha, " +
				"m.imagem, " +
				"s.sttatus " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_modelo m ON e.codModelo = m.codigo " +
				"INNER JOIN tb_equipamento_tipo t ON m.idTipoEquipamento = t.id " +
				"INNER JOIN tb_equipamento_fabricante f ON m.codFabricante = f.codigo " +
				"INNER JOIN tb_equipamento_status s ON e.idStatus = s.id " +
				"WHERE m.idTipoEquipamento = " + tipDto.Id + " " +
				"AND m.codFabricante = '" + fabDto.Nome + "' " +
				"AND e.codModelo = '" + modDto.Codigo + "' " +
				"ORDER BY e.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(15);

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Codigo = leitor.GetString(1);
				eqp.DataAquisicao = leitor.GetDateTime(2).ToString("dd/MM/yyyy");
				eqp.TipoEquipamento = leitor.GetString(3);
				eqp.Fabricante = leitor.GetString(4);
				eqp.Modelo = leitor.GetString(5);
				eqp.Descricao = leitor.GetString(6);
				eqp.Mac = leitor.GetString(7);
				eqp.EnderecoIp = leitor.GetString(8);
				eqp.Mascara = leitor.GetString(9);
				eqp.Gateway = leitor.GetString(10);
				eqp.Usuario = leitor.GetString(11);
				eqp.Senha = leitor.GetString(12);
				eqp.Imagem = leitor.GetString(13);
				eqp.Status = leitor.GetString(14);

				equip.Add(eqp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return equip;
		}

		*/

        public void SalvarEquipamentoRede(RedeDTO r)
        {
			staDto.Status = r.Status;
			staBll.SelecionarIdStatus(staDto);

            cmd.CommandText = "UPDATE tb_rede SET " +                
                "codEquipamento = '" + r.Equipamento + "', " +
				"idStatus = " + staDto.Id + " " +
                "WHERE endIp = '" + r.EndIp + "'";

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

        public string SelecionarStatusRede(RedeDTO r)
        {
            cmd.CommandText = "SELECT " +
				"tb_rede_status.status " +
				"FROM tb_rede " +
				"INNER JOIN tb_rede_status ON tb_rede.idStatus = tb_rede_status.id " +
                "WHERE endIp = '" + r.EndIp + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                r.Status = leitor.GetString(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return r.Status;
        }

        public Int32 SelecionarIdRede(RedeDTO r)
		{
			cmd.CommandText = "SELECT id FROM tb_rede " +
				"WHERE endIp = '" + r.EndIp + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				r.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return r.Id;
		}
		/*
		public List<EquipamentoDTO> SelecionarEquipamentoId(EquipamentoDTO e)
		{
			cmd.CommandText = "SELECT " +
				"e.id, " +
				"e.codigo, " +
				"e.dataAquisicao, " +
				"t.tipo, " +
				"f.nome, " +
				"m.modelo, " +
				"e.mac, " +
				"m.descricao, " +
				"e.endIp, " +
				"e.mascara, " +
				"e.gateway, " +
				"e.usuario, " +
				"e.senha, " +
				"m.imagem, " +
				"e.codEstacao, " +
				"s.sttatus " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_modelo m ON e.codModelo = m.codigo " +
				"INNER JOIN tb_equipamento_tipo t ON m.idTipoEquipamento = t.id " +
				"INNER JOIN tb_equipamento_fabricante f ON m.codFabricante = f.codigo " +
				"INNER JOIN tb_equipamento_status s ON e.idStatus = s.id " +
				"WHERE e.id = " + e.Id;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equip = new List<EquipamentoDTO>(16);

			leitor.Read();

			equip.Add(new EquipamentoDTO());

			equip[0].Id = leitor.GetInt32(0);
			equip[0].Codigo = leitor.GetString(1);
			equip[0].DataAquisicao = leitor.GetDateTime(2).ToString("dd/MM/yyyy");
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
		*/
	}
}
