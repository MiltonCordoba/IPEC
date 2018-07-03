﻿using System;
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
            cb_usuario.SelectedIndex = 0;
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (cb_usuario.Text.Equals("Administrador"))
            {
                if (tb_contraseña.Text.Equals("1234"))
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

        private void cb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_usuario.SelectedIndex == 1)
            {
                tb_contraseña.Enabled = false;
                tb_contraseña.BackColor = Color.Gray;
            }
            else
            {
                tb_contraseña.Enabled = true;
                tb_contraseña.BackColor = Color.White;
            }
        }


    }
}
