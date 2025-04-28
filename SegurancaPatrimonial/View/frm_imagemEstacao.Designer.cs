
namespace SegurancaPatrimonial.View
{
    partial class frm_imagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.img_imagemEstacao = new System.Windows.Forms.Panel();
            this.lbl_codigoEstacao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_imagem = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.img_imagemEstacao.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // img_imagemEstacao
            // 
            this.img_imagemEstacao.BackColor = System.Drawing.Color.DarkRed;
            this.img_imagemEstacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_imagemEstacao.Controls.Add(this.btn_fechar);
            this.img_imagemEstacao.Controls.Add(this.lbl_codigoEstacao);
            this.img_imagemEstacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.img_imagemEstacao.Location = new System.Drawing.Point(0, 0);
            this.img_imagemEstacao.Name = "img_imagemEstacao";
            this.img_imagemEstacao.Size = new System.Drawing.Size(984, 80);
            this.img_imagemEstacao.TabIndex = 1;
            // 
            // lbl_codigoEstacao
            // 
            this.lbl_codigoEstacao.AutoSize = true;
            this.lbl_codigoEstacao.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoEstacao.ForeColor = System.Drawing.Color.White;
            this.lbl_codigoEstacao.Location = new System.Drawing.Point(90, 17);
            this.lbl_codigoEstacao.Name = "lbl_codigoEstacao";
            this.lbl_codigoEstacao.Size = new System.Drawing.Size(50, 45);
            this.lbl_codigoEstacao.TabIndex = 0;
            this.lbl_codigoEstacao.Text = "...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.img_imagem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 504);
            this.panel1.TabIndex = 2;
            // 
            // img_imagem
            // 
            this.img_imagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_imagem.Location = new System.Drawing.Point(0, 0);
            this.img_imagem.Name = "img_imagem";
            this.img_imagem.Size = new System.Drawing.Size(982, 502);
            this.img_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_imagem.TabIndex = 0;
            this.img_imagem.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_fechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Image = global::SegurancaPatrimonial.Properties.Resources.sair25;
            this.btn_fechar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_fechar.Location = new System.Drawing.Point(842, 15);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(129, 50);
            this.btn_fechar.TabIndex = 5;
            this.btn_fechar.Text = "     Fechar";
            this.btn_fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // frm_imagem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 584);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_imagemEstacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_imagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_imagemEstacao_Load);
            this.img_imagemEstacao.ResumeLayout(false);
            this.img_imagemEstacao.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_imagem;
        private System.Windows.Forms.Panel img_imagemEstacao;
        private System.Windows.Forms.Label lbl_codigoEstacao;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel panel1;
    }
}