using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CRUDWinFormsMVP.Models;

namespace CRUDWinFormsMVP.Repository
{
    public class PetRepository : BaseRepository, IPetRepository
    {

        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(PetModel petModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO pet (Name, Type, Colour) VALUES (@Name, @Type, @Colour)";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", petModel.Name);
                    command.Parameters.AddWithValue("@Type", petModel.Type);
                    command.Parameters.AddWithValue("@Colour", petModel.Colour);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(PetModel petModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM pet WHERE Id = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", petModel.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Edit(PetModel petModel)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE pet SET Name = @Name, Type = @Type, Colour = @Colour WHERE Id = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", petModel.Id);
                    command.Parameters.AddWithValue("@Name", petModel.Name);
                    command.Parameters.AddWithValue("@Type", petModel.Type);
                    command.Parameters.AddWithValue("@Colour", petModel.Colour);

                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<PetModel> GetAll()
        {
            var petList = new List<PetModel>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM pet ORDER BY id DESC";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var petModel = new PetModel
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                Type = (string)reader["Type"],
                                Colour = (string)reader["Colour"]
                            };
                            petList.Add(petModel);
                        }
                    }
                }
            }

            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value)
        {
            var petList = new List<PetModel>();

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM pet WHERE (name = @Value OR type = @Value OR colour = @Value)";

                // Check if the value is numeric (int)
                if (int.TryParse(value, out int numericValue))
                {
                    query += " OR (id = @NumericValue)";
                }

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);

                    // Add the numeric value as a parameter if it's numeric
                    if (int.TryParse(value, out numericValue))
                    {
                        command.Parameters.AddWithValue("@NumericValue", numericValue);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var petModel = new PetModel
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                Type = (string)reader["Type"],
                                Colour = (string)reader["Colour"]
                            };
                            petList.Add(petModel);
                        }
                    }
                }
            }

            return petList;
        }



        public void Update(PetModel petModel)
        {
            Edit(petModel);
        }
    }
}
