using System.Collections.Generic;
using System.Data.SqlClient;
using System.EnterpriseServices;
using CRUD_App_Cars_Without_Auth.Models;

namespace CRUD_App_Cars_Without_Auth.Controllers.Data
{
    internal class CarDAO
    {
        private string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cars;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Car> FetchAll()
        {
            List<Car> returnList = new List<Car>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "Select * from dbo.cars";
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Car car = new Car();
                        car.Id = reader.GetInt32(0);
                        car.Carm = reader.GetString(1);
                        car.MPG = (double)reader.GetDecimal(2);
                        car.Cylinders = reader.GetInt32(3);
                        car.Displacement = (double)reader.GetDecimal(4);
                        car.Horsepower = (double)reader.GetDecimal(5);
                        car.Weight = (double)reader.GetDecimal(6);
                        car.Acceleration = (double)reader.GetDecimal(7);
                        car.Model = reader.GetInt32(8);
                        car.Origin = reader.GetString(9);

                        returnList.Add(car);
                    }
                }

            }

            return returnList;
        }

        public Car FetchOne(int id)
        {
            Car returncar = new Car();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "Select * from dbo.cars where ID = @id";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        returncar.Id = reader.GetInt32(0);
                        returncar.Carm = reader.GetString(1);
                        returncar.MPG = (double)reader.GetDecimal(2);
                        returncar.Cylinders = reader.GetInt32(3);
                        returncar.Displacement = (double)reader.GetDecimal(4);
                        returncar.Horsepower = (double)reader.GetDecimal(5);
                        returncar.Weight = (double)reader.GetDecimal(6);
                        returncar.Acceleration = (double)reader.GetDecimal(7);
                        returncar.Model = reader.GetInt32(8);
                        returncar.Origin = reader.GetString(9);
                    }
                }

            }

            return returncar;
        }

        public int CreateOrUpdate(Car carmodel)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "";
                if (carmodel.Id <= 0)
                {
                    sqlQuery =
                        "INSERT INTO dbo.cars VALUES ( @Carm, @MPG, @Cylinders, @Displacement, @Horsepower, @Weight, @Acceleration, @Model, @Origin)";
                }
                else
                {
                    sqlQuery =
                        "UPDATE  dbo.cars SET  Car = @Carm, MPG = @MPG, Cylinders = @Cylinders, Displacement =  @Displacement, Horsepower = @Horsepower, Weight = @Weight, Acceleration = @Acceleration, Model = @Model, Origin = @Origin WHERE id = @Id";

                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = carmodel.Id;
                command.Parameters.Add("@Carm", System.Data.SqlDbType.VarChar, 1000).Value = carmodel.Carm;
                command.Parameters.Add("@MPG", System.Data.SqlDbType.Decimal).Value = carmodel.MPG;
                command.Parameters.Add("@Cylinders", System.Data.SqlDbType.Int).Value = carmodel.Cylinders;
                command.Parameters.Add("@Displacement", System.Data.SqlDbType.Decimal).Value = carmodel.Displacement;
                command.Parameters.Add("@Horsepower", System.Data.SqlDbType.Decimal).Value = carmodel.Horsepower;
                command.Parameters.Add("@Weight", System.Data.SqlDbType.Decimal).Value = carmodel.Weight;
                command.Parameters.Add("@Acceleration", System.Data.SqlDbType.Decimal).Value = carmodel.Acceleration;
                command.Parameters.Add("@Model", System.Data.SqlDbType.Int).Value = carmodel.Model;
                command.Parameters.Add("@Origin", System.Data.SqlDbType.VarChar, 1000).Value = carmodel.Origin;
                connection.Open();

                int newId = command.ExecuteNonQuery();
                return newId;
            }

        }

        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE FROM dbo.cars WHERE Id LIKE @id";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                int deletedID = command.ExecuteNonQuery();

                return deletedID;
            }

        }

        public List<Car> SeachForName(string name)
        {
            List<Car> returnList = new List<Car>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.cars WHERE Car LIKE @var";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@var", System.Data.SqlDbType.VarChar,1000).Value = "%"+name+"%";
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Car car = new Car();
                        car.Id = reader.GetInt32(0);
                        car.Carm = reader.GetString(1);
                        car.MPG = (double)reader.GetDecimal(2);
                        car.Cylinders = reader.GetInt32(3);
                        car.Displacement = (double)reader.GetDecimal(4);
                        car.Horsepower = (double)reader.GetDecimal(5);
                        car.Weight = (double)reader.GetDecimal(6);
                        car.Acceleration = (double)reader.GetDecimal(7);
                        car.Model = reader.GetInt32(8);
                        car.Origin = reader.GetString(9);

                        returnList.Add(car);
                    }
                }
            }
            return returnList;
        }

        public List<Car> SearchForCountry(string name)
        {
            List<Car> returnList = new List<Car>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM dbo.cars WHERE Origin LIKE @var";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@var", System.Data.SqlDbType.VarChar, 1000).Value = "%" + name + "%";
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Car car = new Car();
                        car.Id = reader.GetInt32(0);
                        car.Carm = reader.GetString(1);
                        car.MPG = (double)reader.GetDecimal(2);
                        car.Cylinders = reader.GetInt32(3);
                        car.Displacement = (double)reader.GetDecimal(4);
                        car.Horsepower = (double)reader.GetDecimal(5);
                        car.Weight = (double)reader.GetDecimal(6);
                        car.Acceleration = (double)reader.GetDecimal(7);
                        car.Model = reader.GetInt32(8);
                        car.Origin = reader.GetString(9);

                        returnList.Add(car);
                    }
                }
            }
            return returnList;
        }

    }
}




