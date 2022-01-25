using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DotNet___ADO_DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1 : Create Connection Object
            SqlConnection sqlcon = new SqlConnection("Server=localhost;Database=dev1;Trusted_Connection=True;");
            sqlcon.Open();

            //Step 2 : Command (SQL)
            SqlCommand sqlCommand = new SqlCommand("select * from Persons",sqlcon);


            //SqlCommand sqlCommand1 = new SqlCommand();
            //sqlCommand1.CommandText = "spSelectPersons";
            //sqlCommand1.CommandType = System.Data.CommandType.StoredProcedure;
            //sqlCommand1.Connection = sqlcon;

            //Step 3 : Get the data from Datareader object to browse and fetch the data
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while(sqlDataReader.Read())
            {
                //Display Customer ID and Name
                Console.WriteLine(sqlDataReader["PersonID"]+" -- "+ sqlDataReader["FirstName"] + " "+ sqlDataReader["LastName"]);
            }

            sqlcon.Close();
        }
    }
}
