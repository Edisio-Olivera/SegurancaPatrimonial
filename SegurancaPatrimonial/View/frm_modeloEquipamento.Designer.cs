
namespace SegurancaPatrimonial.View
{
    partial class frm_modeloEquipamento
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_subTitulo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_modeloPesq = new System.Windows.Forms.ComboBox();
            this.cmb_fabricantePesq = new System.Windows.Forms.ComboBox();
            this.cmb_tipoEquipamentoPesq = new System.Windows.Forms.ComboBox();
            this.lbl_modeloPesq = new System.Windows.Forms.Label();
            this.lbl_fabricantePesq = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.txt_mac = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lvw_listaModelosEquipamento = new System.Windows.Forms.ListView();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.txt_mac.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.lbl_subTitulo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(220, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1079, 40);
            this.panel3.TabIndex = 7;
            // 
            // lbl_subTitulo
            // 
            this.lbl_subTitulo.AutoSize = true;
            this.lbl_subTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTitulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_subTitulo.Location = new System.Drawing.Point(37, 8);
            this.lbl_subTitulo.Name = "lbl_subTitulo";
            this.lbl_subTitulo.Size = new System.Drawing.Size(80, 23);
            this.lbl_subTitulo.TabIndex = 2;
            this.lbl_subTitulo.Text = "Subtítulo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmb_modeloPesq);
            this.groupBox3.Controls.Add(this.cmb_fabricantePesq);
            this.groupBox3.Controls.Add(this.cmb_tipoEquipamentoPesq);
            this.groupBox3.Controls.Add(this.lbl_modeloPesq);
            this.groupBox3.Controls.Add(this.lbl_fabricantePesq);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(226, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1100, 91);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar por:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tipo Equipamento";
            // 
            // cmb_modeloPesq
            // 
            this.cmb_modeloPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_modeloPesq.FormattingEnabled = true;
            this.cmb_modeloPesq.Location = new System.Drawing.Point(401, 40);
            this.cmb_modeloPesq.Name = "cmb_modeloPesq";
            this.cmb_modeloPesq.Size = new System.Drawing.Size(217, 23);
            this.cmb_modeloPesq.TabIndex = 3;
            // 
            // cmb_fabricantePesq
            // 
            this.cmb_fabricantePesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_fabricantePesq.FormattingEnabled = true;
            this.cmb_fabricantePesq.Location = new System.Drawing.Point(190, 40);
            this.cmb_fabricantePesq.Name = "cmb_fabricantePesq";
            this.cmb_fabricantePesq.Size = new System.Drawing.Size(205, 23);
            this.cmb_fabricantePesq.TabIndex = 3;
            // 
            // cmb_tipoEquipamentoPesq
            // 
            this.cmb_tipoEquipamentoPesq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_tipoEquipamentoPesq.FormattingEnabled = true;
            this.cmb_tipoEquipamentoPesq.Location = new System.Drawing.Point(20, 40);
            this.cmb_tipoEquipamentoPesq.Name = "cmb_tipoEquipamentoPesq";
            this.cmb_tipoEquipamentoPesq.Size = new System.Drawing.Size(164, 23);
            this.cmb_tipoEquipamentoPesq.TabIndex = 3;
            // 
            // lbl_modeloPesq
            // 
            this.lbl_modeloPesq.AutoSize = true;
            this.lbl_modeloPesq.Location = new System.Drawing.Point(400, 22);
            this.lbl_modeloPesq.Name = "lbl_modeloPesq";
            this.lbl_modeloPesq.Size = new System.Drawing.Size(49, 15);
            this.lbl_modeloPesq.TabIndex = 1;
            this.lbl_modeloPesq.Text = "Modelo";
            // 
            // lbl_fabricantePesq
            // 
            this.lbl_fabricantePesq.AutoSize = true;
            this.lbl_fabricantePesq.Location = new System.Drawing.Point(190, 22);
            this.lbl_fabricantePesq.Name = "lbl_fabricantePesq";
            this.lbl_fabricantePesq.Size = new System.Drawing.Size(66, 15);
            this.lbl_fabricantePesq.TabIndex = 1;
            this.lbl_fabricantePesq.Text = "Fabricante";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_excluir);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_novo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 588);
            this.panel2.TabIndex = 4;
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
            // 
            // txt_mac
            // 
            this.txt_mac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_mac.Controls.Add(this.lbl_titulo);
            this.txt_mac.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_mac.Location = new System.Drawing.Point(0, 0);
            this.txt_mac.Name = "txt_mac";
            this.txt_mac.Size = new System.Drawing.Size(1299, 80);
            this.txt_mac.TabIndex = 5;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(244, 15);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(109, 45);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Título";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(226, 263);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "Lista de  Equipamentos";
            // 
            // lvw_listaModelosEquipamento
            // 
            this.lvw_listaModelosEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaModelosEquipamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaModelosEquipamento.FullRowSelect = true;
            this.lvw_listaModelosEquipamento.GridLines = true;
            this.lvw_listaModelosEquipamento.HideSelection = false;
            this.lvw_listaModelosEquipamento.Location = new System.Drawing.Point(226, 281);
            this.lvw_listaModelosEquipamento.Name = "lvw_listaModelosEquipamento";
            this.lvw_listaModelosEquipamento.Size = new System.Drawing.Size(1100, 375);
            this.lvw_listaModelosEquipamento.TabIndex = 9;
            this.lvw_listaModelosEquipamento.UseCompatibleStateImageBehavior = false;
            this.lvw_listaModelosEquipamento.View = System.Windows.Forms.View.Details;
            // 
            // frm_modeloEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1299, 668);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lvw_listaModelosEquipamento);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_mac);
            this.Name = "frm_modeloEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_modeloEquipamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_modeloEquipamento_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.txt_mac.ResumeLayout(false);
            this.txt_mac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_subTitulo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_modeloPesq;
        private System.Windows.Forms.ComboBox cmb_fabricantePesq;
        private System.Windows.Forms.ComboBox cmb_tipoEquipamentoPesq;
        private System.Windows.Forms.Label lbl_modeloPesq;
        private System.Windows.Forms.Label lbl_fabricantePesq;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Panel txt_mac;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ListView lvw_listaModelosEquipamento;
    }
}