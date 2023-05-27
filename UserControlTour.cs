using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class UserControlTour : UserControl
    {
        public UserControlTour()
        {
            InitializeComponent();
        }
        public UserControlTour(DataRow dr) : this()
        {
            this.hotel_lb.Text = dr[1].ToString();
            this.stars_lb.Text = dr[2].ToString();
            this.destination_lb.Text = dr[3].ToString();
            this.wherefrom_lb.Text = dr[4].ToString();
            this.cost_lb.Text = dr[5].ToString();
            this.day_lb.Text = dr[6].ToString();
            this.date_lb.Text = dr[7].ToString();
        }
    }
}
