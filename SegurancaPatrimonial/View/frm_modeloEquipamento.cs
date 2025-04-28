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
    public partial class frm_modeloEquipamento : Form
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

        MedidasGeraisDTO medFormDTO = new MedidasGeraisDTO();

        public static frm_equipamento modeloInstancia;

        Thread t1;

        private void abrirFormPrincipal(object obj)
        {
            Application.Run(new frm_principal());
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

        public frm_modeloEquipamento()
        {
            InitializeComponent();
        }

        private void frm_modeloEquipamento_Load(object sender, EventArgs e)
        {
            this.Text = "SEGPAT System V. 1.0  -  Equipamentos";

            this.lbl_titulo.Text = "Modelos de Equipamentos";
            this.lbl_titulo.Location = new Point(240, 20);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;

            this.lbl_subTitulo.Text = "Modelos de Equipamentos > Lista";
            this.lbl_subTitulo.Location = new Point(20, 5);
            this.lbl_subTitulo.ForeColor = System.Drawing.Color.Black;

            this.lvw_listaModelosEquipamento.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaModelosEquipamento.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaModelosEquipamento.Columns.Add("Código", 80).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaModelosEquipamento.Columns.Add("Tipo", 95).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaModelosEquipamento.Columns.Add("Fabricante", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaModelosEquipamento.Columns.Add("Modelo", 180).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaModelosEquipamento.Columns.Add("Descrição", 450).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaModelosEquipamento.Columns.Add("Qtd", 84).TextAlign = HorizontalAlignment.Left;

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }
    }
}
