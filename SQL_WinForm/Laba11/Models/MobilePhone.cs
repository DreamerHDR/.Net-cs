using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Laba11.Models
{
    public class MobilePhone
    {
        private static readonly string _selectPhonesCommand = @"SELECT [PhoneID], [Model], [Price] FROM [dbo].[Phones]";
        private static readonly string _insertPhoneCommand = @"INSERT INTO [dbo].[Phones] ([Model], [Price]) VALUES (@Model, @Price)";
        private static readonly string _updatePhoneCommand = @"UPDATE [dbo].[Phones] SET [Model] = @Model, [Price] = @Price WHERE [PhoneID] = @PhoneID";
        private static readonly string _deletePhoneCommand = @"DELETE FROM [dbo].[Phones] WHERE [PhoneID] = @PhoneID";

        public int PhoneID { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        // Метод для получения всех телефонов
        public static List<MobilePhone> List(SqlConnection connection)
        {
            List<MobilePhone> phones = new List<MobilePhone>();
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _selectPhonesCommand;
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        MobilePhone phone = new MobilePhone
                        {
                            PhoneID = (int)reader["PhoneID"],
                            Model = (string)reader["Model"],
                            Price = (decimal)reader["Price"],
                        };
                        phones.Add(phone);
                    }
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
            return phones;
        }

        // Метод для добавления нового телефона
        public static void Insert(SqlConnection connection, MobilePhone phone)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _insertPhoneCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Model", SqlDbType.NVarChar, 100).Value = phone.Model;
                    command.Parameters.Add("@Price", SqlDbType.Decimal).Value = phone.Price;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        // Метод для обновления данных телефона
        public static void Update(SqlConnection connection, MobilePhone phone)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _updatePhoneCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@Model", SqlDbType.NVarChar, 100).Value = phone.Model;
                    command.Parameters.Add("@Price", SqlDbType.Decimal).Value = phone.Price;
                    command.Parameters.Add("@PhoneID", SqlDbType.Int).Value = phone.PhoneID;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                finally
                {
                    if (connection != null && connection.State == ConnectionState.Open) connection.Close();
                }
            }
        }

        // Метод для удаления телефона
        public static void Delete(SqlConnection connection, int phoneID)
        {
            using (SqlCommand command = new SqlCommand())
            {
                try
                {
                    command.Connection = connection;
                    command.CommandText = _deletePhoneCommand;
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@PhoneID", SqlDbType.Int).Value = phoneID;
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
