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
    class EquipamentoModeloBLL
    {
        ConexaoDAL conexao = new ConexaoDAL();
        OleDbCommand cmd = new OleDbCommand();

		EquipamentoTipoDTO tipDto = new EquipamentoTipoDTO();
		EquipamentoTipoBLL tipBll = new EquipamentoTipoBLL();

		EquipamentoFabricanteDTO fabDto = new EquipamentoFabricanteDTO();
		EquipamentoFabricanteBLL fabBll = new EquipamentoFabricanteBLL();

		Int32 qtdIdModeloEquipamento;
		Int32 qtdModeloEquipamento;

        public void CriarNovoModeloEquipamento(EquipamentoModeloDTO m)
		{
			this.ContarIdModeloEquipamento();

			if (qtdIdModeloEquipamento == 0)
			{
				m.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) FROM tb_equipamento_modelo";

				try
				{
					cmd.Connection = conexao.conectar();
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					m.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (OleDbException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarIdModeloEquipamento()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_equipamento_modelo";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdModeloEquipamento = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdModeloEquipamento;
		}

		public void SalvarModeloEquipamento(EquipamentoModeloDTO m)
		{
			tipDto.Tipo = m.TipoEquipamento;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			fabDto.Nome = m.Fabricante;
			fabBll.SelecionarIdFabricante(fabDto);

			cmd.CommandText = "INSERT INTO tb_equipamento_modelo (" +
				"id, " +
				"codigo, " +
				"idTipoEquipamento, " +
				"codFabricante, " +
				"modelo, " +
				"descricao, " +
				"imagem) " +
				"VALUES (" +
				m.Id + ", '" +
				m.Codigo + "', " +
				tipDto.Id + ", " +
				fabDto.Id + ", '" +
				m.Modelo + "', '" +
				m.Descricao + "', '" +
				m.Imagem + ")";

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

		public void EditarModeloEquipamento(EquipamentoModeloDTO m)
		{
			tipDto.Tipo = m.TipoEquipamento;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			fabDto.Nome = m.Fabricante;
			fabBll.SelecionarIdFabricante(fabDto);

			cmd.CommandText = "UPDATE tb_equipamento_modelo SET " +
				"idTipoEquipamento = " + tipDto.Id + ", " +
				"codFabricante = " + fabDto.Id + ", " +
				"modelo = '" + m.Modelo + "', " +
				"descricao = '" + m.Descricao + "' " +
				"WHERE codigo = '" + m.Codigo + "'";

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

		public void ExcluirModeloEquipamento(EquipamentoModeloDTO m)
		{
			cmd.CommandText = "DELETE FROM  tb_equipamento_modelo WHERE codigo = '" + m.Codigo + "'";

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

		public List<EquipamentoModeloDTO> SelecionarModeloEquipamento(EquipamentoModeloDTO m)
		{
			this.SelecionarCodigoModeloEquipamento(m);

			cmd.CommandText = "SELECT " +
                "tb_equipamento_modelo.id, " +
                "tb_equipamento_modelo.codigo, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento_modelo.imagem " +
				"FROM ((tb_equipamento_modelo " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id)" +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "WHERE tb_equipamento_modelo.codigo = '" + m.Codigo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoModeloDTO> modelo = new List<EquipamentoModeloDTO>(7);

			leitor.Read();

			modelo.Add(new EquipamentoModeloDTO());

			modelo[0].Id = leitor.GetInt32(0);
			modelo[0].Codigo = leitor.GetString(1);
			modelo[0].TipoEquipamento = leitor.GetString(2);
			modelo[0].Fabricante = leitor.GetString(3);
			modelo[0].Modelo = leitor.GetString(4);
			modelo[0].Descricao = leitor.GetString(5);
			modelo[0].Imagem = leitor.GetString(6);

			conexao.desconectar();
			cmd.Dispose();

			return modelo;
		}

		public List<EquipamentoModeloDTO> ListarModeloEquipamento(EquipamentoModeloDTO m)
		{
			cmd.CommandText = "SELECT " +
                "tb_equipamento_modelo.id, " +
                "tb_equipamento_modelo.codigo, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento_modelo.imagem " +
                "FROM ((tb_equipamento_modelo " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id)" +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "ORDER BY tb_equipamento_modelo.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoModeloDTO> modelo = new List<EquipamentoModeloDTO>(7);

            while (leitor.Read())
            {
				EquipamentoModeloDTO mod = new EquipamentoModeloDTO();

				mod.Id = leitor.GetInt32(0);
				mod.Codigo = leitor.GetString(1);
				mod.TipoEquipamento = leitor.GetString(2);
				mod.Fabricante = leitor.GetString(3);
				mod.Modelo = leitor.GetString(4);
				mod.Descricao = leitor.GetString(5);
				mod.Imagem = leitor.GetString(6);

				modelo.Add(mod);
			}

			conexao.desconectar();
			cmd.Dispose();

			return modelo;
		}

		public List<EquipamentoModeloDTO> ListarModeloEquipamentoTipo(EquipamentoModeloDTO m)
		{
			tipDto.Tipo = m.TipoEquipamento;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			cmd.CommandText = "SELECT " +
                "tb_equipamento_modelo.id, " +
                "tb_equipamento_modelo.codigo, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento_modelo.imagem " +
                "FROM ((tb_equipamento_modelo " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id)" +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "WHERE tb_equipamento_modelo.idTipoEquipamento = " + tipDto.Id + " " +
                "ORDER BY tb_equipamento_modelo.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoModeloDTO> modelo = new List<EquipamentoModeloDTO>(7);

			while (leitor.Read())
			{
				EquipamentoModeloDTO mod = new EquipamentoModeloDTO();

				mod.Id = leitor.GetInt32(0);
				mod.Codigo = leitor.GetString(1);
				mod.TipoEquipamento = leitor.GetString(2);
				mod.Fabricante = leitor.GetString(3);
				mod.Modelo = leitor.GetString(4);
				mod.Descricao = leitor.GetString(5);
				mod.Imagem = leitor.GetString(6);

				modelo.Add(mod);
			}

			conexao.desconectar();
			cmd.Dispose();

			return modelo;
		}

		public List<EquipamentoModeloDTO> ListarModeloEquipamentoFabricante(EquipamentoModeloDTO m)
		{
			fabDto.Nome = m.Fabricante;
			fabBll.SelecionarIdFabricante(fabDto);

			cmd.CommandText = "SELECT " +
                "tb_equipamento_modelo.id, " +
                "tb_equipamento_modelo.codigo, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento_modelo.imagem " +
                "FROM ((tb_equipamento_modelo " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id)" +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "WHERE tb_equipamento_modelo.idFabricante = " + fabDto.Id + " " +
                "ORDER BY tb_equipamento_modelo.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoModeloDTO> modelo = new List<EquipamentoModeloDTO>(7);

			while (leitor.Read())
			{
				EquipamentoModeloDTO mod = new EquipamentoModeloDTO();

				mod.Id = leitor.GetInt32(0);
				mod.Codigo = leitor.GetString(1);
				mod.TipoEquipamento = leitor.GetString(2);
				mod.Fabricante = leitor.GetString(3);
				mod.Modelo = leitor.GetString(4);
				mod.Descricao = leitor.GetString(5);
				mod.Imagem = leitor.GetString(6);

				modelo.Add(mod);
			}

			conexao.desconectar();
			cmd.Dispose();

			return modelo;
		}

		public List<EquipamentoModeloDTO> ListarModeloEquipamentoTipoFabricante(EquipamentoModeloDTO m)
		{
			tipDto.Tipo = m.TipoEquipamento;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			fabDto.Nome = m.Fabricante;
			fabBll.SelecionarIdFabricante(fabDto);

			cmd.CommandText = "SELECT " +
                "tb_equipamento_modelo.id, " +
                "tb_equipamento_modelo.codigo, " +
                "tb_equipamento_tipo.tipo, " +
                "tb_equipamento_fabricante.nome, " +
                "tb_equipamento_modelo.modelo, " +
                "tb_equipamento_modelo.descricao, " +
                "tb_equipamento_modelo.imagem " +
                "FROM ((tb_equipamento_modelo " +
                "INNER JOIN tb_equipamento_tipo ON tb_equipamento_modelo.idTipoEquipamento = tb_equipamento_tipo.id)" +
                "INNER JOIN tb_equipamento_fabricante ON tb_equipamento_modelo.idFabricante = tb_equipamento_fabricante.id) " +
                "WHERE tb_equipamento_modelo.idFabricante = " + fabDto.Id + " " +
                "AND tb_equipamento_modelo.idTipoEquipamento = " + tipDto.Id + " " +
                "ORDER BY tb_equipamento_modelo.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoModeloDTO> modelo = new List<EquipamentoModeloDTO>(7);

			while (leitor.Read())
			{
				EquipamentoModeloDTO mod = new EquipamentoModeloDTO();

				mod.Id = leitor.GetInt32(0);
				mod.Codigo = leitor.GetString(1);
				mod.TipoEquipamento = leitor.GetString(2);
				mod.Fabricante = leitor.GetString(3);
				mod.Modelo = leitor.GetString(4);
				mod.Descricao = leitor.GetString(5);
				mod.Imagem = leitor.GetString(6);

				modelo.Add(mod);
			}

			conexao.desconectar();
			cmd.Dispose();

			return modelo;
		}

		public List<EquipamentoModeloDTO> PopularComboboxModeloEquipamento(EquipamentoModeloDTO m)
		{
			tipDto.Tipo = m.TipoEquipamento;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			fabDto.Nome = m.Fabricante;
			fabBll.SelecionarIdFabricante(fabDto);

			cmd.CommandText = "SELECT modelo FROM tb_equipamento_modelo " +
				"WHERE idTipoEquipamento = " + tipDto.Id + " " +
				"AND  idFabricante = " + fabDto.Id;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<EquipamentoModeloDTO> modelo = new List<EquipamentoModeloDTO>();

			while (leitor.Read())
			{
				EquipamentoModeloDTO mod = new EquipamentoModeloDTO();
				mod.Modelo = leitor.GetString(0);
				modelo.Add(mod);
			}

			conexao.desconectar();
			cmd.Dispose();

			return modelo;
		}

		public string SelecionarCodigoModeloEquipamento(EquipamentoModeloDTO m)
		{
			tipDto.Tipo = m.TipoEquipamento;
			tipBll.SelecionarIdTipoEquipamento(tipDto);

			fabDto.Nome = m.Fabricante;
			fabBll.SelecionarIdFabricante(fabDto);

			cmd.CommandText = "SELECT codigo FROM tb_equipamento_modelo " +
				"WHERE modelo = '" + m.Modelo + "' " +
				"AND idTipoEquipamento = " + tipDto.Id + " " +
				"AND idFabricante = " + fabDto.Id;

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				m.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return m.Codigo;
		}

        public Int32 ContarQtdModeloEquipamento(EquipamentoModeloDTO em)
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_equipamento_modelo " +
				"WHERE modelo = '" + em.Modelo + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdModeloEquipamento = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdModeloEquipamento;
        }
    }
}
