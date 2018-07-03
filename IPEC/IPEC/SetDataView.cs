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
        private Person person;
        private void btn_cargar_Click(object sender, EventArgs e)
        {
            
                person.FirstName = tb_name.Text;
                person.LastName = tb_lastname.Text;
                person.Dni = int.Parse(tb_dni.Text);
                person.BirthDate = dt_birthdate.Value.Date;
                person.City = cb_country.Text;
                person.Country = tb_city.Text;
                person.Email = tb_email.Text;
                person.Phone = tb_phone.Text;
                person.Category = cb_category.Text;
                person.StartDate = dt_startdate.Value.Date;
                person.ModifyDate = dt_modificacion.Value.Date;
                person.Notes = tb_notas.Text;
                person.Enabled = true;
            Connection.GetInstance.WriteDB("USE ipec_database; INSERT INTO Persons(FirstName, LastName, dni, date_birth, country, city, category, start_date) values(" + person.ToString() + ");");
            //Connection.GetInstance.WriteDB("USE ipec_database; INSERT INTO Persons(FirstName) values(" + person.ToString() + ");");

        }

        private void SetDataView_Load(object sender, EventArgs e)
        {
            person = new Person();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
