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
using QRCoder;

namespace SegurancaPatrimonial.View
{
    public partial class frm_estacao : Form
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
        Int32 id;
        string codigo;
        string pesquisa = "";
        string tipoEstacao = "";

        private void abrirFormPrincipal(object obj)
        {
            Application.Run(new frm_principal());
        }

        private void abrirFormCadEstacaoNovo(object obj)
        {
            Application.Run(new frm_cadEstacao(id));
        }

        private void abrirFormCadEstacaoEditar(object obj)
        {
            Application.Run(new frm_cadEstacao(codigo));
        }

        private void abrirFormQRCode(object obj)
        {
            Application.Run(new frm_qrCodeEstacao(codigo));
        }

        private void EstadoInicial()
        {
            this.btn_novo.Visible = true;
            this.btn_salvar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_cancelar.Visible = false;
            this.btn_excluir.Visible = false;
            this.btn_instalar.Visible = false;
            this.btn_qrCode.Visible = false;
            this.btn_sair.Visible = true;

            this.btn_novo.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert01);
            this.btn_sair.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert02);

            this.cmb_pesquisa.Visible = true;
            this.cmb_tipo.Visible = false;
            this.cmb_basePesq.Visible = false;
            this.cmb_localPesq.Visible = false;
            this.cmb_setorPesq.Visible = false;

            this.lbl_pesquisa.Visible = true;
            this.lbl_tipo.Visible = false;
            this.lbl_base.Visible = false;
            this.lbl_local.Visible = false;
            this.lbl_setor.Visible = false;

            this.btn_pesquisar.Visible = false;
            this.groupBox3.Enabled = true;
        }

        private void CriarNovaEstacao()
        {
            bll.CriarNovaEstacao(dto);

            id = dto.Id;

            t1 = new Thread(abrirFormCadEstacaoNovo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            this.Close();
        }

        private void EditarEstacao()
        {
            codigo = this.lvw_listaEstacao.SelectedItems[0].SubItems[2].Text;

            t1 = new Thread(abrirFormCadEstacaoEditar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
            this.Close();
        }        

        private void ExcluirEstacao()
        {
            dto.Codigo = this.lvw_listaEstacao.SelectedItems[0].SubItems[2].Text;

            DialogResult result = MessageBox.Show("Deseja realmente Deletar esta estação?", "Deletar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bll.ExcluirEstacao(dto);

                MessageBox.Show("Estação deletado com sucesso!", "Deletar Estação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.EstadoInicial();
                this.ListaEstacoes();
            }
        }

        private void SelecionarEstacao()
        {
            this.btn_novo.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_editar.Visible = true;
            this.btn_atualizar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_excluir.Visible = true;
            this.btn_instalar.Visible = true;
            this.btn_qrCode.Visible = true;
            this.btn_sair.Visible = false;

            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert01);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert02);
            this.btn_excluir.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert03);
            this.btn_instalar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert04);
            this.btn_qrCode.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert05);
        }        

        private void ListaEstacoes()
        {
            string[] item = new string[8];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaEstacao = bll.ListarEstacao();

            this.lvw_listaEstacao.Items.Clear();

            foreach (EstacaoDTO eqp in listaEstacao)
            {
                item[0] = eqp.Id.ToString();
                item[1] = prox.ToString();
                item[2] = eqp.Codigo;
                item[3] = eqp.TipoEstacao;
                item[4] = eqp.Base + "-" + eqp.Local + "-" + eqp.Setor;
                item[5] = eqp.Descricao;
                item[6] = eqp.Equipamento;
                item[7] = eqp.Status;

                lvw_listaEstacao.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }

            this.lbl_desempenhoPesquisa.Text = "Qtd de Estações: " + qtd.ToString();
        }

        private void ListaEstacoesTipo(string tipo)
        {
            dto.TipoEstacao = tipo;
            string[] item = new string[11];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaEstacao = bll.ListarEstacaoTipo(dto);

            this.lvw_listaEstacao.Items.Clear();

            foreach (EstacaoDTO eqp in listaEstacao)
            {
                item[0] = eqp.Id.ToString();
                item[1] = prox.ToString();
                item[2] = eqp.Codigo;
                item[3] = eqp.TipoEstacao;
                item[4] = eqp.Base + "-" + eqp.Local + "-" + eqp.Setor;
                item[5] = eqp.Descricao;
                item[6] = eqp.Equipamento;
                item[7] = eqp.Status;

                lvw_listaEstacao.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }

            this.lbl_desempenhoPesquisa.Text = "Qtd de Estações do Tipo " + tipo + ": " + qtd.ToString();
        }

        private void ListaEstacoesBase(string tipo, string baseEst)
        {
            dto.Base = baseEst;
            dto.TipoEstacao = tipo;

            string[] item = new string[8];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaEstacao = bll.ListarEstacaoBase(dto);

            this.lvw_listaEstacao.Items.Clear();

            foreach (EstacaoDTO est in listaEstacao)
            {
                item[0] = est.Id.ToString();
                item[1] = prox.ToString();
                item[2] = est.Codigo;
                item[3] = est.TipoEstacao;
                item[4] = est.Base + " - " + est.Local + " - " + est.Setor;
                item[5] = est.Descricao;
                item[6] = est.Equipamento;
                item[7] = est.Status;

                lvw_listaEstacao.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }

            this.lbl_desempenhoPesquisa.Text = "Qtd de Estações do Tipo " + tipo + ", Base " + baseEst + ": " + qtd.ToString();
        }

        private void ListaEstacoesBaseLocal(string tipo, string baseEst, string localEst)
        {
            dto.Base = baseEst;
            dto.Local = localEst;
            dto.TipoEstacao = tipo;

            string[] item = new string[8];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaEstacao = bll.ListarEstacaoLocal(dto);

            this.lvw_listaEstacao.Items.Clear();

            foreach (EstacaoDTO est in listaEstacao)
            {
                item[0] = est.Id.ToString();
                item[1] = prox.ToString();
                item[2] = est.Codigo;
                item[3] = est.TipoEstacao;
                item[4] = est.Base + " - " + est.Local + " - " + est.Setor;
                item[5] = est.Descricao;
                item[6] = est.Equipamento;
                item[7] = est.Status;

                lvw_listaEstacao.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }

            this.lbl_desempenhoPesquisa.Text = "Qtd de Estações do Tipo " + tipo + ", Base " + baseEst + ", Local " + localEst + ": " + qtd.ToString();
        }

        private void ListaEstacoesBaseLocalSetor(string tipo, string baseEst, string localEst, string setorEst)
        {
            dto.Base = baseEst;
            dto.Local = localEst;
            dto.Setor = setorEst;
            dto.TipoEstacao = tipo;

            string[] item = new string[8];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaEstacao = bll.ListarEstacaoSetor(dto);

            this.lvw_listaEstacao.Items.Clear();

            foreach (EstacaoDTO est in listaEstacao)
            {
                item[0] = est.Id.ToString();
                item[1] = prox.ToString();
                item[2] = est.Codigo;
                item[3] = est.TipoEstacao;
                item[4] = est.Base + " - " + est.Local + " - " + est.Setor;
                item[5] = est.Descricao;
                item[6] = est.Equipamento;
                item[7] = est.Status;

                lvw_listaEstacao.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }

            this.lbl_desempenhoPesquisa.Text = "Qtd de Estações do Tipo " + tipo + ", Base " + baseEst + ", Local " + localEst + ", Setor " + ": " + qtd.ToString();
        }        

        private void PopularComboboxTipo()
        {
            List<EstacaoTipoDTO> tipo = tipBll.PopularComboboxTipoEstacao();

            this.cmb_tipo.DataSource = tipo;
            this.cmb_tipo.DisplayMember = "tipo";
            this.cmb_tipo.Text = "";
        }

        private void PopularComboboxBase()
        {
            List<ClienteBaseDTO> baseCli = basBll.PopularComboboxBaseCliente();

            this.cmb_basePesq.DataSource = baseCli;
            this.cmb_basePesq.DisplayMember = "base";
            this.cmb_basePesq.Text = "";             
        }

        private void PopularComboboxLocal()
        {
            locDto.Base = this.cmb_basePesq.Text;

            List<ClienteBaseLocalDTO> localCli = locBll.PopularComboboxBaseLocal(locDto);

            this.cmb_localPesq.DataSource = localCli;
            this.cmb_localPesq.DisplayMember = "local";
            this.cmb_localPesq.Text = "";    
        }

        private void PopularComboboxSetor()
        {
            setDto.Local = this.cmb_localPesq.Text;

            List<ClienteBaseLocalSetorDTO> setorCli = setBll.PopularComboboxLocalSetor(setDto);

            this.cmb_setorPesq.DataSource = setorCli;
            this.cmb_setorPesq.DisplayMember = "setor";
            this.cmb_setorPesq.Text = "";                   
        }
                
        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.EstadoInicial();
            }
        }

        private void SairFormulario()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Sair deste formulário?", "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {                
                t1 = new Thread(abrirFormPrincipal);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
                this.Close();
            }
        }
                
        public frm_estacao()
        {
            InitializeComponent();
        }

        private void frm_estacao_Load(object sender, EventArgs e)
        {
            this.lvw_listaEstacao.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEstacao.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEstacao.Columns.Add("Código", 120).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEstacao.Columns.Add("Tipo", 95).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEstacao.Columns.Add("Estação", 330).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEstacao.Columns.Add("Descrição", 250).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEstacao.Columns.Add("Equipamento", 120).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEstacao.Columns.Add("Status", 120).TextAlign = HorizontalAlignment.Left;

            this.ListaEstacoes();
            this.EstadoInicial();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovaEstacao();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void cmb_base_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_local_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_basePesq.Text == "SegurancaPatrimonial.DTO.ClienteBaseLocalDTO")
            {
                return;
            }
            else
            {
                this.PopularComboboxSetor();
            }
        }

        private void cmb_tipoEstacao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_tipo.Text == "SegurancaPatrimonial.DTO.EstacaoTipoDTO")
            {
                this.btn_pesquisar.Enabled = false;
                return;
            }
            else
            {
                this.btn_pesquisar.Enabled = true;
            }
        }

        private void cmb_setor_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void lvw_listaEstacao_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaEstacao.SelectedItems.Count > 0)
            {
                this.groupBox3.Enabled = false;
                this.SelecionarEstacao();
            }
        }

        private void btn_criarCodigo_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarEstacao();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            this.ExcluirEstacao();
        }

        private void txt_codigoEquipamento_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_pesquisa_SelectedValueChanged(object sender, EventArgs e)
        {
            string tipo = this.cmb_tipo.Text;
            string baseCli = this.cmb_basePesq.Text;
            string localCli = this.cmb_localPesq.Text;
            string setorCli = this.cmb_setorPesq.Text;

            if (this.cmb_pesquisa.Text == "")
            {
                return;
            }
            else
            {
                pesquisa = this.cmb_pesquisa.Text;

                switch (pesquisa)
                {
                    case "Tipo":
                        this.cmb_pesquisa.Visible = true;
                        this.cmb_tipo.Visible = true;
                        this.cmb_basePesq.Visible = false;
                        this.cmb_localPesq.Visible = false;
                        this.cmb_setorPesq.Visible = false;
                        this.lbl_tipo.Visible = true;
                        this.lbl_base.Visible = false;
                        this.lbl_local.Visible = false;
                        this.lbl_setor.Visible = false;
                        this.btn_pesquisar.Visible = true;
                        this.btn_pesquisar.Location = new Point(215, 65);
                        this.PopularComboboxTipo();
                        //this.cmb_basePesq.Items.Clear();
                        //this.cmb_localPesq.Items.Clear();
                        //this.cmb_setorPesq.Items.Clear();
                        break;
                    case "Base":
                        this.cmb_pesquisa.Visible = true;
                        this.cmb_tipo.Visible = true;
                        this.cmb_basePesq.Visible = true;
                        this.cmb_localPesq.Visible = false;
                        this.cmb_setorPesq.Visible = false;
                        this.lbl_tipo.Visible = true;
                        this.lbl_base.Visible = true;
                        this.lbl_local.Visible = false;
                        this.lbl_setor.Visible = false;
                        this.btn_pesquisar.Visible = true;
                        //this.btn_pesquisar.Location = new Point(577, 22);
                        this.PopularComboboxTipo();
                        this.PopularComboboxBase();
                        //this.cmb_localPesq.Items.Clear();
                        //this.cmb_setorPesq.Items.Clear();
                        break;
                    case "Local":
                        this.cmb_pesquisa.Visible = true;
                        this.cmb_tipo.Visible = true;
                        this.cmb_basePesq.Visible = true;
                        this.cmb_localPesq.Visible = true;
                        this.cmb_setorPesq.Visible = false;
                        this.lbl_tipo.Visible = true;
                        this.lbl_base.Visible = true;
                        this.lbl_local.Visible = true;
                        this.lbl_setor.Visible = false;
                        this.btn_pesquisar.Visible = true;
                        //this.btn_pesquisar.Location = new Point(763, 22);
                        this.PopularComboboxTipo();
                        this.PopularComboboxBase();
                        //this.cmb_setorPesq.Items.Clear();
                        //this.ListaEstacoesBaseLocal(tipo, baseCli, localCli);
                        break;
                    case "Setor":
                        this.cmb_pesquisa.Visible = true;
                        this.cmb_tipo.Visible = true;
                        this.cmb_basePesq.Visible = true;
                        this.cmb_localPesq.Visible = true;
                        this.cmb_setorPesq.Visible = true;
                        this.lbl_tipo.Visible = true;
                        this.lbl_base.Visible = true;
                        this.lbl_local.Visible = true;
                        this.lbl_setor.Visible = true;
                        this.btn_pesquisar.Visible = true;
                        //this.btn_pesquisar.Location = new Point(949, 22);
                        this.PopularComboboxTipo();
                        this.PopularComboboxBase();
                        //this.cmb_localPesq.Items.Clear();
                        //this.cmb_setorPesq.Items.Clear();
                        break;
                    default:
                        this.cmb_pesquisa.Visible = true;
                        this.cmb_tipo.Visible = false;
                        this.cmb_basePesq.Visible = false;
                        this.cmb_localPesq.Visible = false;
                        this.cmb_setorPesq.Visible = false;
                        this.lbl_tipo.Visible = false;
                        this.lbl_base.Visible = false;
                        this.lbl_local.Visible = false;
                        this.lbl_setor.Visible = false;
                        this.btn_pesquisar.Visible = true;
                        //this.btn_pesquisar.Location = new Point(205, 22);
                        break;
                }
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string tipo = this.cmb_tipo.Text;
            string baseCli = this.cmb_basePesq.Text;
            string localCli = this.cmb_localPesq.Text;
            string setorCli = this.cmb_setorPesq.Text;

            if (this.cmb_pesquisa.Text == "")
            {
                return;
            }
            else
            {
                string pesq = this.cmb_pesquisa.Text;                

                switch (pesq)
                {
                    case "Tipo":
                        
                        if (this.cmb_tipo.Text == "")
                        {
                            MessageBox.Show("Selecione um Tipo de Estação!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_tipo.Focus();
                            return;
                        }
                        else
                        {
                            this.ListaEstacoesTipo(tipo);
                        }
                        break;
                    case "Base":
                        
                        if (this.cmb_tipo.Text == "")
                        {
                            MessageBox.Show("Selecione um Tipo de Estação!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_tipo.Focus();
                            return;
                        }
                        else if (this.cmb_basePesq.Text == "")
                        {
                            MessageBox.Show("Selecione uma Base", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_basePesq.Focus();
                            return;
                        }
                        else
                        {
                            this.ListaEstacoesBase(tipo, baseCli);
                        }
                        break;
                    case "Local":
                                               
                        if (this.cmb_tipo.Text == "")
                        {
                            MessageBox.Show("Selecione um Tipo de Estação!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_tipo.Focus();
                            return;
                        }
                        else if (this.cmb_localPesq.Text == "")
                        {
                            MessageBox.Show("Selecione um Local", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_localPesq.Focus();
                            return;
                        }
                        else if (this.cmb_basePesq.Text == "")
                        {
                            MessageBox.Show("Selecione uma Base", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_basePesq.Focus();
                            return;
                        }
                        else
                        {
                            this.ListaEstacoesBaseLocal(tipo, baseCli, localCli);
                        }
                        break;
                    case "Setor":

                        if (this.cmb_tipo.Text == "")
                        {
                            MessageBox.Show("Selecione um Tipo de Estação!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_tipo.Focus();
                            return;
                        }
                        else if (this.cmb_basePesq.Text == "")
                        {
                            MessageBox.Show("Selecione uma Base", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_basePesq.Focus();
                            return;
                        }
                        else if (this.cmb_localPesq.Text == "")
                        {
                            MessageBox.Show("Selecione um Local", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_localPesq.Focus();
                            return;
                        }
                        else if (this.cmb_setorPesq.Text == "")
                        {
                            MessageBox.Show("Selecione um Setor", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.cmb_setorPesq.Focus();
                            return;
                        }
                        else
                        {
                            this.ListaEstacoesBaseLocalSetor(tipo, baseCli, localCli, setorCli);
                        }
                        break;
                    default:
                        this.ListaEstacoes();
                        break;
                }
            }
        }

        private void cmb_basePesq_SelectedValueChanged(object sender, EventArgs e)
        {
            pesquisa = this.cmb_pesquisa.Text;
            string baseCli = this.cmb_basePesq.Text;            

            if(pesquisa == "Base")
            {
                if (baseCli == "SegurancaPatrimonial.DTO.ClienteBaseDTO")
                {
                    return;
                }                
            }
            else if(pesquisa == "Local" || pesquisa == "Setor")
            {
                this.PopularComboboxLocal();
            }
        }

        private void cmb_localPesq_SelectedValueChanged(object sender, EventArgs e)
        {
            pesquisa = this.cmb_pesquisa.Text;
            string baseCli = this.cmb_basePesq.Text;
            string localCli = this.cmb_localPesq.Text;

            if (pesquisa == "Local")
            {
                if (baseCli == "SegurancaPatrimonial.DTO.ClienteBaseDTO")
                {
                    return;
                }
                else if (localCli == "SegurancaPatrimonial.DTO.ClienteBaseLocalDTO")
                {
                    return;
                }
                else
                {
                    this.PopularComboboxSetor();
                }
            }
            else if (pesquisa == "Setor")
            {
                if (baseCli == "SegurancaPatrimonial.DTO.ClienteBaseDTO")
                {
                    return;
                }
                else if (localCli == "SegurancaPatrimonial.DTO.ClienteBaseLocalDTO")
                {
                    return;
                }
                else
                {
                    this.PopularComboboxSetor();
                }
            }
        }

        private void btn_instalar_Click(object sender, EventArgs e)
        {

        }

        private void btn_qrCode_Click(object sender, EventArgs e)
        {
            codigo = this.lvw_listaEstacao.SelectedItems[0].SubItems[2].Text;

            frm_qrCodeEstacao qrCode = new frm_qrCodeEstacao(codigo);
            qrCode.Visible = true;
        }

        private void lvw_listaEstacao_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            codigo = this.lvw_listaEstacao.SelectedItems[0].SubItems[2].Text;

            frm_imagem img = new frm_imagem(codigo);
            img.Visible = true;
        }
    }
}
