namespace SGM_Desktop2
{
    partial class FormEstoque
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
            this.DataProduto = new System.Windows.Forms.DataGridView();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.labelProd = new System.Windows.Forms.Label();
            this.btnProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdeEs = new System.Windows.Forms.TextBox();
            this.TipoMov = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.btnM = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataM = new System.Windows.Forms.DateTimePicker();
            this.btBuscaData = new System.Windows.Forms.Button();
            this.btFim = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DataProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // DataProduto
            // 
            this.DataProduto.AllowUserToAddRows = false;
            this.DataProduto.AllowUserToDeleteRows = false;
            this.DataProduto.AllowUserToResizeColumns = false;
            this.DataProduto.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DataProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.DataProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataProduto.Location = new System.Drawing.Point(12, 94);
            this.DataProduto.MultiSelect = false;
            this.DataProduto.Name = "DataProduto";
            this.DataProduto.RowHeadersVisible = false;
            this.DataProduto.RowHeadersWidth = 10;
            this.DataProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataProduto.Size = new System.Drawing.Size(820, 150);
            this.DataProduto.TabIndex = 0;
            this.DataProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProduto_CellContentClick);
            this.DataProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProduto_CellContentClick_1);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtBusca.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtBusca.ForeColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(100, 51);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(371, 30);
            this.txtBusca.TabIndex = 125;
            this.txtBusca.Text = "Produto";
            this.txtBusca.Click += new System.EventHandler(this.txtBusca_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBusca.FlatAppearance.BorderSize = 3;
            this.btnBusca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBusca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusca.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnBusca.ForeColor = System.Drawing.Color.White;
            this.btnBusca.Location = new System.Drawing.Point(477, 42);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(94, 39);
            this.btnBusca.TabIndex = 126;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelProd
            // 
            this.labelProd.AutoSize = true;
            this.labelProd.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.labelProd.ForeColor = System.Drawing.Color.White;
            this.labelProd.Location = new System.Drawing.Point(8, 59);
            this.labelProd.Name = "labelProd";
            this.labelProd.Size = new System.Drawing.Size(86, 22);
            this.labelProd.TabIndex = 127;
            this.labelProd.Text = "Produtos:";
            this.labelProd.Click += new System.EventHandler(this.label16_Click);
            // 
            // btnProd
            // 
            this.btnProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProd.FlatAppearance.BorderSize = 3;
            this.btnProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProd.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnProd.ForeColor = System.Drawing.Color.White;
            this.btnProd.Location = new System.Drawing.Point(577, 42);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(108, 39);
            this.btnProd.TabIndex = 128;
            this.btnProd.Text = "Produtos";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 130;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(220, 284);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(612, 30);
            this.txtNome.TabIndex = 129;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 132;
            this.label2.Text = "Código:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(83, 291);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(65, 23);
            this.txtCodigo.TabIndex = 131;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 22);
            this.label3.TabIndex = 134;
            this.label3.Text = "Quantidade em Estoque:";
            // 
            // txtQtdeEs
            // 
            this.txtQtdeEs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdeEs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtQtdeEs.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtQtdeEs.ForeColor = System.Drawing.Color.White;
            this.txtQtdeEs.Location = new System.Drawing.Point(220, 344);
            this.txtQtdeEs.Name = "txtQtdeEs";
            this.txtQtdeEs.ReadOnly = true;
            this.txtQtdeEs.Size = new System.Drawing.Size(200, 30);
            this.txtQtdeEs.TabIndex = 133;
            // 
            // TipoMov
            // 
            this.TipoMov.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TipoMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.TipoMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipoMov.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.TipoMov.ForeColor = System.Drawing.Color.White;
            this.TipoMov.FormattingEnabled = true;
            this.TipoMov.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.TipoMov.Location = new System.Drawing.Point(220, 402);
            this.TipoMov.Name = "TipoMov";
            this.TipoMov.Size = new System.Drawing.Size(200, 30);
            this.TipoMov.TabIndex = 136;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(8, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 22);
            this.label4.TabIndex = 135;
            this.label4.Text = "Tipo de Movimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 138;
            this.label5.Text = "Quantidade:";
            // 
            // txtQtde
            // 
            this.txtQtde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtQtde.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtQtde.ForeColor = System.Drawing.Color.White;
            this.txtQtde.Location = new System.Drawing.Point(220, 457);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(200, 30);
            this.txtQtde.TabIndex = 137;
            // 
            // btnM
            // 
            this.btnM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnM.FlatAppearance.BorderSize = 3;
            this.btnM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnM.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnM.ForeColor = System.Drawing.Color.White;
            this.btnM.Location = new System.Drawing.Point(691, 42);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(141, 39);
            this.btnM.TabIndex = 139;
            this.btnM.Text = "Movimentação";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(547, 591);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(255, 51);
            this.button4.TabIndex = 140;
            this.button4.Text = "Confirmar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataM
            // 
            this.dataM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataM.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.dataM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataM.Location = new System.Drawing.Point(173, 44);
            this.dataM.Name = "dataM";
            this.dataM.Size = new System.Drawing.Size(130, 30);
            this.dataM.TabIndex = 142;
            this.dataM.Visible = false;
            // 
            // btBuscaData
            // 
            this.btBuscaData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscaData.Enabled = false;
            this.btBuscaData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBuscaData.FlatAppearance.BorderSize = 3;
            this.btBuscaData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btBuscaData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btBuscaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscaData.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btBuscaData.ForeColor = System.Drawing.Color.White;
            this.btBuscaData.Location = new System.Drawing.Point(477, 42);
            this.btBuscaData.Name = "btBuscaData";
            this.btBuscaData.Size = new System.Drawing.Size(94, 39);
            this.btBuscaData.TabIndex = 141;
            this.btBuscaData.Text = "Buscar";
            this.btBuscaData.UseVisualStyleBackColor = true;
            this.btBuscaData.Visible = false;
            this.btBuscaData.Click += new System.EventHandler(this.btBuscaData_Click);
            // 
            // btFim
            // 
            this.btFim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btFim.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.btFim.Location = new System.Drawing.Point(321, 44);
            this.btFim.Name = "btFim";
            this.btFim.Size = new System.Drawing.Size(133, 30);
            this.btFim.TabIndex = 143;
            this.btFim.Visible = false;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(844, 720);
            this.Controls.Add(this.btFim);
            this.Controls.Add(this.dataM);
            this.Controls.Add(this.btBuscaData);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.TipoMov);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtdeEs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.labelProd);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.DataProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataProduto;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label labelProd;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdeEs;
        private System.Windows.Forms.ComboBox TipoMov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dataM;
        private System.Windows.Forms.Button btBuscaData;
        private System.Windows.Forms.DateTimePicker btFim;
    }
}