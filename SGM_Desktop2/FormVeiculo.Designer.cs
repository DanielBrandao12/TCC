namespace SGM_Desktop2
{
    partial class FormVeiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tipoVec = new System.Windows.Forms.ComboBox();
            this.btCadVeic = new System.Windows.Forms.Button();
            this.dtGridVeic = new System.Windows.Forms.DataGridView();
            this.textBVeic = new System.Windows.Forms.TextBox();
            this.btBuscaVei = new System.Windows.Forms.Button();
            this.btExibeVei = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textIDCliente = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btAlteraVeic = new System.Windows.Forms.Button();
            this.btDelveic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VeicoId = new System.Windows.Forms.Label();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.btUploadVeic = new System.Windows.Forms.Button();
            this.btSalvarveic = new System.Windows.Forms.Button();
            this.txtimagem = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btLimp = new System.Windows.Forms.Button();
            this.btVolta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVeic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 60;
            this.label5.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtPlaca.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtPlaca.ForeColor = System.Drawing.Color.White;
            this.txtPlaca.Location = new System.Drawing.Point(96, 520);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(145, 30);
            this.txtPlaca.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtMarca.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtMarca.ForeColor = System.Drawing.Color.White;
            this.txtMarca.Location = new System.Drawing.Point(96, 413);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(287, 30);
            this.txtMarca.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Modelo:";
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtModelo.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtModelo.ForeColor = System.Drawing.Color.White;
            this.txtModelo.Location = new System.Drawing.Point(96, 467);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(287, 30);
            this.txtModelo.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(12, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 22);
            this.label9.TabIndex = 54;
            this.label9.Text = "Tipo:";
            // 
            // tipoVec
            // 
            this.tipoVec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.tipoVec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipoVec.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tipoVec.ForeColor = System.Drawing.Color.White;
            this.tipoVec.FormattingEnabled = true;
            this.tipoVec.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Onibús",
            "Caminhão",
            "Quadriciculo",
            "Triciculo"});
            this.tipoVec.Location = new System.Drawing.Point(96, 364);
            this.tipoVec.Name = "tipoVec";
            this.tipoVec.Size = new System.Drawing.Size(216, 30);
            this.tipoVec.TabIndex = 69;
            // 
            // btCadVeic
            // 
            this.btCadVeic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btCadVeic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btCadVeic.FlatAppearance.BorderSize = 4;
            this.btCadVeic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btCadVeic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btCadVeic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btCadVeic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadVeic.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btCadVeic.ForeColor = System.Drawing.Color.White;
            this.btCadVeic.Location = new System.Drawing.Point(408, 625);
            this.btCadVeic.Name = "btCadVeic";
            this.btCadVeic.Size = new System.Drawing.Size(121, 40);
            this.btCadVeic.TabIndex = 70;
            this.btCadVeic.Text = "Cadastrar";
            this.btCadVeic.UseVisualStyleBackColor = true;
            this.btCadVeic.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtGridVeic
            // 
            this.dtGridVeic.AllowUserToAddRows = false;
            this.dtGridVeic.AllowUserToDeleteRows = false;
            this.dtGridVeic.AllowUserToResizeColumns = false;
            this.dtGridVeic.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dtGridVeic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridVeic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridVeic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridVeic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dtGridVeic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridVeic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridVeic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridVeic.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridVeic.GridColor = System.Drawing.Color.Black;
            this.dtGridVeic.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtGridVeic.Location = new System.Drawing.Point(12, 96);
            this.dtGridVeic.MultiSelect = false;
            this.dtGridVeic.Name = "dtGridVeic";
            this.dtGridVeic.RowHeadersVisible = false;
            this.dtGridVeic.RowHeadersWidth = 10;
            this.dtGridVeic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridVeic.Size = new System.Drawing.Size(820, 150);
            this.dtGridVeic.TabIndex = 71;
            this.dtGridVeic.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridVeic_CellContentClick);
            this.dtGridVeic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridVeic_CellContentClick_1);
            // 
            // textBVeic
            // 
            this.textBVeic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBVeic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.textBVeic.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.textBVeic.ForeColor = System.Drawing.Color.White;
            this.textBVeic.Location = new System.Drawing.Point(331, 47);
            this.textBVeic.Name = "textBVeic";
            this.textBVeic.Size = new System.Drawing.Size(289, 30);
            this.textBVeic.TabIndex = 72;
            this.textBVeic.Text = "Nome";
            this.textBVeic.Click += new System.EventHandler(this.textBVeic_Click);
            // 
            // btBuscaVei
            // 
            this.btBuscaVei.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscaVei.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBuscaVei.FlatAppearance.BorderSize = 3;
            this.btBuscaVei.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btBuscaVei.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btBuscaVei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscaVei.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscaVei.ForeColor = System.Drawing.Color.White;
            this.btBuscaVei.Location = new System.Drawing.Point(626, 47);
            this.btBuscaVei.Name = "btBuscaVei";
            this.btBuscaVei.Size = new System.Drawing.Size(100, 30);
            this.btBuscaVei.TabIndex = 73;
            this.btBuscaVei.Text = "Buscar";
            this.btBuscaVei.UseVisualStyleBackColor = true;
            this.btBuscaVei.Click += new System.EventHandler(this.btBuscaVei_Click);
            // 
            // btExibeVei
            // 
            this.btExibeVei.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btExibeVei.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btExibeVei.FlatAppearance.BorderSize = 3;
            this.btExibeVei.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btExibeVei.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btExibeVei.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExibeVei.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExibeVei.ForeColor = System.Drawing.Color.White;
            this.btExibeVei.Location = new System.Drawing.Point(732, 47);
            this.btExibeVei.Name = "btExibeVei";
            this.btExibeVei.Size = new System.Drawing.Size(100, 30);
            this.btExibeVei.TabIndex = 74;
            this.btExibeVei.Text = "Exibir";
            this.btExibeVei.UseVisualStyleBackColor = true;
            this.btExibeVei.Click += new System.EventHandler(this.btExibeVei_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 22);
            this.label7.TabIndex = 62;
            this.label7.Text = "Código do Cliente:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textIDCliente
            // 
            this.textIDCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.textIDCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIDCliente.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.textIDCliente.ForeColor = System.Drawing.Color.White;
            this.textIDCliente.Location = new System.Drawing.Point(179, 270);
            this.textIDCliente.Name = "textIDCliente";
            this.textIDCliente.ReadOnly = true;
            this.textIDCliente.Size = new System.Drawing.Size(62, 23);
            this.textIDCliente.TabIndex = 75;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btAlteraVeic
            // 
            this.btAlteraVeic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btAlteraVeic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btAlteraVeic.FlatAppearance.BorderSize = 4;
            this.btAlteraVeic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btAlteraVeic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btAlteraVeic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btAlteraVeic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlteraVeic.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btAlteraVeic.ForeColor = System.Drawing.Color.White;
            this.btAlteraVeic.Location = new System.Drawing.Point(535, 625);
            this.btAlteraVeic.Name = "btAlteraVeic";
            this.btAlteraVeic.Size = new System.Drawing.Size(121, 40);
            this.btAlteraVeic.TabIndex = 78;
            this.btAlteraVeic.Text = "Alterar";
            this.btAlteraVeic.UseVisualStyleBackColor = true;
            this.btAlteraVeic.Click += new System.EventHandler(this.btAlteraVeic_Click);
            // 
            // btDelveic
            // 
            this.btDelveic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btDelveic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btDelveic.FlatAppearance.BorderSize = 4;
            this.btDelveic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btDelveic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btDelveic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btDelveic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelveic.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btDelveic.ForeColor = System.Drawing.Color.White;
            this.btDelveic.Location = new System.Drawing.Point(662, 625);
            this.btDelveic.Name = "btDelveic";
            this.btDelveic.Size = new System.Drawing.Size(121, 40);
            this.btDelveic.TabIndex = 79;
            this.btDelveic.Text = "Deletar";
            this.btDelveic.UseVisualStyleBackColor = true;
            this.btDelveic.Click += new System.EventHandler(this.btDelveic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ano:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 22);
            this.label6.TabIndex = 80;
            this.label6.Text = "Código do Veiculo:";
            // 
            // VeicoId
            // 
            this.VeicoId.AutoSize = true;
            this.VeicoId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.VeicoId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VeicoId.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.VeicoId.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VeicoId.Location = new System.Drawing.Point(183, 316);
            this.VeicoId.Name = "VeicoId";
            this.VeicoId.Size = new System.Drawing.Size(0, 22);
            this.VeicoId.TabIndex = 83;
            // 
            // image1
            // 
            this.image1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.image1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.image1.Location = new System.Drawing.Point(448, 262);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(335, 235);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image1.TabIndex = 84;
            this.image1.TabStop = false;
            // 
            // btUploadVeic
            // 
            this.btUploadVeic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btUploadVeic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btUploadVeic.FlatAppearance.BorderSize = 4;
            this.btUploadVeic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btUploadVeic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btUploadVeic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUploadVeic.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUploadVeic.ForeColor = System.Drawing.Color.White;
            this.btUploadVeic.Location = new System.Drawing.Point(603, 525);
            this.btUploadVeic.Name = "btUploadVeic";
            this.btUploadVeic.Size = new System.Drawing.Size(90, 31);
            this.btUploadVeic.TabIndex = 85;
            this.btUploadVeic.Text = "Abrir";
            this.btUploadVeic.UseVisualStyleBackColor = true;
            this.btUploadVeic.Click += new System.EventHandler(this.btUploadVeic_Click);
            // 
            // btSalvarveic
            // 
            this.btSalvarveic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btSalvarveic.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSalvarveic.FlatAppearance.BorderSize = 4;
            this.btSalvarveic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btSalvarveic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btSalvarveic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvarveic.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarveic.ForeColor = System.Drawing.Color.White;
            this.btSalvarveic.Location = new System.Drawing.Point(699, 525);
            this.btSalvarveic.Name = "btSalvarveic";
            this.btSalvarveic.Size = new System.Drawing.Size(84, 31);
            this.btSalvarveic.TabIndex = 87;
            this.btSalvarveic.Text = "Salvar";
            this.btSalvarveic.UseVisualStyleBackColor = true;
            this.btSalvarveic.Click += new System.EventHandler(this.btSalvarveic_Click);
            // 
            // txtimagem
            // 
            this.txtimagem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtimagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.txtimagem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtimagem.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtimagem.ForeColor = System.Drawing.Color.White;
            this.txtimagem.Location = new System.Drawing.Point(448, 503);
            this.txtimagem.Name = "txtimagem";
            this.txtimagem.Size = new System.Drawing.Size(335, 13);
            this.txtimagem.TabIndex = 88;
            // 
            // txtAno
            // 
            this.txtAno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtAno.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtAno.ForeColor = System.Drawing.Color.White;
            this.txtAno.Location = new System.Drawing.Point(96, 573);
            this.txtAno.MinimumSize = new System.Drawing.Size(10, 10);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 30);
            this.txtAno.TabIndex = 76;
            this.txtAno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAno_KeyPress);
            // 
            // btLimp
            // 
            this.btLimp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btLimp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLimp.FlatAppearance.BorderSize = 4;
            this.btLimp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btLimp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btLimp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btLimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimp.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btLimp.ForeColor = System.Drawing.Color.White;
            this.btLimp.Location = new System.Drawing.Point(281, 625);
            this.btLimp.Name = "btLimp";
            this.btLimp.Size = new System.Drawing.Size(121, 40);
            this.btLimp.TabIndex = 89;
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
            this.btVolta.Location = new System.Drawing.Point(262, 47);
            this.btVolta.Name = "btVolta";
            this.btVolta.Size = new System.Drawing.Size(63, 30);
            this.btVolta.TabIndex = 90;
            this.btVolta.Text = "<";
            this.btVolta.UseVisualStyleBackColor = true;
            this.btVolta.Click += new System.EventHandler(this.btVolta_Click);
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(844, 720);
            this.Controls.Add(this.btVolta);
            this.Controls.Add(this.btLimp);
            this.Controls.Add(this.txtimagem);
            this.Controls.Add(this.btSalvarveic);
            this.Controls.Add(this.btUploadVeic);
            this.Controls.Add(this.image1);
            this.Controls.Add(this.VeicoId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btDelveic);
            this.Controls.Add(this.btAlteraVeic);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.textIDCliente);
            this.Controls.Add(this.btExibeVei);
            this.Controls.Add(this.btBuscaVei);
            this.Controls.Add(this.textBVeic);
            this.Controls.Add(this.btCadVeic);
            this.Controls.Add(this.tipoVec);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtGridVeic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVeiculo";
            this.Text = "2";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVeic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox tipoVec;
        private System.Windows.Forms.Button btCadVeic;
        private System.Windows.Forms.DataGridView dtGridVeic;
        private System.Windows.Forms.TextBox textBVeic;
        private System.Windows.Forms.Button btBuscaVei;
        private System.Windows.Forms.Button btExibeVei;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textIDCliente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btDelveic;
        private System.Windows.Forms.Button btAlteraVeic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VeicoId;
        private System.Windows.Forms.Button btUploadVeic;
        private System.Windows.Forms.PictureBox image1;
        private System.Windows.Forms.Button btSalvarveic;
        private System.Windows.Forms.TextBox txtimagem;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btLimp;
        private System.Windows.Forms.Button btVolta;
    }
}