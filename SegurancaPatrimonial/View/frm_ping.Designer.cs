
namespace SegurancaPatrimonial.View
{
    partial class frm_ping
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ping));
            this.lvw_listaPing = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.lbl_rede = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_rede = new System.Windows.Forms.ComboBox();
            this.cmb_pesquisar = new System.Windows.Forms.ComboBox();
            this.txt_mac = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pgb_desempenho = new System.Windows.Forms.ProgressBar();
            this.txt_desempenho = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.txt_mac.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvw_listaPing
            // 
            this.lvw_listaPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaPing.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaPing.FullRowSelect = true;
            this.lvw_listaPing.GridLines = true;
            this.lvw_listaPing.HideSelection = false;
            this.lvw_listaPing.Location = new System.Drawing.Point(28, 279);
            this.lvw_listaPing.Name = "lvw_listaPing";
            this.lvw_listaPing.Size = new System.Drawing.Size(1315, 377);
            this.lvw_listaPing.TabIndex = 4;
            this.lvw_listaPing.UseCompatibleStateImageBehavior = false;
            this.lvw_listaPing.View = System.Windows.Forms.View.Details;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_parar);
            this.groupBox1.Controls.Add(this.btn_iniciar);
            this.groupBox1.Controls.Add(this.txt_ip);
            this.groupBox1.Controls.Add(this.lbl_rede);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmb_rede);
            this.groupBox1.Controls.Add(this.cmb_pesquisar);
            this.groupBox1.Location = new System.Drawing.Point(28, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1315, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btn_parar
            // 
            this.btn_parar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_parar.FlatAppearance.BorderSize = 0;
            this.btn_parar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_parar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parar.Location = new System.Drawing.Point(568, 16);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(142, 45);
            this.btn_parar.TabIndex = 4;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = false;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_iniciar.FlatAppearance.BorderSize = 0;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar.Location = new System.Drawing.Point(420, 16);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(142, 45);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = false;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.BackColor = System.Drawing.Color.White;
            this.txt_ip.Enabled = false;
            this.txt_ip.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ip.Location = new System.Drawing.Point(716, 38);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(188, 23);
            this.txt_ip.TabIndex = 3;
            this.txt_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_rede
            // 
            this.lbl_rede.AutoSize = true;
            this.lbl_rede.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rede.Location = new System.Drawing.Point(223, 20);
            this.lbl_rede.Name = "lbl_rede";
            this.lbl_rede.Size = new System.Drawing.Size(33, 15);
            this.lbl_rede.TabIndex = 2;
            this.lbl_rede.Text = "Rede";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Pesqisar Por:";
            // 
            // cmb_rede
            // 
            this.cmb_rede.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_rede.FormattingEnabled = true;
            this.cmb_rede.Items.AddRange(new object[] {
            "Todas as Redes",
            "Rede Específica",
            "IP Específico"});
            this.cmb_rede.Location = new System.Drawing.Point(226, 38);
            this.cmb_rede.Name = "cmb_rede";
            this.cmb_rede.Size = new System.Drawing.Size(188, 23);
            this.cmb_rede.TabIndex = 0;
            // 
            // cmb_pesquisar
            // 
            this.cmb_pesquisar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_pesquisar.FormattingEnabled = true;
            this.cmb_pesquisar.Items.AddRange(new object[] {
            "Todas as Redes",
            "Rede Específica",
            "IP Específico"});
            this.cmb_pesquisar.Location = new System.Drawing.Point(32, 38);
            this.cmb_pesquisar.Name = "cmb_pesquisar";
            this.cmb_pesquisar.Size = new System.Drawing.Size(188, 23);
            this.cmb_pesquisar.TabIndex = 0;
            // 
            // txt_mac
            // 
            this.txt_mac.BackColor = System.Drawing.Color.DarkRed;
            this.txt_mac.Controls.Add(this.label1);
            this.txt_mac.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_mac.Location = new System.Drawing.Point(0, 0);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(1370, 80);
            this.txt_mac.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipamentos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pgb_desempenho);
            this.groupBox2.Controls.Add(this.txt_desempenho);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(28, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1315, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // pgb_desempenho
            // 
            this.pgb_desempenho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pgb_desempenho.Location = new System.Drawing.Point(226, 19);
            this.pgb_desempenho.Name = "pgb_desempenho";
            this.pgb_desempenho.Size = new System.Drawing.Size(1000, 23);
            this.pgb_desempenho.TabIndex = 4;
            // 
            // txt_desempenho
            // 
            this.txt_desempenho.BackColor = System.Drawing.Color.White;
            this.txt_desempenho.Enabled = false;
            this.txt_desempenho.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desempenho.Location = new System.Drawing.Point(32, 19);
            this.txt_desempenho.Name = "txt_desempenho";
            this.txt_desempenho.Size = new System.Drawing.Size(188, 23);
            this.txt_desempenho.TabIndex = 3;
            this.txt_desempenho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(1232, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "OnLine.png");
            this.imageList1.Images.SetKeyName(1, "OffLine.png");
            // 
            // frm_ping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 685);
            this.Controls.Add(this.txt_mac);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvw_listaPing);
            this.Name = "frm_ping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ping";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_ping_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.txt_mac.ResumeLayout(false);
            this.txt_mac.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvw_listaPing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel txt_mac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_pesquisar;
        private System.Windows.Forms.Label lbl_rede;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_rede;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pgb_desempenho;
        private System.Windows.Forms.TextBox txt_desempenho;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}