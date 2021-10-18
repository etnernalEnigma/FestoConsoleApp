using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CourseBusinessLayer
    {
        public IEnumerable<CourseModel> GetAllCourse(string args=null)
        {
            string query = "";
            if (!string.IsNullOrWhiteSpace(args))
            {//using like operator due to filter character wise, like operator will reduce performance otherwise we can use =
               query = @"SELECT c.title, ct.name from Course c inner join CourseType ct on c.courseType_id = ct.id where ct.name like '%" + args+"%'";
            }
            else { 
                query = @"SELECT c.title, ct.name from Course c inner join CourseType ct on c.courseType_id = ct.id";
            }
            {
                string connectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                List<CourseModel> courseModels = new List<CourseModel>();
                
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    try
                    {
                        SQLiteCommand command = new SQLiteCommand(query, connection);
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        SQLiteDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            courseModels.Add(new CourseModel()
                            {
                                Title = reader["title"].ToString(),
                                CourseTypeName = reader["name"].ToString()
                            });

                        }
                        reader.Close();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
                return courseModels;
            }
        }
    }
}
