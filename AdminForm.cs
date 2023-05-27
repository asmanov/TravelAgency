using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class AdminForm : Form
    {
        DataTable dataTable = new DataTable();
        DataBaseSingleton dbSingleton;
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommandBuilder commandBuilder;
        public AdminForm()
        {
            InitializeComponent();
            tourList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tourList.AllowUserToAddRows = false;
            
            dbSingleton = DataBaseSingleton.Instance;
            connection = dbSingleton.GetConnection();
            using(adapter = new SqlDataAdapter("SELECT * FROM [Tour]", connection))
            {
                adapter.Fill(dataTable);
                tourList.Width = 1000;
                tourList.Height = 500;
                tourList.BackgroundColor = SystemColors.Window;
                tourList.DataSource = dataTable;
                tourList.Columns["Id"].ReadOnly = true;
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataTable.NewRow();
            dataTable.Rows.Add(dataRow);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in tourList.SelectedRows)
            {
                tourList.Rows.Remove(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (adapter = new SqlDataAdapter("SELECT * FROM [Tour]", connection))
            {
                commandBuilder = new SqlCommandBuilder(adapter);

                adapter.Update(dataTable);
                dataTable.Clear();
                adapter.Fill(dataTable);
            }
        }
    }
}
