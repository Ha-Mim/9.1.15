using System;
using System.Collections.Generic;
using EntryInfo.BLL;
using EntryInfo.DAL.DAO;
using Microsoft.Ajax.Utilities;

namespace EntryInfo.UI
{
    public partial class EntryUI : System.Web.UI.Page
    {
       DepartmentManager aDepartmentManager = new DepartmentManager();
        StudentManager aStudentManager=new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                departmentDropDownList.DataSource = aDepartmentManager.GetAlDepartments();
                departmentDropDownList.DataTextField = "Title";
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataBind();
            }
        }

        public void saveButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();
            aStudent.Name = firstNameTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.Phone = phoneTextBox.Text;
            aStudent.DeptId= Convert.ToInt32(departmentDropDownList.SelectedValue);
            
            aStudent.Id= aStudentManager.Save(aStudent);
            firstNameTextBox.Text = string.Empty;

            addressTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            IdLavel.Text = aStudent.Id.ToString();
            if (aStudent.Id == 0)
            {
                msgLabel.Text = "Not Saved";
            }

        }

        public void updateButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IdLavel.Text);
            Student aStudent = new Student();
            aStudent.Name = firstNameTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.Phone = phoneTextBox.Text;


            aStudentManager.Update(ID, aStudent);

        }
    }
}