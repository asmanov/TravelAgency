using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Linq;

namespace TravelAgency
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        DataBaseSingleton dbSingleton;
        SqlConnection connection;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            dbSingleton = DataBaseSingleton.Instance;
            connection = dbSingleton.GetConnection();
            adapter = dbSingleton.GetAdapter();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(textBox1);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(textBox2);
            button1.Text = "Log In";
            button1.Location = new Point(90, 370);
            this.panel2.Controls.Add(button1);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(textBox1);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(textBox2);
            label4.Location = new Point(55, 250);
            this.panel2.Controls.Add(label4);
            textBox3.Location = new Point(24, 310);
            textBox3.Width = textBox2.Width;
            this.panel2.Controls.Add(textBox3);
            button1.Text = "Registr";
            button1.Location = new Point(90, 370);
            this.panel2.Controls.Add(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataTable = ds.Tables[0];
            foreach (DataRow row in dataTable.Rows)
            {
                users.Add(new User((int)row[0], (string)row[1], (string)row[2]));
            }
            if (radioButton1.Checked)
            {
                if (users.Any(s => s.LogIn == textBox1.Text && s.Password == textBox2.Text))
                {
                    if(textBox1.Text == "Admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }
                    else
                    {
                        UserForm userForm = new UserForm();
                        userForm.Show();
                    }
                }
                else radioButton2.Checked = true;
            }
            if (radioButton2.Checked)
            {
                if (textBox2.Text == textBox3.Text && !(users.Any(s => s.LogIn == textBox1.Text && s.Password == textBox2.Text)))
                {
                    DataRow newRow = dataTable.NewRow();
                    newRow["LogIn"] = textBox2.Text;
                    newRow["Password"] = textBox3.Text;
                    dataTable.Rows.Add(newRow);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds);
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    
                }
            }
        }
    }
}
