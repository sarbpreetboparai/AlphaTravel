namespace FinalProject
{
    partial class MyBookings
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBookings));
            this.listViewBookings = new System.Windows.Forms.ListView();
            this.cAdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPoster = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewBookings
            // 
            this.listViewBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cAdName,
            this.cCity,
            this.cProv,
            this.cStreet,
            this.cPoster});
            this.listViewBookings.Location = new System.Drawing.Point(40, 45);
            this.listViewBookings.Name = "listViewBookings";
            this.listViewBookings.Size = new System.Drawing.Size(512, 219);
            this.listViewBookings.TabIndex = 0;
            this.listViewBookings.UseCompatibleStateImageBehavior = false;
            this.listViewBookings.View = System.Windows.Forms.View.Details;
            // 
            // cAdName
            // 
            this.cAdName.Text = "Name of Ad";
            this.cAdName.Width = 149;
            // 
            // cCity
            // 
            this.cCity.Text = "City";
            this.cCity.Width = 113;
            // 
            // cProv
            // 
            this.cProv.Text = "Province";
            // 
            // cStreet
            // 
            this.cStreet.Text = "Street";
            this.cStreet.Width = 101;
            // 
            // cPoster
            // 
            this.cPoster.Text = "Posted By";
            this.cPoster.Width = 85;
            // 
            // MyBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(594, 314);
            this.Controls.Add(this.listViewBookings);
            this.Name = "MyBookings";
            this.Text = "MyBookings";
            this.Load += new System.EventHandler(this.MyBookings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewBookings;
        private System.Windows.Forms.ColumnHeader cAdName;
        private System.Windows.Forms.ColumnHeader cCity;
        private System.Windows.Forms.ColumnHeader cProv;
        private System.Windows.Forms.ColumnHeader cStreet;
        private System.Windows.Forms.ColumnHeader cPoster;
    }
}