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
    public partial class searchByDeptID : Form
    {
        string depid;
        string cs = "server=localhost;userid=root;password=bcpl6797;database=mydb";
        MySqlConnection conn = null;
        public searchByDeptID()
        {
            InitializeComponent();
            conn = new MySqlConnection(cs);
            conn.Open();
            depIdSearch.Hide();
            Search_button.Show();
        }

        private void depIdSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void depidtext_TextChanged(object sender, EventArgs e)
        {
            depid = depidtext.Text;
            bool allDigits = depid.All(char.IsDigit);
            if(allDigits==false)
            {
                MessageBox.Show("Please enter a valid Department ID");
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            depIdSearch.Show();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("select * from mydb.Department where idDepartment='"+depid+"'", conn);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            depIdSearch.DataSource = DS.Tables[0];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainMenu form = new mainMenu();
            this.Hide();

            conn.Close();
            form.Show();
        }
    }
}
