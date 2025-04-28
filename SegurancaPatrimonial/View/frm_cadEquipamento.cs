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
    public partial class frm_cadEquipamento : Form
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

        //public static frm_equipamento equipamentoInstancia;

        Thread t1;

        private void abrirFormEquipamento(object obj)
        {
            Application.Run(new frm_equipamento());
        }

        public void FecharForm()
        {
            this.Close();
            t1 = new Thread(abrirFormEquipamento);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void EstadoFormNovo()
        {
            //Botões
            this.btn_salvar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_cancelar.Visible = true;

            this.btn_salvar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert01);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert02);

            //Caixa de Grupo Equipamento
            this.txt_id.Enabled = false;
            this.txt_codigoEquipamento.Enabled = false;
            this.dtp_dataAquisicao.Enabled = true;
            this.PopularComboboxTipoEquipamento();
            this.cmb_tipoEquipamento.Enabled = true;
            this.cmb_tipoEquipamento.SelectedIndex = -1;
            this.cmb_fabricante.Enabled = false;
            this.cmb_modelo.Enabled = false;
            this.txt_endMac.Enabled = true;
            this.txt_endIp.Enabled = true;
            this.txt_mascara.Enabled = true;
            this.txt_gateway.Enabled = true;
            this.txt_usuario.Enabled = true;
            this.txt_senha.Enabled = true;
            this.txt_status.Visible = false;
            this.lbl_status.Visible = false;            
            
            this.cmb_fabricante.SelectedIndex = -1;
            this.cmb_modelo.SelectedIndex = -1;

            //Caixa de Grupo Estação
            this.gbx_estacao.Visible = false;
        }

        public void EstadoFormEditar()
        {

        }

        public void EstadoFormAtualizar()
        {

        }
        

        public void SalvarEquipamento()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigoEquipamento.Text;

            //DateTime dataAqui = DateTime.Parse("20/02/2019");
            //dto.DataAquisicao = dataAqui;
            dto.DataAquisicao = this.dtp_dataAquisicao.Value;


            if (this.cmb_tipoEquipamento.Text == "")
            {
                MessageBox.Show("Por favor, Selecione o Tipo do Equipamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoEquipamento.Focus();
                return;
            }
            else
            {
                dto.TipoEquipamento = this.cmb_tipoEquipamento.Text;
            }

            if (this.cmb_fabricante.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Fabricante!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_fabricante.Focus();
                return;
            }
            else
            {
                dto.Fabricante = this.cmb_fabricante.Text;
            }

            if (this.cmb_modelo.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Modelo do Equipamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_modelo.Focus();
                return;
            }
            else
            {
                dto.Modelo = this.cmb_modelo.Text;
            }

            if (this.txt_endMac.Text == "")
            {
                dto.Mac = "-";
            }
            else
            {
                dto.Mac = this.txt_endMac.Text;
            }

            if (this.txt_endIp.Text == "")
            {
                dto.EnderecoIp = "-";
            }
            else
            {
                dto.EnderecoIp = this.txt_endIp.Text;
            }

            //if (this.txt_mascara.Text == "")
            //{
            //    dto.Mascara = "-";
            //}
            //else
            //{
            //    dto.Mascara = this.txt_mascara.Text;
            dto.Mascara = "255.255.255.0";
            //}

            //if (this.txt_gateway.Text == "")
            //{
            //    dto.Gateway = "-";
            //}
            //else
            //{
            //    dto.Gateway = this.txt_gateway.Text;
            dto.Gateway = "172.16.255.4";
            //}

            //if (this.txt_usuario.Text == "")
            //{
            //    dto.Usuario = "-";
            //}
            //else
            //{
            //    dto.Usuario = this.txt_usuario.Text;
            dto.Usuario = "admin";
            //}

            if (this.txt_senha.Text == "")
            {
                dto.Senha = "-";
            }
            else
            {
                dto.Senha = this.txt_senha.Text;
            }

            dto.Estacao = "-";

            dto.Status = "Disponível";

            bll.SalvarEquipamento(dto);

            string endIp = dto.EnderecoIp;
            string codigoEquipamento = dto.Codigo;
            string statusIp = "Ocupado";

            this.AtualizarRede(endIp, codigoEquipamento, statusIp);

            MessageBox.Show("Equipamento salvo com sucesso!", "Salvar Equipamento!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.FecharForm();
        }

        public void EditarEquipamento()
        {
            //Botões
            this.btn_salvar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_atualizar.Visible = true;
            this.btn_cancelar.Visible = true;

            this.btn_atualizar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert01);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor, MedidasGeraisDTO.posicaoVert02);

            //Caixa de Grupo Equipamento
            this.txt_id.Enabled = false;
            this.txt_codigoEquipamento.Enabled = false;
            this.dtp_dataAquisicao.Enabled = true;
            this.cmb_tipoEquipamento.Enabled = true;
            this.cmb_fabricante.Enabled = false;
            this.cmb_modelo.Enabled = false;
            this.txt_endMac.Enabled = true;
            this.txt_endIp.Enabled = true;
            this.txt_mascara.Enabled = true;
            this.txt_gateway.Enabled = true;
            this.txt_usuario.Enabled = true;
            this.txt_senha.Enabled = true;
            this.txt_status.Visible = false;
            this.lbl_status.Visible = false;
        }

        public void AtualizarEquipamento()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigoEquipamento.Text;
            dto.DataAquisicao = this.dtp_dataAquisicao.Value;

            if (this.cmb_tipoEquipamento.Text == "")
            {
                MessageBox.Show("Por favor, Selecione o Tipo do Equipamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoEquipamento.Focus();
                return;
            }
            else
            {
                dto.TipoEquipamento = this.cmb_tipoEquipamento.Text;
            }

            if (this.cmb_fabricante.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Fabricante!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_fabricante.Focus();
                return;
            }
            else
            {
                dto.Fabricante = this.cmb_fabricante.Text;
            }

            if (this.cmb_modelo.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Modelo do Equipamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_modelo.Focus();
                return;
            }
            else
            {
                dto.Modelo = this.cmb_modelo.Text;
            }

            if (this.txt_endMac.Text == "")
            {
                dto.Mac = "-";
            }
            else
            {
                dto.Mac = this.txt_endMac.Text;
            }

            if (this.txt_endIp.Text == "")
            {
                dto.EnderecoIp = "-";
            }
            else
            {
                dto.EnderecoIp = this.txt_endIp.Text;
            }

            if (this.txt_mascara.Text == "")
            {
                dto.Mascara = "-";
            }
            else
            {
                dto.Mascara = this.txt_mascara.Text;
            }

            if (this.txt_gateway.Text == "")
            {
                dto.Gateway = "-";
            }
            else
            {
                dto.Gateway = this.txt_gateway.Text;
            }

            if (this.txt_usuario.Text == "")
            {
                dto.Usuario = "-";
            }
            else
            {
                dto.Usuario = this.txt_usuario.Text;
            }

            if (this.txt_senha.Text == "")
            {
                dto.Senha = "-";
            }
            else
            {
                dto.Senha = this.txt_senha.Text;
            }

            dto.Status = "Disponível";

            bll.EditarEquipamento(dto);

            MessageBox.Show("Equipamento atualizado com sucesso!", "Atualizar Equipamento!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.FecharForm();
        }

        public void AtualizarRede(string endIp, string codigoEquipamento, string statusIp)
        {
            redDto.EndIp = endIp;
            redDto.Equipamento = codigoEquipamento;
            redDto.Status = statusIp;

            redBll.SalvarEquipamentoRede(redDto);
        }

        public void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.FecharForm();
            }
        }

        public void PopularComboboxTipoEquipamento()
        {
            List<EquipamentoTipoDTO> tipo = tipBll.PopularComboboxTipoEquipamento();

            this.cmb_tipoEquipamento.DataSource = tipo;
            this.cmb_tipoEquipamento.DisplayMember = "tipo";
            //this.cmb_tipoEquipamento.SelectedIndex = -1;
        }

        public void PopularComboboxFabricanteEquipamento()
        {
            List<EquipamentoFabricanteDTO> fabricante = fabBll.PopularComboboxFabricante();

            this.cmb_fabricante.DataSource = fabricante;
            this.cmb_fabricante.DisplayMember = "nome";
            //this.cmb_fabricante.SelectedIndex = -1;
        }

        public void PopularComboboxModeloEquipamento(string tipo, string fabricante)
        {
            modDto.TipoEquipamento = tipo;
            modDto.Fabricante = fabricante;

            List<EquipamentoModeloDTO> modelo = modBll.PopularComboboxModeloEquipamento(modDto);

            this.cmb_modelo.DataSource = modelo;
            this.cmb_modelo.DisplayMember = "modelo";
            //this.cmb_modelo.SelectedIndex = -1;
        }

        public void SelecionarModelo(string modelo)
        {
            modDto.Modelo = modelo;

            List<EquipamentoModeloDTO> mod = modBll.SelecionarModeloEquipamento(modDto);

            this.img_imagemEquipamento.Image = Image.FromFile(Application.StartupPath + mod[0].Imagem);
        }

        public void VerificarStatusIp()
        {
            redDto.EndIp = this.txt_endIp.Text;

            redBll.SelecionarStatusRede(redDto);

            if (redDto.Status == "Disponível")
            {
                return;
            }
            else
            {
                MessageBox.Show("O endereço de IP: " + redDto.EndIp + " não está disponível. Por favor, digite outro endereço!", "Endereço de IP ocupado!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public frm_cadEquipamento()
        {
            InitializeComponent();
        }

        //Criar Equipamento
        public frm_cadEquipamento(
            Int32 id, 
            string codigo
            )
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_codigoEquipamento.Text = codigo;

            this.EstadoFormNovo();
        }

        //Editar Equipamento
        public frm_cadEquipamento(
            string codigo
            )
        {
            InitializeComponent();

            dto.Codigo = codigo;

            List<EquipamentoDTO> eqp = bll.SelecionarEquipamento(dto);

            this.txt_id.Text = eqp[0].Id.ToString();
            this.txt_codigoEquipamento.Text = eqp[0].Codigo.ToString();
            string dataAqui = eqp[0].DataAquisicao.ToString("dd/MM/yyyy");
            this.dtp_dataAquisicao.Value = DateTime.Parse(dataAqui);
            this.PopularComboboxTipoEquipamento();
            this.cmb_tipoEquipamento.Text = eqp[0].TipoEquipamento;
            this.PopularComboboxFabricanteEquipamento();
            this.cmb_fabricante.Text = eqp[0].Fabricante;
            this.cmb_modelo.Text = eqp[0].Modelo;
            this.txt_endMac.Text = eqp[0].Mac;
            this.txt_endIp.Text = eqp[0].EnderecoIp;
            this.txt_mascara.Text = eqp[0].Mascara;
            this.txt_gateway.Text = eqp[0].Gateway;
            this.txt_usuario.Text = eqp[0].Usuario;
            this.txt_senha.Text = eqp[0].Senha;
            this.txt_status.Text = eqp[0].Status;

        }

        private void frm_cadEquipamento_Load(object sender, EventArgs e)
        {
            this.Text = "SEGPAT System V. 1.0  -  Equipamentos";

            this.lbl_titulo.Text = "Equipamentos";
            this.lbl_titulo.Location = new Point(240, 20);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;

            this.lbl_subTitulo.Text = "Equipamentos > Cadastro";
            this.lbl_subTitulo.Location = new Point(20, 5);
            this.lbl_subTitulo.ForeColor = System.Drawing.Color.Black;

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;

            this.EstadoFormNovo();
        }

        private void cmb_tipoEquipamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_tipoEquipamento.Text == "SegurancaPatrimonial.DTO.EquipamentoTipoDTO" || this.cmb_tipoEquipamento.Text == "")
            {
                return;
            }
            else
            {
                this.PopularComboboxFabricanteEquipamento();
                this.cmb_fabricante.Enabled = true;
                //this.cmb_tipoEquipamento.SelectedIndex = -1;
            }
        }

        private void cmb_fabricante_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_fabricante.Text == "SegurancaPatrimonial.DTO.EquipamentoFabricanteDTO" || this.cmb_fabricante.Text == "")
            {
                return;
            }
            else
            {
                string tipo = this.cmb_tipoEquipamento.Text;
                string fabricante = this.cmb_fabricante.Text;
                this.PopularComboboxModeloEquipamento(tipo, fabricante);
                this.cmb_modelo.Enabled = true;
                //this.cmb_modelo.SelectedIndex = -1;                
            }
        }

        private void cmb_modelo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_modelo.Text == "SegurancaPatrimonial.DTO.EquipamentoModeloDTO" || this.cmb_modelo.Text == "")
            {
                return;
            }
            else
            {
                string modelo = this.cmb_modelo.Text;
                this.SelecionarModelo(modelo);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();          
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarEquipamento();
        }
    }
}
