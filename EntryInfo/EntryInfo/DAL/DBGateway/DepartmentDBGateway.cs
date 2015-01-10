using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using EntryInfo.DAL.DAO;

namespace EntryInfo.DAL.DBGateway
{
    public class DepartmentDBGateway
    {
         private string connectionString =
            @"Data Source= (LOCAL)\SQLEXPRESS; Database =  Person DB; Integrated Security = true";

        private SqlConnection connection;

        public DepartmentDBGateway()
        {
            connection = new SqlConnection(connectionString);
        }
        public List<Department> GetDepartments()
        {


            List<Department> departmentList = new List<Department>();


            connection.Open();
            string query = "SELECT * FROM T_Department";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Id = (int)reader["Id"];
                aDepartment.Title = reader["Title"].ToString();
               
                departmentList.Add(aDepartment);

            }
            reader.Close();
            connection.Close();
            return departmentList;
        }

    }
}