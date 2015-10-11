namespace WindowsFormsApplication1
{
    partial class mssLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mssLog));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomUsuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.entrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxtipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Firebrick;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // nomUsuario
            // 
            this.nomUsuario.Location = new System.Drawing.Point(214, 162);
            this.nomUsuario.Name = "nomUsuario";
            this.nomUsuario.Size = new System.Drawing.Size(160, 20);
            this.nomUsuario.TabIndex = 2;
            this.nomUsuario.TextChanged += new System.EventHandler(this.nomUsuario_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(214, 205);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(160, 20);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // entrar
            // 
            this.entrar.Location = new System.Drawing.Point(410, 269);
            this.entrar.Name = "entrar";
            this.entrar.Size = new System.Drawing.Size(95, 46);
            this.entrar.TabIndex = 4;
            this.entrar.Text = "Entrar";
            this.entrar.UseVisualStyleBackColor = true;
            this.entrar.Click += new System.EventHandler(this.entrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Firebrick;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base de Datos";
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(214, 65);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(160, 20);
            this.txtbase.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Autentificación";
            // 
            // cboxtipo
            // 
            this.cboxtipo.FormattingEnabled = true;
            this.cboxtipo.Location = new System.Drawing.Point(226, 10);
            this.cboxtipo.Name = "cboxtipo";
            this.cboxtipo.Size = new System.Drawing.Size(165, 21);
            this.cboxtipo.TabIndex = 8;
            this.cboxtipo.SelectedIndexChanged += new System.EventHandler(this.cboxtipo_SelectedIndexChanged);
            // 
            // mssLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(556, 386);
            this.Controls.Add(this.cboxtipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entrar);
            this.Controls.Add(this.password);
            this.Controls.Add(this.nomUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mssLog";
            this.Text = "Sql Server";
            this.Load += new System.EventHandler(this.mssLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomUsuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button entrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxtipo;
    }
}