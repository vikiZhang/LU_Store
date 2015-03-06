using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebForm_V1.Interface;

namespace WebForm_V1.Model
{
    public class Employee : IEmployee
    {
        //public int Empid { get; set; }
        //public string Name { get; set; }

        public string getName()
        {
            return "Bala";
        }

        public int getEmp_id()
        {
            return 1;
        }
    }
}