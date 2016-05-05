using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bangazon
{
    public class Product
    {
        public int idProduct { get; set; }
        public int idProductType { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string description { get; set; }

        public static List<Product> getProducts()
        {
            string query = @"
        SELECT * FROM Product
        ORDER BY Product.Name
      ";

            List<Product> productList = new List<Product>();

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Letch\\Documents\\Visual Studio 2015\\Projects\\BangazonExercise\\Bangazon\\Bangazon\\BangazonDatabase.mdf\";Integrated Security=True"))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read()) // Read advances to the next row.
                        {
                            // Construct Product object and add to list
                            Product currProd = new Product();
                            currProd.idProduct = (int)reader[0];
                            currProd.idProductType = (int)reader[1];
                            currProd.name = (string)reader[2];
                            currProd.price = (float)reader[3];
                            currProd.description = (string)reader[4];
                            productList.Add(currProd);
                        }
                    }
                }
            }
            return productList;
        } // End getProducts()
    }
}
