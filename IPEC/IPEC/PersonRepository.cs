using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace IPEC
{
    class PersonRepository
    {
        private Connection Con;
        public PersonRepository()
        {
            Con = Connection.GetInstance;
        }

        public void CargarPersona(Person person)
        {
            int codigo=0;
            //SqlCommand consulta = new SqlCommand(String.Format("insert into Personas(codigo, nombre, dni, nacimiento, email, telefono, categoria, alta, modificacion, notas, foto) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", codigo, person.Nombre , person.Dni,person.Nacimiento, person.Email,person.Telefono,person.Categoria, person.Alta,person.Renovacion, person.Detalle, person.Foto), Con.sqlConnection);
        }

        public void EditarPersona(int codigo)
        {
           
            //comando.ExecuteNonQuery();
            SqlCommand consulta = new SqlCommand("", Con.sqlConnection);
        }


    }
}
