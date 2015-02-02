using Db4objects.Db4o;
using Db4objects.Db4o.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class frmA1 : Form
    {
        public frmA1()
        {
            InitializeComponent();
        }

        private List<Employee> employee;
        const string filename = "Emp";
        const int columns = 4;
        private IObjectContainer db = null;
        private int indx = 0;

        public void openFile()
        {
            db = Db4oFactory.OpenFile(filename);
        }

        private void retrieveAll()
        {
            IObjectSet result = db.QueryByExample(typeof(Employee));
            storeDataToList(result);
            disp(employee);
        }

        private void storeDataToList(IObjectSet result)
        {
            employee.Clear();
            foreach (Employee v in result)
                employee.Add(v);
        }

        public IObjectSet retrieveData(int id)
        {
            IQuery query = db.Query();
            query.Constrain(typeof(Employee));
            query.Descend("EmpID").Constrain(id);
            IObjectSet result = query.Execute();
            return result;
        }

        private void disp(List<Employee> result)
        {
            dgvResult.Rows.Clear();
            foreach (Employee v in result)
                dgvResult.Rows.Add(v.ID, v.FNAME, v.LNAME, v.SALARY);
        }

        private void frmA1_Load(object sender, EventArgs e)
        {
            employee = new List<Employee>();
            openFile();

            dgvResult.ColumnCount = columns;
            dgvResult.Columns[0].Name = "EmployeeID";
            dgvResult.Columns[1].Name = "First Name";
            dgvResult.Columns[2].Name = "Last Name";
            dgvResult.Columns[3].Name = "Salary";

            retrieveAll();

            indx = dgvResult.RowCount;
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int EmpID = indx;
                string FName = txtFName.Text;
                string LName = txtLName.Text;
                double Salary = double.Parse(txtSalary.Text);

                Employee p = new Employee(EmpID, FName, LName, Salary);
                db.Store(p);
                indx++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdDb4o_Click(object sender, EventArgs e)
        {
            IObjectSet result = retrieveData(int.Parse(txtEmpID.Text));
            storeDataToList(result);
            disp(employee);

        }

        private void cmdLINQ_Click(object sender, EventArgs e)
        {
            IEnumerable<Employee> result = from a in employee
                                           where a.ID == int.Parse(txtEmpID.Text)
                                           select a;
            disp(result.ToList<Employee>());
        }

        private void cmdShowAll_Click(object sender, EventArgs e)
        {
            retrieveAll();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
