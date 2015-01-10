using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntryInfo.DAL.DAO;
using EntryInfo.DAL.DBGateway;

namespace EntryInfo.BLL
{
    public class DepartmentManager
    {

        public List<Department> GetAlDepartments()
        {
          DepartmentDBGateway aDepartmentDbGateway  = new DepartmentDBGateway();
            return aDepartmentDbGateway.GetDepartments();
        }
    }
}