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
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace SegurancaPatrimonial.View
{
    public partial class frm_addRede : Form
    {

        RedeBLL bLL = new RedeBLL();
        RedeDTO dto = new RedeDTO();

        EquipamentoDTO eqpDto = new EquipamentoDTO();
        EquipamentoBLL bllEqp = new EquipamentoBLL();
        

        










        public frm_addRede()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip1 = this.textBox1.Text;
            string ip2 = this.textBox2.Text;
            string ip3 = this.textBox3.Text;

            string ip = ip1 + "." + ip2 + "." + ip3 + ".";

            string mascara1 = this.textBox4.Text;
            string mascara2 = this.textBox5.Text;
            string mascara3 = this.textBox6.Text;
            string mascara4 = this.textBox7.Text;

            string mascara = mascara1 + "." + mascara2 + "." + mascara3 + "." + mascara4;

            string gateway = ip + "4";

            for(Int32 x = 1; x < 255; x++)
            {
                bLL.CriarNovaRede(dto);

                Int32 id = dto.Id;

                dto.Id = id;
                dto.EndIp = ip + x;
                dto.Mascara = mascara;
                dto.Gateway = gateway;
                dto.Equipamento = "-";
                dto.Status = "Disponível";

                bLL.SalvarRede(dto);
                
            }

            MessageBox.Show("Rede salva com sucesso!", "Salvar Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void frm_addRede_Load(object sender, EventArgs e)
        {

        }
    }
}
