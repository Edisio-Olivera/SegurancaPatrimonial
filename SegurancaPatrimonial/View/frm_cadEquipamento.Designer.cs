
namespace SegurancaPatrimonial.View
{
    partial class frm_cadEquipamento
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
            this.dtp_dataAquisicao = new System.Windows.Forms.DateTimePicker();
            this.txt_endMac = new System.Windows.Forms.MaskedTextBox();
            this.txt_descricaoEstacao = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_addModelo = new System.Windows.Forms.Button();
            this.img_imagemEquipamento = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cmb_fabricante = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_modelo = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cmb_tipoEquipamento = new System.Windows.Forms.ComboBox();
            this.txt_codigoEstacao = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_gateway = new System.Windows.Forms.MaskedTextBox();
            this.txt_mascara = new System.Windows.Forms.MaskedTextBox();
            this.txt_endIp = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigoEquipamento = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_mac = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_subTitulo = new System.Windows.Forms.Label();
            this.txt_baseEstacao = new System.Windows.Forms.TextBox();
            this.txt_localEstacao = new System.Windows.Forms.TextBox();
            this.txt_setorEstacao = new System.Windows.Forms.TextBox();
            this.txt_numeroSetorEstacao = new System.Windows.Forms.TextBox();
            this.gbx_estacao = new System.Windows.Forms.GroupBox();
            this.gbx_equipamento = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagemEquipamento)).BeginInit();
            this.txt_mac.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbx_estacao.SuspendLayout();
            this.gbx_equipamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_dataAquisicao
            // 
            this.dtp_dataAquisicao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataAquisicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataAquisicao.Location = new System.Drawing.Point(210, 45);
            this.dtp_dataAquisicao.Name = "dtp_dataAquisicao";
            this.dtp_dataAquisicao.Size = new System.Drawing.Size(100, 23);
            this.dtp_dataAquisicao.TabIndex = 1;
            // 
            // txt_endMac
            // 
            this.txt_endMac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_endMac.Location = new System.Drawing.Point(26, 137);
            this.txt_endMac.Name = "txt_endMac";
            this.txt_endMac.Size = new System.Drawing.Size(178, 23);
            this.txt_endMac.TabIndex = 5;
            this.txt_endMac.ValidatingType = typeof(System.DateTime);
            // 
            // txt_descricaoEstacao
            // 
            this.txt_descricaoEstacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_descricaoEstacao.Enabled = false;
            this.txt_descricaoEstacao.Location = new System.Drawing.Point(26, 90);
            this.txt_descricaoEstacao.Multiline = true;
            this.txt_descricaoEstacao.Name = "txt_descricaoEstacao";
            this.txt_descricaoEstacao.Size = new System.Drawing.Size(312, 23);
            this.txt_descricaoEstacao.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "Descrição";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(686, 28);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 15);
            this.label23.TabIndex = 1;
            this.label23.Text = "Número";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(24, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 15);
            this.label21.TabIndex = 1;
            this.label21.Text = "Código";
            // 
            // btn_addModelo
            // 
            this.btn_addModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_addModelo.FlatAppearance.BorderSize = 0;
            this.btn_addModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addModelo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addModelo.ForeColor = System.Drawing.Color.White;
            this.btn_addModelo.Location = new System.Drawing.Point(693, 91);
            this.btn_addModelo.Name = "btn_addModelo";
            this.btn_addModelo.Size = new System.Drawing.Size(49, 23);
            this.btn_addModelo.TabIndex = 4;
            this.btn_addModelo.Text = "+";
            this.btn_addModelo.UseVisualStyleBackColor = false;
            // 
            // img_imagemEquipamento
            // 
            this.img_imagemEquipamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_imagemEquipamento.Location = new System.Drawing.Point(769, 45);
            this.img_imagemEquipamento.Name = "img_imagemEquipamento";
            this.img_imagemEquipamento.Size = new System.Drawing.Size(184, 172);
            this.img_imagemEquipamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_imagemEquipamento.TabIndex = 4;
            this.img_imagemEquipamento.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(502, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "Setor";
            // 
            // cmb_fabricante
            // 
            this.cmb_fabricante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_fabricante.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fabricante.FormattingEnabled = true;
            this.cmb_fabricante.Location = new System.Drawing.Point(210, 91);
            this.cmb_fabricante.Name = "cmb_fabricante";
            this.cmb_fabricante.Size = new System.Drawing.Size(209, 23);
            this.cmb_fabricante.TabIndex = 3;
            this.cmb_fabricante.SelectedValueChanged += new System.EventHandler(this.cmb_fabricante_SelectedValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(341, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Local";
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_modelo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_modelo.FormattingEnabled = true;
            this.cmb_modelo.Location = new System.Drawing.Point(425, 91);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(262, 23);
            this.cmb_modelo.TabIndex = 4;
            this.cmb_modelo.SelectedValueChanged += new System.EventHandler(this.cmb_modelo_SelectedValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(157, 28);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(33, 15);
            this.label25.TabIndex = 1;
            this.label25.Text = "Base";
            // 
            // cmb_tipoEquipamento
            // 
            this.cmb_tipoEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_tipoEquipamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoEquipamento.FormattingEnabled = true;
            this.cmb_tipoEquipamento.Location = new System.Drawing.Point(26, 91);
            this.cmb_tipoEquipamento.Name = "cmb_tipoEquipamento";
            this.cmb_tipoEquipamento.Size = new System.Drawing.Size(178, 23);
            this.cmb_tipoEquipamento.TabIndex = 2;
            this.cmb_tipoEquipamento.SelectedValueChanged += new System.EventHandler(this.cmb_tipoEquipamento_SelectedValueChanged);
            // 
            // txt_codigoEstacao
            // 
            this.txt_codigoEstacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_codigoEstacao.Enabled = false;
            this.txt_codigoEstacao.Location = new System.Drawing.Point(26, 46);
            this.txt_codigoEstacao.Name = "txt_codigoEstacao";
            this.txt_codigoEstacao.Size = new System.Drawing.Size(128, 23);
            this.txt_codigoEstacao.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(766, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Imagem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fabricante";
            // 
            // txt_gateway
            // 
            this.txt_gateway.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_gateway.Location = new System.Drawing.Point(536, 138);
            this.txt_gateway.Name = "txt_gateway";
            this.txt_gateway.Size = new System.Drawing.Size(151, 23);
            this.txt_gateway.TabIndex = 8;
            this.txt_gateway.ValidatingType = typeof(System.DateTime);
            // 
            // txt_mascara
            // 
            this.txt_mascara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_mascara.Location = new System.Drawing.Point(374, 138);
            this.txt_mascara.Name = "txt_mascara";
            this.txt_mascara.Size = new System.Drawing.Size(156, 23);
            this.txt_mascara.TabIndex = 7;
            this.txt_mascara.ValidatingType = typeof(System.DateTime);
            // 
            // txt_endIp
            // 
            this.txt_endIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_endIp.Location = new System.Drawing.Point(210, 138);
            this.txt_endIp.Name = "txt_endIp";
            this.txt_endIp.Size = new System.Drawing.Size(158, 23);
            this.txt_endIp.TabIndex = 6;
            this.txt_endIp.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tipo Equipamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Aquisição";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(533, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Gateway";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Código";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(371, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Máscara";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(207, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Endereço IP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(422, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Modelo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Endereço Mac";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(371, 167);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(41, 15);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "Status";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(207, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Senha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // txt_codigoEquipamento
            // 
            this.txt_codigoEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_codigoEquipamento.Enabled = false;
            this.txt_codigoEquipamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoEquipamento.Location = new System.Drawing.Point(102, 45);
            this.txt_codigoEquipamento.Name = "txt_codigoEquipamento";
            this.txt_codigoEquipamento.Size = new System.Drawing.Size(102, 23);
            this.txt_codigoEquipamento.TabIndex = 0;
            this.txt_codigoEquipamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_status.Enabled = false;
            this.txt_status.Location = new System.Drawing.Point(374, 185);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(156, 23);
            this.txt_status.TabIndex = 0;
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_senha.Location = new System.Drawing.Point(210, 185);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(158, 23);
            this.txt_senha.TabIndex = 10;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_usuario.Location = new System.Drawing.Point(27, 185);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(177, 23);
            this.txt_usuario.TabIndex = 9;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(26, 45);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(70, 23);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_mac
            // 
            this.txt_mac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_mac.Controls.Add(this.lbl_titulo);
            this.txt_mac.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_mac.Location = new System.Drawing.Point(0, 0);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(1253, 80);
            this.txt_mac.TabIndex = 9;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(467, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(242, 45);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Equipamentos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_atualizar);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_salvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 669);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 40);
            this.panel3.TabIndex = 14;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.Location = new System.Drawing.Point(5, 250);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(210, 60);
            this.btn_cancelar.TabIndex = 14;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.Location = new System.Drawing.Point(5, 185);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(210, 60);
            this.btn_atualizar.TabIndex = 13;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.Location = new System.Drawing.Point(5, 120);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(210, 60);
            this.btn_editar.TabIndex = 12;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_salvar.Location = new System.Drawing.Point(5, 55);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(210, 60);
            this.btn_salvar.TabIndex = 11;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lbl_subTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 40);
            this.panel1.TabIndex = 11;
            // 
            // lbl_subTitulo
            // 
            this.lbl_subTitulo.AutoSize = true;
            this.lbl_subTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTitulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_subTitulo.Location = new System.Drawing.Point(166, 3);
            this.lbl_subTitulo.Name = "lbl_subTitulo";
            this.lbl_subTitulo.Size = new System.Drawing.Size(207, 23);
            this.lbl_subTitulo.TabIndex = 1;
            this.lbl_subTitulo.Text = "Equipamentos > Cadastro";
            // 
            // txt_baseEstacao
            // 
            this.txt_baseEstacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_baseEstacao.Enabled = false;
            this.txt_baseEstacao.Location = new System.Drawing.Point(160, 47);
            this.txt_baseEstacao.Name = "txt_baseEstacao";
            this.txt_baseEstacao.Size = new System.Drawing.Size(178, 23);
            this.txt_baseEstacao.TabIndex = 0;
            // 
            // txt_localEstacao
            // 
            this.txt_localEstacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_localEstacao.Enabled = false;
            this.txt_localEstacao.Location = new System.Drawing.Point(344, 47);
            this.txt_localEstacao.Name = "txt_localEstacao";
            this.txt_localEstacao.Size = new System.Drawing.Size(155, 23);
            this.txt_localEstacao.TabIndex = 0;
            // 
            // txt_setorEstacao
            // 
            this.txt_setorEstacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_setorEstacao.Enabled = false;
            this.txt_setorEstacao.Location = new System.Drawing.Point(505, 46);
            this.txt_setorEstacao.Name = "txt_setorEstacao";
            this.txt_setorEstacao.Size = new System.Drawing.Size(178, 23);
            this.txt_setorEstacao.TabIndex = 0;
            // 
            // txt_numeroSetorEstacao
            // 
            this.txt_numeroSetorEstacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_numeroSetorEstacao.Enabled = false;
            this.txt_numeroSetorEstacao.Location = new System.Drawing.Point(689, 47);
            this.txt_numeroSetorEstacao.Name = "txt_numeroSetorEstacao";
            this.txt_numeroSetorEstacao.Size = new System.Drawing.Size(53, 23);
            this.txt_numeroSetorEstacao.TabIndex = 0;
            // 
            // gbx_estacao
            // 
            this.gbx_estacao.Controls.Add(this.label21);
            this.gbx_estacao.Controls.Add(this.txt_codigoEstacao);
            this.gbx_estacao.Controls.Add(this.txt_baseEstacao);
            this.gbx_estacao.Controls.Add(this.txt_localEstacao);
            this.gbx_estacao.Controls.Add(this.txt_descricaoEstacao);
            this.gbx_estacao.Controls.Add(this.txt_setorEstacao);
            this.gbx_estacao.Controls.Add(this.txt_numeroSetorEstacao);
            this.gbx_estacao.Controls.Add(this.label20);
            this.gbx_estacao.Controls.Add(this.label25);
            this.gbx_estacao.Controls.Add(this.label17);
            this.gbx_estacao.Controls.Add(this.label23);
            this.gbx_estacao.Controls.Add(this.label18);
            this.gbx_estacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_estacao.Location = new System.Drawing.Point(230, 381);
            this.gbx_estacao.Name = "gbx_estacao";
            this.gbx_estacao.Size = new System.Drawing.Size(978, 141);
            this.gbx_estacao.TabIndex = 12;
            this.gbx_estacao.TabStop = false;
            this.gbx_estacao.Text = "Dados da Estação";
            // 
            // gbx_equipamento
            // 
            this.gbx_equipamento.Controls.Add(this.txt_id);
            this.gbx_equipamento.Controls.Add(this.label8);
            this.gbx_equipamento.Controls.Add(this.label13);
            this.gbx_equipamento.Controls.Add(this.dtp_dataAquisicao);
            this.gbx_equipamento.Controls.Add(this.label9);
            this.gbx_equipamento.Controls.Add(this.label15);
            this.gbx_equipamento.Controls.Add(this.img_imagemEquipamento);
            this.gbx_equipamento.Controls.Add(this.txt_endMac);
            this.gbx_equipamento.Controls.Add(this.label12);
            this.gbx_equipamento.Controls.Add(this.label10);
            this.gbx_equipamento.Controls.Add(this.txt_senha);
            this.gbx_equipamento.Controls.Add(this.label11);
            this.gbx_equipamento.Controls.Add(this.txt_codigoEquipamento);
            this.gbx_equipamento.Controls.Add(this.txt_usuario);
            this.gbx_equipamento.Controls.Add(this.txt_endIp);
            this.gbx_equipamento.Controls.Add(this.label2);
            this.gbx_equipamento.Controls.Add(this.cmb_modelo);
            this.gbx_equipamento.Controls.Add(this.label3);
            this.gbx_equipamento.Controls.Add(this.txt_mascara);
            this.gbx_equipamento.Controls.Add(this.btn_addModelo);
            this.gbx_equipamento.Controls.Add(this.label6);
            this.gbx_equipamento.Controls.Add(this.label4);
            this.gbx_equipamento.Controls.Add(this.txt_gateway);
            this.gbx_equipamento.Controls.Add(this.cmb_fabricante);
            this.gbx_equipamento.Controls.Add(this.cmb_tipoEquipamento);
            this.gbx_equipamento.Controls.Add(this.label5);
            this.gbx_equipamento.Controls.Add(this.lbl_status);
            this.gbx_equipamento.Controls.Add(this.txt_status);
            this.gbx_equipamento.Controls.Add(this.label7);
            this.gbx_equipamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_equipamento.Location = new System.Drawing.Point(230, 125);
            this.gbx_equipamento.Name = "gbx_equipamento";
            this.gbx_equipamento.Size = new System.Drawing.Size(978, 246);
            this.gbx_equipamento.TabIndex = 13;
            this.gbx_equipamento.TabStop = false;
            this.gbx_equipamento.Text = "Dados do Equipamento";
            // 
            // frm_cadEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 749);
            this.Controls.Add(this.gbx_equipamento);
            this.Controls.Add(this.gbx_estacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_mac);
            this.Name = "frm_cadEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_cadEquipamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_cadEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_imagemEquipamento)).EndInit();
            this.txt_mac.ResumeLayout(false);
            this.txt_mac.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbx_estacao.ResumeLayout(false);
            this.gbx_estacao.PerformLayout();
            this.gbx_equipamento.ResumeLayout(false);
            this.gbx_equipamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtp_dataAquisicao;
        private System.Windows.Forms.MaskedTextBox txt_endMac;
        private System.Windows.Forms.TextBox txt_descricaoEstacao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_addModelo;
        private System.Windows.Forms.PictureBox img_imagemEquipamento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmb_fabricante;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmb_modelo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmb_tipoEquipamento;
        private System.Windows.Forms.TextBox txt_codigoEstacao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txt_gateway;
        private System.Windows.Forms.MaskedTextBox txt_mascara;
        private System.Windows.Forms.MaskedTextBox txt_endIp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigoEquipamento;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel txt_mac;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_subTitulo;
        private System.Windows.Forms.TextBox txt_baseEstacao;
        private System.Windows.Forms.TextBox txt_localEstacao;
        private System.Windows.Forms.TextBox txt_setorEstacao;
        private System.Windows.Forms.TextBox txt_numeroSetorEstacao;
        private System.Windows.Forms.GroupBox gbx_estacao;
        private System.Windows.Forms.GroupBox gbx_equipamento;
        private System.Windows.Forms.Panel panel3;
    }
}