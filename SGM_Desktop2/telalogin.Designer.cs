namespace SGM_Desktop2
{
    partial class telalogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telalogin));
            this.caixausuario = new System.Windows.Forms.TextBox();
            this.linhausuario = new System.Windows.Forms.Panel();
            this.linhasenha = new System.Windows.Forms.Panel();
            this.caixasenha = new System.Windows.Forms.TextBox();
            this.iconesenha = new System.Windows.Forms.PictureBox();
            this.iconeusuario = new System.Windows.Forms.PictureBox();
            this.fechar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.entrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconesenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // caixausuario
            // 
            this.caixausuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixausuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixausuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.caixausuario.HideSelection = false;
            this.caixausuario.Location = new System.Drawing.Point(74, 196);
            this.caixausuario.Name = "caixausuario";
            this.caixausuario.Size = new System.Drawing.Size(230, 22);
            this.caixausuario.TabIndex = 4;
            this.caixausuario.TabStop = false;
            this.caixausuario.Text = "usuário";
            this.caixausuario.Click += new System.EventHandler(this.caixausuario_Click);
            this.caixausuario.TextChanged += new System.EventHandler(this.caixausuario_TextChanged);
            // 
            // linhausuario
            // 
            this.linhausuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.linhausuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.linhausuario.Location = new System.Drawing.Point(27, 224);
            this.linhausuario.Name = "linhausuario";
            this.linhausuario.Size = new System.Drawing.Size(285, 3);
            this.linhausuario.TabIndex = 5;
            // 
            // linhasenha
            // 
            this.linhasenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.linhasenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.linhasenha.Location = new System.Drawing.Point(27, 289);
            this.linhasenha.Name = "linhasenha";
            this.linhasenha.Size = new System.Drawing.Size(285, 3);
            this.linhasenha.TabIndex = 8;
            // 
            // caixasenha
            // 
            this.caixasenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixasenha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixasenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.caixasenha.HideSelection = false;
            this.caixasenha.Location = new System.Drawing.Point(74, 261);
            this.caixasenha.Name = "caixasenha";
            this.caixasenha.PasswordChar = '*';
            this.caixasenha.Size = new System.Drawing.Size(230, 22);
            this.caixasenha.TabIndex = 7;
            this.caixasenha.TabStop = false;
            this.caixasenha.Tag = "";
            this.caixasenha.Text = "Senha";
            this.caixasenha.Click += new System.EventHandler(this.caixasenha_Click);
            // 
            // iconesenha
            // 
            this.iconesenha.Image = ((System.Drawing.Image)(resources.GetObject("iconesenha.Image")));
            this.iconesenha.Location = new System.Drawing.Point(27, 251);
            this.iconesenha.Name = "iconesenha";
            this.iconesenha.Size = new System.Drawing.Size(32, 32);
            this.iconesenha.TabIndex = 6;
            this.iconesenha.TabStop = false;
            // 
            // iconeusuario
            // 
            this.iconeusuario.Image = global::SGM_Desktop2.Properties.Resources.pessoa;
            this.iconeusuario.Location = new System.Drawing.Point(27, 186);
            this.iconeusuario.Name = "iconeusuario";
            this.iconeusuario.Size = new System.Drawing.Size(32, 32);
            this.iconeusuario.TabIndex = 3;
            this.iconeusuario.TabStop = false;
            // 
            // fechar
            // 
            this.fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechar.Image = global::SGM_Desktop2.Properties.Resources.fechar1;
            this.fechar.Location = new System.Drawing.Point(298, 1);
            this.fechar.Name = "fechar";
            this.fechar.Size = new System.Drawing.Size(25, 25);
            this.fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fechar.TabIndex = 2;
            this.fechar.TabStop = false;
            this.fechar.Click += new System.EventHandler(this.fechar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Image = global::SGM_Desktop2.Properties.Resources.minimizar1;
            this.minimizar.Location = new System.Drawing.Point(270, 1);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(25, 25);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizar.TabIndex = 1;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // logo
            // 
            this.logo.Image = global::SGM_Desktop2.Properties.Resources.logo_sgm;
            this.logo.Location = new System.Drawing.Point(0, 27);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(330, 150);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // entrar
            // 
            this.entrar.BackColor = System.Drawing.Color.White;
            this.entrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.entrar.FlatAppearance.BorderSize = 2;
            this.entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entrar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(50)))));
            this.entrar.Location = new System.Drawing.Point(74, 358);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(172, 36);
            this.entrar.TabIndex = 9;
            this.entrar.Text = "ENTRAR";
            this.entrar.UseVisualStyleBackColor = false;
            this.entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(59, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 20;
            // 
            // telalogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.linhasenha);
            this.Controls.Add(this.caixasenha);
            this.Controls.Add(this.iconesenha);
            this.Controls.Add(this.linhausuario);
            this.Controls.Add(this.caixausuario);
            this.Controls.Add(this.iconeusuario);
            this.Controls.Add(this.fechar);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telalogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.telalogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iconesenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconeusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.PictureBox fechar;
        private System.Windows.Forms.PictureBox iconeusuario;
        private System.Windows.Forms.TextBox caixausuario;
        private System.Windows.Forms.Panel linhausuario;
        private System.Windows.Forms.Panel linhasenha;
        private System.Windows.Forms.TextBox caixasenha;
        private System.Windows.Forms.PictureBox iconesenha;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label label1;
    }
}

