using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EntryInfo.DAL.DBGateway
{
    public class StudentDBGateway
    {
        
        string connectionString = @"Data Source= (LOCAL)\SQLEXPRESS; Database = Person DB; Integrated Security = true";
        private SqlConnection connection;

        public StudentDBGateway()
        {
            connection=new SqlConnection(connectionString);
        }
     
        public int Save(Student aStudent)
        {
            int Id = 0;
            connection.Open();
            string query = "INSERT INTO T_Person VALUES('" + aStudent.Name + "','" + aStudent.Address + "','" +
                           aStudent.Phone  + "','"+aStudent.DeptId+"');";
            SqlCommand command = new SqlCommand(query, connection);
           int rowAffected=command.ExecuteNonQuery();
            string getIdQuery = "SELECT MAX(Id) as ID FROM T_Person;";
            if (rowAffected > 0)
            {
                command.CommandText = getIdQuery;
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Id = (int) reader["Id"];
                }
                connection.Close();
            }
            return Id;

        }

        internal void Update(int ID, Student aStudent)
        {
            connection.Open();
            string query = "UPDATE T_Person VALUES('" + aStudent.Name + "','" + aStudent.Address + "','" +
                           aStudent.Phone + "','" + aStudent.DeptId + "' WHERE ID = '"+ID+"');";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            
        }

        internal List<Student> GetAllStudent(int selectedDept)
        {
            List<Student> studentList = new List<Student>();


            connection.Open();
            string query = "SELECT * FROM T_Person WHERE DeptId= '"+selectedDept+"'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student aStudent= new Student();
                aStudent.Id = (int)reader["Id"];
                aStudent.Name = reader["Name"].ToString();
                aStudent.Address = reader["Address"].ToString();
                aStudent.Phone = reader["Phone"].ToString();
                

                studentList.Add(aStudent);

            }
            reader.Close();
            connection.Close();
            return studentList;
        }

        internal void Confirm(int selectedStudent)
        {

            connection.Open();
            string query = "SELECT FROM T_Person WHERE ID = '" + selectedStudent + "'SET Confirm='True';";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}