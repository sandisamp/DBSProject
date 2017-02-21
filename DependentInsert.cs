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
    public partial class DependentInsert : Form
    {
        String depid, empid, dob, relation;
        string cs = "server=localhost;userid=root;password=bcpl6797;database=mydb";

        private void dep_text_TextChanged(object sender, EventArgs e)
        {
            depid = dep_text.Text;
            bool allDigit = depid.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid Dependent ID");
            }

        }

        private void Dob_TextChanged(object sender, EventArgs e)
        {
            dob = Dob.Text;
        }

        private void Rel_text_TextChanged(object sender, EventArgs e)
        {
            relation = Rel_text.Text;
            bool allAlphabet = relation.All(char.IsLetter);
            if (allAlphabet == false)
            {
                MessageBox.Show("Please enter a valid relation");
            }
        }

        private void insert_butt_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "insert into mydb.dependent(idDependent,idEmployee,DependentDOB,Relation) values(" + depid + "," + empid + ",'" + dob + "','" + relation + "');";
                MySqlCommand insComm = new MySqlCommand(query, conn);
                MySqlDataReader MyReader;
                MyReader = insComm.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader.Read())
                {
                }
            }
            catch (MySqlException ex) { MessageBox.Show(ex + ""); }

        }

        private void close_butt_Click(object sender, EventArgs e)
        {
            mainMenu form = new mainMenu();
            this.Hide();

            conn.Close();
            form.Show();
        }

        MySqlConnection conn = null;
        public DependentInsert()
        {
            InitializeComponent();
            conn = new MySqlConnection(cs);
            conn.Open();
        }

        private void emp_text_TextChanged(object sender, EventArgs e)
        {
            empid = emp_text.Text;
            bool allDigit = empid.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid employee ID");
            }
        }
    }
}
