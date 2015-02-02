using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Employee
    {
        private int 
            EmpID;
        private string 
            FName,
            LName;
        private double
            Salary;

        public Employee(int EmpID, string FName, string LName, double Salary)
        {
            ID = EmpID;
            FNAME = FName;
            LNAME = LName;
            SALARY = Salary;
        }

        public int ID
        {
            get
            {
                return EmpID;
            }
            set
            {
                EmpID = value;
            }
        }

        public string FNAME
        {
            get
            {
                return FName;
            }
            set
            {
                FName = value;
            }
        }

        public string LNAME
        {
            get
            {
                return LName;
            }
            set
            {
                LName = value;
            }
        }
        public double SALARY
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }
    }
}
