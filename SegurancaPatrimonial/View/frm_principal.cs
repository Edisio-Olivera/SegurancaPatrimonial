using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Timers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegurancaPatrimonial.View;
using System.Net.NetworkInformation;
using SegurancaPatrimonial.DTO;
using SegurancaPatrimonial.BLL;

namespace SegurancaPatrimonial
{
    public partial class frm_principal : Form
    {
        EquipamentoDTO dto = new EquipamentoDTO();
        EquipamentoBLL bll = new EquipamentoBLL();

        //===========================================================================================================

        public void SalvarEquipamento()
        {
            dto.Id = 9;
            dto.Codigo = "EQP-0009";
            string data = "20/02/2019";
            dto.DataAquisicao = DateTime.Parse(data);
            dto.TipoEquipamento = "Gravador";
            dto.Fabricante = "Hikivision";
            dto.Modelo = "DS-7732NI-K4/16P";
            dto.EnderecoIp = "172.16.255.2";
            dto.Mascara = "255.255.255.0";
            dto.Gateway = "172.16.255.4";
            dto.Usuario = "admin";
            dto.Senha = "3Coracoes";
            dto.Mac = "98:8B:0A:B7:DE:B0";
            dto.Estacao = "-";
            dto.Status = "Disponível";

            bll.SalvarEquipamento(dto);
        }
            

        

        //===========================================================================================================






























        Thread t1;

        Int32 qtdEquip = 0;
        Int32 ipAtual = 1;
        Int32 qtdIpCon = 0;
        Int32 qtdIpDes = 0;

        private void abrirFormEquipamentos(object obj)
        {
            Application.Run(new frm_equipamento());
        }

        private void abrirFormEstacoes(object obj)
        {
            Application.Run(new frm_estacao());
        }

        private void abrirFormPing(object obj)
        {
            Application.Run(new frm_ping());
        }

        private void abrirFormRede(object obj)
        {
            Application.Run(new frm_addRede());
        }

        private void abrirFormModelo(object obj)
        {
            Application.Run(new frm_modeloEquipamento());
        }

        private void StartPing()
        {
            //qtdEquip = eqpBll.ContarIdEquipamento();
            
            //    eqpDto.Id = ipAtual;

            //    List<EquipamentoDTO> eqp = eqpBll.SelecionarEquipamentoId(eqpDto);

            //    string ip = eqp[0].EnderecoIp;

            //    Ping ping = new Ping();
            //    PingReply reply = ping.Send(ip, 1000);

            //    this.lbl_qtdIpVerificado.Text = "Qtd IP Verificado: " + ipAtual.ToString();
                
            //    string statusIp = reply.Status.ToString();

            //    if (statusIp == "Success")
            //    {
            //        qtdIpCon++;
            //        this.lbl_qtdIpConectado.Text = "Qtd IP Conectado: " + qtdIpCon.ToString();                    
            //    }
            //    else if (statusIp == "TimedOut")
            //    {
            //        qtdIpDes++;
            //        this.lbl_qtdIpDesconectado.Text = "Qtd IP Desconectado: " + qtdIpDes.ToString();
            //    }

            //    this.lbl_status.Text = "IP: " + ip;
            //float desempenho = ((float)qtdIpCon / (float)ipAtual) * 100;
            //this.lbl_desempenho.Text = "Desempenho: " + desempenho.ToString("##0.00") + "%";              

            //if(ipAtual >= qtdEquip)
            //{
            //    timer1.Enabled = false;
            //    MessageBox.Show("Ping finalizado com sucesso!");
            //}

            //ipAtual++;
        }

        private void StopPing()
        {
            timer1.Enabled = false;
            MessageBox.Show("Ping finalizado com sucesso!");
            this.btn_start.Enabled = true;
            this.btn_stopPing.Enabled = false;
            qtdEquip = 0;
            ipAtual = 1;
            qtdIpCon = 0;
            qtdIpDes = 0;
            this.lbl_qtdIpVerificado.Text = "Qtd IP Verificado: " + 0.ToString();
            this.lbl_qtdIpConectado.Text = "Qtd IP Conectado: " + qtdIpCon.ToString();
            this.lbl_qtdIpDesconectado.Text = "Qtd IP Desconectado: " + qtdIpDes.ToString();
            this.lbl_status.Text = "Status: " + 0.ToString();
            this.lbl_desempenho.Text = "Desempenho: 0,00%";
        }
        //private System.Timers.Timer timer;

        public frm_principal()
        {
            InitializeComponent();            
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormEquipamentos);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btn_estacao_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormEstacoes);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.btn_stopPing.Enabled = true;
            //this.StopPing();
        }

        private void btn_ping_Click_1(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormPing);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.btn_start.Enabled = false;
            this.btn_stopPing.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.StartPing();
        }

        private void btn_stopPing_Click(object sender, EventArgs e)
        {
            //this.StopPing();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormRede);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void listaDeModelosDeEquipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormModelo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
