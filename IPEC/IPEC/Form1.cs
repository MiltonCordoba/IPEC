using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPEC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Connection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            cbUserName.SelectedIndex = 0;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (cbUserName.Text.Equals("Administrador"))
            {
                if (tbPassword.Text.Equals("1234"))
                {
                    con = Connection.GetInstance;
                    con.Usuario = true;
                    SetDataView screenView = new SetDataView();
                    this.Hide();
                    screenView.ShowDialog();
                    this.Close();
                }
                else { MessageBox.Show("Contraseña Incorrecta para aministrador"); }
            }
            else
            {
                con = Connection.GetInstance;
                con.Usuario = false;
                SetDataView screenView = new SetDataView();
                screenView.Show();
            }
        }

        private void cbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbUserName.SelectedIndex == 1)
            {
                tbPassword.Enabled = false;
                tbPassword.BackColor = Color.Gray;
            }
            else
            {
                tbPassword.Enabled = true;
                tbPassword.BackColor = Color.White;
            }
        }
    }
}
