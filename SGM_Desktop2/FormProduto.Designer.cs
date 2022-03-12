namespace SGM_Desktop2
{
    partial class FormProduto
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
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtQtde = new System.Windows.Forms.NumericUpDown();
            this.txtValorC = new System.Windows.Forms.MaskedTextBox();
            this.txtValorV = new System.Windows.Forms.MaskedTextBox();
            this.dataGriProd = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdForne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.btExcluirProd = new System.Windows.Forms.Button();
            this.btAlteraProd = new System.Windows.Forms.Button();
            this.btLimp = new System.Windows.Forms.Button();
            this.btVolta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(2, 341);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 22);
            this.label9.TabIndex = 39;
            this.label9.Text = "Produto:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(2, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(2, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 43;
            this.label4.Text = "Fabricante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(2, 519);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Valor de Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(368, 514);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 22);
            this.label6.TabIndex = 47;
            this.label6.Text = "Valor de Venda:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(543, 289);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "Quantidade:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtFornecedor.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtFornecedor.ForeColor = System.Drawing.Color.White;
            this.txtFornecedor.Location = new System.Drawing.Point(290, 57);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(1);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(310, 30);
            this.txtFornecedor.TabIndex = 52;
            this.txtFornecedor.Text = "Fornecedor";
            this.txtFornecedor.Click += new System.EventHandler(this.txtFornecedor_Click);
            this.txtFornecedor.TextChanged += new System.EventHandler(this.txtFornecedor_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(618, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 53;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtDesc.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtDesc.ForeColor = System.Drawing.Color.White;
            this.txtDesc.Location = new System.Drawing.Point(104, 396);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(1);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(615, 30);
            this.txtDesc.TabIndex = 42;
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtMarca.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(104, 454);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(1);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(615, 30);
            this.txtMarca.TabIndex = 44;
            // 
            // txtProd
            // 
            this.txtProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtProd.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtProd.ForeColor = System.Drawing.Color.White;
            this.txtProd.Location = new System.Drawing.Point(104, 338);
            this.txtProd.Margin = new System.Windows.Forms.Padding(1);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(615, 30);
            this.txtProd.TabIndex = 40;
            this.txtProd.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnCad
            // 
            this.btnCad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCad.FlatAppearance.BorderSize = 4;
            this.btnCad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.ForeColor = System.Drawing.Color.White;
            this.btnCad.Location = new System.Drawing.Point(339, 639);
            this.btnCad.Margin = new System.Windows.Forms.Padding(1);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(117, 38);
            this.btnCad.TabIndex = 54;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtQtde
            // 
            this.txtQtde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtQtde.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtQtde.ForeColor = System.Drawing.Color.White;
            this.txtQtde.Location = new System.Drawing.Point(660, 281);
            this.txtQtde.Margin = new System.Windows.Forms.Padding(1);
            this.txtQtde.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(59, 30);
            this.txtQtde.TabIndex = 55;
            this.txtQtde.ValueChanged += new System.EventHandler(this.txtQtde_ValueChanged);
            // 
            // txtValorC
            // 
            this.txtValorC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtValorC.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtValorC.ForeColor = System.Drawing.Color.White;
            this.txtValorC.Location = new System.Drawing.Point(155, 511);
            this.txtValorC.Margin = new System.Windows.Forms.Padding(1);
            this.txtValorC.Name = "txtValorC";
            this.txtValorC.Size = new System.Drawing.Size(200, 30);
            this.txtValorC.TabIndex = 56;
            this.txtValorC.MaskChanged += new System.EventHandler(this.txtValorC_MaskChanged);
            this.txtValorC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtValorC_MaskInputRejected);
            this.txtValorC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtValorC_MouseClick);
            this.txtValorC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtValorC_MouseDoubleClick);
            // 
            // txtValorV
            // 
            this.txtValorV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtValorV.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtValorV.ForeColor = System.Drawing.Color.White;
            this.txtValorV.Location = new System.Drawing.Point(519, 511);
            this.txtValorV.Margin = new System.Windows.Forms.Padding(1);
            this.txtValorV.Name = "txtValorV";
            this.txtValorV.Size = new System.Drawing.Size(200, 30);
            this.txtValorV.TabIndex = 57;
            this.txtValorV.MaskChanged += new System.EventHandler(this.txtValorV_MaskChanged);
            this.txtValorV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtValorV_MouseClick);
            // 
            // dataGriProd
            // 
            this.dataGriProd.AllowUserToAddRows = false;
            this.dataGriProd.AllowUserToDeleteRows = false;
            this.dataGriProd.AllowUserToResizeColumns = false;
            this.dataGriProd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataGriProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGriProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGriProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGriProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dataGriProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriProd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGriProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGriProd.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGriProd.Location = new System.Drawing.Point(6, 106);
            this.dataGriProd.Margin = new System.Windows.Forms.Padding(1);
            this.dataGriProd.MultiSelect = false;
            this.dataGriProd.Name = "dataGriProd";
            this.dataGriProd.RowHeadersVisible = false;
            this.dataGriProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGriProd.Size = new System.Drawing.Size(820, 150);
            this.dataGriProd.TabIndex = 58;
            this.dataGriProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriProd_CellClick);
            this.dataGriProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriProd_CellContentClick_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(726, 54);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 59;
            this.button3.Text = "Exibir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(2, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "Codigo Fornecedor:";
            // 
            // txtIdForne
            // 
            this.txtIdForne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtIdForne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdForne.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtIdForne.ForeColor = System.Drawing.Color.White;
            this.txtIdForne.Location = new System.Drawing.Point(174, 289);
            this.txtIdForne.Name = "txtIdForne";
            this.txtIdForne.ReadOnly = true;
            this.txtIdForne.Size = new System.Drawing.Size(48, 23);
            this.txtIdForne.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(286, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "Codigo Produto:";
            // 
            // txtIdProd
            // 
            this.txtIdProd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtIdProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdProd.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtIdProd.ForeColor = System.Drawing.Color.White;
            this.txtIdProd.Location = new System.Drawing.Point(429, 289);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.ReadOnly = true;
            this.txtIdProd.Size = new System.Drawing.Size(46, 23);
            this.txtIdProd.TabIndex = 64;
            // 
            // btExcluirProd
            // 
            this.btExcluirProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExcluirProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btExcluirProd.FlatAppearance.BorderSize = 4;
            this.btExcluirProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btExcluirProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btExcluirProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluirProd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluirProd.ForeColor = System.Drawing.Color.White;
            this.btExcluirProd.Location = new System.Drawing.Point(601, 639);
            this.btExcluirProd.Margin = new System.Windows.Forms.Padding(1);
            this.btExcluirProd.Name = "btExcluirProd";
            this.btExcluirProd.Size = new System.Drawing.Size(117, 38);
            this.btExcluirProd.TabIndex = 65;
            this.btExcluirProd.Text = "Deletar";
            this.btExcluirProd.UseVisualStyleBackColor = true;
            this.btExcluirProd.Click += new System.EventHandler(this.btExcluirProd_Click);
            // 
            // btAlteraProd
            // 
            this.btAlteraProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlteraProd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAlteraProd.FlatAppearance.BorderSize = 4;
            this.btAlteraProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btAlteraProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btAlteraProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlteraProd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlteraProd.ForeColor = System.Drawing.Color.White;
            this.btAlteraProd.Location = new System.Drawing.Point(467, 639);
            this.btAlteraProd.Margin = new System.Windows.Forms.Padding(1);
            this.btAlteraProd.Name = "btAlteraProd";
            this.btAlteraProd.Size = new System.Drawing.Size(117, 38);
            this.btAlteraProd.TabIndex = 66;
            this.btAlteraProd.Text = "Alterar";
            this.btAlteraProd.UseVisualStyleBackColor = true;
            this.btAlteraProd.Click += new System.EventHandler(this.btAlteraProd_Click);
            // 
            // btLimp
            // 
            this.btLimp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLimp.FlatAppearance.BorderSize = 4;
            this.btLimp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btLimp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btLimp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btLimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimp.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btLimp.ForeColor = System.Drawing.Color.White;
            this.btLimp.Location = new System.Drawing.Point(198, 639);
            this.btLimp.Name = "btLimp";
            this.btLimp.Size = new System.Drawing.Size(121, 38);
            this.btLimp.TabIndex = 90;
            this.btLimp.Text = "Limpar";
            this.btLimp.UseVisualStyleBackColor = true;
            this.btLimp.Click += new System.EventHandler(this.btLimp_Click);
            // 
            // btVolta
            // 
            this.btVolta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btVolta.FlatAppearance.BorderSize = 3;
            this.btVolta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btVolta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVolta.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolta.ForeColor = System.Drawing.Color.White;
            this.btVolta.Location = new System.Drawing.Point(207, 57);
            this.btVolta.Name = "btVolta";
            this.btVolta.Size = new System.Drawing.Size(63, 30);
            this.btVolta.TabIndex = 91;
            this.btVolta.Text = "<";
            this.btVolta.UseVisualStyleBackColor = true;
            this.btVolta.Click += new System.EventHandler(this.btVolta_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(844, 720);
            this.Controls.Add(this.btVolta);
            this.Controls.Add(this.btLimp);
            this.Controls.Add(this.btAlteraProd);
            this.Controls.Add(this.btExcluirProd);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdForne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtValorV);
            this.Controls.Add(this.txtValorC);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.dataGriProd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduto";
            this.Text = "subForm3";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.Click += new System.EventHandler(this.FormProduto_Click);
            ((System.ComponentModel.ISupportInitialize)(this.txtQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.NumericUpDown txtQtde;
        private System.Windows.Forms.MaskedTextBox txtValorC;
        private System.Windows.Forms.MaskedTextBox txtValorV;
        private System.Windows.Forms.DataGridView dataGriProd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdForne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProd;
        private System.Windows.Forms.Button btExcluirProd;
        private System.Windows.Forms.Button btAlteraProd;
        private System.Windows.Forms.Button btLimp;
        private System.Windows.Forms.Button btVolta;
    }
}