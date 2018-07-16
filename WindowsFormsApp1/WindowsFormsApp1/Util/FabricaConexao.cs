using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1
{
    static class FabricaConexao
    {
        static string serverName = "127.0.0.1";                                          //localhost
        static string port = "5432";                                                            //porta default
        static string userName = "postgres";                                               //nome do administrador
        static string password = "oitudobem";                                             //senha do administrador
        static string databaseName = "bancotestePessoa";  

        public static NpgsqlConnection getConexao()
        {
            string connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", serverName, port, userName, password, databaseName);
            NpgsqlConnection conn = new NpgsqlConnection(connString);

            return conn;
        }
    }
}
