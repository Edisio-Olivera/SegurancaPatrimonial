
namespace SegurancaPatrimonial.View
{
    partial class frm_equipamento
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
            this.txt_mac = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_pingIp = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_instalar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.lvw_listaEquipamento = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_modeloPesq = new System.Windows.Forms.ComboBox();
            this.cmb_fabricantePesq = new System.Windows.Forms.ComboBox();
            this.cmb_tipoEquipamentoPesq = new System.Windows.Forms.ComboBox();
            this.lbl_modeloPesq = new System.Windows.Forms.Label();
            this.lbl_fabricantePesq = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_subTitulo = new System.Windows.Forms.Label();
            this.lbl_resultadoPesquisa = new System.Windows.Forms.Label();
            this.rdb_tipo = new System.Windows.Forms.RadioButton();
            this.rdb_fabricante = new System.Windows.Forms.RadioButton();
            this.rdb_modelo = new System.Windows.Forms.RadioButton();
            this.rdb_endIp = new System.Windows.Forms.RadioButton();
            this.rdb_endMac = new System.Windows.Forms.RadioButton();
            this.rdb_estacao = new System.Windows.Forms.RadioButton();
            this.txt_endIpPesq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_endMacPesq = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.rdb_todos = new System.Windows.Forms.RadioButton();
            this.txt_mac.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_mac
            // 
            this.txt_mac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_mac.Controls.Add(this.lbl_titulo);
            this.txt_mac.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_mac.Location = new System.Drawing.Point(0, 0);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(1361, 80);
            this.txt_mac.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(210, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(109, 45);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Título";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btn_pingIp);
            this.panel2.Controls.Add(this.btn_imprimir);
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Controls.Add(this.btn_instalar);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_excluir);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_novo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 631);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 40);
            this.panel1.TabIndex = 4;
            // 
            // btn_pingIp
            // 
            this.btn_pingIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_pingIp.FlatAppearance.BorderSize = 0;
            this.btn_pingIp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_pingIp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_pingIp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pingIp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pingIp.ForeColor = System.Drawing.Color.White;
            this.btn_pingIp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pingIp.Location = new System.Drawing.Point(0, 559);
            this.btn_pingIp.Name = "btn_pingIp";
            this.btn_pingIp.Size = new System.Drawing.Size(210, 60);
            this.btn_pingIp.TabIndex = 6;
            this.btn_pingIp.Text = "Ping";
            this.btn_pingIp.UseVisualStyleBackColor = false;
            this.btn_pingIp.Click += new System.EventHandler(this.btn_pingIp_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_imprimir.Location = new System.Drawing.Point(0, 500);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(210, 60);
            this.btn_imprimir.TabIndex = 5;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.Location = new System.Drawing.Point(0, 434);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(210, 60);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_instalar
            // 
            this.btn_instalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_instalar.FlatAppearance.BorderSize = 0;
            this.btn_instalar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_instalar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_instalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_instalar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_instalar.ForeColor = System.Drawing.Color.White;
            this.btn_instalar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_instalar.Location = new System.Drawing.Point(0, 374);
            this.btn_instalar.Name = "btn_instalar";
            this.btn_instalar.Size = new System.Drawing.Size(210, 60);
            this.btn_instalar.TabIndex = 4;
            this.btn_instalar.Text = "Instalar";
            this.btn_instalar.UseVisualStyleBackColor = false;
            this.btn_instalar.Click += new System.EventHandler(this.btn_instalar_Click);
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
            this.btn_cancelar.Location = new System.Drawing.Point(0, 319);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(210, 60);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.Location = new System.Drawing.Point(0, 259);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(210, 60);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
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
            this.btn_editar.Location = new System.Drawing.Point(0, 140);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(210, 60);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.Location = new System.Drawing.Point(3, 74);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(210, 60);
            this.btn_novo.TabIndex = 4;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // lvw_listaEquipamento
            // 
            this.lvw_listaEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaEquipamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaEquipamento.FullRowSelect = true;
            this.lvw_listaEquipamento.GridLines = true;
            this.lvw_listaEquipamento.HideSelection = false;
            this.lvw_listaEquipamento.Location = new System.Drawing.Point(230, 283);
            this.lvw_listaEquipamento.Name = "lvw_listaEquipamento";
            this.lvw_listaEquipamento.Size = new System.Drawing.Size(1100, 375);
            this.lvw_listaEquipamento.TabIndex = 1;
            this.lvw_listaEquipamento.UseCompatibleStateImageBehavior = false;
            this.lvw_listaEquipamento.View = System.Windows.Forms.View.Details;
            this.lvw_listaEquipamento.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaEquipamento_ItemSelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_pesquisar);
            this.groupBox3.Controls.Add(this.txt_endMacPesq);
            this.groupBox3.Controls.Add(this.txt_endIpPesq);
            this.groupBox3.Controls.Add(this.rdb_todos);
            this.groupBox3.Controls.Add(this.rdb_estacao);
            this.groupBox3.Controls.Add(this.rdb_endMac);
            this.groupBox3.Controls.Add(this.rdb_endIp);
            this.groupBox3.Controls.Add(this.rdb_modelo);
            this.groupBox3.Controls.Add(this.rdb_fabricante);
            this.groupBox3.Controls.Add(this.rdb_tipo);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmb_modeloPesq);
            this.groupBox3.Controls.Add(this.cmb_fabricantePesq);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmb_tipoEquipamentoPesq);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl_modeloPesq);
            this.groupBox3.Controls.Add(this.lbl_fabricantePesq);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(230, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1100, 125);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar por:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 66);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tipo Equipamento";
            // 
            // cmb_modeloPesq
            // 
            this.cmb_modeloPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_modeloPesq.FormattingEnabled = true;
            this.cmb_modeloPesq.Location = new System.Drawing.Point(399, 84);
            this.cmb_modeloPesq.Name = "cmb_modeloPesq";
            this.cmb_modeloPesq.Size = new System.Drawing.Size(217, 23);
            this.cmb_modeloPesq.TabIndex = 3;
            this.cmb_modeloPesq.SelectedValueChanged += new System.EventHandler(this.cmb_modeloPesq_SelectedValueChanged);
            // 
            // cmb_fabricantePesq
            // 
            this.cmb_fabricantePesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_fabricantePesq.FormattingEnabled = true;
            this.cmb_fabricantePesq.Location = new System.Drawing.Point(188, 84);
            this.cmb_fabricantePesq.Name = "cmb_fabricantePesq";
            this.cmb_fabricantePesq.Size = new System.Drawing.Size(205, 23);
            this.cmb_fabricantePesq.TabIndex = 3;
            this.cmb_fabricantePesq.SelectedIndexChanged += new System.EventHandler(this.cmb_fabricantePesq_SelectedIndexChanged);
            this.cmb_fabricantePesq.SelectedValueChanged += new System.EventHandler(this.cmb_fabricantePesq_SelectedValueChanged);
            // 
            // cmb_tipoEquipamentoPesq
            // 
            this.cmb_tipoEquipamentoPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_tipoEquipamentoPesq.FormattingEnabled = true;
            this.cmb_tipoEquipamentoPesq.Location = new System.Drawing.Point(18, 84);
            this.cmb_tipoEquipamentoPesq.Name = "cmb_tipoEquipamentoPesq";
            this.cmb_tipoEquipamentoPesq.Size = new System.Drawing.Size(164, 23);
            this.cmb_tipoEquipamentoPesq.TabIndex = 3;
            this.cmb_tipoEquipamentoPesq.SelectedValueChanged += new System.EventHandler(this.cmb_tipoEquipamentoPesq_SelectedValueChanged);
            // 
            // lbl_modeloPesq
            // 
            this.lbl_modeloPesq.AutoSize = true;
            this.lbl_modeloPesq.Location = new System.Drawing.Point(398, 66);
            this.lbl_modeloPesq.Name = "lbl_modeloPesq";
            this.lbl_modeloPesq.Size = new System.Drawing.Size(49, 15);
            this.lbl_modeloPesq.TabIndex = 1;
            this.lbl_modeloPesq.Text = "Modelo";
            // 
            // lbl_fabricantePesq
            // 
            this.lbl_fabricantePesq.AutoSize = true;
            this.lbl_fabricantePesq.Location = new System.Drawing.Point(188, 66);
            this.lbl_fabricantePesq.Name = "lbl_fabricantePesq";
            this.lbl_fabricantePesq.Size = new System.Drawing.Size(66, 15);
            this.lbl_fabricantePesq.TabIndex = 1;
            this.lbl_fabricantePesq.Text = "Fabricante";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(230, 265);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "Lista de  Equipamentos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.lbl_subTitulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1141, 40);
            this.panel3.TabIndex = 3;
            // 
            // lbl_subTitulo
            // 
            this.lbl_subTitulo.AutoSize = true;
            this.lbl_subTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTitulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_subTitulo.Location = new System.Drawing.Point(52, 3);
            this.lbl_subTitulo.Name = "lbl_subTitulo";
            this.lbl_subTitulo.Size = new System.Drawing.Size(80, 23);
            this.lbl_subTitulo.TabIndex = 2;
            this.lbl_subTitulo.Text = "Subtítulo";
            // 
            // lbl_resultadoPesquisa
            // 
            this.lbl_resultadoPesquisa.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultadoPesquisa.ForeColor = System.Drawing.Color.Red;
            this.lbl_resultadoPesquisa.Location = new System.Drawing.Point(230, 664);
            this.lbl_resultadoPesquisa.Name = "lbl_resultadoPesquisa";
            this.lbl_resultadoPesquisa.Size = new System.Drawing.Size(1100, 16);
            this.lbl_resultadoPesquisa.TabIndex = 1;
            this.lbl_resultadoPesquisa.Text = "...";
            this.lbl_resultadoPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdb_tipo
            // 
            this.rdb_tipo.AutoSize = true;
            this.rdb_tipo.Location = new System.Drawing.Point(205, 29);
            this.rdb_tipo.Name = "rdb_tipo";
            this.rdb_tipo.Size = new System.Drawing.Size(49, 19);
            this.rdb_tipo.TabIndex = 4;
            this.rdb_tipo.Text = "Tipo";
            this.rdb_tipo.UseVisualStyleBackColor = true;
            this.rdb_tipo.CheckedChanged += new System.EventHandler(this.rdb_tipo_CheckedChanged);
            // 
            // rdb_fabricante
            // 
            this.rdb_fabricante.AutoSize = true;
            this.rdb_fabricante.Location = new System.Drawing.Point(298, 29);
            this.rdb_fabricante.Name = "rdb_fabricante";
            this.rdb_fabricante.Size = new System.Drawing.Size(84, 19);
            this.rdb_fabricante.TabIndex = 4;
            this.rdb_fabricante.Text = "Fabricante";
            this.rdb_fabricante.UseVisualStyleBackColor = true;
            this.rdb_fabricante.CheckedChanged += new System.EventHandler(this.rdb_fabricante_CheckedChanged);
            // 
            // rdb_modelo
            // 
            this.rdb_modelo.AutoSize = true;
            this.rdb_modelo.Location = new System.Drawing.Point(432, 29);
            this.rdb_modelo.Name = "rdb_modelo";
            this.rdb_modelo.Size = new System.Drawing.Size(67, 19);
            this.rdb_modelo.TabIndex = 4;
            this.rdb_modelo.Text = "Modelo";
            this.rdb_modelo.UseVisualStyleBackColor = true;
            // 
            // rdb_endIp
            // 
            this.rdb_endIp.AutoSize = true;
            this.rdb_endIp.Location = new System.Drawing.Point(556, 29);
            this.rdb_endIp.Name = "rdb_endIp";
            this.rdb_endIp.Size = new System.Drawing.Size(105, 19);
            this.rdb_endIp.TabIndex = 4;
            this.rdb_endIp.Text = "Endereço de IP";
            this.rdb_endIp.UseVisualStyleBackColor = true;
            // 
            // rdb_endMac
            // 
            this.rdb_endMac.AutoSize = true;
            this.rdb_endMac.Location = new System.Drawing.Point(698, 29);
            this.rdb_endMac.Name = "rdb_endMac";
            this.rdb_endMac.Size = new System.Drawing.Size(103, 19);
            this.rdb_endMac.TabIndex = 4;
            this.rdb_endMac.Text = "Endereço MAC";
            this.rdb_endMac.UseVisualStyleBackColor = true;
            // 
            // rdb_estacao
            // 
            this.rdb_estacao.AutoSize = true;
            this.rdb_estacao.Location = new System.Drawing.Point(851, 29);
            this.rdb_estacao.Name = "rdb_estacao";
            this.rdb_estacao.Size = new System.Drawing.Size(68, 19);
            this.rdb_estacao.TabIndex = 4;
            this.rdb_estacao.Text = "Estação";
            this.rdb_estacao.UseVisualStyleBackColor = true;
            // 
            // txt_endIpPesq
            // 
            this.txt_endIpPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_endIpPesq.Location = new System.Drawing.Point(622, 84);
            this.txt_endIpPesq.Name = "txt_endIpPesq";
            this.txt_endIpPesq.Size = new System.Drawing.Size(168, 23);
            this.txt_endIpPesq.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Endereço de IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(793, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço MAC";
            // 
            // txt_endMacPesq
            // 
            this.txt_endMacPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_endMacPesq.Location = new System.Drawing.Point(796, 84);
            this.txt_endMacPesq.Name = "txt_endMacPesq";
            this.txt_endMacPesq.Size = new System.Drawing.Size(168, 23);
            this.txt_endMacPesq.TabIndex = 5;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btn_pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pesquisar.Location = new System.Drawing.Point(970, 68);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(117, 39);
            this.btn_pesquisar.TabIndex = 7;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // rdb_todos
            // 
            this.rdb_todos.AutoSize = true;
            this.rdb_todos.Checked = true;
            this.rdb_todos.Location = new System.Drawing.Point(18, 29);
            this.rdb_todos.Name = "rdb_todos";
            this.rdb_todos.Size = new System.Drawing.Size(154, 19);
            this.rdb_todos.TabIndex = 4;
            this.rdb_todos.TabStop = true;
            this.rdb_todos.Text = "Todos os Equipamentos";
            this.rdb_todos.UseVisualStyleBackColor = true;
            this.rdb_todos.CheckedChanged += new System.EventHandler(this.rdb_todos_CheckedChanged);
            // 
            // frm_equipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1361, 711);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_resultadoPesquisa);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lvw_listaEquipamento);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_mac);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_equipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_equipamento_Load);
            this.txt_mac.ResumeLayout(false);
            this.txt_mac.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel txt_mac;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ListView lvw_listaEquipamento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_modeloPesq;
        private System.Windows.Forms.ComboBox cmb_fabricantePesq;
        private System.Windows.Forms.ComboBox cmb_tipoEquipamentoPesq;
        private System.Windows.Forms.Label lbl_modeloPesq;
        private System.Windows.Forms.Label lbl_fabricantePesq;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_instalar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_pingIp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_subTitulo;
        private System.Windows.Forms.Label lbl_resultadoPesquisa;
        private System.Windows.Forms.TextBox txt_endIpPesq;
        private System.Windows.Forms.RadioButton rdb_estacao;
        private System.Windows.Forms.RadioButton rdb_endMac;
        private System.Windows.Forms.RadioButton rdb_endIp;
        private System.Windows.Forms.RadioButton rdb_modelo;
        private System.Windows.Forms.RadioButton rdb_fabricante;
        private System.Windows.Forms.RadioButton rdb_tipo;
        private System.Windows.Forms.TextBox txt_endMacPesq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.RadioButton rdb_todos;
    }
}