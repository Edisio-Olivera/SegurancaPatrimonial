using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using SegurancaPatrimonial.BLL;
using SegurancaPatrimonial.DTO;

namespace SegurancaPatrimonial.View
{
    public partial class frm_ping : Form
    {
        RedeDTO dto = new RedeDTO();
        RedeBLL bll = new RedeBLL();

        EquipamentoDTO eqpDto = new EquipamentoDTO();
        EquipamentoBLL eqpBll = new EquipamentoBLL();


        Int32 qtdEquip = 0;
        Int32 ipAtual = 1;
        Int32 qtdIpCon = 0;
        Int32 qtdIpDes = 0;

        string statusIp = "";

        private void EstadoInicial()
        {
            this.cmb_pesquisar.Enabled = true;
            this.cmb_rede.Visible = false;
            this.lbl_rede.Visible = false;
            this.txt_ip.Visible = false;
            this.txt_desempenho.Text = "";
            this.btn_iniciar.Enabled = true;
            this.btn_parar.Visible = false;

            this.btn_iniciar.Location = new Point(226, 16);
        }

        private void PingRedeToda()
        {
            Int32 qtdIdRede = bll.ContarIdRede();

            for(int x = 1; x <= qtdIdRede; x++)
            {
                dto.Id = x;
                List<RedeDTO> rede = bll.SelecionarRede(dto);

                Int32 id = rede[0].Id;
                string ip = rede[0].EndIp;
                string mascara = rede[0].Mascara;
                string gateway = rede[0].Gateway;
                string equipamento = rede[0].Equipamento;
                string ipStatus = rede[0].Status;

                if(equipamento != "-")
                {
                    eqpDto.Codigo = equipamento;
                    List<EquipamentoDTO> equip = eqpBll.SelecionarEquipamento(eqpDto);

                }
                

                this.StartPing(ip);

                



                MessageBox.Show("PING!" + "\n" + id + "\n" + ip + "\n" + mascara + "\n" + gateway + "\n" + ipStatus + "\n" + statusIp + "\n" + equipamento + "\n", "Ping!", MessageBoxButtons.OK, MessageBoxIcon.Information);





            }









        }

        private void PingRedeEspecifica(string rede)
        {



        }

        private void PingIp(string ip)
        {





        }

        private string StartPing(string ip)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(ip, 1000);
            //NetworkInterface[] mac = NetworkInterface.GetAllNetworkInterfaces();
            //PhysicalAddress address = InfoMac

            statusIp = reply.Status.ToString();

            if(reply.Status.ToString() == "Success")
            {
                statusIp = "OnLine";
            }
            else if(reply.Status.ToString() == "TimedOut")
            {
                statusIp = "OffLine";
            }

            return statusIp;
        }

        public void ListaRedePing()
        {
            //string[] item = new string[11];
            //Int32 prox = 1;
            //Int32 qtd = 0;

            //var listaEquipamento = bll.ListarEquipamento();

            //this.lvw_listaEquipamento.Items.Clear();

            //foreach (EquipamentoDTO eqp in listaEquipamento)
            //{
            //    item[0] = eqp.Id.ToString();
            //    item[1] = prox.ToString();
            //    item[2] = eqp.Codigo;
            //    item[3] = eqp.TipoEquipamento;
            //    item[4] = eqp.Fabricante;
            //    item[5] = eqp.Modelo;
            //    item[6] = eqp.Mac;
            //    item[7] = eqp.EnderecoIp;
            //    item[8] = eqp.Mascara;
            //    item[9] = eqp.Gateway;
            //    item[10] = eqp.Status;

            //    lvw_listaEquipamento.Items.Add(new ListViewItem(item));
            //    prox++;
            //    qtd++;
            //}
        }


        public frm_ping()
        {
            InitializeComponent();
        }

        private void frm_ping_Load(object sender, EventArgs e)
        {
            this.EstadoInicial();

            this.lvw_listaPing.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaPing.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaPing.Columns.Add("Código", 120).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaPing.Columns.Add("Tipo", 95).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaPing.Columns.Add("Estação", 330).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaPing.Columns.Add("Descrição", 250).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaPing.Columns.Add("Equipamento", 120).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaPing.Columns.Add("Endereço IP", 120).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaPing.Columns.Add("Endereço MAC", 120).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaPing.Columns.Add("Status", 95).TextAlign = HorizontalAlignment.Left;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            this.PingRedeToda();
        }
    }
}
