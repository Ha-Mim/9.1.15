using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntryInfo.BLL;

namespace EntryInfo.UI
{
    public partial class ConfirmUI : System.Web.UI.Page
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
        StudentManager aStudentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                departmentDropDownList.DataSource =  aDepartmentManager.GetAlDepartments();
                departmentDropDownList.DataTextField = "Title";
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataBind();

                int selectedDept = Convert.ToInt32(departmentDropDownList.SelectedValue);
                studentDropDownList.DataSource = aStudentManager.GetALLStudent(selectedDept);
                studentDropDownList.DataTextField = "Name";
                studentDropDownList.DataValueField = "Id";
                studentDropDownList.DataBind();
            }
        }

        protected void confirmButton_Click(object sender, EventArgs e)
        {
            int selectedStudent = Convert.ToInt32(studentDropDownList.SelectedValue);
            aStudentManager.Confirm(selectedStudent);
        }
    }
}