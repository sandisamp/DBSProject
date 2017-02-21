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
    public partial class dept_insert : Form
    {
        String depid, manid, loc, name;
        string cs = "server=localhost;userid=root;password=bcpl6797;database=mydb";
        MySqlConnection conn = null;
        private void Locationtextbox_TextChanged(object sender, EventArgs e)
        {
            loc = Locationtextbox.Text;
            bool allAlphabet = loc.All(char.IsLetter);
            if (allAlphabet == false)
            {
                MessageBox.Show("Please enter a valid Location");
            }
        }

        private void ManID_TextChanged(object sender, EventArgs e)
        {
            manid = ManID.Text;
            bool allDigit = manid.All(char.IsDigit);
            if (allDigit == false)
            {
                MessageBox.Show("Please enter a valid Manager ID");
            }
        }

        private void insert_button_Click(object sender, EventArgs e)
        {
            try {
                String query = "insert into mydb.department(idDepartment,DeptName,Location,idEmployee) values(" + depid + ",'" + name + "','" + loc + "'," + manid + ");";
                MySqlCommand insComm = new MySqlCommand(query, conn);
                MySqlDataReader MyReader;
                MyReader = insComm.ExecuteReader();
                MessageBox.Show("Save Data");
                while (MyReader.Read())
                {
                } }catch(MySqlException ex) { MessageBox.Show(ex + ""); }

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            Depid.Clear();
            ManID.Clear();
            Locationtextbox.Clear();
            nameTesxtBox.Clear();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            mainMenu form = new mainMenu();
            this.Hide();
            
            conn.Close();
            form.Show();
        }

        private void nameTesxtBox_TextChanged(object sender, EventArgs e)
        {
            name = nameTesxtBox.Text;
            bool allAlphabet = name.All(char.IsLetter);
            if (allAlphabet == false)
            {
                MessageBox.Show("Please enter a valid Department Name");
            }
        }

        public dept_insert()
        {
            InitializeComponent();
            headerTextBox.ReadOnly = true;
            conn = new MySqlConnection(cs);
            conn.Open();
        }

        private void Depid_TextChanged(object sender, EventArgs e)
        {
            depid = Depid.Text;
            bool allDigits = depid.All(char.IsDigit);
            if (allDigits == false)
            {
                MessageBox.Show("Please enter a valid Department ID");
            }
        }
    }
}
