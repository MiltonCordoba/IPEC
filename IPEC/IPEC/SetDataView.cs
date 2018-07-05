using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IPEC
{
    public partial class SetDataView : Form
    {
        public SetDataView()
        {
            InitializeComponent();
        }
        private Person person;
        private String pathImage = "";
        private Image defaultImage;
        private Byte[] imageByteArray;

        private void SetDataView_Load(object sender, EventArgs e)
        {
            dtStartDate.Value = DateTime.Now;
            /*Connection.GetInstance.DeleteTable("Persons");
            Connection.GetInstance.newTablePersons();*/
        }

        private void btnLoadPhoto_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadPerson_Click(object sender, EventArgs e)
        {
            try
            {
                person = new Person();
                if (string.IsNullOrEmpty(tbFirstName.Text) || string.IsNullOrEmpty(tbLastname.Text)|| string.IsNullOrEmpty(tbDni.Text)|| string.IsNullOrEmpty(dtBirthDate.Text) || string.IsNullOrEmpty(tbCity.Text) || string.IsNullOrEmpty(cbCountry.Text) || string.IsNullOrEmpty(cbCategory.Text) || string.IsNullOrEmpty(dtStartDate.Text))
                {
                    throw new ArgumentException("Complete los campos", "");
                }
                person.FirstName = tbFirstName.Text;
                person.LastName = tbLastname.Text;
                person.Dni = int.Parse(tbDni.Text);
                person.BirthDate = dtStartDate.Value.Date.ToString("d");
                person.City = tbCity.Text;
                person.Country = cbCountry.Text;
                person.Email = tbEmail.Text;
                person.Phone = tbPhone.Text;
                person.Category = cbCategory.Text;
                person.StartDate = dtStartDate.Value.Date.ToString("d");
                person.Notes = tbNotes.Text;
                person.Enabled = true;
                Connection.GetInstance.WriteDB("USE ipec_database;\n" +
                    "INSERT INTO " +
                    "Persons (FirstName, LastName, dni, birth_date, country, city, category, start_date) " +
                    "values('" +
                    person.FirstName + "', '" +
                    person.LastName + "', " +
                    person.Dni + ", '" +
                    person.BirthDate + "', '" +
                    person.Country + "', '" +
                    person.City + "', '" +
                    person.Category + "', '" +
                    person.StartDate + "');");
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
            }
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "image files (*.jpg)|*.jpg";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathImage = openFileDialog.FileName;
                    Image image = new Bitmap(pathImage);
                    //Image image = Image.FromFile(pathImage);
                    pbPhoto.Image = image;
                    pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;                    
                    pbPhoto.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido " + ex.Message);
            }
        }

        private void loadImageProfile()
        {
            if(pathImage == "")
            {
                if(imageByteArray.Length != 0)
                {
                    imageByteArray = new byte[] { };
                }
                else
                {
                    Image temp = new Bitmap(pathImage);
                    MemoryStream strm = new MemoryStream();
                    temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
                    imageByteArray = strm.ToArray();
                }
            }
        }

        /*void RefreshImageGrid()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
            SqlDataAdapter sqlda = new SqlDataAdapter("ImageViewAll", sqlcon);
            sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtblImages = new DataTable();
            sqlda.Fill(dtblImages);
            dgvImages.DataSource = dtblImages;
            dgvImages.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvImages.Columns[2].Visible = false;
        }*/
    }
}
