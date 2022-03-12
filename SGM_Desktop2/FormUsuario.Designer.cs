namespace SGM_Desktop2
{
    partial class FormUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.labelnome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsalva = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnExc = new System.Windows.Forms.Button();
            this.btnBusc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUser
            // 
            this.dataUser.AllowUserToAddRows = false;
            this.dataUser.AllowUserToDeleteRows = false;
            this.dataUser.AllowUserToResizeColumns = false;
            this.dataUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dataUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataUser.Location = new System.Drawing.Point(12, 96);
            this.dataUser.Name = "dataUser";
            this.dataUser.RowHeadersVisible = false;
            this.dataUser.RowHeadersWidth = 10;
            this.dataUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataUser.Size = new System.Drawing.Size(820, 150);
            this.dataUser.TabIndex = 0;
            this.dataUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataUser_CellContentClick);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtUser.ForeColor = System.Drawing.Color.White;
            this.txtUser.Location = new System.Drawing.Point(96, 336);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(341, 30);
            this.txtUser.TabIndex = 54;
            this.txtUser.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelnome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelnome.Location = new System.Drawing.Point(12, 339);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(78, 22);
            this.labelnome.TabIndex = 53;
            this.labelnome.Text = "Usuário:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(459, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Tipo de Usuário:";
            // 
            // txtConfi
            // 
            this.txtConfi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtConfi.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtConfi.ForeColor = System.Drawing.Color.White;
            this.txtConfi.Location = new System.Drawing.Point(565, 402);
            this.txtConfi.Name = "txtConfi";
            this.txtConfi.Size = new System.Drawing.Size(245, 30);
            this.txtConfi.TabIndex = 58;
            this.txtConfi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(389, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 22);
            this.label2.TabIndex = 57;
            this.label2.Text = "Confirmar Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtSenha.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtSenha.ForeColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(96, 402);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(264, 30);
            this.txtSenha.TabIndex = 60;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 59;
            this.label3.Text = "Senha:";
            // 
            // btnsalva
            // 
            this.btnsalva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsalva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsalva.FlatAppearance.BorderSize = 4;
            this.btnsalva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnsalva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnsalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalva.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnsalva.ForeColor = System.Drawing.Color.White;
            this.btnsalva.Location = new System.Drawing.Point(311, 567);
            this.btnsalva.Name = "btnsalva";
            this.btnsalva.Size = new System.Drawing.Size(142, 48);
            this.btnsalva.TabIndex = 86;
            this.btnsalva.Text = "Salvar";
            this.btnsalva.UseVisualStyleBackColor = true;
            this.btnsalva.Click += new System.EventHandler(this.btnsalva_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtTipo.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtTipo.ForeColor = System.Drawing.Color.White;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Funcionario",
            "Administrador"});
            this.txtTipo.Location = new System.Drawing.Point(641, 336);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(169, 30);
            this.txtTipo.TabIndex = 87;
            // 
            // btnAlt
            // 
            this.btnAlt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlt.Enabled = false;
            this.btnAlt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlt.FlatAppearance.BorderSize = 4;
            this.btnAlt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlt.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnAlt.ForeColor = System.Drawing.Color.White;
            this.btnAlt.Location = new System.Drawing.Point(480, 567);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(142, 48);
            this.btnAlt.TabIndex = 88;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnExc
            // 
            this.btnExc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExc.FlatAppearance.BorderSize = 4;
            this.btnExc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnExc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnExc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExc.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnExc.ForeColor = System.Drawing.Color.White;
            this.btnExc.Location = new System.Drawing.Point(641, 567);
            this.btnExc.Name = "btnExc";
            this.btnExc.Size = new System.Drawing.Size(142, 48);
            this.btnExc.TabIndex = 89;
            this.btnExc.Text = "Excluir";
            this.btnExc.UseVisualStyleBackColor = true;
            this.btnExc.Click += new System.EventHandler(this.btnExc_Click);
            // 
            // btnBusc
            // 
            this.btnBusc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBusc.FlatAppearance.BorderSize = 4;
            this.btnBusc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBusc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBusc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusc.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnBusc.ForeColor = System.Drawing.Color.White;
            this.btnBusc.Location = new System.Drawing.Point(712, 49);
            this.btnBusc.Name = "btnBusc";
            this.btnBusc.Size = new System.Drawing.Size(120, 41);
            this.btnBusc.TabIndex = 91;
            this.btnBusc.Text = "Buscar";
            this.btnBusc.UseVisualStyleBackColor = true;
            this.btnBusc.Click += new System.EventHandler(this.btnBusc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(792, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtBusca.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtBusca.ForeColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(353, 55);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(341, 30);
            this.txtBusca.TabIndex = 94;
            this.txtBusca.Text = "Nome Usuario";
            this.txtBusca.Click += new System.EventHandler(this.txtBusca_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(844, 720);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBusc);
            this.Controls.Add(this.btnExc);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnsalva);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.labelnome);
            this.Controls.Add(this.dataUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsuario";
            this.Text = "FormUsuario";
            this.Load += new System.EventHandler(this.FormUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsalva;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnExc;
        private System.Windows.Forms.Button btnBusc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBusca;
    }
}