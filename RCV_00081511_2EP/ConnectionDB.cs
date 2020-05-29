﻿using System;
using System.Data;
using Npgsql;

namespace RCV_00081511_2EP
{
    public static class ConnectionDB
    {
        public static String host ="127.0.0.1",
            dataBase ="uca",
            userId ="postgres",
            pass ="1234";

        private static String sConnection = $"Server={host};Port={5432};User Id={userId};Password={pass};Database={dataBase};";

        public static DataTable executeQuery(String query)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            DataSet ds = new DataSet();
            connection.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
            da.Fill(ds);
            connection.Close();
            return ds.Tables[0];
        }
        
        public static void executeNonQuery(String act)
        {
            NpgsqlConnection connection = new NpgsqlConnection(sConnection);
            
            connection.Open();
            NpgsqlCommand command = new NpgsqlCommand(act,connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}