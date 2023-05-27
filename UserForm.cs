using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class UserForm : Form
    {
        DataTable dataTable = new DataTable();
        DataBaseSingleton dbSingleton;
        SqlConnection connection;
        SqlDataAdapter adapter;
        public UserForm()
        {
            InitializeComponent();
            dbSingleton = DataBaseSingleton.Instance;
            connection = dbSingleton.GetConnection();
            using (adapter = new SqlDataAdapter("SELECT * FROM [Tour]", connection))
            {
                adapter.Fill(dataTable);
                int y = 0;
                foreach(DataRow dr in dataTable.Rows)
                {
                    Console.WriteLine("1");
                    UserControlTour tour = new UserControlTour(dr);
                    tour.Location = new Point(0, y);
                    this.Controls.Add(tour);
                    y += 100;
                }
            }
        }
    }

}