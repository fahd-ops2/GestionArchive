﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ClassLibrary
{
    public class Singleton
    {
        private SqlConnection connection = null;
        private static Singleton _instance = null;

        public Singleton()
        {
            try
            {
                
                //Data Source=192.168.1.6\SERVER;Initial Catalog=LyceeIbnSina;User ID=sa;Password=***********
                string connectionString2 = @"Data Source=192.168.1.6;Initial Catalog=LyceeIbnSina;User ID=fahd;Password=azertyuiop789;";
                connection = new SqlConnection(connectionString2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Signleton : " + ex.Message);
            }
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
                _instance = new Singleton();
            return _instance;
        }

        public SqlConnection GetConnection()
        {
            return this.connection;
        }
    }
}
