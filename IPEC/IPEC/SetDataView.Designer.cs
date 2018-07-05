namespace IPEC
{
    partial class SetDataView
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.btnLoadPerson = new System.Windows.Forms.Button();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnLoadPhoto = new System.Windows.Forms.Button();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(7, 87);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 3;
            this.tbFirstName.Text = "Nombre";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(7, 113);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 3;
            this.tbDni.Text = "123456";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(7, 166);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Text = "Email";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(113, 166);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 3;
            this.tbPhone.Text = "Telefono";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(113, 113);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(100, 20);
            this.dtBirthDate.TabIndex = 4;
            // 
            // dtStartDate
            // 
            this.dtStartDate.CustomFormat = "dd-MM-yyyy";
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartDate.Location = new System.Drawing.Point(113, 193);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(100, 20);
            this.dtStartDate.TabIndex = 5;
            this.dtStartDate.Value = new System.DateTime(2018, 7, 5, 0, 0, 0, 0);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(7, 192);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(100, 21);
            this.cbCategory.TabIndex = 7;
            this.cbCategory.Text = "Categoria";
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(7, 139);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(100, 21);
            this.cbCountry.TabIndex = 8;
            this.cbCountry.Text = "Pais";
            // 
            // btnLoadPerson
            // 
            this.btnLoadPerson.Location = new System.Drawing.Point(269, 302);
            this.btnLoadPerson.Name = "btnLoadPerson";
            this.btnLoadPerson.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPerson.TabIndex = 9;
            this.btnLoadPerson.Text = "Cargar";
            this.btnLoadPerson.UseVisualStyleBackColor = true;
            this.btnLoadPerson.Click += new System.EventHandler(this.btnLoadPerson_Click);
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(7, 219);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(206, 106);
            this.tbNotes.TabIndex = 10;
            this.tbNotes.Text = "Notas";
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(369, 302);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(75, 23);
            this.btnShowList.TabIndex = 11;
            this.btnShowList.Text = "Datos";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(473, 302);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(352, 68);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(150, 124);
            this.pbPhoto.TabIndex = 13;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Location = new System.Drawing.Point(393, 198);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnLoadPhoto.TabIndex = 14;
            this.btnLoadPhoto.Text = "Cambiar";
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(113, 87);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(100, 20);
            this.tbLastname.TabIndex = 15;
            this.tbLastname.Text = "Apellidos";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(113, 139);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 17;
            this.tbCity.Text = "Ciudad";
            // 
            // SetDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IPEC.Properties.Resources.alta_socio;
            this.ClientSize = new System.Drawing.Size(560, 337);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbLastname);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.btnLoadPerson);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(576, 376);
            this.MinimumSize = new System.Drawing.Size(576, 376);
            this.Name = "SetDataView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPEC";
            this.Load += new System.EventHandler(this.SetDataView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Button btnLoadPerson;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Button btnLoadPhoto;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbCity;
    }
}