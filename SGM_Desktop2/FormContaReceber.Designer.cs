namespace SGM_Desktop2
{
    partial class FormContaReceber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataCliente = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAltera = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.txtValorParc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCr = new System.Windows.Forms.TextBox();
            this.dataConta = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipoPagamento = new System.Windows.Forms.TextBox();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.btnbusca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataCliente
            // 
            this.dataCliente.AllowUserToAddRows = false;
            this.dataCliente.AllowUserToDeleteRows = false;
            this.dataCliente.AllowUserToResizeColumns = false;
            this.dataCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            this.dataCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dataCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dataCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCliente.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataCliente.Location = new System.Drawing.Point(12, 94);
            this.dataCliente.MultiSelect = false;
            this.dataCliente.Name = "dataCliente";
            this.dataCliente.RowHeadersVisible = false;
            this.dataCliente.RowHeadersWidth = 10;
            this.dataCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCliente.Size = new System.Drawing.Size(820, 150);
            this.dataCliente.TabIndex = 35;
            this.dataCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCliente_CellClick);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 4;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 39);
            this.button3.TabIndex = 103;
            this.button3.Text = "Exibir Clientes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(8, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(161, 22);
            this.label13.TabIndex = 133;
            this.label13.Text = "Código do Cliente:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigo.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(175, 267);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(51, 23);
            this.txtCodigo.TabIndex = 132;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(245, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 22);
            this.label14.TabIndex = 131;
            this.label14.Text = "Nome do Cliente:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(401, 258);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(431, 30);
            this.txtNome.TabIndex = 130;
            // 
            // btnAltera
            // 
            this.btnAltera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAltera.Enabled = false;
            this.btnAltera.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAltera.FlatAppearance.BorderSize = 4;
            this.btnAltera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAltera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAltera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltera.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnAltera.ForeColor = System.Drawing.Color.White;
            this.btnAltera.Location = new System.Drawing.Point(616, 216);
            this.btnAltera.Name = "btnAltera";
            this.btnAltera.Size = new System.Drawing.Size(166, 73);
            this.btnAltera.TabIndex = 169;
            this.btnAltera.Text = "Alterar Status";
            this.btnAltera.UseVisualStyleBackColor = true;
            this.btnAltera.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtData.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtData.ForeColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(462, 144);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(109, 30);
            this.txtData.TabIndex = 168;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // txtValorParc
            // 
            this.txtValorParc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtValorParc.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtValorParc.ForeColor = System.Drawing.Color.White;
            this.txtValorParc.Location = new System.Drawing.Point(318, 90);
            this.txtValorParc.Name = "txtValorParc";
            this.txtValorParc.ReadOnly = true;
            this.txtValorParc.Size = new System.Drawing.Size(79, 30);
            this.txtValorParc.TabIndex = 167;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(169, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 22);
            this.label3.TabIndex = 166;
            this.label3.Text = "Valor da Parcela:";
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
            this.Status.Location = new System.Drawing.Point(442, 38);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(155, 30);
            this.Status.TabIndex = 164;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(373, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 163;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(14, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 161;
            this.label5.Text = "Juros:";
            // 
            // txtQtde
            // 
            this.txtQtde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtQtde.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtQtde.ForeColor = System.Drawing.Color.White;
            this.txtQtde.Location = new System.Drawing.Point(200, 144);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.ReadOnly = true;
            this.txtQtde.Size = new System.Drawing.Size(72, 30);
            this.txtQtde.TabIndex = 162;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(14, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 22);
            this.label9.TabIndex = 159;
            this.label9.Text = "Valor Total:";
            // 
            // txtValorT
            // 
            this.txtValorT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtValorT.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtValorT.ForeColor = System.Drawing.Color.White;
            this.txtValorT.Location = new System.Drawing.Point(125, 198);
            this.txtValorT.Name = "txtValorT";
            this.txtValorT.ReadOnly = true;
            this.txtValorT.Size = new System.Drawing.Size(159, 30);
            this.txtValorT.TabIndex = 160;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(283, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 22);
            this.label12.TabIndex = 157;
            this.label12.Text = "Data de Vencimento:";
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtObs.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtObs.ForeColor = System.Drawing.Color.White;
            this.txtObs.Location = new System.Drawing.Point(18, 269);
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.Size = new System.Drawing.Size(562, 109);
            this.txtObs.TabIndex = 155;
            this.txtObs.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(14, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(186, 22);
            this.label15.TabIndex = 153;
            this.label15.Text = "Quatidade de Parcela:";
            // 
            // txtJuros
            // 
            this.txtJuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtJuros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuros.ForeColor = System.Drawing.Color.White;
            this.txtJuros.Location = new System.Drawing.Point(78, 91);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.ReadOnly = true;
            this.txtJuros.Size = new System.Drawing.Size(86, 29);
            this.txtJuros.TabIndex = 154;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(14, 244);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 22);
            this.label17.TabIndex = 150;
            this.label17.Text = "Observações:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(14, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(180, 22);
            this.label18.TabIndex = 149;
            this.label18.Text = "Forma de pagamento:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(602, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 171;
            this.label2.Text = "Código da Venda:";
            // 
            // txtCodCr
            // 
            this.txtCodCr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodCr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtCodCr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodCr.Enabled = false;
            this.txtCodCr.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtCodCr.ForeColor = System.Drawing.Color.White;
            this.txtCodCr.Location = new System.Drawing.Point(764, 305);
            this.txtCodCr.Name = "txtCodCr";
            this.txtCodCr.Size = new System.Drawing.Size(51, 23);
            this.txtCodCr.TabIndex = 170;
            // 
            // dataConta
            // 
            this.dataConta.AllowUserToAddRows = false;
            this.dataConta.AllowUserToDeleteRows = false;
            this.dataConta.AllowUserToResizeColumns = false;
            this.dataConta.AllowUserToResizeRows = false;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            this.dataConta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dataConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataConta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataConta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dataConta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataConta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataConta.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataConta.Location = new System.Drawing.Point(12, 94);
            this.dataConta.MultiSelect = false;
            this.dataConta.Name = "dataConta";
            this.dataConta.RowHeadersVisible = false;
            this.dataConta.RowHeadersWidth = 10;
            this.dataConta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataConta.Size = new System.Drawing.Size(820, 150);
            this.dataConta.TabIndex = 172;
            this.dataConta.Visible = false;
            this.dataConta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataConta_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 10;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(820, 150);
            this.dataGridView1.TabIndex = 173;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TipoPagamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAltera);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Controls.Add(this.txtValorParc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Status);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQtde);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtValorT);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtJuros);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 399);
            this.groupBox1.TabIndex = 174;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contas a Receber:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TipoPagamento
            // 
            this.TipoPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.TipoPagamento.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoPagamento.ForeColor = System.Drawing.Color.White;
            this.TipoPagamento.Location = new System.Drawing.Point(198, 39);
            this.TipoPagamento.Name = "TipoPagamento";
            this.TipoPagamento.ReadOnly = true;
            this.TipoPagamento.Size = new System.Drawing.Size(150, 29);
            this.TipoPagamento.TabIndex = 172;
            // 
            // txtbusca
            // 
            this.txtbusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtbusca.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtbusca.ForeColor = System.Drawing.Color.White;
            this.txtbusca.Location = new System.Drawing.Point(252, 44);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(340, 30);
            this.txtbusca.TabIndex = 175;
            this.txtbusca.Text = "Nome";
            this.txtbusca.Click += new System.EventHandler(this.txtbusca_Click);
            // 
            // btnbusca
            // 
            this.btnbusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbusca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbusca.FlatAppearance.BorderSize = 3;
            this.btnbusca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnbusca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnbusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbusca.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbusca.ForeColor = System.Drawing.Color.White;
            this.btnbusca.Location = new System.Drawing.Point(609, 44);
            this.btnbusca.Name = "btnbusca";
            this.btnbusca.Size = new System.Drawing.Size(100, 32);
            this.btnbusca.TabIndex = 176;
            this.btnbusca.Text = "Buscar";
            this.btnbusca.UseVisualStyleBackColor = true;
            this.btnbusca.Click += new System.EventHandler(this.btnbusca_Click);
            // 
            // FormContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(844, 720);
            this.Controls.Add(this.txtbusca);
            this.Controls.Add(this.btnbusca);
            this.Controls.Add(this.txtCodCr);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataConta);
            this.Controls.Add(this.dataCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContaReceber";
            this.Text = "FormContaPagar";
            this.Load += new System.EventHandler(this.FormContaReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataCliente;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAltera;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtValorParc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCr;
        private System.Windows.Forms.DataGridView dataConta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TipoPagamento;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Button btnbusca;
    }
}