namespace CrudWC
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_incio = new System.Windows.Forms.Button();
            this.Txt_pass = new System.Windows.Forms.TextBox();
            this.Txt_usu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_incio
            // 
            this.btn_incio.BackColor = System.Drawing.Color.Transparent;
            this.btn_incio.Location = new System.Drawing.Point(268, 474);
            this.btn_incio.Name = "btn_incio";
            this.btn_incio.Size = new System.Drawing.Size(75, 23);
            this.btn_incio.TabIndex = 9;
            this.btn_incio.Text = "INGRESAR";
            this.btn_incio.UseVisualStyleBackColor = false;
            this.btn_incio.Click += new System.EventHandler(this.btn_incio_Click);
            // 
            // Txt_pass
            // 
            this.Txt_pass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_pass.Location = new System.Drawing.Point(184, 365);
            this.Txt_pass.Name = "Txt_pass";
            this.Txt_pass.PasswordChar = '+';
            this.Txt_pass.Size = new System.Drawing.Size(300, 20);
            this.Txt_pass.TabIndex = 8;
            this.Txt_pass.TextChanged += new System.EventHandler(this.Txt_pass_TextChanged);
            // 
            // Txt_usu
            // 
            this.Txt_usu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Txt_usu.Location = new System.Drawing.Point(184, 297);
            this.Txt_usu.Name = "Txt_usu";
            this.Txt_usu.Size = new System.Drawing.Size(300, 20);
            this.Txt_usu.TabIndex = 10;
            this.Txt_usu.TextChanged += new System.EventHandler(this.Txt_usu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(179, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "INGRESO AL SISTEMA";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(599, 527);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_usu);
            this.Controls.Add(this.btn_incio);
            this.Controls.Add(this.Txt_pass);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_incio;
        private System.Windows.Forms.TextBox Txt_pass;
        private System.Windows.Forms.TextBox Txt_usu;
        private System.Windows.Forms.Label label3;
    }
}