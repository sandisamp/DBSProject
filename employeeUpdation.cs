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
    public partial class employeeUpdation : Form
    {
        string cs = "server=localhost;userid=root;password=bcpl6797;database=mydb";
        MySqlConnection conn = null;
        String empid, lname, fname, posid,qualid,depid,sal,commisson,hireda,birthda,emplevel;

        private void hire_da_TextChanged(object sender, EventArgs e)
        {
            hireda = hire_da.Text;

        }

        private void birth_da_TextChanged(object sender, EventArgs e)
        {
            birthda = birth_da.Text;
        }

        private void ins_button_Click(object sender, EventArgs e)
        {
            try {

                String query = "insert into mydb.employee(idEmployee,Last_name,First_name,idPosition,idQualification,iddepartment,Salary,Commisson,HireDate,BirthDate,idEmployeelevel) values(" + empid + ",'" + lname  + "','" + fname  + "'," + posid  + ","+qualid+"," + depid + "," + sal + "," + commisson + ",'" + hireda + "','" + birthda + "'," + emplevel + ");";
                MySqlCommand insComm = new MySqlCommand(query, conn);
                MySqlDataReader MyReader;
                MyReader = insComm.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader.Read())
                {
                }
            }catch(MySqlException ex) { MessageBox.Show(ex.ToString()); }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            mainMenu form = new mainMenu();
            this.Hide();

            conn.Close();
            form.Show();
        }

        private void emplevel_textbox_TextChanged(object sender, EventArgs e)
        {
            emplevel = emplevel_textbox.Text;
            bool allDigit = emplevel.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid EmplevelID");
            }

        }

        private void Salary_textBox_TextChanged(object sender, EventArgs e)
        {
            sal=Salary_textBox.Text;
            Double number;
            if (!(Double.TryParse(sal, out number)))
                MessageBox.Show("enter a valid salary(double format)");
        }

        private void commisson_textBox_TextChanged(object sender, EventArgs e)
        {
            commisson = commisson_textBox.Text;
            Double number;
            if (!(Double.TryParse(commisson, out number)))
                MessageBox.Show("enter a valid commisson(double format)");
        }

        

        private void qualID_textBox_TextChanged(object sender, EventArgs e)
        {
            qualid = qualID_textBox.Text;
            bool allDigit = qualid.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid Qualification ID");
            }
        }

        private void Dep_textBox_TextChanged(object sender, EventArgs e)
        {
            depid = Dep_textBox.Text;
            bool allDigit = depid.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid Department ID");
            }

        }

        public employeeUpdation()
        {
            InitializeComponent();
            conn = new MySqlConnection(cs);
            conn.Open();
        }

        private void fname_textBox_TextChanged(object sender, EventArgs e)
        {
            fname = fname_textBox.Text;
            bool allAlphabet = fname.All(char.IsLetter);
            if (allAlphabet == false)
            {
                MessageBox.Show("Please enter a valid first name");
            }
        }

        

        private void positionid_textBox_TextChanged(object sender, EventArgs e)
        {
            posid = positionid_textBox.Text;
            bool allDigit = posid.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid Position ID");
            }
        }

        private void lname_textBox_TextChanged(object sender, EventArgs e)
        {
            lname = lname_textBox.Text;
            bool allAlphabet = lname.All(char.IsLetter);
            if (allAlphabet == false)
            {
                MessageBox.Show("Please enter a valid last name");
            }
        }

        private void empid_textBox_TextChanged(object sender, EventArgs e)
        {
            empid = empid_textBox.Text;
            bool allDigit = empid.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid Employee ID");
            }
        }
    }
}
