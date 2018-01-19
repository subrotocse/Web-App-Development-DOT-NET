using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace HelloMVC.DAL
{
    public class ItemGateway
    {

        string connectionString = WebConfigurationManager.ConnectionStrings["InventoryDbConnection"].ConnectionString.ToString();
        public dynamic Save(Item item)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Items(Name,UnitPrice) VALUES('" + item.Name + "','" + item.UnitPrice + "')";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public Item IsExist()
        {
             Item item = new Item();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from Items Where Name='"+item.Name+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
           SqlDataReader reader= command.ExecuteReader();
            while(reader.Read())
            {
               
                string name = reader["Name"].ToString();
                string unitPrice = reader["UnitPrice"].ToString();
            }
            reader.Close();
            connection.Close();
            return item;
        }
    }
}