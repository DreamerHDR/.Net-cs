using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Laba11.Models
{
    public class Maker
    {
        // SQL-запросы
        private static readonly string _selectMakersCommand = @"SELECT [ManufacturerID], [Name], [Country], [PhoneID] FROM [dbo].[Manufacturers]";
        private static readonly string _insertMakerCommand = @"INSERT INTO [dbo].[Manufacturers] ([Name], [Country], [PhoneID]) VALUES (@Name, @Country, @PhoneID)";
        private static readonly string _updateMakerCommand = @"UPDATE [dbo].[Manufacturers] SET [Name] = @Name, [Country] = @Country, [PhoneID] = @PhoneID WHERE [ManufacturerID] = @ManufacturerID";
        private static readonly string _deleteMakerCommand = @"DELETE FROM [dbo].[Manufacturers] WHERE [ManufacturerID] = @ManufacturerID";

        // Свойства
        public int ManufacturerID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int PhoneID { get; set; } // Внешний ключ, ссылающийся на таблицу Phones

        // Метод для получения всех производителей
        public static List<Maker> List(SqlConnection connection)
        {
            List<Maker> makers = new List<Maker>();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectMakersCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Maker maker = new Maker
                        {
                            ManufacturerID = (int)reader["ManufacturerID"],
                            Name = (string)reader["Name"],
                            Country = (string)reader["Country"],
                            PhoneID = (int)reader["PhoneID"], // Получение PhoneID
                        };
                        makers.Add(maker);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return makers;
        }

        // Метод для добавления нового производителя
        public static void Insert(SqlConnection connection, Maker maker)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO [dbo].[Manufacturers] ([Name], [Country], [PhoneID]) 
                                    VALUES (@Name, @Country, @PhoneID)";
                    command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = maker.Name;
                    command.Parameters.Add("@Country", SqlDbType.NVarChar).Value = maker.Country;
                    command.Parameters.Add("@PhoneID", SqlDbType.Int).Value = maker.PhoneID; // Убедитесь, что PhoneID установлен

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }


        // Метод для обновления данных производителя
        public static void Update(SqlConnection connection, Maker maker)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updateMakerCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = maker.Name;
                    command.Parameters.Add("@Country", SqlDbType.NVarChar, 100).Value = maker.Country;
                    command.Parameters.Add("@PhoneID", SqlDbType.Int).Value = maker.PhoneID;
                    command.Parameters.Add("@ManufacturerID", SqlDbType.Int).Value = maker.ManufacturerID;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        // Метод для удаления производителя
        public static void Delete(SqlConnection connection, int manufacturerID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deleteMakerCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@ManufacturerID", SqlDbType.Int).Value = manufacturerID;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }
    }
}
