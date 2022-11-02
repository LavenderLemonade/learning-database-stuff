using DatabaseStuff22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabaseStuff22.DAO
{
    public class ShoeSqlDao : IShoeDao
    {
        private readonly string connectiongString; //so, I think this is an internal holder for the actual URL to the SQL database that we'll pass this bad boy

        public ShoeSqlDao(string connString)
        {
            connectiongString = connString; //lmao I was right, we set it up with on inside, and use this cosntructor to bring it in from the outside
        }

        //so now we write a method to retrive a shoe from the database by way of an id we pass in 

        public Shoe GetShoe(int shoeId)
        {
            Shoe shoe = null; //we make an empty shoe object real quick

            using (SqlConnection conn = new SqlConnection(connectiongString)) //alright, this is where we initialize the connection 
            {
                conn.Open(); //this is where we open the connection, and where we're gonna be reading/holding the data we get

                SqlCommand cmd = new SqlCommand("SELECT * FROM shoe WHERE shoe_id = @shoe_id", conn); //so this is where we actually run that SQL command and toss the data onto the connection

                cmd.Parameters.AddWithValue("@shoe_id", shoeId); //this is where we make sure to slide in that shoe ID into the actual SQL command

                SqlDataReader reader = cmd.ExecuteReader(); //this starts the SQL command stuff idk what you want me to say here

                if (reader.Read())
                {
                    shoe = MakeShoeFromSQL(reader);
                }
            }
            return shoe;
        }

        public List<string> GetInventory()
        {
            List<string> allShoes = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectiongString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT DISTINCT shoe_name FROM shoe", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string shoe_name = Convert.ToString(reader["shoe_name"]);
                    allShoes.Add(shoe_name);
                }
            }
            return allShoes;
        }

        private Shoe MakeShoeFromSQL(SqlDataReader reader) //reading from the database into objects in C#
        {
            Shoe shoe = new Shoe();
            shoe.ShoeId = Convert.ToInt32(reader["shoe_id"]);
            shoe.ShoeName = Convert.ToString(reader["shoe_name"]);
            shoe.Manufacturer = Convert.ToString(reader["manufacturer"]);
            shoe.ShoeType = Convert.ToString(reader["shoe_type"]);
            shoe.ShoeSize = Convert.ToInt32(reader["shoe_size"]);
            shoe.Price = Convert.ToDecimal(reader["price"]);
            shoe.Quantity = Convert.ToInt32(reader["quantity"]);
            return shoe;

        }
    }
}
