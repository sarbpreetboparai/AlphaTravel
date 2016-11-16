namespace FinalProject
{
    partial class MyAds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAds));
            this.listViewMyAds = new System.Windows.Forms.ListView();
            this.cNameOfAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProvince = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBookedBy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoveAd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMyAds
            // 
            this.listViewMyAds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNameOfAd,
            this.cCity,
            this.cProvince,
            this.cStreet,
            this.cBookedBy});
            this.listViewMyAds.Location = new System.Drawing.Point(22, 26);
            this.listViewMyAds.Name = "listViewMyAds";
            this.listViewMyAds.Size = new System.Drawing.Size(606, 187);
            this.listViewMyAds.TabIndex = 0;
            this.listViewMyAds.UseCompatibleStateImageBehavior = false;
            this.listViewMyAds.View = System.Windows.Forms.View.Details;
            // 
            // cNameOfAd
            // 
            this.cNameOfAd.Text = "Name Of Ad";
            this.cNameOfAd.Width = 163;
            // 
            // cCity
            // 
            this.cCity.Text = "City";
            this.cCity.Width = 119;
            // 
            // cProvince
            // 
            this.cProvince.Text = "Province";
            this.cProvince.Width = 68;
            // 
            // cStreet
            // 
            this.cStreet.Text = "Street";
            this.cStreet.Width = 127;
            // 
            // cBookedBy
            // 
            this.cBookedBy.Text = "Booked By";
            this.cBookedBy.Width = 125;
            // 
            // btnRemoveAd
            // 
            this.btnRemoveAd.BackColor = System.Drawing.Color.Khaki;
            this.btnRemoveAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAd.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnRemoveAd.Location = new System.Drawing.Point(276, 219);
            this.btnRemoveAd.Name = "btnRemoveAd";
            this.btnRemoveAd.Size = new System.Drawing.Size(127, 34);
            this.btnRemoveAd.TabIndex = 1;
            this.btnRemoveAd.Text = "Remove Ad";
            this.btnRemoveAd.UseVisualStyleBackColor = false;
            this.btnRemoveAd.Click += new System.EventHandler(this.btnRemoveAd_Click);
            // 
            // MyAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 261);
            this.Controls.Add(this.btnRemoveAd);
            this.Controls.Add(this.listViewMyAds);
            this.Name = "MyAds";
            this.Text = "MyAds";
            this.Load += new System.EventHandler(this.MyAds_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewMyAds;
        private System.Windows.Forms.ColumnHeader cNameOfAd;
        private System.Windows.Forms.ColumnHeader cCity;
        private System.Windows.Forms.ColumnHeader cProvince;
        private System.Windows.Forms.ColumnHeader cStreet;
        private System.Windows.Forms.ColumnHeader cBookedBy;
        private System.Windows.Forms.Button btnRemoveAd;



    }
}