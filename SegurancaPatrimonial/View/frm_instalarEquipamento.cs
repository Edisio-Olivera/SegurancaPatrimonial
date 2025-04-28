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

namespace SegurancaPatrimonial.View
{
    public partial class frm_instalarEquipamento : Form
    {
        EstacaoDTO dto = new EstacaoDTO();
        EstacaoBLL bll = new EstacaoBLL();

        EstacaoTipoDTO tipDto = new EstacaoTipoDTO();
        EstacaoTipoBLL tipBll = new EstacaoTipoBLL();        

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


        private void EstadoInicial()
        {
            this.cmb_tipoEstacao.Enabled = true;
            this.cmb_base.Enabled = false;
            this.cmb_local.Enabled = false;
            this.cmb_setor.Enabled = false;
            this.cmb_numero.Enabled = false;
            this.cmb_numero.Items.Clear();
            this.btn_instalar.Enabled = false;
            this.btn_canecelar.Enabled = true;
            this.lbl_statusEstacao.Text = "...";
        }



        private void abrirFormInstalarEquipamento(object obj)
        {
            Application.Run(new frm_principal());
        }

        private void PopularComboboxTipoEstacao()
        {
            List<EstacaoTipoDTO> tipo = tipBll.PopularComboboxTipoEstacao();

            this.cmb_tipoEstacao.DataSource = tipo;
            this.cmb_tipoEstacao.DisplayMember = "tipo";
            this.cmb_tipoEstacao.Text = "";
        }

        private void PopularComboboxBase()
        {
            List<ClienteBaseDTO> baseCli = basBll.PopularComboboxBaseCliente();

            this.cmb_base.Enabled = true;
            this.cmb_base.DataSource = baseCli;
            this.cmb_base.DisplayMember = "base";
            this.cmb_base.Text = "";
        }

        private void PopularComboboxLocal(string baseCli)
        {
            locDto.Base = baseCli;

            List<ClienteBaseLocalDTO> localCli = locBll.PopularComboboxBaseLocal(locDto);

            this.cmb_local.Enabled = true;
            this.cmb_local.DataSource = localCli;
            this.cmb_local.DisplayMember = "local";
            this.cmb_local.Text = "";
        }

        private void PopularComboboxSetor(string localCli)
        {
            setDto.Local = localCli;

            List<ClienteBaseLocalSetorDTO> setorCli = setBll.PopularComboboxLocalSetor(setDto);

            this.cmb_setor.Enabled = true;
            this.cmb_setor.DataSource = setorCli;
            this.cmb_setor.DisplayMember = "setor";
            this.cmb_setor.Text = "";
        }

        private void PopularComboboxNumero(string SetorCli)
        {
            dto.Setor = this.cmb_setor.Text;
            Int32 qtd = bll.ContarQtdEstacaoSetor(dto);
            this.cmb_numero.Items.Clear();

            for (int x = 1; x <= qtd; x++)
            {
                this.cmb_numero.Items.Add(x.ToString());
            }

            this.cmb_numero.Enabled = true;
        }

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

            dto.Codigo = codigoEstacao;
            List<EstacaoDTO> est = bll.SelecionarEstacao(dto);
            string statusEstacao = est[0].Status;

            if(statusEstacao == "Disponível")
            {
                this.txt_codigoestacao.Text = codigoEstacao;
                this.btn_instalar.Enabled = true;
                this.btn_canecelar.Enabled = true;
                this.lbl_statusEstacao.Text = "Estação " + statusEstacao;
            }
            else
            {
                this.txt_codigoestacao.Text = codigoEstacao;
                this.btn_instalar.Enabled = false;
                this.btn_canecelar.Enabled = true;
                this.lbl_statusEstacao.Text = "Estação não disponível";
            }            
        }

        private void SalvarEquipamento(string estacao, string equipamento)
        {
            dto.Codigo = estacao;
            dto.Equipamento = equipamento;

            bll.InstalarEquipamentoEstacao(dto);

            eqpDto.Codigo = equipamento;
            eqpDto.Estacao = estacao;

            eqpBll.InstalarEquipamentoEstacao(eqpDto);

            MessageBox.Show("Equipamento " + equipamento + " instalado na Estação " + estacao + " com sucesso!", "Instalar Equipamento!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //frm_equipamento.equipamentoInstancia.ListaEquipamentos();

            this.Close();
        }

        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



        public frm_instalarEquipamento()
        {
            InitializeComponent();
        }

        public frm_instalarEquipamento(string codigo)
        {
            InitializeComponent();

            eqpDto.Codigo = codigo;

            List<EquipamentoDTO> eqp = eqpBll.SelecionarEquipamento(eqpDto);

            this.txt_codigoEquipamento.Text = codigo;
            this.img_imagemEquipamento.Image = Image.FromFile(Application.StartupPath + eqp[0].Imagem);
        }

        private void frm_instalarEquipamento_Load(object sender, EventArgs e)
        {
            this.EstadoInicial();
            this.PopularComboboxTipoEstacao();
        }

        private void cmb_tipoEstacao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_tipoEstacao.Text == "SegurancaPatrimonial.DTO.EstacaoTipoDTO")
            {
                return;
            }
            else
            {
                this.PopularComboboxBase();
                this.cmb_base.Enabled = true;
            }
        }

        private void cmb_base_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_base.Text == "SegurancaPatrimonial.DTO.ClienteBaseDTO")
            {
                this.cmb_local.Enabled = false;
                this.cmb_local.Items.Clear();
                return;
            }
            else
            {
                string baseCli = this.cmb_base.Text;
                this.cmb_local.Enabled = true;
                this.PopularComboboxLocal(baseCli);
            }
        }

        private void cmb_local_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_local.Text == "SegurancaPatrimonial.DTO.ClienteBaseLocalDTO")
            {
                this.cmb_setor.Enabled = false;
                this.cmb_setor.Items.Clear();
                return;
            }
            else
            {
                string localCli = this.cmb_local.Text;
                this.cmb_setor.Enabled = true;
                this.PopularComboboxSetor(localCli);
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

                PopularComboboxNumero(setorCli);
            }
        }

        private void cmb_numero_SelectedValueChanged(object sender, EventArgs e)
        {
            string codigoBase = this.cmb_base.Text;
            string codigoLocal = this.cmb_local.Text;
            string codigoSetor = this.cmb_setor.Text;
            Int32 numero = Int32.Parse(this.cmb_numero.Text);

            this.CapturarCodigoEstacao(codigoBase, codigoLocal, codigoSetor, numero);
        }

        private void btn_instalar_Click(object sender, EventArgs e)
        {
            string estacao = this.txt_codigoestacao.Text;
            string equipamento = this.txt_codigoEquipamento.Text;

            this.SalvarEquipamento(estacao, equipamento);
        }

        private void btn_canecelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }
    }
}
