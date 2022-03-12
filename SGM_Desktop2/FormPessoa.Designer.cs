namespace SGM_Desktop2
{
    partial class FormPessoa
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
            this.labelcnpj = new System.Windows.Forms.Label();
            this.txtrazao = new System.Windows.Forms.TextBox();
            this.labelrazao = new System.Windows.Forms.Label();
            this.labelfantasia = new System.Windows.Forms.Label();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.panelPessoa1 = new System.Windows.Forms.Panel();
            this.txtCel = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.radioPf = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.labelsexo = new System.Windows.Forms.Label();
            this.btnAlteraC = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCadastrarP = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.radioPj = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboUf = new System.Windows.Forms.TextBox();
            this.labelnome = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelcpf = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtfantasia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcomple = new System.Windows.Forms.TextBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.panelPessoa = new System.Windows.Forms.Panel();
            this.panelPessoa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelcnpj
            // 
            this.labelcnpj.AutoSize = true;
            this.labelcnpj.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcnpj.Location = new System.Drawing.Point(14, 146);
            this.labelcnpj.Name = "labelcnpj";
            this.labelcnpj.Size = new System.Drawing.Size(62, 22);
            this.labelcnpj.TabIndex = 17;
            this.labelcnpj.Text = "CNPJ:";
            this.labelcnpj.Visible = false;
            // 
            // txtrazao
            // 
            this.txtrazao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrazao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtrazao.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtrazao.ForeColor = System.Drawing.Color.White;
            this.txtrazao.Location = new System.Drawing.Point(413, 81);
            this.txtrazao.Name = "txtrazao";
            this.txtrazao.Size = new System.Drawing.Size(399, 30);
            this.txtrazao.TabIndex = 22;
            this.txtrazao.Visible = false;
            // 
            // labelrazao
            // 
            this.labelrazao.AutoSize = true;
            this.labelrazao.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrazao.Location = new System.Drawing.Point(281, 88);
            this.labelrazao.Name = "labelrazao";
            this.labelrazao.Size = new System.Drawing.Size(121, 22);
            this.labelrazao.TabIndex = 21;
            this.labelrazao.Text = "Razão Social:";
            this.labelrazao.Visible = false;
            this.labelrazao.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelfantasia
            // 
            this.labelfantasia.AutoSize = true;
            this.labelfantasia.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfantasia.Location = new System.Drawing.Point(287, 147);
            this.labelfantasia.Name = "labelfantasia";
            this.labelfantasia.Size = new System.Drawing.Size(134, 22);
            this.labelfantasia.TabIndex = 23;
            this.labelfantasia.Text = "Nome Fantasia:";
            this.labelfantasia.Visible = false;
            // 
            // txtcnpj
            // 
            this.txtcnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtcnpj.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtcnpj.ForeColor = System.Drawing.Color.White;
            this.txtcnpj.Location = new System.Drawing.Point(81, 138);
            this.txtcnpj.Mask = "##,###,###/####-##";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(196, 30);
            this.txtcnpj.TabIndex = 45;
            // 
            // panelPessoa1
            // 
            this.panelPessoa1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPessoa1.Controls.Add(this.txtCel);
            this.panelPessoa1.Controls.Add(this.txtTelefone);
            this.panelPessoa1.Controls.Add(this.radioPf);
            this.panelPessoa1.Controls.Add(this.button1);
            this.panelPessoa1.Controls.Add(this.labelsexo);
            this.panelPessoa1.Controls.Add(this.btnAlteraC);
            this.panelPessoa1.Controls.Add(this.label11);
            this.panelPessoa1.Controls.Add(this.btnCadastrarP);
            this.panelPessoa1.Controls.Add(this.label12);
            this.panelPessoa1.Controls.Add(this.txtEmail);
            this.panelPessoa1.Controls.Add(this.radioPj);
            this.panelPessoa1.Controls.Add(this.label10);
            this.panelPessoa1.Controls.Add(this.button2);
            this.panelPessoa1.Controls.Add(this.txtnome);
            this.panelPessoa1.Controls.Add(this.label9);
            this.panelPessoa1.Controls.Add(this.txtCep);
            this.panelPessoa1.Controls.Add(this.label8);
            this.panelPessoa1.Controls.Add(this.txtrazao);
            this.panelPessoa1.Controls.Add(this.comboUf);
            this.panelPessoa1.Controls.Add(this.labelrazao);
            this.panelPessoa1.Controls.Add(this.labelnome);
            this.panelPessoa1.Controls.Add(this.comboTipo);
            this.panelPessoa1.Controls.Add(this.label3);
            this.panelPessoa1.Controls.Add(this.labelcnpj);
            this.panelPessoa1.Controls.Add(this.label7);
            this.panelPessoa1.Controls.Add(this.labelcpf);
            this.panelPessoa1.Controls.Add(this.txtcidade);
            this.panelPessoa1.Controls.Add(this.txtfantasia);
            this.panelPessoa1.Controls.Add(this.labelfantasia);
            this.panelPessoa1.Controls.Add(this.label6);
            this.panelPessoa1.Controls.Add(this.txtcomple);
            this.panelPessoa1.Controls.Add(this.comboSexo);
            this.panelPessoa1.Controls.Add(this.label1);
            this.panelPessoa1.Controls.Add(this.txtrua);
            this.panelPessoa1.Controls.Add(this.txtbairro);
            this.panelPessoa1.Controls.Add(this.label5);
            this.panelPessoa1.Controls.Add(this.label4);
            this.panelPessoa1.Controls.Add(this.txtnumero);
            this.panelPessoa1.Controls.Add(this.txtcpf);
            this.panelPessoa1.Controls.Add(this.txtcnpj);
            this.panelPessoa1.Location = new System.Drawing.Point(0, 12);
            this.panelPessoa1.Name = "panelPessoa1";
            this.panelPessoa1.Size = new System.Drawing.Size(834, 705);
            this.panelPessoa1.TabIndex = 54;
            this.panelPessoa1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPessoa_Paint);
            // 
            // txtCel
            // 
            this.txtCel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtCel.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtCel.ForeColor = System.Drawing.Color.White;
            this.txtCel.Location = new System.Drawing.Point(583, 431);
            this.txtCel.Mask = "(99)0 0000-0000";
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(225, 30);
            this.txtCel.TabIndex = 55;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtTelefone.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtTelefone.ForeColor = System.Drawing.Color.White;
            this.txtTelefone.Location = new System.Drawing.Point(235, 431);
            this.txtTelefone.Mask = "(99)0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(215, 30);
            this.txtTelefone.TabIndex = 54;
            // 
            // radioPf
            // 
            this.radioPf.AutoSize = true;
            this.radioPf.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPf.Location = new System.Drawing.Point(18, 43);
            this.radioPf.Name = "radioPf";
            this.radioPf.Size = new System.Drawing.Size(132, 25);
            this.radioPf.TabIndex = 13;
            this.radioPf.TabStop = true;
            this.radioPf.Text = "Pessoa Fisíca";
            this.radioPf.UseVisualStyleBackColor = true;
            this.radioPf.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 4;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(583, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 51);
            this.button1.TabIndex = 52;
            this.button1.Text = "Alterar Fornecedores";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelsexo
            // 
            this.labelsexo.AutoSize = true;
            this.labelsexo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsexo.Location = new System.Drawing.Point(301, 146);
            this.labelsexo.Name = "labelsexo";
            this.labelsexo.Size = new System.Drawing.Size(55, 22);
            this.labelsexo.TabIndex = 53;
            this.labelsexo.Text = "Sexo:";
            // 
            // btnAlteraC
            // 
            this.btnAlteraC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlteraC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAlteraC.FlatAppearance.BorderSize = 4;
            this.btnAlteraC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAlteraC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnAlteraC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlteraC.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraC.ForeColor = System.Drawing.Color.White;
            this.btnAlteraC.Location = new System.Drawing.Point(402, 602);
            this.btnAlteraC.Name = "btnAlteraC";
            this.btnAlteraC.Size = new System.Drawing.Size(160, 51);
            this.btnAlteraC.TabIndex = 51;
            this.btnAlteraC.Text = "Alterar Clientes";
            this.btnAlteraC.UseVisualStyleBackColor = true;
            this.btnAlteraC.Click += new System.EventHandler(this.btnAlteraP_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label11.Location = new System.Drawing.Point(14, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 22);
            this.label11.TabIndex = 41;
            this.label11.Text = "E-mail:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // btnCadastrarP
            // 
            this.btnCadastrarP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCadastrarP.FlatAppearance.BorderSize = 4;
            this.btnCadastrarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCadastrarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCadastrarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarP.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarP.Location = new System.Drawing.Point(210, 602);
            this.btnCadastrarP.Name = "btnCadastrarP";
            this.btnCadastrarP.Size = new System.Drawing.Size(158, 51);
            this.btnCadastrarP.TabIndex = 43;
            this.btnCadastrarP.Text = "Cadastrar";
            this.btnCadastrarP.UseVisualStyleBackColor = true;
            this.btnCadastrarP.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label12.Location = new System.Drawing.Point(678, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 22);
            this.label12.TabIndex = 50;
            this.label12.Text = "UF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(115, 501);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(693, 30);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // radioPj
            // 
            this.radioPj.AutoSize = true;
            this.radioPj.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPj.Location = new System.Drawing.Point(168, 43);
            this.radioPj.Name = "radioPj";
            this.radioPj.Size = new System.Drawing.Size(145, 25);
            this.radioPj.TabIndex = 14;
            this.radioPj.TabStop = true;
            this.radioPj.Text = "Pessoa Juridíca";
            this.radioPj.UseVisualStyleBackColor = true;
            this.radioPj.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label10.Location = new System.Drawing.Point(487, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 22);
            this.label10.TabIndex = 39;
            this.label10.Text = "Celular:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(251, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 30);
            this.button2.TabIndex = 49;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnome
            // 
            this.txtnome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtnome.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtnome.ForeColor = System.Drawing.Color.White;
            this.txtnome.Location = new System.Drawing.Point(357, 81);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(455, 30);
            this.txtnome.TabIndex = 5;
            this.txtnome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label9.Location = new System.Drawing.Point(14, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Telefone residencial:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtCep
            // 
            this.txtCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtCep.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtCep.ForeColor = System.Drawing.Color.White;
            this.txtCep.Location = new System.Drawing.Point(66, 203);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(179, 30);
            this.txtCep.TabIndex = 48;
            this.txtCep.TextChanged += new System.EventHandler(this.txtCep_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 47;
            this.label8.Text = "CEP:";
            // 
            // comboUf
            // 
            this.comboUf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.comboUf.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.comboUf.ForeColor = System.Drawing.Color.White;
            this.comboUf.Location = new System.Drawing.Point(724, 204);
            this.comboUf.Name = "comboUf";
            this.comboUf.Size = new System.Drawing.Size(88, 30);
            this.comboUf.TabIndex = 46;
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome.Location = new System.Drawing.Point(283, 88);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(63, 22);
            this.labelnome.TabIndex = 4;
            this.labelnome.Text = "Nome:";
            // 
            // comboTipo
            // 
            this.comboTipo.AllowDrop = true;
            this.comboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.comboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboTipo.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.comboTipo.ForeColor = System.Drawing.Color.White;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Cliente ",
            "Fornecedor"});
            this.comboTipo.Location = new System.Drawing.Point(81, 85);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboTipo.Size = new System.Drawing.Size(197, 30);
            this.comboTipo.TabIndex = 15;
            this.comboTipo.SelectedIndexChanged += new System.EventHandler(this.comboTipo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tipo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label7.Location = new System.Drawing.Point(341, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Cidade:";
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcpf.Location = new System.Drawing.Point(9, 146);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(51, 22);
            this.labelcpf.TabIndex = 11;
            this.labelcpf.Text = "CPF:";
            // 
            // txtcidade
            // 
            this.txtcidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtcidade.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtcidade.ForeColor = System.Drawing.Color.White;
            this.txtcidade.Location = new System.Drawing.Point(420, 204);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(255, 30);
            this.txtcidade.TabIndex = 34;
            // 
            // txtfantasia
            // 
            this.txtfantasia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfantasia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtfantasia.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtfantasia.ForeColor = System.Drawing.Color.White;
            this.txtfantasia.Location = new System.Drawing.Point(418, 140);
            this.txtfantasia.Name = "txtfantasia";
            this.txtfantasia.Size = new System.Drawing.Size(394, 30);
            this.txtfantasia.TabIndex = 24;
            this.txtfantasia.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 31;
            this.label6.Text = "Complemento:";
            // 
            // txtcomple
            // 
            this.txtcomple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcomple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtcomple.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtcomple.ForeColor = System.Drawing.Color.White;
            this.txtcomple.Location = new System.Drawing.Point(151, 262);
            this.txtcomple.Name = "txtcomple";
            this.txtcomple.Size = new System.Drawing.Size(284, 30);
            this.txtcomple.TabIndex = 32;
            // 
            // comboSexo
            // 
            this.comboSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.comboSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboSexo.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.comboSexo.ForeColor = System.Drawing.Color.White;
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.comboSexo.Location = new System.Drawing.Point(362, 140);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(143, 30);
            this.comboSexo.TabIndex = 20;
            this.comboSexo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.Location = new System.Drawing.Point(441, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Bairro:";
            // 
            // txtrua
            // 
            this.txtrua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtrua.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtrua.ForeColor = System.Drawing.Color.White;
            this.txtrua.Location = new System.Drawing.Point(72, 333);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(566, 30);
            this.txtrua.TabIndex = 28;
            // 
            // txtbairro
            // 
            this.txtbairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtbairro.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtbairro.ForeColor = System.Drawing.Color.White;
            this.txtbairro.Location = new System.Drawing.Point(515, 267);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(293, 30);
            this.txtbairro.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(658, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Número:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Rua:";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // txtnumero
            // 
            this.txtnumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtnumero.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtnumero.ForeColor = System.Drawing.Color.White;
            this.txtnumero.Location = new System.Drawing.Point(747, 333);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(61, 30);
            this.txtnumero.TabIndex = 30;
            // 
            // txtcpf
            // 
            this.txtcpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtcpf.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtcpf.ForeColor = System.Drawing.Color.White;
            this.txtcpf.Location = new System.Drawing.Point(81, 139);
            this.txtcpf.Mask = "###,###,###-##";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(196, 30);
            this.txtcpf.TabIndex = 44;
            this.txtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtcpf_MaskInputRejected);
            // 
            // panelPessoa
            // 
            this.panelPessoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPessoa.Location = new System.Drawing.Point(0, 0);
            this.panelPessoa.Name = "panelPessoa";
            this.panelPessoa.Size = new System.Drawing.Size(833, 720);
            this.panelPessoa.TabIndex = 54;
            this.panelPessoa.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPessoa_Paint_1);
            // 
            // FormPessoa
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(833, 720);
            this.Controls.Add(this.panelPessoa1);
            this.Controls.Add(this.panelPessoa);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPessoa";
            this.Load += new System.EventHandler(this.subForm1_Load);
            this.panelPessoa1.ResumeLayout(false);
            this.panelPessoa1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelcnpj;
        private System.Windows.Forms.TextBox txtrazao;
        private System.Windows.Forms.Label labelrazao;
        private System.Windows.Forms.Label labelfantasia;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.Panel panelPessoa1;
        private System.Windows.Forms.RadioButton radioPf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelsexo;
        private System.Windows.Forms.Button btnAlteraC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCadastrarP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton radioPj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox comboUf;
        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelcpf;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtfantasia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcomple;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Panel panelPessoa;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCel;
    }
}