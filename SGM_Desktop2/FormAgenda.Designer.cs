namespace SGM_Desktop2
{
    partial class FormAgenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btBuscaData = new System.Windows.Forms.Button();
            this.dataAgenda = new System.Windows.Forms.DateTimePicker();
            this.dtgAgen = new System.Windows.Forms.DataGridView();
            this.comboboxNome = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.horamarca = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAtribuir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboConta = new System.Windows.Forms.ComboBox();
            this.dateAgen = new System.Windows.Forms.DateTimePicker();
            this.textIDagenda = new System.Windows.Forms.TextBox();
            this.btexibAgen = new System.Windows.Forms.Button();
            this.btLimp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgen)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscaData
            // 
            this.btBuscaData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBuscaData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btBuscaData.FlatAppearance.BorderSize = 3;
            this.btBuscaData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btBuscaData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btBuscaData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscaData.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btBuscaData.ForeColor = System.Drawing.Color.White;
            this.btBuscaData.Location = new System.Drawing.Point(498, 45);
            this.btBuscaData.Name = "btBuscaData";
            this.btBuscaData.Size = new System.Drawing.Size(100, 41);
            this.btBuscaData.TabIndex = 74;
            this.btBuscaData.Text = "Buscar";
            this.btBuscaData.UseVisualStyleBackColor = true;
            this.btBuscaData.Click += new System.EventHandler(this.btBuscaData_Click);
            // 
            // dataAgenda
            // 
            this.dataAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataAgenda.CalendarFont = new System.Drawing.Font("Times New Roman", 15F);
            this.dataAgenda.CalendarForeColor = System.Drawing.Color.White;
            this.dataAgenda.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.dataAgenda.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dataAgenda.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dataAgenda.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dataAgenda.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.dataAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataAgenda.Location = new System.Drawing.Point(334, 48);
            this.dataAgenda.Name = "dataAgenda";
            this.dataAgenda.Size = new System.Drawing.Size(149, 30);
            this.dataAgenda.TabIndex = 75;
            this.dataAgenda.ValueChanged += new System.EventHandler(this.dataAgenda_ValueChanged);
            // 
            // dtgAgen
            // 
            this.dtgAgen.AllowDrop = true;
            this.dtgAgen.AllowUserToAddRows = false;
            this.dtgAgen.AllowUserToDeleteRows = false;
            this.dtgAgen.AllowUserToResizeColumns = false;
            this.dtgAgen.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dtgAgen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgAgen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAgen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAgen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.dtgAgen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgAgen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgAgen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgen.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAgen.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgAgen.Location = new System.Drawing.Point(155, 97);
            this.dtgAgen.Name = "dtgAgen";
            this.dtgAgen.ReadOnly = true;
            this.dtgAgen.RowHeadersVisible = false;
            this.dtgAgen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAgen.Size = new System.Drawing.Size(558, 150);
            this.dtgAgen.TabIndex = 76;
            this.dtgAgen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgen_CellClick);
            this.dtgAgen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgen_CellContentClick);
            // 
            // comboboxNome
            // 
            this.comboboxNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.comboboxNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboboxNome.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.comboboxNome.ForeColor = System.Drawing.Color.White;
            this.comboboxNome.FormattingEnabled = true;
            this.comboboxNome.Items.AddRange(new object[] {
            "Carro",
            "Moto",
            "Onibús",
            "Caminhão",
            "Quadriciculo",
            "Triciculo"});
            this.comboboxNome.Location = new System.Drawing.Point(77, 303);
            this.comboboxNome.Name = "comboboxNome";
            this.comboboxNome.Size = new System.Drawing.Size(493, 30);
            this.comboboxNome.TabIndex = 77;
            this.comboboxNome.Text = "Cliente";
            this.comboboxNome.SelectedIndexChanged += new System.EventHandler(this.comboboxNome_SelectedIndexChanged);
            this.comboboxNome.Click += new System.EventHandler(this.comboboxNome_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(8, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 78;
            this.label9.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(576, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 79;
            this.label1.Text = "Contato:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(8, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 101;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(255, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 102;
            this.label3.Text = "Hora:";
            // 
            // horamarca
            // 
            this.horamarca.CalendarForeColor = System.Drawing.Color.White;
            this.horamarca.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.horamarca.CalendarTitleBackColor = System.Drawing.Color.White;
            this.horamarca.CalendarTitleForeColor = System.Drawing.Color.White;
            this.horamarca.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.horamarca.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.horamarca.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.horamarca.Location = new System.Drawing.Point(317, 362);
            this.horamarca.Name = "horamarca";
            this.horamarca.ShowUpDown = true;
            this.horamarca.Size = new System.Drawing.Size(110, 30);
            this.horamarca.TabIndex = 103;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.txtDescricao.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(12, 446);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(823, 123);
            this.txtDescricao.TabIndex = 133;
            this.txtDescricao.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(8, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 134;
            this.label4.Text = "Descrição:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(524, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 135;
            this.button1.Text = "Agendar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(679, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 136;
            this.button2.Text = "Desmarcar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(438, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 137;
            this.label5.Text = "Atribuir:";
            // 
            // comboBoxAtribuir
            // 
            this.comboBoxAtribuir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAtribuir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.comboBoxAtribuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAtribuir.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.comboBoxAtribuir.ForeColor = System.Drawing.Color.White;
            this.comboBoxAtribuir.FormattingEnabled = true;
            this.comboBoxAtribuir.Location = new System.Drawing.Point(524, 362);
            this.comboBoxAtribuir.Name = "comboBoxAtribuir";
            this.comboBoxAtribuir.Size = new System.Drawing.Size(308, 30);
            this.comboBoxAtribuir.TabIndex = 138;
            this.comboBoxAtribuir.SelectedIndexChanged += new System.EventHandler(this.comboBoxAtribuir_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(8, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 139;
            this.label6.Text = "Codigo Agenda:";
            // 
            // comboConta
            // 
            this.comboConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.comboConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboConta.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.comboConta.ForeColor = System.Drawing.Color.White;
            this.comboConta.FormattingEnabled = true;
            this.comboConta.Location = new System.Drawing.Point(659, 303);
            this.comboConta.Name = "comboConta";
            this.comboConta.Size = new System.Drawing.Size(173, 30);
            this.comboConta.TabIndex = 141;
            this.comboConta.SelectedIndexChanged += new System.EventHandler(this.comboConta_SelectedIndexChanged);
            // 
            // dateAgen
            // 
            this.dateAgen.CalendarFont = new System.Drawing.Font("Times New Roman", 15F);
            this.dateAgen.CalendarForeColor = System.Drawing.Color.White;
            this.dateAgen.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.dateAgen.CalendarTitleBackColor = System.Drawing.Color.White;
            this.dateAgen.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateAgen.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dateAgen.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.dateAgen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAgen.Location = new System.Drawing.Point(77, 362);
            this.dateAgen.MinDate = new System.DateTime(2016, 11, 24, 0, 0, 0, 0);
            this.dateAgen.Name = "dateAgen";
            this.dateAgen.Size = new System.Drawing.Size(152, 30);
            this.dateAgen.TabIndex = 142;
            this.dateAgen.Value = new System.DateTime(2019, 5, 8, 0, 0, 0, 0);
            // 
            // textIDagenda
            // 
            this.textIDagenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.textIDagenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIDagenda.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.textIDagenda.ForeColor = System.Drawing.Color.White;
            this.textIDagenda.Location = new System.Drawing.Point(147, 265);
            this.textIDagenda.Name = "textIDagenda";
            this.textIDagenda.ReadOnly = true;
            this.textIDagenda.Size = new System.Drawing.Size(62, 23);
            this.textIDagenda.TabIndex = 143;
            // 
            // btexibAgen
            // 
            this.btexibAgen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btexibAgen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btexibAgen.FlatAppearance.BorderSize = 3;
            this.btexibAgen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btexibAgen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btexibAgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexibAgen.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btexibAgen.ForeColor = System.Drawing.Color.White;
            this.btexibAgen.Location = new System.Drawing.Point(613, 45);
            this.btexibAgen.Name = "btexibAgen";
            this.btexibAgen.Size = new System.Drawing.Size(100, 41);
            this.btexibAgen.TabIndex = 144;
            this.btexibAgen.Text = "Exibir";
            this.btexibAgen.UseVisualStyleBackColor = true;
            this.btexibAgen.Click += new System.EventHandler(this.btexibAgen_Click);
            // 
            // btLimp
            // 
            this.btLimp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLimp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btLimp.FlatAppearance.BorderSize = 4;
            this.btLimp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btLimp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btLimp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btLimp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLimp.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btLimp.ForeColor = System.Drawing.Color.White;
            this.btLimp.Location = new System.Drawing.Point(378, 623);
            this.btLimp.Name = "btLimp";
            this.btLimp.Size = new System.Drawing.Size(121, 40);
            this.btLimp.TabIndex = 145;
            this.btLimp.Text = "Limpar";
            this.btLimp.UseVisualStyleBackColor = true;
            this.btLimp.Click += new System.EventHandler(this.btLimp_Click);
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(844, 720);
            this.Controls.Add(this.btLimp);
            this.Controls.Add(this.btexibAgen);
            this.Controls.Add(this.textIDagenda);
            this.Controls.Add(this.dateAgen);
            this.Controls.Add(this.comboConta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxAtribuir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.horamarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboboxNome);
            this.Controls.Add(this.dtgAgen);
            this.Controls.Add(this.dataAgenda);
            this.Controls.Add(this.btBuscaData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgenda";
            this.Text = "FormAgenda";
            this.Load += new System.EventHandler(this.FormAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscaData;
        private System.Windows.Forms.DateTimePicker dataAgenda;
        private System.Windows.Forms.DataGridView dtgAgen;
        private System.Windows.Forms.ComboBox comboboxNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker horamarca;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAtribuir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboConta;
        private System.Windows.Forms.DateTimePicker dateAgen;
        private System.Windows.Forms.TextBox textIDagenda;
        private System.Windows.Forms.Button btexibAgen;
        private System.Windows.Forms.Button btLimp;
    }
}