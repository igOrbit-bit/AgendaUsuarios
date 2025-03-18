namespace AgendaApp
{
    partial class Form1
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
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.txtWhatsapp = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbWhatsapp = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbNome.Location = new System.Drawing.Point(48, 40);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(109, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(338, 31);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(390, 294);
            this.dgv_Usuarios.TabIndex = 3;
            // 
            // txtWhatsapp
            // 
            this.txtWhatsapp.Location = new System.Drawing.Point(144, 134);
            this.txtWhatsapp.Name = "txtWhatsapp";
            this.txtWhatsapp.Size = new System.Drawing.Size(100, 20);
            this.txtWhatsapp.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbEmail.Location = new System.Drawing.Point(48, 89);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(53, 20);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lbWhatsapp
            // 
            this.lbWhatsapp.AutoSize = true;
            this.lbWhatsapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhatsapp.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lbWhatsapp.Location = new System.Drawing.Point(48, 134);
            this.lbWhatsapp.Name = "lbWhatsapp";
            this.lbWhatsapp.Size = new System.Drawing.Size(90, 20);
            this.lbWhatsapp.TabIndex = 6;
            this.lbWhatsapp.Text = "Whatsapp";
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.Black;
            this.btAdicionar.Location = new System.Drawing.Point(52, 194);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(105, 36);
            this.btAdicionar.TabIndex = 8;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbWhatsapp);
            this.Controls.Add(this.txtWhatsapp);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.TextBox txtWhatsapp;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbWhatsapp;
        private System.Windows.Forms.Button btAdicionar;
    }
}

