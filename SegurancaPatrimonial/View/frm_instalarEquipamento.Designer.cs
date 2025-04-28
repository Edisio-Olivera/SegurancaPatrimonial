
namespace SegurancaPatrimonial.View
{
    partial class frm_instalarEquipamento
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
            this.cmb_tipoEstacao = new System.Windows.Forms.ComboBox();
            this.cmb_base = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_local = new System.Windows.Forms.ComboBox();
            this.cmb_setor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_numero = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_codigoestacao = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_instalar = new System.Windows.Forms.Button();
            this.btn_canecelar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_codigoEquipamento = new System.Windows.Forms.MaskedTextBox();
            this.txt_mac = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_statusEstacao = new System.Windows.Forms.Label();
            this.img_imagemEquipamento = new System.Windows.Forms.PictureBox();
            this.txt_mac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagemEquipamento)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tipoEstacao
            // 
            this.cmb_tipoEstacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_tipoEstacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoEstacao.FormattingEnabled = true;
            this.cmb_tipoEstacao.Location = new System.Drawing.Point(86, 200);
            this.cmb_tipoEstacao.Name = "cmb_tipoEstacao";
            this.cmb_tipoEstacao.Size = new System.Drawing.Size(210, 23);
            this.cmb_tipoEstacao.TabIndex = 6;
            this.cmb_tipoEstacao.SelectedValueChanged += new System.EventHandler(this.cmb_tipoEstacao_SelectedValueChanged);
            // 
            // cmb_base
            // 
            this.cmb_base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_base.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_base.FormattingEnabled = true;
            this.cmb_base.Location = new System.Drawing.Point(86, 247);
            this.cmb_base.Name = "cmb_base";
            this.cmb_base.Size = new System.Drawing.Size(210, 23);
            this.cmb_base.TabIndex = 7;
            this.cmb_base.SelectedValueChanged += new System.EventHandler(this.cmb_base_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(83, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Tipo Estação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Base";
            // 
            // cmb_local
            // 
            this.cmb_local.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_local.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_local.FormattingEnabled = true;
            this.cmb_local.Location = new System.Drawing.Point(86, 292);
            this.cmb_local.Name = "cmb_local";
            this.cmb_local.Size = new System.Drawing.Size(210, 23);
            this.cmb_local.TabIndex = 10;
            this.cmb_local.SelectedValueChanged += new System.EventHandler(this.cmb_local_SelectedValueChanged);
            // 
            // cmb_setor
            // 
            this.cmb_setor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_setor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_setor.FormattingEnabled = true;
            this.cmb_setor.Location = new System.Drawing.Point(86, 338);
            this.cmb_setor.Name = "cmb_setor";
            this.cmb_setor.Size = new System.Drawing.Size(210, 23);
            this.cmb_setor.TabIndex = 11;
            this.cmb_setor.SelectedValueChanged += new System.EventHandler(this.cmb_setor_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Local";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Setor";
            // 
            // cmb_numero
            // 
            this.cmb_numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_numero.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_numero.FormattingEnabled = true;
            this.cmb_numero.Location = new System.Drawing.Point(86, 382);
            this.cmb_numero.Name = "cmb_numero";
            this.cmb_numero.Size = new System.Drawing.Size(112, 23);
            this.cmb_numero.TabIndex = 13;
            this.cmb_numero.SelectedValueChanged += new System.EventHandler(this.cmb_numero_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o Tipo da Estação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecione a Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(306, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selecione o Local da Base";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(306, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Selecione o Setor do Local";
            // 
            // txt_codigoestacao
            // 
            this.txt_codigoestacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_codigoestacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoestacao.Location = new System.Drawing.Point(86, 428);
            this.txt_codigoestacao.Name = "txt_codigoestacao";
            this.txt_codigoestacao.Size = new System.Drawing.Size(210, 23);
            this.txt_codigoestacao.TabIndex = 15;
            this.txt_codigoestacao.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(83, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Código da Estação";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 385);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Selecione o Número do Setor";
            // 
            // btn_instalar
            // 
            this.btn_instalar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_instalar.FlatAppearance.BorderSize = 0;
            this.btn_instalar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_instalar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_instalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instalar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instalar.ForeColor = System.Drawing.Color.White;
            this.btn_instalar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_instalar.Location = new System.Drawing.Point(86, 468);
            this.btn_instalar.Name = "btn_instalar";
            this.btn_instalar.Size = new System.Drawing.Size(210, 60);
            this.btn_instalar.TabIndex = 16;
            this.btn_instalar.Text = "Instalar";
            this.btn_instalar.UseVisualStyleBackColor = false;
            this.btn_instalar.Click += new System.EventHandler(this.btn_instalar_Click);
            // 
            // btn_canecelar
            // 
            this.btn_canecelar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_canecelar.FlatAppearance.BorderSize = 0;
            this.btn_canecelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_canecelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_canecelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_canecelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_canecelar.ForeColor = System.Drawing.Color.White;
            this.btn_canecelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_canecelar.Location = new System.Drawing.Point(302, 468);
            this.btn_canecelar.Name = "btn_canecelar";
            this.btn_canecelar.Size = new System.Drawing.Size(210, 60);
            this.btn_canecelar.TabIndex = 16;
            this.btn_canecelar.Text = "Cancelar";
            this.btn_canecelar.UseVisualStyleBackColor = false;
            this.btn_canecelar.Click += new System.EventHandler(this.btn_canecelar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 15);
            this.label11.TabIndex = 14;
            this.label11.Text = "Código do Equipamento";
            // 
            // txt_codigoEquipamento
            // 
            this.txt_codigoEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_codigoEquipamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoEquipamento.Location = new System.Drawing.Point(86, 146);
            this.txt_codigoEquipamento.Name = "txt_codigoEquipamento";
            this.txt_codigoEquipamento.Size = new System.Drawing.Size(210, 23);
            this.txt_codigoEquipamento.TabIndex = 15;
            this.txt_codigoEquipamento.ValidatingType = typeof(System.DateTime);
            // 
            // txt_mac
            // 
            this.txt_mac.BackColor = System.Drawing.Color.DarkRed;
            this.txt_mac.Controls.Add(this.label12);
            this.txt_mac.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_mac.Location = new System.Drawing.Point(0, 0);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(590, 80);
            this.txt_mac.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(78, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(355, 45);
            this.label12.TabIndex = 1;
            this.label12.Text = "Instalar Equipamento";
            // 
            // lbl_statusEstacao
            // 
            this.lbl_statusEstacao.AutoSize = true;
            this.lbl_statusEstacao.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statusEstacao.ForeColor = System.Drawing.Color.Red;
            this.lbl_statusEstacao.Location = new System.Drawing.Point(306, 431);
            this.lbl_statusEstacao.Name = "lbl_statusEstacao";
            this.lbl_statusEstacao.Size = new System.Drawing.Size(16, 15);
            this.lbl_statusEstacao.TabIndex = 9;
            this.lbl_statusEstacao.Text = "...";
            // 
            // img_imagemEquipamento
            // 
            this.img_imagemEquipamento.Location = new System.Drawing.Point(421, 86);
            this.img_imagemEquipamento.Name = "img_imagemEquipamento";
            this.img_imagemEquipamento.Size = new System.Drawing.Size(91, 83);
            this.img_imagemEquipamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_imagemEquipamento.TabIndex = 18;
            this.img_imagemEquipamento.TabStop = false;
            // 
            // frm_instalarEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 563);
            this.ControlBox = false;
            this.Controls.Add(this.img_imagemEquipamento);
            this.Controls.Add(this.txt_mac);
            this.Controls.Add(this.btn_canecelar);
            this.Controls.Add(this.btn_instalar);
            this.Controls.Add(this.txt_codigoEquipamento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_codigoestacao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmb_numero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_local);
            this.Controls.Add(this.cmb_setor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_statusEstacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_tipoEstacao);
            this.Controls.Add(this.cmb_base);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_instalarEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_instalarEquipamento_Load);
            this.txt_mac.ResumeLayout(false);
            this.txt_mac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagemEquipamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_tipoEstacao;
        private System.Windows.Forms.ComboBox cmb_base;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_local;
        private System.Windows.Forms.ComboBox cmb_setor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_codigoestacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_instalar;
        private System.Windows.Forms.Button btn_canecelar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_codigoEquipamento;
        private System.Windows.Forms.Panel txt_mac;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_statusEstacao;
        private System.Windows.Forms.PictureBox img_imagemEquipamento;
    }
}