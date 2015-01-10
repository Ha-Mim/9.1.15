using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EntryInfo
{
    [Serializable]
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public int DeptId { set; get; }

     

}
}