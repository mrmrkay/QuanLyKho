﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Controller
{
    public class SqlConnect
    {
        private static SqlConnect instance;
        public static SqlConnect Instance
        {
            get { if (instance == null) instance = new SqlConnect(); return instance; }
            set { instance = value; }
        }
        //Data Source = MRMRKAY\SQLEXPRESS;Initial Catalog = QLKHO; Integrated Security = True
        private SqlConnect() { }

        private string connectionString = @"Data Source = MRMRKAY\SQLEXPRESS;Initial Catalog = QLKHO; Integrated Security = True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using(SqlConnection connect =new SqlConnection(connectionString))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }

            return data;
        }
        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                connect.Close();
            }
            
        }
    }
}
