namespace TravelAgency
{
    partial class UserControlTour
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hotel_lb = new System.Windows.Forms.Label();
            this.stars_lb = new System.Windows.Forms.Label();
            this.destination_lb = new System.Windows.Forms.Label();
            this.wherefrom_lb = new System.Windows.Forms.Label();
            this.cost_lb = new System.Windows.Forms.Label();
            this.day_lb = new System.Windows.Forms.Label();
            this.date_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hotel_lb
            // 
            this.hotel_lb.AutoSize = true;
            this.hotel_lb.Location = new System.Drawing.Point(74, 61);
            this.hotel_lb.Name = "hotel_lb";
            this.hotel_lb.Size = new System.Drawing.Size(65, 20);
            this.hotel_lb.TabIndex = 0;
            this.hotel_lb.Text = "HOTEL";
            // 
            // stars_lb
            // 
            this.stars_lb.AutoSize = true;
            this.stars_lb.Location = new System.Drawing.Point(188, 61);
            this.stars_lb.Name = "stars_lb";
            this.stars_lb.Size = new System.Drawing.Size(66, 20);
            this.stars_lb.TabIndex = 1;
            this.stars_lb.Text = "STARS";
            // 
            // destination_lb
            // 
            this.destination_lb.AutoSize = true;
            this.destination_lb.Location = new System.Drawing.Point(317, 61);
            this.destination_lb.Name = "destination_lb";
            this.destination_lb.Size = new System.Drawing.Size(74, 16);
            this.destination_lb.TabIndex = 2;
            this.destination_lb.Text = "Destination";
            // 
            // wherefrom_lb
            // 
            this.wherefrom_lb.AutoSize = true;
            this.wherefrom_lb.Location = new System.Drawing.Point(487, 65);
            this.wherefrom_lb.Name = "wherefrom_lb";
            this.wherefrom_lb.Size = new System.Drawing.Size(58, 20);
            this.wherefrom_lb.TabIndex = 3;
            this.wherefrom_lb.Text = "FROM";
            // 
            // cost_lb
            // 
            this.cost_lb.AutoSize = true;
            this.cost_lb.Location = new System.Drawing.Point(622, 69);
            this.cost_lb.Name = "cost_lb";
            this.cost_lb.Size = new System.Drawing.Size(55, 20);
            this.cost_lb.TabIndex = 4;
            this.cost_lb.Text = "COST";
            // 
            // day_lb
            // 
            this.day_lb.AutoSize = true;
            this.day_lb.Location = new System.Drawing.Point(742, 73);
            this.day_lb.Name = "day_lb";
            this.day_lb.Size = new System.Drawing.Size(44, 20);
            this.day_lb.TabIndex = 5;
            this.day_lb.Text = "DAY";
            // 
            // date_lb
            // 
            this.date_lb.AutoSize = true;
            this.date_lb.Location = new System.Drawing.Point(863, 73);
            this.date_lb.Name = "date_lb";
            this.date_lb.Size = new System.Drawing.Size(113, 20);
            this.date_lb.TabIndex = 6;
            this.date_lb.Text = "DATESTART";
            // 
            // UserControlTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date_lb);
            this.Controls.Add(this.day_lb);
            this.Controls.Add(this.cost_lb);
            this.Controls.Add(this.wherefrom_lb);
            this.Controls.Add(this.destination_lb);
            this.Controls.Add(this.stars_lb);
            this.Controls.Add(this.hotel_lb);
            this.Name = "UserControlTour";
            this.Size = new System.Drawing.Size(1001, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hotel_lb;
        private System.Windows.Forms.Label stars_lb;
        private System.Windows.Forms.Label destination_lb;
        private System.Windows.Forms.Label wherefrom_lb;
        private System.Windows.Forms.Label cost_lb;
        private System.Windows.Forms.Label day_lb;
        private System.Windows.Forms.Label date_lb;
    }
}
