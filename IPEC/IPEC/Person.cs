using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.SqlClient;

namespace IPEC
{
    class Person
    {
        private int personId;
        private String firstName, lastName, country, city, email, phone, category, notes;
        private int dni;
        private DateTime birthDate, startDate, modifyDate;
        private Boolean enabled;
        private Image picture;

        public Person()
        {

        }

        public int PersonId { get => personId; }
        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Category { get => category; set => category = value; }
        public string Notes { get => notes; set => notes = value; }
        public int Dni { get => dni; set => dni = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime ModifyDate { get => modifyDate; set => modifyDate = value; }
        public bool Enabled { get => enabled; set => enabled = value; }
        public Image Picture { get => picture; set => picture = value; }

        public override string ToString()
        {
            return "'" + firstName + "', '" + lastName + "', " + dni + ", " + birthDate + ", '" + country + "', '" + city + "', '" + category + "', " + startDate;
        }

       
    }
}