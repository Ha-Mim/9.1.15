using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using EntryInfo.DAL.DAO;
using EntryInfo.DAL.DBGateway;

namespace EntryInfo.BLL
{
    public class StudentManager
    {
        public int Save(Student aStudent)
        {
            StudentDBGateway aStudentDbGateway=new StudentDBGateway();
            return aStudentDbGateway.Save(aStudent);
        }

        internal void Update(int ID, Student aStudent)
        {
           StudentDBGateway aStudentDbGateway = new StudentDBGateway();
            aStudentDbGateway.Update(ID, aStudent);
        }



        internal List<Student> GetALLStudent(int selectedDept)
        {
            StudentDBGateway aGateway = new StudentDBGateway();
            return  aGateway.GetAllStudent(selectedDept);
        }

        internal void Confirm(int selectedStudent)
        {
            StudentDBGateway aDbGateway = new StudentDBGateway();
            aDbGateway.Confirm(selectedStudent);
        }
    }
}