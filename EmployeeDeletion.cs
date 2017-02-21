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
    public partial class EmployeeDeletion : Form
    {
        string cs = "server=localhost;userid=root;password=bcpl6797;database=mydb";
        MySqlConnection conn = null;
        string empid;
        public EmployeeDeletion()
        {
            InitializeComponent();
            header.ReadOnly = true;
            conn = new MySqlConnection(cs);
            conn.Open();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            empid = textBox2.Text;
            bool allDigit = empid.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid Employee ID");
            }
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            try {
                String query = "delete from mydb.employee where idEmployee=" + empid + ";";
                MySqlCommand insComm = new MySqlCommand(query, conn);
                MySqlDataReader MyReader;
                MyReader = insComm.ExecuteReader();       
                MessageBox.Show("Row Deleted");
                while (MyReader.Read())
                {
                } }catch(MySqlException ex) { MessageBox.Show("enter valid Employee Id \n"+ex); }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            conn.Close();
            mainMenu form = new mainMenu();
            form.Show();

        }
    }
}
