
namespace SegurancaPatrimonial
{
    partial class frm_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_equipamentos = new System.Windows.Forms.Button();
            this.btn_estacao = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_rede = new System.Windows.Forms.Button();
            this.btn_ping = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_desempenho = new System.Windows.Forms.Label();
            this.lbl_qtdIpDesconectado = new System.Windows.Forms.Label();
            this.lbl_qtdIpConectado = new System.Windows.Forms.Label();
            this.lbl_qtdIpVerificado = new System.Windows.Forms.Label();
            this.txt_desempenho = new System.Windows.Forms.TextBox();
            this.txt_qtdIpDesconectado = new System.Windows.Forms.TextBox();
            this.txt_qtdIpConectado = new System.Windows.Forms.TextBox();
            this.txt_qtdIpVerificado = new System.Windows.Forms.TextBox();
            this.btn_stopPing = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.equipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEquipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeModelosDeEquipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_equipamentos
            // 
            this.btn_equipamentos.Location = new System.Drawing.Point(24, 149);
            this.btn_equipamentos.Name = "btn_equipamentos";
            this.btn_equipamentos.Size = new System.Drawing.Size(159, 82);
            this.btn_equipamentos.TabIndex = 0;
            this.btn_equipamentos.Text = "Equipamentos";
            this.btn_equipamentos.UseVisualStyleBackColor = true;
            this.btn_equipamentos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_estacao
            // 
            this.btn_estacao.Location = new System.Drawing.Point(24, 233);
            this.btn_estacao.Name = "btn_estacao";
            this.btn_estacao.Size = new System.Drawing.Size(159, 82);
            this.btn_estacao.TabIndex = 1;
            this.btn_estacao.Text = "Estações";
            this.btn_estacao.UseVisualStyleBackColor = true;
            this.btn_estacao.Click += new System.EventHandler(this.btn_estacao_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.btn_rede);
            this.panel1.Controls.Add(this.btn_ping);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 88);
            this.panel1.TabIndex = 2;
            // 
            // btn_rede
            // 
            this.btn_rede.Location = new System.Drawing.Point(888, 3);
            this.btn_rede.Name = "btn_rede";
            this.btn_rede.Size = new System.Drawing.Size(159, 82);
            this.btn_rede.TabIndex = 2;
            this.btn_rede.Text = "Rede";
            this.btn_rede.UseVisualStyleBackColor = true;
            this.btn_rede.Click += new System.EventHandler(this.btn_ping_Click_1);
            // 
            // btn_ping
            // 
            this.btn_ping.Location = new System.Drawing.Point(663, 3);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(159, 82);
            this.btn_ping.TabIndex = 2;
            this.btn_ping.Text = "Ping";
            this.btn_ping.UseVisualStyleBackColor = true;
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_status);
            this.panel2.Controls.Add(this.lbl_desempenho);
            this.panel2.Controls.Add(this.lbl_qtdIpDesconectado);
            this.panel2.Controls.Add(this.lbl_qtdIpConectado);
            this.panel2.Controls.Add(this.lbl_qtdIpVerificado);
            this.panel2.Controls.Add(this.txt_desempenho);
            this.panel2.Controls.Add(this.txt_qtdIpDesconectado);
            this.panel2.Controls.Add(this.txt_qtdIpConectado);
            this.panel2.Controls.Add(this.txt_qtdIpVerificado);
            this.panel2.Controls.Add(this.btn_stopPing);
            this.panel2.Controls.Add(this.btn_start);
            this.panel2.Location = new System.Drawing.Point(349, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 326);
            this.panel2.TabIndex = 3;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(22, 198);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(65, 19);
            this.lbl_status.TabIndex = 6;
            this.lbl_status.Text = "Status: 0";
            // 
            // lbl_desempenho
            // 
            this.lbl_desempenho.AutoSize = true;
            this.lbl_desempenho.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desempenho.Location = new System.Drawing.Point(22, 144);
            this.lbl_desempenho.Name = "lbl_desempenho";
            this.lbl_desempenho.Size = new System.Drawing.Size(110, 19);
            this.lbl_desempenho.TabIndex = 6;
            this.lbl_desempenho.Text = "Desempenho: 0";
            // 
            // lbl_qtdIpDesconectado
            // 
            this.lbl_qtdIpDesconectado.AutoSize = true;
            this.lbl_qtdIpDesconectado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdIpDesconectado.Location = new System.Drawing.Point(22, 111);
            this.lbl_qtdIpDesconectado.Name = "lbl_qtdIpDesconectado";
            this.lbl_qtdIpDesconectado.Size = new System.Drawing.Size(161, 19);
            this.lbl_qtdIpDesconectado.TabIndex = 6;
            this.lbl_qtdIpDesconectado.Text = "Qtd IP Desconectado: 0";
            // 
            // lbl_qtdIpConectado
            // 
            this.lbl_qtdIpConectado.AutoSize = true;
            this.lbl_qtdIpConectado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdIpConectado.Location = new System.Drawing.Point(22, 78);
            this.lbl_qtdIpConectado.Name = "lbl_qtdIpConectado";
            this.lbl_qtdIpConectado.Size = new System.Drawing.Size(138, 19);
            this.lbl_qtdIpConectado.TabIndex = 6;
            this.lbl_qtdIpConectado.Text = "Qtd IP Conectado: 0";
            // 
            // lbl_qtdIpVerificado
            // 
            this.lbl_qtdIpVerificado.AutoSize = true;
            this.lbl_qtdIpVerificado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdIpVerificado.Location = new System.Drawing.Point(22, 45);
            this.lbl_qtdIpVerificado.Name = "lbl_qtdIpVerificado";
            this.lbl_qtdIpVerificado.Size = new System.Drawing.Size(133, 19);
            this.lbl_qtdIpVerificado.TabIndex = 6;
            this.lbl_qtdIpVerificado.Text = "Qtd IP Verificado: 0";
            // 
            // txt_desempenho
            // 
            this.txt_desempenho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_desempenho.Enabled = false;
            this.txt_desempenho.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desempenho.Location = new System.Drawing.Point(272, 141);
            this.txt_desempenho.Name = "txt_desempenho";
            this.txt_desempenho.Size = new System.Drawing.Size(100, 27);
            this.txt_desempenho.TabIndex = 5;
            // 
            // txt_qtdIpDesconectado
            // 
            this.txt_qtdIpDesconectado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_qtdIpDesconectado.Enabled = false;
            this.txt_qtdIpDesconectado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdIpDesconectado.Location = new System.Drawing.Point(272, 108);
            this.txt_qtdIpDesconectado.Name = "txt_qtdIpDesconectado";
            this.txt_qtdIpDesconectado.Size = new System.Drawing.Size(100, 27);
            this.txt_qtdIpDesconectado.TabIndex = 5;
            // 
            // txt_qtdIpConectado
            // 
            this.txt_qtdIpConectado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_qtdIpConectado.Enabled = false;
            this.txt_qtdIpConectado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdIpConectado.Location = new System.Drawing.Point(272, 75);
            this.txt_qtdIpConectado.Name = "txt_qtdIpConectado";
            this.txt_qtdIpConectado.Size = new System.Drawing.Size(100, 27);
            this.txt_qtdIpConectado.TabIndex = 5;
            // 
            // txt_qtdIpVerificado
            // 
            this.txt_qtdIpVerificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_qtdIpVerificado.Enabled = false;
            this.txt_qtdIpVerificado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdIpVerificado.Location = new System.Drawing.Point(272, 42);
            this.txt_qtdIpVerificado.Name = "txt_qtdIpVerificado";
            this.txt_qtdIpVerificado.Size = new System.Drawing.Size(100, 27);
            this.txt_qtdIpVerificado.TabIndex = 5;
            // 
            // btn_stopPing
            // 
            this.btn_stopPing.BackColor = System.Drawing.Color.Red;
            this.btn_stopPing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stopPing.ForeColor = System.Drawing.Color.White;
            this.btn_stopPing.Location = new System.Drawing.Point(244, 243);
            this.btn_stopPing.Name = "btn_stopPing";
            this.btn_stopPing.Size = new System.Drawing.Size(128, 44);
            this.btn_stopPing.TabIndex = 4;
            this.btn_stopPing.Text = "STOP PING";
            this.btn_stopPing.UseVisualStyleBackColor = false;
            this.btn_stopPing.Click += new System.EventHandler(this.btn_stopPing_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.Black;
            this.btn_start.Location = new System.Drawing.Point(20, 243);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(128, 44);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "START PING";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rede";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equipamentosToolStripMenuItem,
            this.estaçõesToolStripMenuItem,
            this.redeToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // equipamentosToolStripMenuItem
            // 
            this.equipamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeEquipamentosToolStripMenuItem,
            this.listaDeModelosDeEquipamentosToolStripMenuItem});
            this.equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            this.equipamentosToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.equipamentosToolStripMenuItem.Text = "Equipamento";
            // 
            // estaçõesToolStripMenuItem
            // 
            this.estaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem1});
            this.estaçõesToolStripMenuItem.Name = "estaçõesToolStripMenuItem";
            this.estaçõesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.estaçõesToolStripMenuItem.Text = "Estação";
            // 
            // listaDeEquipamentosToolStripMenuItem
            // 
            this.listaDeEquipamentosToolStripMenuItem.Name = "listaDeEquipamentosToolStripMenuItem";
            this.listaDeEquipamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeEquipamentosToolStripMenuItem.Text = "Equipamentos";
            // 
            // listaDeModelosDeEquipamentosToolStripMenuItem
            // 
            this.listaDeModelosDeEquipamentosToolStripMenuItem.Name = "listaDeModelosDeEquipamentosToolStripMenuItem";
            this.listaDeModelosDeEquipamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeModelosDeEquipamentosToolStripMenuItem.Text = "Modelos";
            this.listaDeModelosDeEquipamentosToolStripMenuItem.Click += new System.EventHandler(this.listaDeModelosDeEquipamentosToolStripMenuItem_Click);
            // 
            // redeToolStripMenuItem
            // 
            this.redeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem});
            this.redeToolStripMenuItem.Name = "redeToolStripMenuItem";
            this.redeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.redeToolStripMenuItem.Text = "Rede";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaToolStripMenuItem.Text = "Redes";
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listaToolStripMenuItem1.Text = "Estações";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_estacao);
            this.Controls.Add(this.btn_equipamentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_equipamentos;
        private System.Windows.Forms.Button btn_estacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ping;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_desempenho;
        private System.Windows.Forms.Label lbl_qtdIpDesconectado;
        private System.Windows.Forms.Label lbl_qtdIpConectado;
        private System.Windows.Forms.Label lbl_qtdIpVerificado;
        private System.Windows.Forms.TextBox txt_desempenho;
        private System.Windows.Forms.TextBox txt_qtdIpDesconectado;
        private System.Windows.Forms.TextBox txt_qtdIpConectado;
        private System.Windows.Forms.TextBox txt_qtdIpVerificado;
        private System.Windows.Forms.Button btn_stopPing;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_rede;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem equipamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEquipamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeModelosDeEquipamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

