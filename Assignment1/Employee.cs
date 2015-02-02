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

            /*setEmpID(EmpID);
            setFName(FName);
            setLName(LName);
            setSalary(Salary);*/
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

        /*public void setEmpID(int EmpID)
        {
            this.EmpID = EmpID;
        }

        public void setFName(string FName)
        {
            this.FName = FName;
        }

        public void setLName(string LName)
        {
            this.LName = LName;
        }

        public void setSalary(double Salary)
        {
            this.Salary = Salary;
        }

        public int getEmpID()
        {
            return EmpID;
        }

        public string getFName()
        {
            return FName;
        }

        public string getLName()
        {
            return FName;
        }

        public double getSalary()
        {
            return Salary;
        }*/
    }
}
