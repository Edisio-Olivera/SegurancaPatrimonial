using SegurancaPatrimonial.BLL;
using SegurancaPatrimonial.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void EstadoInicial()
        {

        }

        public void SalvarEquipamento()
        {

        }

        public void EditarEquipamento()
        {

        }

        public void AtualizarEquipamento()
        {

        }

        public void ExcluirEquipamento()
        {

        }

        public void SelecionarEquipamento()
        {

        }

        public void ListaEquipamentos()
        {
            string[] item = new string[8];
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
                item[6] = eqp.EnderecoIp;
                item[7] = eqp.Status;

                lvw_listaEquipamento.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
            }
        }



        public frm_equipamento()
        {
            InitializeComponent();
        }

        private void frm_equipamento_Load(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.FromArgb(171, 37, 47);
            //this.panel2.BackColor = Color.FromArgb(67, 120, 57);
            //this.panel3.BackColor = Color.FromArgb(255, 202, 47);

            this.lvw_listaEquipamento.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Código", 80).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Tipo", 95).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Fabricante", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("Modelo", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("End. IP", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("Status", 8).TextAlign = HorizontalAlignment.Right;

            this.ListaEquipamentos();
        }
    }
}
