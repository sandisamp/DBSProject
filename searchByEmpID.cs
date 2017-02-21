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
    public partial class searchByEmpID : Form
    {
        string cs = "server=localhost;userid=root;password=bcpl6797;database=mydb";
        MySqlConnection conn = null;
        string empid;
        public searchByEmpID()
        {
            InitializeComponent();
            empIdSearchGrid.Hide();
            conn = new MySqlConnection(cs);
            conn.Open();
        }

        private void empIdTextBox_TextChanged(object sender, EventArgs e)
        {
            empid = empIdTextBox.Text;
            bool allDigits = empid.All(char.IsDigit);
            if (allDigits == false)
            {
                MessageBox.Show("Please enter a valid Employee ID");
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            empIdSearchGrid.Show();
            try { MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from mydb.Employee where idEmployee='" + empid + "'", conn);
                DataSet EmpDS = new DataSet();
                mySqlDataAdapter.Fill(EmpDS);

                empIdSearchGrid.DataSource = EmpDS.Tables[0]; }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
