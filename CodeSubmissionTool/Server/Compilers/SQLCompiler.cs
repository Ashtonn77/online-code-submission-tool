    using CodeSubmissionTool.Server.ICompilers;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.Compilers
{
    public class SQLCompiler : ICompiler
    {
        public void CreateFile(string c, string f)
        {
            throw new NotImplementedException();
        }

        public string ExecuteScript(string sample, string query)
        {
            //create connection
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "./test_take_1.db";

            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                connection.Open();

                //create table
                var tableCmd = connection.CreateCommand();
                //tableCmd.CommandText = "CREATE TABLE IF NOT EXISTS favorite_beers(name VARCHAR(50));";

                tableCmd.CommandText = "CREATE TABLE IF NOT EXISTS users(firstname varchar(255), lastname varchar(255), gender varchar(255), email varchar(255));";

                tableCmd.ExecuteNonQuery();

                //insert some records
                //using (var transaction = connection.BeginTransaction())
                //{
                //    var insertCmd = connection.CreateCommand();
                //    insertCmd.CommandText = "INSERT INTO users VALUES('Jay', 'Gatsby', 'male', 'jg@hotmail.com');";
                //    insertCmd.ExecuteNonQuery();

                //    insertCmd.CommandText = "INSERT INTO users VALUES('Daisy', 'Buchannan', 'female', 'db@hotmail.com');";
                //    insertCmd.ExecuteNonQuery();

                //    insertCmd.CommandText = "INSERT INTO users VALUES('Jordan', 'Baker', 'female', 'jordon@gmail.com');";
                //    insertCmd.ExecuteNonQuery();

                //    insertCmd.CommandText = "INSERT INTO users VALUES('Nick', 'Carraway', 'male', 'nicky@gmail.com');";
                //    insertCmd.ExecuteNonQuery();

                //    transaction.Commit();

                //}

                //read records
                var selectCmd = connection.CreateCommand();
                selectCmd.CommandText = query;
                string user_details = "";
                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var first = reader.GetString(0);
                        var last = reader.GetString(1);
                        var gender = reader.GetString(2);
                        var email = reader.GetString(3);

                        string temp = $"{first}#{last}#{gender}#{email}*";
                        user_details += temp;
                        //Console.WriteLine($"{first}:{last}, {gender} -> {email}");

                    }
                }

                return user_details;

            }

        }
    }

}