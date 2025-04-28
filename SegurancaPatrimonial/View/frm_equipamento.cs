using SegurancaPatrimonial.BLL;
using SegurancaPatrimonial.DTO;
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
using System.Net.NetworkInformation;

namespace SegurancaPatrimonial.View
{
    public partial class frm_equipamento : Form
    {
        EquipamentoDTO dto = new EquipamentoDTO();
        EquipamentoBLL bll = new EquipamentoBLL();

        EquipamentoTipoDTO tipDto = new EquipamentoTipoDTO();
        EquipamentoTipoBLL tipBll = new EquipamentoTipoBLL();

        EquipamentoFabricanteDTO fabDto = new EquipamentoFabricanteDTO();
        EquipamentoFabricanteBLL fabBll = new EquipamentoFabricanteBLL();

        EquipamentoModeloDTO modDto = new EquipamentoModeloDTO();
        EquipamentoModeloBLL modBll = new EquipamentoModeloBLL();

        EquipamentoStatusDTO staDto = new EquipamentoStatusDTO();
        EquipamentoStatusBLL staBll = new EquipamentoStatusBLL();

        EstacaoDTO estDto = new EstacaoDTO();
        EstacaoBLL estBll = new EstacaoBLL();

        EstacaoTipoDTO tesDto = new EstacaoTipoDTO();
        EstacaoTipoBLL tesBll = new EstacaoTipoBLL();

        ClienteBaseDTO basDto = new ClienteBaseDTO();
        ClienteBaseBLL basBll = new ClienteBaseBLL();

        ClienteBaseLocalDTO locDto = new ClienteBaseLocalDTO();
        ClienteBaseLocalBLL locBll = new ClienteBaseLocalBLL();

        ClienteBaseLocalSetorDTO setDto = new ClienteBaseLocalSetorDTO();
        ClienteBaseLocalSetorBLL setBll = new ClienteBaseLocalSetorBLL();

        RedeDTO redDto = new RedeDTO();
        RedeBLL redBll = new RedeBLL();

        MedidasGeraisDTO medFormDTO = new MedidasGeraisDTO();

        public static frm_equipamento equipamentoInstancia;

        Thread t1;

        Int32 qtdEquip = 0;
        Int32 ipAtual = 1;
        Int32 qtdIpCon = 0;
        Int32 qtdIpDes = 0;
        string codigo;

        Int32 id;
        string codigoEquipamento;
        string tipo;
        string fabricante;
        string modelo;

        private void abrirFormPrincipal(object obj)
        {
            Application.Run(new frm_principal());
        }

        private void abrirFormAddEquipamentoNovo(object obj)
        {
            Application.Run(new frm_cadEquipamento(id, codigoEquipamento));
        }

        private void abrirFormAddEquipamentoEditar(object obj)
        {
            Application.Run(new frm_cadEquipamento(codigoEquipamento));
        }

        private void abrirFormInstalarEquipamento(object obj)
        {
            Application.Run(new frm_instalarEquipamento(codigo));
        }

        public void EstadoInicial()
        {
            this.btn_novo.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_cancelar.Visible = false;
            this.btn_excluir.Visible = false;
            this.btn_instalar.Visible = false;
            this.btn_imprimir.Visible = false;
            this.btn_pingIp.Visible = false;
            this.btn_sair.Visible = true;

            this.btn_novo.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert01);
            this.btn_sair.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert02);

            this.groupBox3.Enabled = true;
            this.lvw_listaEquipamento.Enabled = true;
            
