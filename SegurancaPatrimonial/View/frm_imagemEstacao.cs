using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SegurancaPatrimonial.DTO;
using SegurancaPatrimonial.BLL;

namespace SegurancaPatrimonial.View
{
    public partial class frm_imagem : Form
    {
        EstacaoDTO dto = new EstacaoDTO();
        EstacaoBLL bll = new EstacaoBLL();

        public frm_imagem()
        {
            InitializeComponent();
        }

        public frm_imagem(string codigo)
        {
            InitializeComponent();

            dto.Codigo = codigo;

            List<EstacaoDTO> est = bll.SelecionarEstacao(dto);

            this.lbl_codigoEstacao.Text = codigo + " - " + est[0].Descricao;
            
            this.img_imagem.Image = Image.FromFile(Application.StartupPath + est[0].Imagem);
        }

        private void frm_imagemEstacao_Load(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
