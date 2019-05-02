using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperStudents.Models;

namespace DapperStudents.Repository
{
    public class StudentDataAccess
    {
        private string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ТынышбаевА.CORP\source\repos\DapperStudents\DapperStudents.Repository\Database.mdf;Integrated Security=True";



        public string InsertStudent(string query , Student student )
        {
            using (var sql = new SqlConnection(ConnectionString))
            {
                var res = sql.Execute(query , student);
                if(res < 1)
                {
                    throw new Exception("Ereor");
                }

                return "Good";
            }
        }

        public List<Student> GetAllStudent(string query)
        {
            using (var sql = new SqlConnection(ConnectionString))
            {

                return sql.Query<Student>(query).ToList();
            }


        }


        public List<Group> GetAllGroup(string query)
        {
            using (var sql = new SqlConnection(ConnectionString))
            {

                return sql.Query<Group>(query).ToList();
            }


        }


        public List<Student> DeleteStudent(string query)
        {
            using (var sql = new SqlConnection(ConnectionString))
            {
               var res =  sql.Query<Student>(query).ToList();
                return res;
            }
        }



        public string UpdateGroupId(string query)
        {
            using (var sql = new SqlConnection(ConnectionString))
            {
                var res = sql.Execute(query);
                if (res < 1)
                {
                    throw new Exception("Ereor");
                }

                return "Good";
            }
        }


    }
}


































