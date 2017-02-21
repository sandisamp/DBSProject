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
    public partial class dependentDeletion : Form
    {
        String dpnid;
        string cs = "server=localhost;userid=root;password=bcpl6797;database=mydb";
        MySqlConnection conn = null;
        public dependentDeletion()
        {
            InitializeComponent();
            conn = new MySqlConnection(cs);
            conn.Open();
        }

        private void Depndntid_Textbox_TextChanged(object sender, EventArgs e)
        {
            dpnid = Depndntid_Textbox.Text;
            bool allDigit = dpnid.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid Employee ID");
            }
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "delete from mydb.employee where idEmployee=" + dpnid + ";";
                MySqlCommand insComm = new MySqlCommand(query, conn);
                MySqlDataReader MyReader;
                MyReader = insComm.ExecuteReader();
                MessageBox.Show("Row Deleted");
                while (MyReader.Read())
                {
                }
            }
            catch (MySqlException ex) { MessageBox.Show("enter valid Employee Id \n" + ex); }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Depndntid_Textbox.Clear();
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
