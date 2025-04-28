using SegurancaPatrimonial.DTO;
using SegurancaPatrimonial.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SegurancaPatrimonial.View
{
    public partial class frm_cadEstacao : Form
    {
        EstacaoDTO dto = new EstacaoDTO();
        EstacaoBLL bll = new EstacaoBLL();

        EstacaoTipoDTO tipDto = new EstacaoTipoDTO();
        EstacaoTipoBLL tipBll = new EstacaoTipoBLL();

        TipoConexaoDTO conDto = new TipoConexaoDTO();
        TipoConexaoBLL conBll = new TipoConexaoBLL();

        TipoAlimentacaoDTO aliDto = new TipoAlimentacaoDTO();
        TipoAlimentacaoBLL aliBll = new TipoAlimentacaoBLL();

        TipoCaboDTO cabDto = new TipoCaboDTO();
        TipoCaboBLL cabBll = new TipoCaboBLL();

        TipoFixacaoDTO fixDto = new TipoFixacaoDTO();
        TipoFixacaoBLL fixBll = new TipoFixacaoBLL();

        TipoInfraDTO infDto = new TipoInfraDTO();
        TipoInfraBLL infBll = new TipoInfraBLL();

        ClienteBaseDTO basDto = new ClienteBaseDTO();
        ClienteBaseBLL basBll = new ClienteBaseBLL();

        ClienteBaseLocalDTO locDto = new ClienteBaseLocalDTO();
        ClienteBaseLocalBLL locBll = new ClienteBaseLocalBLL();

        ClienteBaseLocalSetorDTO setDto = new ClienteBaseLocalSetorDTO();
        ClienteBaseLocalSetorBLL setBll = new ClienteBaseLocalSetorBLL();

        EquipamentoDTO eqpDto = new EquipamentoDTO();
        EquipamentoBLL eqpBll = new EquipamentoBLL();

        EstacaoStatusDTO staDto = new EstacaoStatusDTO();
        EstacaoStatusBLL staBll = new EstacaoStatusBLL();

        Thread t1;

        string origemCompleta = "";
        string imagem = "";
        string pastaDestino = "";
        string destinoCompleto = "";
        string codigoEstacao = "";
        string tipoEstacao;

        private void abrirFormEstacao(object obj)
        {
            Application.Run(new frm_estacao());
        }

        private void EstadoInicial()
        {

        }

        private void ConfiguracaoForm()
        {
            this.Text = "SEGPAT Manager v-1.0 | Cadastro de Estação";
        }
 
        private void SalvarEstacao()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            if (this.txt_codigoEstacao.Text == "")
            {
                MessageBox.Show("Por favor, crie um Código para a Estação!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoEstacao.Focus();
                return;
            }
            else
            {
                dto.Codigo = this.txt_codigoEstacao.Text;
            }

            if (this.cmb_tipoEstacao.Text == "")
            {
                MessageBox.Show("Por favor, Selecione o Tipo da Estação!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoEstacao.Focus();
                return;
            }
            else
            {
                dto.TipoEstacao = this.cmb_tipoEstacao.Text;
            }

            if (this.cmb_base.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Base!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_base.Focus();
                return;
            }
            else
            {
                dto.Base = this.cmb_base.Text;
            }

            if (this.cmb_local.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Fabricante!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_local.Focus();
                return;
            }
            else
            {
                dto.Local = this.cmb_local.Text;
            }

            if (this.cmb_setor.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Modelo do Equipamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_setor.Focus();
                return;
            }
            else
            {
                dto.Setor = this.cmb_setor.Text;
            }

            if (this.txt_descricao.Text == "")
            {
                dto.Descricao = "-";
            }
            else
            {
                dto.Descricao = this.txt_descricao.Text;
            }

            if (this.txt_observacao.Text == "")
            {
                dto.Observacao = "-";
            }
            else
            {
                dto.Observacao = this.txt_observacao.Text;
            }

            if (this.txt_altura.Text == "")
            {
                dto.Altura = 0;
            }
            else
            {
                dto.Altura = Int32.Parse(this.txt_altura.Text);
            }

            if (this.cmb_tipoConexao.Text == "")
            {
                dto.TipoConexao = "Não Informado";
            }
            else
            {
                dto.TipoConexao = this.cmb_tipoConexao.Text;
            }

            if (this.cmb_tipoAlimentacao.Text == "")
            {
                dto.TipoAlimentacao = "Não Informado";
            }
            else
            {
                dto.TipoAlimentacao = this.cmb_tipoAlimentacao.Text;
            }

            if (this.cmb_tipoCabo.Text == "")
            {
                dto.TipoCabo = "Não Informado";
            }
            else
            {
                dto.TipoCabo = this.cmb_tipoCabo.Text;
            }

            if (this.cmb_tipoInfra.Text == "")
            {
                dto.TipoInfra = "Não Informado";
            }
            else
            {
                dto.TipoInfra = this.cmb_tipoInfra.Text;
            }

            if (this.cmb_tipoFixacao.Text == "")
            {
                dto.TipoFixacao = "Não Informado";
            }
            else
            {
                dto.TipoFixacao = this.cmb_tipoFixacao.Text;
            }

            if (this.txt_qtdCabo.Text == "")
            {
                dto.QtdCabo = 0;
            }
            else
            {
                dto.QtdCabo = Int32.Parse(this.txt_qtdCabo.Text);
            }

            dto.Equipamento = "-";
            dto.Status = "Disponível";

            bll.SalvarEstacao(dto);

            MessageBox.Show("Estação salva com sucesso!", "Salvar Estação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            t1 = new Thread(abrirFormEstacao);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            this.Close();
        }

        private void SalvarVariasEstacao()
        {
            bll.CriarNovaEstacao(dto);       

            if (this.cmb_tipoEstacao.Text == "")
            {
                MessageBox.Show("Por favor, Selecione o Tipo da Estação!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoEstacao.Focus();
                return;
            }
            else
            {
                dto.TipoEstacao = this.cmb_tipoEstacao.Text;
            }

            if (this.cmb_base.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Base!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_base.Focus();
                return;
            }
            else
            {
                dto.Base = this.cmb_base.Text;
            }

            if (this.cmb_local.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Local!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_local.Focus();
                return;
            }
            else
            {
                dto.Local = this.cmb_local.Text;
            }

            if (this.cmb_setor.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Setor!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_setor.Focus();
                return;
            }
            else
            {
                dto.Setor = this.cmb_setor.Text;
            }

            dto.Descricao = "-";
            dto.Observacao = "-";
            dto.TipoConexao = "Não Informado";
            dto.TipoAlimentacao = "Não Informado";
            dto.TipoCabo = "Não Informado";
            dto.TipoInfra = "Não Informado";
            dto.TipoFixacao = "Não Informado";
            dto.Altura = 0;
            dto.QtdCabo = 0;
            dto.Equipamento = "-";
            dto.Status = "Disponível";
            dto.Imagem = @"\Imagens\Estações\sem_imagem.jpg";

            this.CriarCodigoEstacao(dto.Base, dto.Local, dto.Setor);

            dto.Codigo = this.txt_codigoEstacao.Text;           

            bll.SalvarEstacao(dto);            
        }

        private void EditarEstacao()
        {
            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = true;
            this.btn_editar.Visible = false;

            this.btn_atualizar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert01);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert02);

            this.cmb_tipoEstacao.Enabled = false;
            this.txt_qtdEstacao.Visible = false;
            this.lbl_qtdEstacao.Visible = false;
            this.cmb_base.Enabled = false;
            this.cmb_local.Enabled = false;
            this.cmb_setor.Enabled = false;
            this.txt_descricao.Enabled = true;
            this.txt_observacao.Enabled = true;
            this.txt_altura.Enabled = true;
            this.cmb_tipoConexao.Enabled = true;
            this.cmb_tipoAlimentacao.Enabled = true;
            this.cmb_tipoCabo.Enabled = true;
            this.cmb_tipoInfra.Enabled = true;
            this.cmb_tipoFixacao.Enabled = true;
            this.txt_qtdCabo.Enabled = true;
            this.txt_statusEstacao.Enabled = false;
            this.txt_codigoEquipamento.Enabled = false;
        }

        private void AtualizarEstacao()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigoEstacao.Text;

            if (this.cmb_tipoEstacao.Text == "")
            {
                MessageBox.Show("Por favor, Selecione o Tipo da Estação!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoEstacao.Focus();
                return;
            }
            else
            {
                dto.TipoEstacao = this.cmb_tipoEstacao.Text;
            }

            if (this.cmb_base.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Base!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_base.Focus();
                return;
            }
            else
            {
                dto.Base = this.cmb_base.Text;
            }

            if (this.cmb_local.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Local!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_local.Focus();
                return;
            }
            else
            {
                dto.Local = this.cmb_local.Text;
            }

            if (this.cmb_setor.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Setor!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_setor.Focus();
                return;
            }
            else
            {
                dto.Setor = this.cmb_setor.Text;
            }

            if (this.txt_descricao.Text == "")
            {
                dto.Descricao = "-";
            }
            else
            {
                dto.Descricao = this.txt_descricao.Text;
            }

            if (this.txt_observacao.Text == "")
            {
                dto.Observacao = "-";
            }
            else
            {
                dto.Observacao = this.txt_observacao.Text;
            }

            if (this.txt_altura.Text == "")
            {
                dto.Altura = 0;
            }
            else
            {
                dto.Altura = Int32.Parse(this.txt_altura.Text);
            }

            if (this.cmb_tipoConexao.Text == "")
            {
                dto.TipoConexao = "Não Informado";
            }
            else
            {
                dto.TipoConexao = this.cmb_tipoConexao.Text;
            }

            if (this.cmb_tipoAlimentacao.Text == "")
            {
                dto.TipoAlimentacao = "Não Informado";
            }
            else
            {
                dto.TipoAlimentacao = this.cmb_tipoAlimentacao.Text;
            }

            if (this.cmb_tipoCabo.Text == "")
            {
                dto.TipoCabo = "Não Informado";
            }
            else
            {
                dto.TipoCabo = this.cmb_tipoCabo.Text;
            }

            if (this.cmb_tipoInfra.Text == "")
            {
                dto.TipoInfra = "Não Informado";
            }
            else
            {
                dto.TipoInfra = this.cmb_tipoInfra.Text;
            }

            if (this.cmb_tipoFixacao.Text == "")
            {
                dto.TipoFixacao = "Não Informado";
            }
            else
            {
                dto.TipoFixacao = this.cmb_tipoFixacao.Text;
            }

            if (this.txt_qtdCabo.Text == "")
            {
                dto.QtdCabo = 0;
            }
            else
            {
                dto.QtdCabo = Int32.Parse(this.txt_qtdCabo.Text);
            }

            bll.EditarEstacao(dto);

            MessageBox.Show("Estação atualizada com sucesso!", "Atualizar Estação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            t1 = new Thread(abrirFormEstacao);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            this.Close();
        }

        private void PopularComboboxTipoEstacao()
        {
            List<EstacaoTipoDTO> tipo = tipBll.PopularComboboxTipoEstacao();

            this.cmb_tipoEstacao.DataSource = tipo;
            this.cmb_tipoEstacao.DisplayMember = "tipo";
            this.cmb_tipoEstacao.SelectedIndex = -1;
        }

        private void PopularComboboxBase()
        {
            List<ClienteBaseDTO> baseCli = basBll.PopularComboboxBaseCliente();

            this.cmb_base.DataSource = baseCli;
            this.cmb_base.DisplayMember = "base";
            this.cmb_base.Text = "";
        }

        private void PopularComboboxLocal(string baseCli)
        {
            locDto.Base = baseCli;

            List<ClienteBaseLocalDTO> localCli = locBll.PopularComboboxBaseLocal(locDto);

            this.cmb_local.DataSource = localCli;
            this.cmb_local.DisplayMember = "local";
            this.cmb_local.SelectedIndex = -1;
        }

        private void PopularComboboxSetor(string localCli)
        {
            setDto.Local = localCli;

            List<ClienteBaseLocalSetorDTO> setorCli = setBll.PopularComboboxLocalSetor(setDto);

            this.cmb_setor.DataSource = setorCli;
            this.cmb_setor.DisplayMember = "setor";
            this.cmb_setor.Text = "";
        }

        private void PopularComboboxTipoConexao()
        {
            List<TipoConexaoDTO> conexao = conBll.PopularComboboxTipoConexao();

            this.cmb_tipoConexao.DataSource = conexao;
            this.cmb_tipoConexao.DisplayMember = "tipo";
            this.cmb_tipoConexao.Text = "";
        }

        private void PopularComboboxTipoAlimentacao()
        {
            List<TipoAlimentacaoDTO> alimentacao = aliBll.PopularComboboxTipoAlimentacao();

            this.cmb_tipoAlimentacao.DataSource = alimentacao;
            this.cmb_tipoAlimentacao.DisplayMember = "tipo";
            this.cmb_tipoAlimentacao.Text = "";
        }

        private void PopularComboboxTipoCabo()
        {
            List<TipoCaboDTO> cabo = cabBll.PopularComboboxTipoCabo();

            this.cmb_tipoCabo.DataSource = cabo;
            this.cmb_tipoCabo.DisplayMember = "tipo";
            this.cmb_tipoCabo.Text = "";
        }

        private void PopularComboboxTipoFixacao()
        {
            List<TipoFixacaoDTO> fixacao = fixBll.PopularComboboxTipoFixacao();

            this.cmb_tipoFixacao.DataSource = fixacao;
            this.cmb_tipoFixacao.DisplayMember = "tipo";
            this.cmb_tipoFixacao.Text = "";
        }

        private void PopularComboboxTipoInfra()
        {
            List<TipoInfraDTO> infra = infBll.PopularComboboxTipoInfra();

            this.cmb_tipoInfra.DataSource = infra;
            this.cmb_tipoInfra.DisplayMember = "tipo";
            this.cmb_tipoInfra.Text = "";
        }

        private void ProcurarImagem()
        {            
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleta = openFileDialog1.FileName;
                this.img_imagem.ImageLocation = openFileDialog1.FileName;

                this.btn_novoImagem.Visible = false;
                this.btn_salvarImagem.Visible = true;
                this.btn_cancelarImagem.Visible = true;
                this.btn_deletarImagem.Visible = false;

                this.btn_salvarImagem.Enabled = true;
                this.btn_cancelarImagem.Enabled = true;

                this.btn_salvarImagem.Location = new Point(34, 332);
                this.btn_cancelarImagem.Location = new Point(139, 332);
            }
        }

        private void SalvarImagemEstacao()
        {
            codigoEstacao = this.txt_codigoEstacao.Text;
            imagem = @"\\Imagens\\Estações\\" + codigoEstacao + ".jpg";
            pastaDestino = Application.StartupPath + imagem;

            if (File.Exists(pastaDestino))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Salvar Imagem!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    System.IO.File.Copy(origemCompleta, pastaDestino, true);

                    dto.Codigo = codigoEstacao;
                    dto.Imagem = imagem;
                    bll.AtualizarImagemEstacao(dto);

                    MessageBox.Show("Imagem salva com sucesso!", "Salvar Imagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                System.IO.File.Copy(origemCompleta, pastaDestino, true);

                dto.Codigo = codigoEstacao;
                dto.Imagem = imagem;
                bll.AtualizarImagemEstacao(dto);

                MessageBox.Show("Imagem salva com sucesso!", "Salvar Imagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.btn_novoImagem.Visible = true;
            this.btn_salvarImagem.Visible = false;
            this.btn_cancelarImagem.Visible = false;
            this.btn_deletarImagem.Visible = false;

            this.btn_novoImagem.Enabled = true;

            this.btn_novoImagem.Location = new Point(34, 332);
        }

        private void CancelarImagemEstacao()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse Registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.btn_novoImagem.Visible = true;
                this.btn_salvarImagem.Visible = false;
                this.btn_cancelarImagem.Visible = false;
                this.btn_deletarImagem.Visible = false;

                this.btn_novoImagem.Enabled = true;

                this.btn_novoImagem.Location = new Point(34, 332);
            }
        }

        private void DeletarImagemEstacao()
        {
            codigoEstacao = this.txt_codigoEstacao.Text;
            imagem = @"\\Imagens\\Estações\\sem_imagem.jpg";

            DialogResult result = MessageBox.Show("Deseja realmente Deletar essa imagem?", "Deletar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dto.Codigo = codigoEstacao;
                dto.Imagem = imagem;
                bll.AtualizarImagemEstacao(dto);

                MessageBox.Show("Imagem deletada com sucesso!", "Deletar Imagem!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.img_imagem.ImageLocation = Application.StartupPath + imagem;
            }            
        }

        private void CriarCodigoEstacao(string baseCli, string localCli, string setorCli)
        {
            string iataBase;
            string iataLocal;
            string iataSetor;

            if (this.cmb_base.Text == "")
            {
                return;
            }
            else
            {
                basDto.Base = baseCli;
                List<ClienteBaseDTO> b = basBll.SelecionarBaseCliente(basDto);
                iataBase = b[0].Iata;
            }

            if (this.cmb_local.Text == "")
            {
                return;
            }
            else
            {
                locDto.Local = localCli;
                List<ClienteBaseLocalDTO> l = locBll.SelecionarBaseLocal(locDto);
                iataLocal = l[0].Iata;
            }

            if (this.cmb_setor.Text == "")
            {
                return;
            }
            else
            {
                setDto.Setor = setorCli;
                setDto.Local = localCli;
                List<ClienteBaseLocalSetorDTO> s = setBll.SelecionarLocalSetor(setDto);
                iataSetor = s[0].Iata;
            }

            dto.Setor = setorCli;
            Int32 qtdEstacao = bll.ContarQtdEstacaoSetor(dto) + 1;

            string codigoEstacao = iataBase + "-" + iataLocal + "-" + iataSetor + "-" + qtdEstacao.ToString("00#");

            this.txt_codigoEstacao.Text = codigoEstacao;
        }

        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse Registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                t1 = new Thread(abrirFormEstacao);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
                this.Close();
            }
        }

        private void CriarNovoRegistro()
        {
            Int32 id = bll.ContarIdEstacao();

            this.txt_id.Text = id.ToString();
        }

        private void CriarNovaEstacaoTipo(string tipo)
        {
            Int32 id = bll.ContarIdEstacao();
            Int32 idTipo;

            dto.TipoEstacao = tipo;
            bll.CriarNovaEstacao(dto);
            this.txt_id.Text = dto.Id.ToString();

            switch (tipo)
            {
                case "CFTV":
                    dto.TipoEstacao = "CFTV";
                    idTipo = bll.ContarIdEstacaoTipo(dto) + 1;
                    codigoEstacao = "CAM-" + idTipo.ToString("000#");
                    this.txt_id.Text = id.ToString();
                    this.txt_codigoEstacao.Text = codigoEstacao;
                    break;
                case "Controle de Acesso":
                    dto.TipoEstacao = "Controle de Acesso";
                    idTipo = bll.ContarIdEstacaoTipo(dto) + 1;
                    codigoEstacao = "ACS-" + idTipo.ToString("000#");
                    this.txt_id.Text = id.ToString();
                    this.txt_codigoEstacao.Text = codigoEstacao;
                    break;
                case "Alarme":
                    dto.TipoEstacao = "Alarme";
                    idTipo = bll.ContarIdEstacaoTipo(dto) + 1;
                    codigoEstacao = "ALM-" + idTipo.ToString("000#");
                    this.txt_id.Text = id.ToString();
                    this.txt_codigoEstacao.Text = codigoEstacao;
                    break;
            }
        }

        public frm_cadEstacao(Int32 id)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();

            this.img_imagem.Image = Image.FromFile(Application.StartupPath + @"\Imagens\Estações\sem_imagem.jpg");

            this.PopularComboboxTipoEstacao();
            this.cmb_tipoEstacao.SelectedIndex = -1;
            //this.PopularComboboxBase();
            //this.cmb_base.SelectedIndex = -1;
            //this.PopularComboboxTipoAlimentacao();
            //this.PopularComboboxTipoCabo();
            //this.PopularComboboxTipoConexao();
            //this.PopularComboboxTipoFixacao();
            //this.PopularComboboxTipoInfra();

            this.btn_salvar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = false;
            this.btn_editar.Visible = false;

            this.btn_salvar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert01);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert02);
        }

        //Criar Estação
        public frm_cadEstacao(string tipo)
        {
            InitializeComponent();
        }

        /*
        //Editar Estação
        public frm_cadEstacao(string codigo)
        {
            InitializeComponent();

            dto.Codigo = codigo;

            List<EstacaoDTO> est = bll.SelecionarEstacao(dto);

            this.txt_id.Text = est[0].Id.ToString();
            this.txt_codigoEstacao.Text = est[0].Codigo;
            this.PopularComboboxTipoEstacao();
            this.cmb_tipoEstacao.Text = est[0].TipoEstacao;
            this.PopularComboboxBase();
            this.cmb_base.Text = est[0].Base;
            this.cmb_local.Text = est[0].Local;
            this.cmb_setor.Text = est[0].Setor;
            this.txt_descricao.Text = est[0].Descricao;
            this.txt_observacao.Text = est[0].Observacao;
            this.txt_altura.Text = est[0].Altura.ToString();
            this.PopularComboboxTipoConexao();
            this.cmb_tipoConexao.Text = est[0].TipoConexao;
            this.PopularComboboxTipoAlimentacao();
            this.cmb_tipoAlimentacao.Text = est[0].TipoAlimentacao;
            this.PopularComboboxTipoCabo();
            this.cmb_tipoCabo.Text = est[0].TipoCabo;
            this.PopularComboboxTipoInfra();
            this.cmb_tipoInfra.Text = est[0].TipoInfra;
            this.PopularComboboxTipoFixacao();
            this.cmb_tipoFixacao.Text = est[0].TipoFixacao;
            this.txt_qtdCabo.Text = est[0].QtdCabo.ToString();
            this.txt_statusEstacao.Text = est[0].Status;
            this.txt_codigoEquipamento.Text = est[0].Equipamento;
            this.img_imagem.Image = Image.FromFile(Application.StartupPath + est[0].Imagem);
            this.img_qrCode.Image = Image.FromFile(Application.StartupPath + est[0].QrCode);

            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = false;
            this.btn_editar.Visible = true;

            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert01);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert02);

            this.cmb_tipoEstacao.Enabled = false;
            this.txt_qtdEstacao.Visible = false;
            this.lbl_qtdEstacao.Visible = false;
            this.cmb_base.Enabled = false;
            this.cmb_local.Enabled = false;
            this.cmb_setor.Enabled = false;
            this.txt_descricao.Enabled = false;
            this.txt_observacao.Enabled = false;
            this.txt_altura.Enabled = false;
            this.cmb_tipoConexao.Enabled = false;
            this.cmb_tipoAlimentacao.Enabled = false;
            this.cmb_tipoCabo.Enabled = false;
            this.cmb_tipoInfra.Enabled = false;
            this.cmb_tipoFixacao.Enabled = false;
            this.txt_qtdCabo.Enabled = false;
            this.txt_statusEstacao.Enabled = false;
            this.txt_codigoEquipamento.Enabled = false;

            if(est[0].Imagem == @"\Imagens\Estações\sem_imagem.jpg")
            {
                this.btn_novoImagem.Visible = true;
                this.btn_salvarImagem.Visible = false;
                this.btn_cancelarImagem.Visible = false;
                this.btn_deletarImagem.Visible = false;

                this.btn_novoImagem.Enabled = true;

                this.btn_novoImagem.Location = new Point(34, 332);
            }
            else
            {
                this.btn_novoImagem.Visible = true;
                this.btn_salvarImagem.Visible = false;
                this.btn_cancelarImagem.Visible = false;
                this.btn_deletarImagem.Visible = true;

                this.btn_novoImagem.Enabled = true;
                this.btn_deletarImagem.Enabled = true;

                this.btn_novoImagem.Location = new Point(34, 332);
                this.btn_deletarImagem.Location = new Point(139, 332);
            }
        }
        */

        private void frm_cadEstacao_Load(object sender, EventArgs e)
        {
            this.ConfiguracaoForm();
        }

        private void cmb_base_SelectedValueChanged(object sender, EventArgs e)
        {
            string baseCli = this.cmb_base.Text;

            if (baseCli == "SegurancaPatrimonial.DTO.ClienteBaseDTO" || baseCli == "")
            {
                this.cmb_local.Items.Clear();
                this.cmb_local.Enabled = false;
                return;
            }
            else
            {                
                this.PopularComboboxLocal(baseCli);
                this.cmb_local.Enabled = true;
            }
        }

        private void cmb_local_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_local.Text == "SegurancaPatrimonial.DTO.ClienteBaseLocalDTO" || this.cmb_local.Text == "")
            {
                this.cmb_setor.Items.Clear();
                this.cmb_setor.Enabled = false;
                return;
            }
            else
            {
                string localCli = this.cmb_local.Text;
                this.PopularComboboxSetor(localCli);
                this.cmb_setor.Enabled = true;
            }
        }

        private void cmb_setor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_setor.Text == "SegurancaPatrimonial.DTO.ClienteBaseLocalSetorDTO")
            {
                return;
            }
            else
            {
                string setorCli = this.cmb_setor.Text;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string qtdEstacoes = this.txt_qtdEstacao.Text;

            if(qtdEstacoes == "")
            {
                this.SalvarEstacao();
            }
            else if(Int32.Parse(qtdEstacoes) > 1)
            {
                for(Int32 x = 1; x <= Int32.Parse(qtdEstacoes); x++)
                {
                    this.SalvarVariasEstacao();
                }

                MessageBox.Show( qtdEstacoes + " Estações salvas com sucesso!", "Salvar Estações!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                t1 = new Thread(abrirFormEstacao);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void txt_codigoEquipamento_TextChanged(object sender, EventArgs e)
        {
            string codigo = this.txt_codigoEquipamento.Text;

            if(codigo == "-")
            {
                return;
            }
            else
            {
                eqpDto.Codigo = codigo;

                List<EquipamentoDTO> eqp = eqpBll.SelecionarEquipamento(eqpDto);

                this.txt_TipoEquipamento.Text = eqp[0].TipoEquipamento;
                this.txt_fabricanteEquipamento.Text = eqp[0].Fabricante;
                this.txt_modeloEquipamento.Text = eqp[0].Modelo;
                this.txt_ipEquipamento.Text = eqp[0].EnderecoIp;
                this.txt_mascaraEquipamento.Text = eqp[0].Mascara;
                this.txt_macEquipamento.Text = eqp[0].Mac;
                this.txt_statusEquipamento.Text = eqp[0].Status;
                this.img_imagemEquipamento.Image = Image.FromFile(Application.StartupPath + eqp[0].Imagem);
            }            
        }

        private void btn_novoImagem_Click(object sender, EventArgs e)
        {
            this.ProcurarImagem();
        }

        private void btn_salvarImagem_Click(object sender, EventArgs e)
        {
            this.SalvarImagemEstacao();
        }

        private void btn_cancelarImagem_Click(object sender, EventArgs e)
        {
            this.CancelarImagemEstacao();
        }

        private void btn_deletarImagem_Click(object sender, EventArgs e)
        {
            this.DeletarImagemEstacao();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarEstacao();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarEstacao();
        }

        private void cmb_tipoEstacao_SelectedValueChanged(object sender, EventArgs e)
        {
            tipoEstacao = this.cmb_tipoEstacao.Text;

            if (tipoEstacao == "SegurancaPatrimonial.DTO.EstacaoTipoDTO")
            {
                return;
            }
            else
            {
                this.CriarNovaEstacaoTipo(tipoEstacao);
            }
        }
    }
}
