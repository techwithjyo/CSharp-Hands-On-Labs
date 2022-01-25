using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DotNet___ADO_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DataReader Section
            ////Step 1 : Create Connection Object
            //SqlConnection sqlcon = new SqlConnection("Server=localhost;Database=dev1;Trusted_Connection=True;");
            //sqlcon.Open();

            ////Step 2 : Command (SQL)
            //SqlCommand sqlCommand = new SqlCommand("select * from Persons",sqlcon);


            ////SqlCommand sqlCommand1 = new SqlCommand();
            ////sqlCommand1.CommandText = "spSelectPersons";
            ////sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            ////sqlCommand1.Connection = sqlcon;

            ////Step 3 : Get the data from Datareader object to browse and fetch the data
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //while(sqlDataReader.Read())
            //{
            //    //Display Customer ID and Name
            //    Console.WriteLine(sqlDataReader["PersonID"]+" -- "+ sqlDataReader["FirstName"] + " "+ sqlDataReader["LastName"]);
            //}

            //sqlcon.Close();

            #endregion
            #region DataAdapter
            //Step 1 : Create Connection Object
            SqlConnection sqlcon = new SqlConnection("Server=localhost;Database=dev1;Trusted_Connection=True;");
            sqlcon.Open();

            //Step 2 : Command (SQL)
            SqlCommand sqlCommand = new SqlCommand("select * from Persons", sqlcon);


            //Step 3 : Get the data from Datasets
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine(dr["PersonID"]+" -- " + dr["FirstName"] + " " + dr["LastName"]);
            }

            sqlcon.Close();
            #endregion
        }
    }
}
