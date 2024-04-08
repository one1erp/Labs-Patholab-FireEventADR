using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a connection to Oracle
            string conString = "User Id=lims_sys; password=lims_sys;" +

            //How to connect to an Oracle DB without SQL*Net configuration file
            //also known as tnsnames.ora.
            //"Data Source=100.100.103.63:1522/NAUT; Pooling=false;";

            //How to connect to an Oracle Database with a Database alias.
            //Uncomment below and comment above.
            "Data Source=NAUT;Pooling=false;";

            OracleConnection con = new OracleConnection();
            con.ConnectionString = conString;
            con.Open();

            //Create a command within the context of the connection
            //Use the command to display employee names and salary from the Employees table
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from sdg where sdg_id > 10000 AND ROWNUM < 10";

            //Execute the command and use datareader to display the data
            OracleDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Employee Name: " + reader["NAME"]);
            }
            Console.ReadLine();

        }
    }
}