            this.cmb_tipoEquipamentoPesq.Visible = true;
            this.cmb_fabricantePesq.Visible = false;
            this.cmb_modeloPesq.Visible = false;
        }

        public void CriarNovoEquipamento()
        {
            bll.CriarNovoEquipamento(dto);

            id = dto.Id;
            codigoEquipamento = "EQP-" + id.ToString("000#");

            this.Close();
            t1 = new Thread(abrirFormAddEquipamentoNovo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }       

        public void EditarEquipamento()
        {
            codigoEquipamento = this.lvw_listaEquipamento.SelectedItems[0].SubItems[2].Text;

            this.Close();
            t1 = new Thread(abrirFormAddEquipamentoEditar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        

        public void ExcluirEquipamento()
        {
            dto.Codigo = this.lvw_listaEquipamento.SelectedItems[0].SubItems[2].Text;

            DialogResult result = MessageBox.Show("Deseja realmente Deletar este Equipamento?", "Deletar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bll.ExcluirEquipamento(dto);

                MessageBox.Show("Equipamento deletado com sucesso!", "Deletar Equipamento!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.EstadoInicial();
            }            
        }        

        private void InstalarEquipamento()
        {
            codigo = this.lvw_listaEquipamento.SelectedItems[0].SubItems[2].Text;

            this.Close();
            t1 = new Thread(abrirFormInstalarEquipamento);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void SelecionarEquipamento()
        {
            dto.Codigo = this.lvw_listaEquipamento.SelectedItems[0].SubItems[2].Text;

            List<EquipamentoDTO> eqp = bll.SelecionarEquipamento(dto);
            
            this.btn_novo.Visible = false;
            this.btn_editar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_excluir.Visible = true;

            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert01);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert02);
            this.btn_excluir.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert03);

            if (eqp[0].Status == "Disponível")
            {
                this.btn_instalar.Visible = true;
                this.btn_instalar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert04);
                this.btn_pingIp.Visible = false;
                
            }
            else
            {
                this.btn_instalar.Visible = false;
                this.btn_pingIp.Visible = true;
                this.btn_pingIp.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert04);
            }           
            
            this.btn_imprimir.Visible = false;
            this.btn_sair.Visible = false;
            
        }

        private void SelecionarEstacao(string codigo)
        {
            estDto.Codigo = codigo;

            List<EstacaoDTO> est = estBll.SelecionarEstacao(estDto);

            //this.txt_base.Text = est[0].Base;
            //this.txt_local.Text = est[0].Local;
            //this.txt_setor.Text = est[0].Setor;
            //this.txt_descricaoEstacao.Text = est[0].Descricao;
        }

        

        public void ListaEquipamentos()
        {
            string[] item = new string[11];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaEquipamento = bll.ListarEquipamento();

            this.lvw_listaEquipamento.Items.Clear();

            foreach (EquipamentoDTO eqp in listaEquipamento)
            {
                item[0] = eqp.Id.ToString();
                item[1] = prox.ToString();
                item[2] = eqp.Codigo;
                item[3] = eqp.TipoEquipamento;
                item[4] = eqp.Fabricante;
                item[5] = eqp.Modelo;
                item[6] = eqp.Mac;
                item[7] = eqp.EnderecoIp;
                item[8] = eqp.Estacao;
                item[8] = eqp.Estacao;
                item[9] = eqp.Status;

                lvw_listaEquipamento.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }

            this.lbl_resultadoPesquisa.Text = qtd.ToString() + " equipamentos cadastrados!";
        }

        public void ListaEquipamentosTipo(string tipo)
        {
            dto.TipoEquipamento = tipo;
            string[] item = new string[11];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaEquipamento = bll.ListarEquipamentoTipo(dto);

            this.lvw_listaEquipamento.Items.Clear();

            foreach (EquipamentoDTO eqp in listaEquipamento)
            {
                item[0] = eqp.Id.ToString();
                item[1] = prox.ToString();
                item[2] = eqp.Codigo;
                item[3] = eqp.TipoEquipamento;
                item[4] = eqp.Fabricante;
                item[5] = eqp.Modelo;
                item[6] = eqp.Mac;
                item[7] = eqp.EnderecoIp;
                item[8] = eqp.Estacao;
                item[8] = eqp.Estacao;
                item[9] = eqp.Status;

                lvw_listaEquipamento.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }

            this.lbl_resultadoPesquisa.Text = qtd.ToString() + " equipamentos do tipo: " + tipo + ", cadastrados!";
        }

        public void ListaEquipamentosFabrica(string tipo, string fabricante)
        {
            dto.TipoEquipamento = tipo;
            dto.Fabricante = fabricante;

            string[] item = new string[11];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaEquipamento = bll.ListarEquipamentoTipoFabricante(dto);

            this.lvw_listaEquipamento.Items.Clear();

            foreach (EquipamentoDTO eqp in listaEquipamento)
            {
                item[0] = eqp.Id.ToString();
                item[1] = prox.ToString();
                item[2] = eqp.Codigo;
                item[3] = eqp.TipoEquipamento;
                item[4] = eqp.Fabricante;
                item[5] = eqp.Modelo;
                item[6] = eqp.Mac;
                item[7] = eqp.EnderecoIp;
                item[8] = eqp.Estacao;
                item[8] = eqp.Estacao;
                item[9] = eqp.Status;

                lvw_listaEquipamento.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }

            this.lbl_resultadoPesquisa.Text = qtd.ToString() + " equipamentos do tipo: " + tipo + " e do fabricante: " + fabricante + " cadastrados!";
        }

        public void ListaEquipamentosModelo(string tipo, string fabricante, string modelo)
        {
            dto.TipoEquipamento = tipo;
            dto.Fabricante = fabricante;
            dto.Modelo = modelo;

            string[] item = new string[11];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaEquipamento = bll.ListarEquipamentoTipoFabricanteModelo(dto);

            this.lvw_listaEquipamento.Items.Clear();

            foreach (EquipamentoDTO eqp in listaEquipamento)
            {
                item[0] = eqp.Id.ToString();
                item[1] = prox.ToString();
                item[2] = eqp.Codigo;
                item[3] = eqp.TipoEquipamento;
                item[4] = eqp.Fabricante;
                item[5] = eqp.Modelo;
                item[6] = eqp.Mac;
                item[7] = eqp.EnderecoIp;
                item[8] = eqp.Estacao;
                item[9] = eqp.Status;

                lvw_listaEquipamento.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }

            this.lbl_resultadoPesquisa.Text = qtd.ToString() + " equipamentos do tipo: " + tipo + " do fabricante: " + fabricante + " e do modelo: " + modelo + " cadastrados!";
        }

        

        

        

        public void PopularComboboxTipoEquipamentoPesquisa()
        {
            List<EquipamentoTipoDTO> tipo = tipBll.PopularComboboxTipoEquipamento();

            this.cmb_tipoEquipamentoPesq.DataSource = tipo;
            this.cmb_tipoEquipamentoPesq.DisplayMember = "tipo";
            this.cmb_tipoEquipamentoPesq.SelectedIndex = -1;
        }

        public void PopularComboboxFabricantePesquisa()
        {
            List<EquipamentoFabricanteDTO> fabricante = fabBll.PopularComboboxFabricante();

            this.cmb_fabricantePesq.DataSource = fabricante;
            this.cmb_fabricantePesq.DisplayMember = "nome";
            this.cmb_fabricantePesq.SelectedIndex = -1;
        }

        public void PopularComboboxModeloPesquisa(string tipo, string fabricante)
        {
            modDto.TipoEquipamento = tipo;
            modDto.Fabricante = fabricante;

            List<EquipamentoModeloDTO> modelo = modBll.PopularComboboxModeloEquipamento(modDto);

            this.cmb_modeloPesq.DataSource = modelo;
            this.cmb_modeloPesq.DisplayMember = "modelo";
            this.cmb_modeloPesq.SelectedIndex = -1;
        }

        private void Ping(string codigo)
        {
            dto.Codigo = codigo;

            List<EquipamentoDTO> eqp = bll.SelecionarEquipamento(dto);

            string ip = eqp[0].EnderecoIp;
            string equipamento = eqp[0].Modelo;

            Ping ping = new Ping();
            PingReply reply = ping.Send(ip, 1000);

            string statusIp = reply.Status.ToString();

            if(statusIp == "Success")
            {
                MessageBox.Show("Equipamento: " + equipamento + "\n" +
                "Endereço de IP: " + ip + "\n" +
                "Status: " + statusIp, "Ping!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Equipamento: " + equipamento + "\n" +
                "Endereço de IP: " + ip + "\n" +
                "Status: " + statusIp, "Ping!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                       
        }

        private void PopularComboboxTipoEstacao()
        {
            List<EstacaoTipoDTO> tipo = tesBll.PopularComboboxTipoEstacao();

            //this.cmb_tipoEstacao.DataSource = tipo;
            //this.cmb_tipoEstacao.DisplayMember = "tipo";
            //this.cmb_tipoEstacao.Text = "";
        }

        //private void PopularComboboxBase()
        //{
        //    List<ClienteBaseDTO> baseCli = basBll.PopularComboboxBaseCliente();

        //    this.cmb_base.Enabled = true;
        //    this.cmb_base.DataSource = baseCli;
        //    this.cmb_base.DisplayMember = "base";
        //    this.cmb_base.Text = "";
        //}

        //private void PopularComboboxLocal(string baseCli)
        //{
        //    locDto.Base = baseCli;

        //    List<ClienteBaseLocalDTO> localCli = locBll.PopularComboboxBaseLocal(locDto);

        //    this.cmb_local.Enabled = true;
        //    this.cmb_local.DataSource = localCli;
        //    this.cmb_local.DisplayMember = "local";
        //    this.cmb_local.Text = "";
        //}

        //private void PopularComboboxSetor(string localCli)
        //{
        //    setDto.Local = localCli;

        //    List<ClienteBaseLocalSetorDTO> setorCli = setBll.PopularComboboxLocalSetor(setDto);

        //    this.cmb_setor.Enabled = true;
        //    this.cmb_setor.DataSource = setorCli;
        //    this.cmb_setor.DisplayMember = "setor";
        //    this.cmb_setor.Text = "";
        //}

        //private void PopularComboboxNumero(string SetorCli)
        //{
        //    estDto.Setor = this.cmb_setor.Text;
        //    Int32 qtd = estBll.ContarQtdEstacaoSetor(estDto);
        //    this.cmb_numero.Items.Clear();

        //    for (int x = 1; x <= qtd; x++)
        //    {
        //        this.cmb_numero.Items.Add(x.ToString());
        //    }

        //    this.cmb_numero.Enabled = true;
        //}

        private void CapturarCodigoEstacao(string nomeBase, string nomeLocal, string nomeSetor, Int32 numero)
        {
            basDto.Base = nomeBase;
            List<ClienteBaseDTO> bas = basBll.SelecionarBaseCliente(basDto);

            string iataBase = bas[0].Iata;

            locDto.Local = nomeLocal;
            List<ClienteBaseLocalDTO> loc = locBll.SelecionarBaseLocal(locDto);

            string iataLocal = loc[0].Iata;

            setDto.Setor = nomeSetor;
            List<ClienteBaseLocalSetorDTO> set = setBll.SelecionarLocalSetor(setDto);

            string iataSetor = set[0].Iata;

            string numeroEstacao = numero.ToString("00#");

            string codigoEstacao = iataBase + "-" + iataLocal + "-" + iataSetor + "-" + numeroEstacao;

            estDto.Codigo = codigoEstacao;
            List<EstacaoDTO> est = estBll.SelecionarEstacao(estDto);
            string statusEstacao = est[0].Status;

            if (statusEstacao == "Disponível")
            {
                //this.txt_codigoEstacao.Text = codigoEstacao;
                //this.btn_instalar.Enabled = true;
                //this.btn_canecelar.Enabled = true;
                //this.lbl_statusEstacao.Text = "Estação " + statusEstacao;
            }
            else
            {                
                MessageBox.Show("Estação não disponível", "Estação!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void SalvarEquipamento(string estacao, string equipamento)
        {
            estDto.Codigo = estacao;
            estDto.Equipamento = equipamento;

            estBll.InstalarEquipamentoEstacao(estDto);

            dto.Codigo = equipamento;
            dto.Estacao = estacao;

            bll.InstalarEquipamentoEstacao(dto);

            MessageBox.Show("Equipamento " + equipamento + " instalado na Estação " + estacao + " com sucesso!", "Instalar Equipamento!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();
            this.ListaEquipamentos();
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
                this.Close();
                t1 = new Thread(abrirFormPrincipal);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

   

        public frm_equipamento()
        {
            InitializeComponent();

            equipamentoInstancia = this;
        }

        private void frm_equipamento_Load(object sender, EventArgs e)
        {
            this.Text = "SEGPAT System V. 1.0  -  Equipamentos";

            this.lbl_titulo.Text = "Equipamentos";
            this.lbl_titulo.Location = new Point(240, 20);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;

            this.lbl_subTitulo.Text = "Equipamentos > Lista";
            this.lbl_subTitulo.Location = new Point(20, 5);
            this.lbl_subTitulo.ForeColor = System.Drawing.Color.Black;

            this.lvw_listaEquipamento.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Código", 80).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Tipo", 95).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("Fabricante", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("Modelo", 180).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("MAC", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("End. IP", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("Estação", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("Status", 84).TextAlign = HorizontalAlignment.Left;

            this.EstadoInicial();
            this.ListaEquipamentos();           
            
            //this.PopularComboboxTipoEquipamentoPesquisa();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovoEquipamento();
            //this.Close();
            //t1 = new Thread(abrirFormAddEquipamento);
            //t1.SetApartmentState(ApartmentState.STA);
            //t1.Start();
        }        

        //private void cmb_tipoEquipamento_SelectedValueChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void cmb_fabricante_SelectedValueChanged(object sender, EventArgs e)
        //{
            
        //}

        //private void cmb_modelo_SelectedValueChanged(object sender, EventArgs e)
        //{
            
        //}

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }

        private void cmb_tipoEquipamentoPesq_SelectedValueChanged(object sender, EventArgs e)
        {
            tipo = this.cmb_tipoEquipamentoPesq.Text;

            if (tipo == "SegurancaPatrimonial.DTO.EquipamentoTipoDTO" || tipo == "")
            {
                return;
            }
            else
            {
                this.PopularComboboxFabricantePesquisa();
                this.lbl_fabricantePesq.Visible = true;
                this.cmb_fabricantePesq.Enabled = true;
                //this.ListaEquipamentosTipo(tipo);
            }
        }

        private void cmb_fabricantePesq_SelectedValueChanged(object sender, EventArgs e)
        {
            //tipo = this.cmb_tipoEquipamentoPesq.Text;
            //fabricante = this.cmb_fabricantePesq.Text;

            //if (fabricante == "SegurancaPatrimonial.DTO.EquipamentoFabricanteDTO" || fabricante == "")
            //{
            //    return;
            //}
            //else
            //{
            //    this.lbl_modeloPesq.Visible = true;
            //    this.cmb_modeloPesq.Visible = true;
            //    this.PopularComboboxModeloPesquisa(tipo, fabricante);
            //    this.ListaEquipamentosFabrica(tipo, fabricante);
            //}
        }

        private void cmb_modeloPesq_SelectedValueChanged(object sender, EventArgs e)
        {
            //modelo = this.cmb_modeloPesq.Text;

            //if (modelo == "SegurancaPatrimonial.DTO.EquipamentoModeloDTO" || modelo == "")
            //{
            //    return;
            //}
            //else
            //{
            //    string tipo = this.cmb_tipoEquipamentoPesq.Text;
            //    string fabricante = this.cmb_fabricantePesq.Text;
            //    string modelo = this.cmb_modeloPesq.Text;
            //    this.lbl_modeloPesq.Visible = true;
            //    this.cmb_modeloPesq.Visible = true;
            //    this.PopularComboboxModeloPesquisa(tipo, fabricante);
            //    this.ListaEquipamentosModelo(tipo, fabricante, modelo);
            //}
        }

        private void lvw_listaEquipamento_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaEquipamento.SelectedItems.Count > 0)
            {                
                this.SelecionarEquipamento();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarEquipamento();
        }

        private void txt_codigoEstacao_TextChanged(object sender, EventArgs e)
        {
            //string codigoEstacao = this.txt_codigoEstacao.Text;

            //if(codigoEstacao == "-" || codigoEstacao == "")
            //{
            //    return;
            //}
            //else
            //{
            //    this.SelecionarEstacao(codigoEstacao);
            //}
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            //string ip = this.txt_endIp.Text;

            //Ping ping = new Ping();
            //PingReply reply = ping.Send(ip, 1000);
            //MessageBox.Show(reply.Status.ToString());

        }

        private void btn_pingIp_Click(object sender, EventArgs e)
        {
            string codigo = this.lvw_listaEquipamento.SelectedItems[0].SubItems[2].Text;

            this.Ping(codigo);
        }

        private void btn_instalar_Click(object sender, EventArgs e)
        {
            //this.groupBox1.Enabled = true;
            //this.PopularComboboxBase();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //this.SalvarEquipamento();
        }

        private void cmb_base_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (this.cmb_base.Text == "SegurancaPatrimonial.DTO.ClienteBaseDTO")
            //{
            //    return;
            //}
            //else
            //{
            //    string baseCli = this.cmb_base.Text;
            //    this.cmb_local.Enabled = true;
            //    this.PopularComboboxLocal(baseCli);
            //}
        }

        private void cmb_local_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (this.cmb_local.Text == "SegurancaPatrimonial.DTO.ClienteBaseLocalDTO")
            //{
            //    return;
            //}
            //else
            //{
            //    string localCli = this.cmb_local.Text;
            //    this.cmb_setor.Enabled = true;
            //    this.PopularComboboxSetor(localCli);
            //}
        }

        private void cmb_setor_SelectedValueChanged(object sender, EventArgs e)
        {
            //if (this.cmb_setor.Text == "SegurancaPatrimonial.DTO.ClienteBaseLocalSetorDTO")
            //{
            //    return;
            //}
            //else
            //{
            //    string setorCli = this.cmb_setor.Text;
            //    this.cmb_numero.Items.Clear();
            //    PopularComboboxNumero(setorCli);
            //}
        }

        private void cmb_numero_SelectedValueChanged(object sender, EventArgs e)
        {
            //string codigoBase = this.cmb_base.Text;
            //string codigoLocal = this.cmb_local.Text;
            //string codigoSetor = this.cmb_setor.Text;
            //Int32 numero = Int32.Parse(this.cmb_numero.Text);

            //this.CapturarCodigoEstacao(codigoBase, codigoLocal, codigoSetor, numero);
        }

        private void txt_endMac_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_fabricantePesq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdb_todos_CheckedChanged(object sender, EventArgs e)
        {
            this.cmb_tipoEquipamentoPesq.SelectedIndex = -1;

            if (this.rdb_todos.Checked)
            {
                this.ListaEquipamentos();
                this.cmb_tipoEquipamentoPesq.Visible = false;
                
                this.cmb_fabricantePesq.Visible = false;
                this.cmb_fabricantePesq.SelectedIndex = -1;
                this.cmb_modeloPesq.Visible = false;
                this.cmb_modeloPesq.Items.Clear();
                this.txt_endIpPesq.Visible = false;
                this.txt_endIpPesq.Text = "";
                this.txt_endMacPesq.Visible = false;
                this.txt_endMacPesq.Text = "";
            }
        }

        private void rdb_tipo_CheckedChanged(object sender, EventArgs e)
        {
            this.cmb_fabricantePesq.SelectedIndex = -1;

            if (this.rdb_tipo.Checked)
            {
                this.cmb_tipoEquipamentoPesq.SelectedIndex = -1;
                this.cmb_tipoEquipamentoPesq.Visible = true;
                this.PopularComboboxTipoEquipamentoPesquisa();                
                this.cmb_fabricantePesq.Visible = false;                
                this.cmb_modeloPesq.Visible = false;
                this.cmb_modeloPesq.Items.Clear();
                this.txt_endIpPesq.Visible = false;
                this.txt_endIpPesq.Text = "";
                this.txt_endMacPesq.Visible = false;
                this.txt_endMacPesq.Text = "";
            }
        }

        private void rdb_fabricante_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdb_fabricante.Checked)
            {
                if (tipo == "SegurancaPatrimonial.DTO.EquipamentoTipoDTO" || tipo == "")
                {
                    this.cmb_tipoEquipamentoPesq.SelectedIndex = -1;
                    this.cmb_tipoEquipamentoPesq.Visible = true;
                    this.cmb_tipoEquipamentoPesq.Enabled = true;
                    this.PopularComboboxTipoEquipamentoPesquisa();
                    this.cmb_fabricantePesq.Visible = true;
                    this.cmb_fabricantePesq.Enabled = false;

                }
                else
                {
                    tipo = this.cmb_tipoEquipamentoPesq.Text;

                    this.cmb_tipoEquipamentoPesq.Visible = true;
                    this.PopularComboboxFabricantePesquisa();
                    this.cmb_modeloPesq.Visible = false;
                    this.cmb_modeloPesq.Items.Clear();
                    this.txt_endIpPesq.Visible = false;
                    this.txt_endIpPesq.Text = "";
                    this.txt_endMacPesq.Visible = false;
                    this.txt_endMacPesq.Text = "";
                }                
            }
        }
    }
}
