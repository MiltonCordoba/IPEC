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
    public partial class SetDataView : Form
    {
        public SetDataView()
        {
            InitializeComponent();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            
        }

        private void SetDataView_Load(object sender, EventArgs e)
        {
            Connection.GetInstance.NewDB();
            Connection.GetInstance.WriteDB("USE ipec_database; INSERT INTO Persons(FirstName, LastName, dni, date_birth, country, city, category, start_date) values('Milton', 'Cordoba', 30123123, CONVERT(date, '2010-08-25'), 'Argentina', 'Paraná', 'OWNER', CONVERT(date, '2017-08-25'));");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
