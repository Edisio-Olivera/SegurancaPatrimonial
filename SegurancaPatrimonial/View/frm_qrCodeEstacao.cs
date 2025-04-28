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
using System.IO;

namespace SegurancaPatrimonial.View
{
    public partial class frm_qrCodeEstacao : Form
    {
        EstacaoDTO dto = new EstacaoDTO();
        EstacaoBLL bll = new EstacaoBLL();

        string codigo = "";
        string imagem = "";
        string qrCode = "";
        string pastaDestino = "";
        string enderecoCompleto = "";

        private void GerarQRCodeEstacao(string codigo)
        {
            dto.Codigo = codigo;

            List<EstacaoDTO> estacao = bll.SelecionarEstacao(dto);

            string dadosEstacao = "* Código: " + estacao[0].Codigo + "\n" +
                "* Tipo de Estação: " + estacao[0].TipoEstacao + "\n" +
                "* Base: " + estacao[0].Base + "\n" +
                "* Local: " + estacao[0].Local + "\n" +
                "* Setor: " + estacao[0].Setor + "\n" +
                "* Descrição: " + estacao[0].Descricao + "\n" +
                "* Observações: " + estacao[0].Observacao + "\n" +
                "* Altura: " + estacao[0].Altura + "\n" +
                "* Tipo de Infra: " + estacao[0].TipoInfra + "\n" +
                "* Tipo de Fixação: " + estacao[0].TipoFixacao + "\n" +
                "* Tipo de Alimentação: " + estacao[0].TipoAlimentacao + "\n" +
                "* Tipo de Cabo: " + estacao[0].TipoCabo + "\n" +
                "* Tipo de Conexão: " + estacao[0].TipoConexao + "\n" +
                "* Qtd de Cabo: " + estacao[0].QtdCabo;

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(dadosEstacao, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            this.img_qrCode.Image = qrCodeImage;
            this.lbl_codigoEstacao.Text = codigo;
        }

        private void SalvarQRCode()
        {
            codigo = this.lbl_codigoEstacao.Text;
            qrCode = @"\\Imagens\\Estações\\QRCode\\" + codigo + ".jpg";
            pastaDestino = Application.StartupPath + qrCode;

            if (File.Exists(pastaDestino))
            {
                if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Salvar Imagem!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.img_qrCode.Image.Save(pastaDestino);

                    dto.Codigo = codigo;
                    dto.QrCode = qrCode;
                    bll.AtualizarQRCodeEstacao(dto);

                    MessageBox.Show("QRCode salvo novamente com sucesso!", "Salvar QRCode!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                this.img_qrCode.Image.Save(pastaDestino);

                dto.Codigo = codigo;
                dto.QrCode = qrCode;
                bll.AtualizarQRCodeEstacao(dto);

                MessageBox.Show("QRCode salvo com sucesso!", "Salvar QRCode!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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


        public frm_qrCodeEstacao()
        {
            InitializeComponent();
        }

        public frm_qrCodeEstacao(string codigo)
        {
            InitializeComponent();

            this.GerarQRCodeEstacao(codigo);

        }

        private void frm_qrCodeEstacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarQRCode();
        }
    }
}
