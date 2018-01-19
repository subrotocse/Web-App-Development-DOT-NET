using ItemController.Controllers;
using ItemController.Inventory.Core.DAL;
using ItemController.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ItemController.Inventory.Core.BLL
{
    public class ItemGateway
    {
       
        internal int Save(Item item)
{
    string connectionString = WebConfigurationManager.ConnectionStrings["InventoryDBconnectionString"].ConnectionString;
    SqlConnection connection = new SqlConnection(connectionString);
    string query = "Insert into Items(Name,UnitPrice) Values(@name,@unitprice)";
    SqlCommand command = new SqlCommand(query, connection);
    command.Parameters.Add("@name", SqlDbType.VarChar);
    command.Parameters["@name"].Value = item.Name;

    command.Parameters.Add("@unitprice", SqlDbType.VarChar);
    command.Parameters["@unitprice"].Value = item.UnitPrice;
    connection.Open();
    int rowAffected = command.ExecuteNonQuery();
    connection.Close();
    return rowAffected;

      }
    }
}