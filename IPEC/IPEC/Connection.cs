﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace IPEC
{
    public class Connection
    {
        private static Connection instance=null;
        private SqlConnection connection;
        private Boolean usuario;

        private Connection() {
            //this.connection = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Programacion\\C#\\IPEC2\\IPEC\\IPEC\\basessssss.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            this.connection = new SqlConnection("Server=(local)\\SQLEXPRESS; integrated security=yes");
            //this.connection.Open();
        }
        public Boolean Usuario { get { return usuario; } set { usuario = value; } }
        public static Connection GetInstance
        {
          get
          {
             if (instance == null)
             {
                 instance = new Connection();
             }
             return instance;
          }
        }

        public SqlConnection sqlConnection { get { return this.connection; } }

        public void NewDB()
        {
            //ver si la db ya existe y preguntar si sobreescribrla o no
            this.connection.Open();
            String str = "if db_id('ipec_database') is null CREATE DATABASE ipec_database;";
            SqlCommand myCommand = new SqlCommand(str, this.connection);
            myCommand.ExecuteNonQuery();
            
            //INSERTs
            //if (connection.State == ConnectionState.Open)
            //{
            this.connection.Close();
            //}
        }

        public void newTablePerson()
        {
            this.connection.Open();
            String str = "USE ipec_database; " +
                "CREATE TABLE Persons(" +
                "PersonID int IDENTITY(1,1) PRIMARY KEY, " +
                "FirstName varchar(255) NOT NULL, " +
                "LastName varchar(255) NOT NULL, " +
                "dni int NOT NULL, " +
                "date_birth date NOT NULL, " +
                "country varchar(255) NOT NULL, " +
                "city varchar(255) NOT NULL, " +
                "email varchar(255), " +
                "phone varchar(255), " +
                "category varchar(255) NOT NULL, " +
                "start_date date NOT NULL, " +
                "modify_date date, " +
                "notes varchar(255), " +
                "picture image, " +
                "enabled bit, " +
                ");";
            SqlCommand myCommand = new SqlCommand(str, this.connection);
            myCommand.ExecuteNonQuery();
            this.connection.Close();
        }

        public void DeleteDB()
        {
            String str = "DROP DATABASE ipec_database";
            SqlCommand myCommand = new SqlCommand(str, connection);
            connection.Open();
            myCommand.ExecuteNonQuery();

            connection.Close();
        }

        public SqlDataReader ReadDB(String query)
        {
            SqlCommand myCommand = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader readDB = myCommand.ExecuteReader();
            connection.Close();
            return readDB;
        }

        public void WriteDB(String query)
        {
            SqlCommand myCommand = new SqlCommand(query, connection);
            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();
        }

        public bool ValidateDB()
        {

            return true;
        }
    }
}
