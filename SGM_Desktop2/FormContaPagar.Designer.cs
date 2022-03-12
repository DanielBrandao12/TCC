namespace SGM_Desktop2
{
    partial class FormContaPagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TipoPagamento = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.dataFornecedor = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorT = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.txtValorParc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCodCp = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridParcelas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataFornecedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalva.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalva.FlatAppearance.BorderSize = 4;
            this.btnSalva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSalva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalva.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnSalva.Location = new System.Drawing.Point(650, 189);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(121, 50);
            this.btnSalva.TabIndex = 113;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(282, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 22);
            this.label12.TabIndex = 111;
            this.label12.Text = "Data devencimento:";
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.TipoPagamento.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.TipoPagamento.ForeColor = System.Drawing.Color.White;
            this.TipoPagamento.FormattingEnabled = true;
            this.TipoPagamento.Items.AddRange(new object[] {
            "A vista",
            "Parcelado"});
            this.TipoPagamento.Location = new System.Drawing.Point(193, 32);
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.Size = new System.Drawing.Size(158, 30);
            this.TipoPagamento.TabIndex = 110;
            this.TipoPagamento.SelectedIndexChanged += new System.EventHandler(this.TipoPagamento_SelectedIndexChanged);
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtObs.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtObs.ForeColor = System.Drawing.Color.White;
            this.txtObs.Location = new System.Drawing.Point(17, 275);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(562, 109);
            this.txtObs.TabIndex = 109;
            this.txtObs.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 107;
            this.label3.Text = "Quatidade de Parcela:";
            // 
            // txtJuros
            // 
            this.txtJuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtJuros.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtJuros.ForeColor = System.Drawing.Color.White;
            this.txtJuros.Location = new System.Drawing.Point(248, 85);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(72, 30);
            this.txtJuros.TabIndex = 108;
            this.txtJuros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtJuros_MouseClick);
            this.txtJuros.TextChanged += new System.EventHandler(this.txtJuros_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 105;
            this.label4.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtValor.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtValor.ForeColor = System.Drawing.Color.White;
            this.txtValor.Location = new System.Drawing.Point(72, 85);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(112, 30);
            this.txtValor.TabIndex = 106;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 104;
            this.label5.Text = "Observações:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(13, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 22);
            this.label9.TabIndex = 103;
            this.label9.Text = "Forma de pagamento:";
            // 
            // txtRazao
            // 
            this.txtRazao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtRazao.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtRazao.ForeColor = System.Drawing.Color.White;
            this.txtRazao.Location = new System.Drawing.Point(384, 258);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.ReadOnly = true;
            this.txtRazao.Size = new System.Drawing.Size(448, 30);
            this.txtRazao.TabIndex = 125;
            // 
            // dataFornecedor
            // 
            this.dataFornecedor.AllowUserToAddRows = false;
            this.dataFornecedor.AllowUserToDeleteRows = false;
            this.dataFornecedor.AllowUserToResizeColumns = false;
            this.dataFornecedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dataFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFornecedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dataFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFornecedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataFornecedor.Location = new System.Drawing.Point(12, 94);
            this.dataFornecedor.MultiSelect = false;
            this.dataFornecedor.Name = "dataFornecedor";
            this.dataFornecedor.RowHeadersVisible = false;
            this.dataFornecedor.RowHeadersWidth = 10;
            this.dataFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataFornecedor.Size = new System.Drawing.Size(820, 150);
            this.dataFornecedor.TabIndex = 114;
            this.dataFornecedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataFornecedor_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(275, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 127;
            this.label7.Text = "Fornecedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 22);
            this.label2.TabIndex = 129;
            this.label2.Text = "Código do Fornecedor:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(205, 265);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(51, 23);
            this.txtCodigo.TabIndex = 128;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(690, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 40);
            this.button2.TabIndex = 133;
            this.button2.Text = "Fornecedores";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.btnBusca.Location = new System.Drawing.Point(584, 41);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(100, 40);
            this.btnBusca.TabIndex = 131;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtBusca.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtBusca.ForeColor = System.Drawing.Color.White;
            this.txtBusca.Location = new System.Drawing.Point(12, 47);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(559, 30);
            this.txtBusca.TabIndex = 130;
            this.txtBusca.Text = "Fornecedor";
            this.txtBusca.Click += new System.EventHandler(this.txtBusca_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(189, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 22);
            this.label8.TabIndex = 136;
            this.label8.Text = "Juros:";
            // 
            // txtQtde
            // 
            this.txtQtde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtQtde.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtQtde.ForeColor = System.Drawing.Color.White;
            this.txtQtde.Location = new System.Drawing.Point(205, 140);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(72, 30);
            this.txtQtde.TabIndex = 137;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(13, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 22);
            this.label10.TabIndex = 134;
            this.label10.Text = "Valor Total:";
            // 
            // txtValorT
            // 
            this.txtValorT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtValorT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtValorT.ForeColor = System.Drawing.Color.White;
            this.txtValorT.Location = new System.Drawing.Point(124, 195);
            this.txtValorT.Name = "txtValorT";
            this.txtValorT.ReadOnly = true;
            this.txtValorT.Size = new System.Drawing.Size(153, 30);
            this.txtValorT.TabIndex = 135;
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.Status.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Status.ForeColor = System.Drawing.Color.White;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Pago",
            "A pagar"});
            this.Status.Location = new System.Drawing.Point(424, 32);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(155, 30);
            this.Status.TabIndex = 139;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(357, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 22);
            this.label11.TabIndex = 138;
            this.label11.Text = "Status:";
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAtualiza.FlatAppearance.BorderSize = 4;
            this.btnAtualiza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAtualiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAtualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualiza.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnAtualiza.Location = new System.Drawing.Point(295, 189);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(106, 39);
            this.btnAtualiza.TabIndex = 140;
            this.btnAtualiza.Text = "Atualizar Valor";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtValorParc
            // 
            this.txtValorParc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtValorParc.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtValorParc.ForeColor = System.Drawing.Color.White;
            this.txtValorParc.Location = new System.Drawing.Point(448, 85);
            this.txtValorParc.Name = "txtValorParc";
            this.txtValorParc.ReadOnly = true;
            this.txtValorParc.Size = new System.Drawing.Size(131, 30);
            this.txtValorParc.TabIndex = 142;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(325, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 22);
            this.label13.TabIndex = 141;
            this.label13.Text = "Valor Parcela:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(629, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 22);
            this.label14.TabIndex = 145;
            this.label14.Text = "Código Conta:";
            // 
            // txtCodCp
            // 
            this.txtCodCp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodCp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtCodCp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodCp.Enabled = false;
            this.txtCodCp.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtCodCp.ForeColor = System.Drawing.Color.White;
            this.txtCodCp.Location = new System.Drawing.Point(766, 303);
            this.txtCodCp.Name = "txtCodCp";
            this.txtCodCp.Size = new System.Drawing.Size(51, 23);
            this.txtCodCp.TabIndex = 144;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtData.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(452, 140);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(127, 30);
            this.txtData.TabIndex = 146;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 4;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.button5.Location = new System.Drawing.Point(650, 250);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 63);
            this.button5.TabIndex = 147;
            this.button5.Text = "Alterar Status";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 4;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.button6.Location = new System.Drawing.Point(650, 325);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 50);
            this.button6.TabIndex = 148;
            this.button6.Text = "Deletar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(820, 150);
            this.dataGridView1.TabIndex = 150;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtValorParc);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.btnAtualiza);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtQtde);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtValorT);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TipoPagamento);
            this.groupBox1.Controls.Add(this.btnSalva);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtJuros);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 401);
            this.groupBox1.TabIndex = 151;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contas a Pagar:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridParcelas
            // 
            this.dataGridParcelas.AllowUserToAddRows = false;
            this.dataGridParcelas.AllowUserToDeleteRows = false;
            this.dataGridParcelas.AllowUserToResizeColumns = false;
            this.dataGridParcelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.dataGridParcelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridParcelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridParcelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridParcelas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dataGridParcelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridParcelas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridParcelas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridParcelas.Location = new System.Drawing.Point(12, 94);
            this.dataGridParcelas.MultiSelect = false;
            this.dataGridParcelas.Name = "dataGridParcelas";
            this.dataGridParcelas.RowHeadersVisible = false;
            this.dataGridParcelas.RowHeadersWidth = 10;
            this.dataGridParcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridParcelas.Size = new System.Drawing.Size(820, 150);
            this.dataGridParcelas.TabIndex = 152;
            this.dataGridParcelas.Visible = false;
            // 
            // FormContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(844, 720);
            this.Controls.Add(this.txtCodCp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRazao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataFornecedor);
            this.Controls.Add(this.dataGridParcelas);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContaPagar";
            this.Text = "FormContaPagar";
            this.Load += new System.EventHandler(this.FormContaPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFornecedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TipoPagamento;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.DataGridView dataFornecedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorT;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.TextBox txtValorParc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCodCp;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridParcelas;
    }
}