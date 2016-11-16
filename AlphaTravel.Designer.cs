namespace FinalProject
{
    partial class AlphaTravel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlphaTravel));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listPlaces = new System.Windows.Forms.ListView();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.prov = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.adultNo = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.childNo = new System.Windows.Forms.NumericUpDown();
            this.roomNo = new System.Windows.Forms.NumericUpDown();
            this.destination = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.greet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.myAds = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.duration = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adultNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(296, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "To travel is to live!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Going to:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(228, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "No of Rooms:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "No. of People:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.duration);
            this.groupBox1.Controls.Add(this.listPlaces);
            this.groupBox1.Controls.Add(this.bookButton);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.prov);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Controls.Add(this.adultNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.childNo);
            this.groupBox1.Controls.Add(this.roomNo);
            this.groupBox1.Controls.Add(this.destination);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(31, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 260);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter your travelling details here:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listPlaces
            // 
            this.listPlaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cStreet,
            this.cCity,
            this.cProv,
            this.cPrice});
            this.listPlaces.Location = new System.Drawing.Point(521, 99);
            this.listPlaces.Name = "listPlaces";
            this.listPlaces.Size = new System.Drawing.Size(309, 108);
            this.listPlaces.TabIndex = 22;
            this.listPlaces.UseCompatibleStateImageBehavior = false;
            this.listPlaces.View = System.Windows.Forms.View.Details;
            // 
            // cName
            // 
            this.cName.Text = "Name";
            // 
            // cStreet
            // 
            this.cStreet.Text = "Street";
            // 
            // cCity
            // 
            this.cCity.Text = "City";
            // 
            // cProv
            // 
            this.cProv.Text = "Province";
            // 
            // cPrice
            // 
            this.cPrice.Text = "Price";
            // 
            // bookButton
            // 
            this.bookButton.BackColor = System.Drawing.Color.Khaki;
            this.bookButton.Location = new System.Drawing.Point(632, 213);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(93, 36);
            this.bookButton.TabIndex = 21;
            this.bookButton.Text = "Book!";
            this.bookButton.UseVisualStyleBackColor = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Province";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "City";
            // 
            // prov
            // 
            this.prov.Location = new System.Drawing.Point(9, 138);
            this.prov.Name = "prov";
            this.prov.Size = new System.Drawing.Size(200, 20);
            this.prov.TabIndex = 17;
            this.prov.Validating += new System.ComponentModel.CancelEventHandler(this.prov_Validating);
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.Khaki;
            this.findButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.findButton.Location = new System.Drawing.Point(571, 29);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(192, 45);
            this.findButton.TabIndex = 16;
            this.findButton.Text = "Find Hotels and Places";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // adultNo
            // 
            this.adultNo.Location = new System.Drawing.Point(377, 145);
            this.adultNo.Name = "adultNo";
            this.adultNo.Size = new System.Drawing.Size(120, 20);
            this.adultNo.TabIndex = 15;
            this.adultNo.Validating += new System.ComponentModel.CancelEventHandler(this.adultNo_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(377, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Adults:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Children (age<10):";
            // 
            // childNo
            // 
            this.childNo.Location = new System.Drawing.Point(231, 145);
            this.childNo.Name = "childNo";
            this.childNo.Size = new System.Drawing.Size(120, 20);
            this.childNo.TabIndex = 12;
            this.childNo.Validating += new System.ComponentModel.CancelEventHandler(this.childNo_Validating);
            // 
            // roomNo
            // 
            this.roomNo.Location = new System.Drawing.Point(231, 59);
            this.roomNo.Name = "roomNo";
            this.roomNo.Size = new System.Drawing.Size(120, 20);
            this.roomNo.TabIndex = 11;
            this.roomNo.Validating += new System.ComponentModel.CancelEventHandler(this.roomNo_Validating);
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(9, 82);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(200, 20);
            this.destination.TabIndex = 8;
            this.destination.TextChanged += new System.EventHandler(this.destination_TextChanged);
            this.destination.Validating += new System.ComponentModel.CancelEventHandler(this.destination_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Khaki;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(350, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 31);
            this.label7.TabIndex = 8;
            this.label7.Text = "Alpha Travel";
            // 
            // greet
            // 
            this.greet.AutoSize = true;
            this.greet.BackColor = System.Drawing.Color.Khaki;
            this.greet.ForeColor = System.Drawing.Color.Chocolate;
            this.greet.Location = new System.Drawing.Point(627, 4);
            this.greet.Name = "greet";
            this.greet.Size = new System.Drawing.Size(0, 13);
            this.greet.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button1.Location = new System.Drawing.Point(663, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Post An Ad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // myAds
            // 
            this.myAds.BackColor = System.Drawing.Color.Khaki;
            this.myAds.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAds.ForeColor = System.Drawing.Color.SaddleBrown;
            this.myAds.Location = new System.Drawing.Point(31, 389);
            this.myAds.Name = "myAds";
            this.myAds.Size = new System.Drawing.Size(75, 23);
            this.myAds.TabIndex = 11;
            this.myAds.Text = "My Ads";
            this.myAds.UseVisualStyleBackColor = false;
            this.myAds.Click += new System.EventHandler(this.myAds_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button3.Location = new System.Drawing.Point(144, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "My Bookings";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // duration
            // 
            this.duration.Location = new System.Drawing.Point(23, 204);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(120, 20);
            this.duration.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "nights";
            // 
            // AlphaTravel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(891, 424);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.myAds);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.greet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AlphaTravel";
            this.Text = "AlphaTravel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adultNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.NumericUpDown adultNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown childNo;
        private System.Windows.Forms.NumericUpDown roomNo;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label greet;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox prov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button myAds;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.ListView listPlaces;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cStreet;
        private System.Windows.Forms.ColumnHeader cCity;
        private System.Windows.Forms.ColumnHeader cProv;
        private System.Windows.Forms.ColumnHeader cPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown duration;
    }
}

