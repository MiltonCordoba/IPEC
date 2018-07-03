namespace IPEC
{
    partial class Form1
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
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.btn_log = new System.Windows.Forms.Button();
            this.cb_usuario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(201, 121);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.Size = new System.Drawing.Size(100, 20);
            this.tb_contraseña.TabIndex = 1;
            // 
            // btn_log
            // 
            this.btn_log.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_log.Location = new System.Drawing.Point(156, 155);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 23);
            this.btn_log.TabIndex = 2;
            this.btn_log.Text = "Entrar";
            this.btn_log.UseVisualStyleBackColor = false;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // cb_usuario
            // 
            this.cb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_usuario.FormattingEnabled = true;
            this.cb_usuario.Items.AddRange(new object[] {
            "Administrador",
            "Invitado"});
            this.cb_usuario.Location = new System.Drawing.Point(201, 85);
            this.cb_usuario.Name = "cb_usuario";
            this.cb_usuario.Size = new System.Drawing.Size(100, 21);
            this.cb_usuario.TabIndex = 3;
            this.cb_usuario.SelectedIndexChanged += new System.EventHandler(this.cb_usuario_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_log;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IPEC.Properties.Resources.WhatsApp_Image_2017_09_07_at_19_39_57;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(399, 190);
            this.Controls.Add(this.cb_usuario);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.tb_contraseña);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.ComboBox cb_usuario;
    }
}

