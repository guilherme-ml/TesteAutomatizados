using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AutomationPractice.Base
{
    public static class Utils
    {
        private static Random random = new Random();
        public static string GetJsonToken(this string fileName, string token)
        {
            try
            {
                return JObject.Parse(File.ReadAllText(fileName)).Value<string>(token);
            }
            catch
            {
                return "";
            }
        }

        public static void Log(this string report, string message)
        {
            using (StreamWriter sw = new StreamWriter(report, true))
            {
                sw.WriteLine($"<h4>{message}</h4>");
            }
        }
        public static string RandomEmail()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
             var email =new string(Enumerable.Repeat(chars, 10)
            .Select(s => s[random.Next(s.Length)]).ToArray()) + "@gmail.com";
            return email;
        }
        public static string[] BuscarUsuario(string idUser)
        {

            string myConnectionString = "DataBase=cadastrousuario;Data Source=localhost;User Id=root";
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string myQuery = $"select * from pessoas where id = {idUser}";
            MySqlCommand myCommand = new MySqlCommand(myQuery);
            myCommand.Connection = myConnection;
            myConnection.Open();
            MySqlDataReader myReader;
            myReader = myCommand.ExecuteReader();
            string id = "";
            string nome = "";
            string sobrenome = "";
            string password = "";
            string company = "";
            string address = "";
            string addressLineTwo = "";
            string city = "";
            string addInformation = "";
            string homePhone = "";
            string mobilePhone = "";
            string assignAddress = "";
            string state = "";
            string country = "";
            try
            {
                while (myReader.Read())
                {
                    id = myReader.GetString(0).ToString();
                    nome = myReader.GetString(1).ToString();
                    sobrenome = myReader.GetString(2).ToString();
                    password = myReader.GetString(3).ToString();
                    company = myReader.GetString(4).ToString();
                    address = myReader.GetString(5).ToString();
                    addressLineTwo = myReader.GetString(6).ToString();
                    city = myReader.GetString(7).ToString();
                    state = myReader.GetString(8).ToString();
                    country = myReader.GetString(9).ToString();
                    addInformation = myReader.GetString(10).ToString();
                    homePhone = myReader.GetString(14).ToString();
                    mobilePhone = myReader.GetString(11).ToString();
                    assignAddress = myReader.GetString(12).ToString();
                }

            }
            finally
            {
                myReader.Close();
                myConnection.Close();
            }
            string[] test = { id, nome, sobrenome, password, company, address, addressLineTwo, city, addInformation, homePhone, mobilePhone, assignAddress, state, country};

            return test;
            

        }
    }
}
