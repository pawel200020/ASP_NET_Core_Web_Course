using ASP_NET_Core_Web_Development_course.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ASP_NET_Core_Web_Development_course.Services
{
    public class ProductsDAO : IProductDataService
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public List<ProductModel> GetAllProducts()
        {

            List<ProductModel> foundProducts = new List<ProductModel>();
            string sqlStatement = "SELECT * FROM dbo.Products";
            SqlConnection connection = new SqlConnection(connectionString);
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductModel { Id = (int)reader[0], Name = (string)reader[1], price = (decimal)reader[2], Description = (string)reader[3] });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            return foundProducts;
        }
        public List<ProductModel> SearchProducts(string searchTerm)
        {
            List<ProductModel> foundProducts = new List<ProductModel>();
            string sqlStatement = "SELECT * FROM dbo.Products WHERE Name LIKE @Name ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Name", '%' + searchTerm + '%');
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductModel { Id = (int)reader[0], Name = (string)reader[1], price = (decimal)reader[2], Description = (string)reader[3] });
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            return foundProducts;
        }

        public int Update(ProductModel product)
        {
            int NewId = -1;
            string sqlStatement = "UPDATE dbo.Products SET Name = @Name, price = @Price, Description = @Description WHERE Id = @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.price);
                command.Parameters.AddWithValue("@Description", product.Description);
                command.Parameters.AddWithValue("@Id", product.Id);
                try
                {
                    connection.Open();
                    NewId = Convert.ToInt32( command.ExecuteScalar()); //first column of sth what was update
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            return NewId;
        }
        public int Insert(ProductModel product)
        {
            int NewId = -1;
            string sqlStatement = "INSERT INTO dbo.Products (Name, price, Description) VALUES (@name, @price, @description)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.price);
                command.Parameters.AddWithValue("@description", product.Description);
                try
                {
                    connection.Open();
                    NewId = Convert.ToInt32(command.ExecuteScalar()); //first column of sth what was update
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            return NewId;
        }
        public int Delete(ProductModel product)
        {
            int NewId = -1;
            string sqlStatement = "DELETE FROM dbo.Products WHERE Id=@Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Id", product.Id);
                try
                {
                    connection.Open();
                    NewId = Convert.ToInt32(command.ExecuteScalar()); //first column of sth what was update
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            return NewId;
        }
        public ProductModel GetProductById(int id)
        {
            ProductModel foundProducts = null;
            string sqlStatement = "SELECT * FROM dbo.Products WHERE Id = @Id ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);
                command.Parameters.AddWithValue("@Id",  id );
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts = new ProductModel { Id = (int)reader[0], Name = (string)reader[1], price = (decimal)reader[2], Description = (string)reader[3] };
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            return foundProducts;
        }
    }
}
