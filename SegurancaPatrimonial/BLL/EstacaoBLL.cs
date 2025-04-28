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
    class EstacaoBLL
    {
        ConexaoDAL conexao = new ConexaoDAL();
        OleDbCommand cmd = new OleDbCommand();

		EquipamentoTipoDTO tipDto = new EquipamentoTipoDTO();
		EquipamentoTipoBLL tipBll = new EquipamentoTipoBLL();

		ClienteBaseDTO basDto = new ClienteBaseDTO();
		ClienteBaseBLL basBll = new ClienteBaseBLL();

		ClienteBaseLocalDTO locDto = new ClienteBaseLocalDTO();
		ClienteBaseLocalBLL locBll = new ClienteBaseLocalBLL();

		ClienteBaseLocalSetorDTO setDto = new ClienteBaseLocalSetorDTO();
		ClienteBaseLocalSetorBLL setBll = new ClienteBaseLocalSetorBLL();

		TipoAlimentacaoDTO aliDto = new TipoAlimentacaoDTO();
		TipoAlimentacaoBLL aliBll = new TipoAlimentacaoBLL();

		TipoCaboDTO cabDto = new TipoCaboDTO();
		TipoCaboBLL cabBll = new TipoCaboBLL();

		TipoConexaoDTO conDto = new TipoConexaoDTO();
		TipoConexaoBLL conBll = new TipoConexaoBLL();

		TipoFixacaoDTO fixDto = new TipoFixacaoDTO();
		TipoFixacaoBLL fixBll = new TipoFixacaoBLL();

		TipoInfraDTO infDto = new TipoInfraDTO();
		TipoInfraBLL infBll = new TipoInfraBLL();

		EquipamentoDTO eqpDto = new EquipamentoDTO();
		EquipamentoBLL eqpBll = new EquipamentoBLL();

        EstacaoTipoDTO etpDto = new EstacaoTipoDTO();
        EstacaoTipoBLL etpBll = new EstacaoTipoBLL();

        EstacaoStatusDTO staDto = new EstacaoStatusDTO();
		EstacaoStatusBLL staBll = new EstacaoStatusBLL();

		Int32 qtdIdEstacao;
        Int32 qtdIdEstacaoTipo;
        Int32 qtdEstacaoSetor;

		public void CriarNovaEstacao(EstacaoDTO e)
		{
			this.ContarIdEstacao();

			if (qtdIdEstacao == 0)
			{
				e.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) FROM tb_estacao";

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

		public Int32 ContarIdEstacaoTipo(EstacaoDTO e)
		{
            etpDto.Tipo = e.TipoEstacao;
            etpBll.SelecionarIdTipoEstacao(etpDto);

            cmd.CommandText = "SELECT COUNT(id) FROM tb_estacao " +
				"WHERE idTipoEstacao = " + etpDto.Id;

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdEstacaoTipo = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdEstacaoTipo;
		}

        public Int32 ContarIdEstacao()
        {
			cmd.CommandText = "SELECT COUNT(id) FROM tb_estacao";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdEstacao = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdEstacao;
        }

        public void SalvarEstacao(EstacaoDTO e)
		{
			tipDto.Tipo = e.TipoEstacao;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			basDto.Base = e.Base;
			basBll.SelecionarCodigoBaseCliente(basDto);

			locDto.Base = e.Base;
			locDto.Local = e.Local;
			locBll.SelecionarCodigoBaseLocal(locDto);

			setDto.Local = e.Local;
			setDto.Setor = e.Setor;
			setBll.SelecionarCodigoLocalSetor(setDto);

			conDto.Tipo = e.TipoConexao;
			conBll.SelecionarIdTipoConexao(conDto);

			aliDto.Tipo = e.TipoAlimentacao;
			aliBll.SelecionarIdTipoAlimentacao(aliDto);

			cabDto.Tipo = e.TipoCabo;
			cabBll.SelecionarIdTipoCabo(cabDto);

			infDto.Tipo = e.TipoInfra;
			infBll.SelecionarIdTipoInfra(infDto);

			fixDto.Tipo = e.TipoFixacao;
			fixBll.SelecionarIdTipoFixacao(fixDto);

			staDto.Status = e.Status;
			staBll.SelecionarIdTipoStatus(staDto);

			cmd.CommandText = "INSERT INTO tb_estacao (" +
				"id, " +
				"codigo, " +
				"idTipoEstacao, " +
				"codSetor, " +
				"descricao, " +
				"observacao, " +
				"altura, " +
				"idTipoConexao, " +
				"idTipoAlimentacao, " +
				"idTipoCabo, " +
				"idTipoInfra, " +
				"idTipoFixacao, " +
				"qtdCabo, " +
				"codEquipamento, " +
				"imagem, " +
				"idStatus) " +
				"VALUES (" +
				e.Id + ", '" +
				e.Codigo + "', " +
				tipDto.Id + ", '" +
				setDto.Codigo + "', '" +
				e.Descricao + "', '" +
				e.Observacao + "', " +
				e.Altura + ", " +
				conDto.Id + ", " +
				aliDto.Id + ", " +
				cabDto.Id + ", " +
				infDto.Id + ", " +
				fixDto.Id + ", " +
				e.QtdCabo + ", '" +
				e.Equipamento + "', '" +
				e.Imagem + "', " +
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

		public void EditarEstacao(EstacaoDTO e)
		{
			tipDto.Tipo = e.TipoEstacao;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			basDto.Base = e.Base;
			basBll.SelecionarCodigoBaseCliente(basDto);

			locDto.Base = e.Base;
			locDto.Local = e.Local;
			locBll.SelecionarCodigoBaseLocal(locDto);

			setDto.Local = e.Local;
			setDto.Setor = e.Setor;
			setBll.SelecionarCodigoLocalSetor(setDto);

			conDto.Tipo = e.TipoConexao;
			conBll.SelecionarIdTipoConexao(conDto);

			aliDto.Tipo = e.TipoAlimentacao;
			aliBll.SelecionarIdTipoAlimentacao(aliDto);

			cabDto.Tipo = e.TipoCabo;
			cabBll.SelecionarIdTipoCabo(cabDto);

			infDto.Tipo = e.TipoInfra;
			infBll.SelecionarIdTipoInfra(infDto);

			fixDto.Tipo = e.TipoFixacao;
			fixBll.SelecionarIdTipoFixacao(fixDto);

			cmd.CommandText = "UPDATE tb_estacao SET " +
				"idTipoEstacao = " + tipDto.Id + ", " +
				"codSetor = '" + setDto.Codigo + "', " +
				"descricao = '" + e.Descricao + "', " +
				"observacao = '" + e.Observacao + "', " +
				"altura = " + e.Altura + ", " +
				"idTipoConexao = " + conDto.Id + ", " +
				"idTipoAlimentacao = " + aliDto.Id + ", " +
				"idTipoCabo = " + cabDto.Id + ", " +
				"idTipoInfra = " + infDto.Id + ", " +
				"idTipoFixacao = " + fixDto.Id + ", " +
				"qtdCabo = " + e.QtdCabo + " " +
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

		public void ExcluirEstacao(EstacaoDTO e)
		{
			cmd.CommandText = "DELETE FROM tb_estacao WHERE codigo = '" + e.Codigo + "'";

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

		public List<EstacaoDTO> SelecionarEstacao(EstacaoDTO e)
		{
			cmd.CommandText = "SELECT " +
                "tb_estacao.id, " +
                "tb_estacao.codigo, " +
                "tb_estacao_tipo.tipo, " +
                "tb_cliente_base.nome, " +
                "tb_cliente_base_local.nome, " +
                "tb_cliente_base_local_setor.nome, " +
                "tb_estacao.descricao, " +
                "tb_estacao.observacao, " +
                "tb_estacao.altura, " +
                "tb_tipo_conexao.tipo, " +
                "tb_tipo_alimentacao.tipo, " +
                "tb_tipo_cabo.tipo, " +
                "tb_tipo_infra.tipo, " +
                "tb_tipo_fixacao.tipo, " +
                "tb_estacao.qtdCabo, " +
                "tb_estacao.codEquipamento, " +
                "tb_estacao_status.status, " +
                "tb_estacao.imagem, " +
                "tb_estacao.qrCode " +
				"FROM ((((((((((tb_estacao " +
                "INNER JOIN tb_estacao_tipo ON tb_estacao.idTipoEstacao = tb_estacao_tipo.id) " +
                "INNER JOIN tb_cliente_base_local_setor ON tb_estacao.codSetor = tb_cliente_base_local_setor.codigo) " +
                "INNER JOIN tb_cliente_base_local ON tb_cliente_base_local_setor.codLocal = tb_cliente_base_local.codigo) " +
                "INNER JOIN tb_cliente_base ON tb_cliente_base_local.codBase = tb_cliente_base.codigo) " +
                "INNER JOIN tb_tipo_conexao ON tb_estacao.idTipoConexao = tb_tipo_conexao.id) " +
                "INNER JOIN tb_tipo_alimentacao ON tb_estacao.idTipoAlimentacao = tb_tipo_alimentacao.id) " +
                "INNER JOIN tb_tipo_cabo ON tb_estacao.idTipoCabo = tb_tipo_cabo.id) " +
                "INNER JOIN tb_tipo_infra ON tb_estacao.idTipoInfra = tb_tipo_infra.id) " +
                "INNER JOIN tb_tipo_fixacao ON tb_estacao.idTipoFixacao = tb_tipo_fixacao.id) " +
                "INNER JOIN tb_estacao_status ON tb_estacao.idStatus = tb_estacao_status.id) " +
                "WHERE tb_estacao.codigo = '" + e.Codigo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EstacaoDTO> estacao = new List<EstacaoDTO>(19);

			leitor.Read();

			estacao.Add(new EstacaoDTO());

			estacao[0].Id = leitor.GetInt32(0);
			estacao[0].Codigo = leitor.GetString(1);
			estacao[0].TipoEstacao = leitor.GetString(2);
			estacao[0].Base = leitor.GetString(3);
			estacao[0].Local = leitor.GetString(4);
			estacao[0].Setor = leitor.GetString(5);
			estacao[0].Descricao = leitor.GetString(6);
			estacao[0].Observacao = leitor.GetString(7);
			estacao[0].Altura = leitor.GetInt32(8);
			estacao[0].TipoConexao = leitor.GetString(9);
			estacao[0].TipoAlimentacao = leitor.GetString(10);
			estacao[0].TipoCabo = leitor.GetString(11);
			estacao[0].TipoInfra = leitor.GetString(12);
			estacao[0].TipoFixacao = leitor.GetString(13);
			estacao[0].QtdCabo = leitor.GetInt32(14);
			estacao[0].Equipamento = leitor.GetString(15);
			estacao[0].Status = leitor.GetString(16);
			estacao[0].Imagem = leitor.GetString(17);
			estacao[0].QrCode = leitor.GetString(18);

			conexao.desconectar();
			cmd.Dispose();

			return estacao;
		}

		public List<EstacaoDTO> ListarEstacao()
		{
			cmd.CommandText = "SELECT " +
                "tb_estacao.id, " +
                "tb_estacao.codigo, " +
                "tb_estacao_tipo.tipo, " +
                "tb_cliente_base.nome, " +
                "tb_cliente_base_local.nome, " +
                "tb_cliente_base_local_setor.nome, " +
                "tb_estacao.descricao, " +
                "tb_estacao.codEquipamento, " +
                "tb_estacao_status.status " +
				"FROM (((((tb_estacao " +
                "INNER JOIN tb_estacao_tipo ON tb_estacao.idTipoEstacao = tb_estacao_tipo.id) " +
                "INNER JOIN tb_cliente_base_local_setor ON tb_estacao.codSetor = tb_cliente_base_local_setor.codigo) " +
                "INNER JOIN tb_cliente_base_local ON tb_cliente_base_local_setor.codLocal = tb_cliente_base_local.codigo) " +
                "INNER JOIN tb_cliente_base ON tb_cliente_base_local.codBase = tb_cliente_base.codigo) " +
                "INNER JOIN tb_estacao_status ON tb_estacao.idStatus = tb_estacao_status.id) " +
                "ORDER BY tb_estacao.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EstacaoDTO> estacao = new List<EstacaoDTO>(9);

			while (leitor.Read())
			{
				EstacaoDTO est = new EstacaoDTO();

				est.Id = leitor.GetInt32(0);
				est.Codigo = leitor.GetString(1);
				est.TipoEstacao = leitor.GetString(2);
				est.Base = leitor.GetString(3);
				est.Local = leitor.GetString(4);
				est.Setor = leitor.GetString(5);
				est.Descricao = leitor.GetString(6);
				est.Equipamento = leitor.GetString(7);
				est.Status = leitor.GetString(8);

				estacao.Add(est);
			}

			conexao.desconectar();
			cmd.Dispose();

			return estacao;
		}

		public List<EstacaoDTO> ListarEstacaoTipo(EstacaoDTO e)
		{
			cmd.CommandText = "SELECT " +
                "tb_estacao.id, " +
                "tb_estacao.codigo, " +
                "tb_estacao_tipo.tipo, " +
                "tb_cliente_base.nome, " +
                "tb_cliente_base_local.nome, " +
                "tb_cliente_base_local_setor.nome, " +
                "tb_estacao.descricao, " +
                "tb_estacao.codEquipamento, " +
                "tb_estacao_status.status " +
                "FROM (((((tb_estacao " +
                "INNER JOIN tb_estacao_tipo ON tb_estacao.idTipoEstacao = tb_estacao_tipo.id) " +
                "INNER JOIN tb_cliente_base_local_setor ON tb_estacao.codSetor = tb_cliente_base_local_setor.codigo) " +
                "INNER JOIN tb_cliente_base_local ON tb_cliente_base_local_setor.codLocal = tb_cliente_base_local.codigo) " +
                "INNER JOIN tb_cliente_base ON tb_cliente_base_local.codBase = tb_cliente_base.codigo) " +
                "INNER JOIN tb_estacao_status ON tb_estacao.idStatus = tb_estacao_status.id) " +
                "WHERE tb_estacao_tipo.tipo = '" + e.TipoEstacao + "' " +
                "ORDER BY tb_estacao.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EstacaoDTO> estacao = new List<EstacaoDTO>(9);

			while (leitor.Read())
			{
				EstacaoDTO est = new EstacaoDTO();

				est.Id = leitor.GetInt32(0);
				est.Codigo = leitor.GetString(1);
				est.TipoEstacao = leitor.GetString(2);
				est.Base = leitor.GetString(3);
				est.Local = leitor.GetString(4);
				est.Setor = leitor.GetString(5);
				est.Descricao = leitor.GetString(6);
				est.Equipamento = leitor.GetString(7);
				est.Status = leitor.GetString(8);

				estacao.Add(est);
			}

			conexao.desconectar();
			cmd.Dispose();

			return estacao;
		}

		public List<EstacaoDTO> ListarEstacaoBase(EstacaoDTO e)
		{
			cmd.CommandText = "SELECT " +
                "tb_estacao.id, " +
                "tb_estacao.codigo, " +
                "tb_estacao_tipo.tipo, " +
                "tb_cliente_base.nome, " +
                "tb_cliente_base_local.nome, " +
                "tb_cliente_base_local_setor.nome, " +
                "tb_estacao.descricao, " +
                "tb_estacao.codEquipamento, " +
                "tb_estacao_status.status " +
                "FROM (((((tb_estacao " +
                "INNER JOIN tb_estacao_tipo ON tb_estacao.idTipoEstacao = tb_estacao_tipo.id) " +
                "INNER JOIN tb_cliente_base_local_setor ON tb_estacao.codSetor = tb_cliente_base_local_setor.codigo) " +
                "INNER JOIN tb_cliente_base_local ON tb_cliente_base_local_setor.codLocal = tb_cliente_base_local.codigo) " +
                "INNER JOIN tb_cliente_base ON tb_cliente_base_local.codBase = tb_cliente_base.codigo) " +
                "INNER JOIN tb_estacao_status ON tb_estacao.idStatus = tb_estacao_status.id) " +
                "WHERE tb_cliente_base.nome = '" + e.Base + "' " +
                "AND tb_estacao_tipo.tipo = '" + e.TipoEstacao + "' " +
                "ORDER BY tb_estacao.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EstacaoDTO> estacao = new List<EstacaoDTO>(9);

			while (leitor.Read())
			{
				EstacaoDTO est = new EstacaoDTO();

				est.Id = leitor.GetInt32(0);
				est.Codigo = leitor.GetString(1);
				est.TipoEstacao = leitor.GetString(2);
				est.Base = leitor.GetString(3);
				est.Local = leitor.GetString(4);
				est.Setor = leitor.GetString(5);
				est.Descricao = leitor.GetString(6);
				est.Equipamento = leitor.GetString(7);
				est.Status = leitor.GetString(8);

				estacao.Add(est);
			}

			conexao.desconectar();
			cmd.Dispose();

			return estacao;
		}

		public List<EstacaoDTO> ListarEstacaoLocal(EstacaoDTO e)
		{
			cmd.CommandText = "SELECT " +
                "tb_estacao.id, " +
                "tb_estacao.codigo, " +
                "tb_estacao_tipo.tipo, " +
                "tb_cliente_base.nome, " +
                "tb_cliente_base_local.nome, " +
                "tb_cliente_base_local_setor.nome, " +
                "tb_estacao.descricao, " +
                "tb_estacao.codEquipamento, " +
                "tb_estacao_status.status " +
                "FROM (((((tb_estacao " +
                "INNER JOIN tb_estacao_tipo ON tb_estacao.idTipoEstacao = tb_estacao_tipo.id) " +
                "INNER JOIN tb_cliente_base_local_setor ON tb_estacao.codSetor = tb_cliente_base_local_setor.codigo) " +
                "INNER JOIN tb_cliente_base_local ON tb_cliente_base_local_setor.codLocal = tb_cliente_base_local.codigo) " +
                "INNER JOIN tb_cliente_base ON tb_cliente_base_local.codBase = tb_cliente_base.codigo) " +
                "INNER JOIN tb_estacao_status ON tb_estacao.idStatus = tb_estacao_status.id) " +
                "WHERE tb_cliente_base_local.nome = '" + e.Local + "' " +
                "AND tb_cliente_base.nome = '" + e.Base + "' " +
                "AND tb_estacao_tipo.tipo = '" + e.TipoEstacao + "' " +
                "ORDER BY tb_estacao.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EstacaoDTO> estacao = new List<EstacaoDTO>(9);

			while (leitor.Read())
			{
				EstacaoDTO est = new EstacaoDTO();

				est.Id = leitor.GetInt32(0);
				est.Codigo = leitor.GetString(1);
				est.TipoEstacao = leitor.GetString(2);
				est.Base = leitor.GetString(3);
				est.Local = leitor.GetString(4);
				est.Setor = leitor.GetString(5);
				est.Descricao = leitor.GetString(6);
				est.Equipamento = leitor.GetString(7);
				est.Status = leitor.GetString(8);

				estacao.Add(est);
			}

			conexao.desconectar();
			cmd.Dispose();

			return estacao;
		}

		public List<EstacaoDTO> ListarEstacaoSetor(EstacaoDTO e)
		{
			cmd.CommandText = "SELECT " +
                "tb_estacao.id, " +
                "tb_estacao.codigo, " +
                "tb_estacao_tipo.tipo, " +
                "tb_cliente_base.nome, " +
                "tb_cliente_base_local.nome, " +
                "tb_cliente_base_local_setor.nome, " +
                "tb_estacao.descricao, " +
                "tb_estacao.codEquipamento, " +
                "tb_estacao_status.status " +
                "FROM (((((tb_estacao " +
                "INNER JOIN tb_estacao_tipo ON tb_estacao.idTipoEstacao = tb_estacao_tipo.id) " +
                "INNER JOIN tb_cliente_base_local_setor ON tb_estacao.codSetor = tb_cliente_base_local_setor.codigo) " +
                "INNER JOIN tb_cliente_base_local ON tb_cliente_base_local_setor.codLocal = tb_cliente_base_local.codigo) " +
                "INNER JOIN tb_cliente_base ON tb_cliente_base_local.codBase = tb_cliente_base.codigo) " +
                "INNER JOIN tb_estacao_status ON tb_estacao.idStatus = tb_estacao_status.id) " +
                "WHERE tb_cliente_base_local_setor.nome = '" + e.Setor + "' " +
                "AND tb_cliente_base_local.nome = '" + e.Local + "' " +
                "AND tb_cliente_base.nome = '" + e.Base + "' " +
                "AND tb_estacao_tipo.tipo = '" + e.TipoEstacao + "' " +
                "ORDER BY tb_estacao.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EstacaoDTO> estacao = new List<EstacaoDTO>(9);

			while (leitor.Read())
			{
				EstacaoDTO est = new EstacaoDTO();

				est.Id = leitor.GetInt32(0);
				est.Codigo = leitor.GetString(1);
				est.TipoEstacao = leitor.GetString(2);
				est.Base = leitor.GetString(3);
				est.Local = leitor.GetString(4);
				est.Setor = leitor.GetString(5);
				est.Descricao = leitor.GetString(6);
				est.Equipamento = leitor.GetString(7);
				est.Status = leitor.GetString(8);

				estacao.Add(est);
			}

			conexao.desconectar();
			cmd.Dispose();

			return estacao;
		}

		public Int32 ContarQtdEstacaoSetor(EstacaoDTO e)
		{
			setDto.Setor = e.Setor;
			setDto.Local = e.Local;
			setBll.SelecionarCodigoLocalSetor(setDto);

            cmd.CommandText = "SELECT COUNT(id) FROM tb_estacao " +
                "WHERE codSetor = '" + setDto.Codigo + "'";

            try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdEstacaoSetor = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdEstacaoSetor;
		}

		public void InstalarEquipamentoEstacao(EstacaoDTO e)
        {
			cmd.CommandText = "UPDATE tb_estacao SET " +
				"codEquipamento = '" + e.Equipamento + "', " +
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

		public void AtualizarImagemEstacao(EstacaoDTO e)
        {
			cmd.CommandText = "UPDATE tb_estacao SET " +
				"imagem = '" + e.Imagem + "' " +				
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

		public void AtualizarQRCodeEstacao(EstacaoDTO e)
		{
			cmd.CommandText = "UPDATE tb_estacao SET " +
				"qrCode = '" + e.QrCode + "' " +
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

