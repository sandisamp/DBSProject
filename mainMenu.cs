using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DBSProject
{
    public partial class mainMenu : Form
    {
        string cs = "server=localhost;userid=root;password=bcpl6797;database=mydb";
        MySqlConnection conn = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainMenu());
        }
            
        public mainMenu()
        {
            InitializeComponent();
            payrollGridView.Hide();
            conn=new MySqlConnection(cs);
            conn.Open();
        }
        

        private void mainMenu_Load(object sender, EventArgs e)
        {

        }

        private void showPayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            payrollGridView.Show();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select idEmployee,Salary,First_name,Last_name,commisson from mydb.employee", conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            payrollGridView.DataSource = DS.Tables[0];
            
        }

        private void departmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchByDeptID depform = new searchByDeptID();
            this.Hide();
            conn.Close();
            depform.Show();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchByEmpID empform = new searchByEmpID();
            this.Hide();
            conn.Close();
            empform.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dept_insert form = new dept_insert();
            this.Hide();
            conn.Close();
            form.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeUpdation form = new employeeUpdation();
            this.Hide();
            conn.Close();
            form.Show();
        }

        private void departmentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
            payrollGridView.Show();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from mydb.department", conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            payrollGridView.DataSource = DS.Tables[0];
        }

        private void dependentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            payrollGridView.Show();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from mydb.dependent", conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            payrollGridView.DataSource = DS.Tables[0];
        }

        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            payrollGridView.Show();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from mydb.employee", conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            payrollGridView.DataSource = DS.Tables[0];
        }

        private void employeeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EmployeeDeletion form = new EmployeeDeletion();
            this.Hide();
            conn.Close();
            form.Show();
        }

        private void dependentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DependentInsert form = new DependentInsert();
            this.Hide();
            conn.Close();
            form.Show();
            
        }
    }
}
