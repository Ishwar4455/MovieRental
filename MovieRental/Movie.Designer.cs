namespace MovieRental
{
    partial class Movie
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
            this.zzzz = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCustomerFName = new System.Windows.Forms.TextBox();
            this.txtCustomerLName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRentalCost = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.rdAllRented = new System.Windows.Forms.RadioButton();
            this.rdOutRented = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRentalID = new System.Windows.Forms.TextBox();
            this.zzzz.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zzzz
            // 
            this.zzzz.Controls.Add(this.tabPage1);
            this.zzzz.Controls.Add(this.tabPage2);
            this.zzzz.Controls.Add(this.tabPage3);
            this.zzzz.Location = new System.Drawing.Point(40, 22);
            this.zzzz.Name = "zzzz";
            this.zzzz.SelectedIndex = 0;
            this.zzzz.Size = new System.Drawing.Size(636, 254);
            this.zzzz.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(715, 228);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(628, 228);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rental";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(632, 228);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Customer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(144, 282);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(58, 20);
            this.txtCustomerID.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(337, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete Customer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCustomerFName
            // 
            this.txtCustomerFName.Location = new System.Drawing.Point(144, 312);
            this.txtCustomerFName.Name = "txtCustomerFName";
            this.txtCustomerFName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerFName.TabIndex = 5;
            // 
            // txtCustomerLName
            // 
            this.txtCustomerLName.Location = new System.Drawing.Point(259, 312);
            this.txtCustomerLName.Name = "txtCustomerLName";
            this.txtCustomerLName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerLName.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(365, 312);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(471, 311);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(576, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 49);
            this.button4.TabIndex = 9;
            this.button4.Text = "Return Movie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.Location = new System.Drawing.Point(640, 278);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(59, 49);
            this.btnIssueMovie.TabIndex = 10;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = true;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(40, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Add Movie";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(144, 357);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.ReadOnly = true;
            this.txtMovieID.Size = new System.Drawing.Size(58, 20);
            this.txtMovieID.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(209, 356);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(316, 357);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 14;
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Location = new System.Drawing.Point(423, 357);
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.Size = new System.Drawing.Size(100, 20);
            this.txtRentalCost.TabIndex = 15;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(530, 357);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(100, 20);
            this.txtPlot.TabIndex = 16;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(40, 400);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 23);
            this.button7.TabIndex = 17;
            this.button7.Text = "Delete Movie";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(144, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(100, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "Update Movie";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // rdAllRented
            // 
            this.rdAllRented.AutoSize = true;
            this.rdAllRented.Location = new System.Drawing.Point(3, 23);
            this.rdAllRented.Name = "rdAllRented";
            this.rdAllRented.Size = new System.Drawing.Size(74, 17);
            this.rdAllRented.TabIndex = 19;
            this.rdAllRented.TabStop = true;
            this.rdAllRented.Text = "All Rented";
            this.rdAllRented.UseVisualStyleBackColor = true;
            this.rdAllRented.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdOutRented
            // 
            this.rdOutRented.AutoSize = true;
            this.rdOutRented.Location = new System.Drawing.Point(94, 23);
            this.rdOutRented.Name = "rdOutRented";
            this.rdOutRented.Size = new System.Drawing.Size(80, 17);
            this.rdOutRented.TabIndex = 20;
            this.rdOutRented.TabStop = true;
            this.rdOutRented.Text = "Out Rented";
            this.rdOutRented.UseVisualStyleBackColor = true;
            this.rdOutRented.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdAllRented);
            this.panel1.Controls.Add(this.rdOutRented);
            this.panel1.Location = new System.Drawing.Point(588, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 55);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Rented Movies";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRentalID
            // 
            this.txtRentalID.Location = new System.Drawing.Point(636, 357);
            this.txtRentalID.Name = "txtRentalID";
            this.txtRentalID.ReadOnly = true;
            this.txtRentalID.Size = new System.Drawing.Size(28, 20);
            this.txtRentalID.TabIndex = 22;
            // 
            // Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRentalID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtRentalCost);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnIssueMovie);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCustomerLName);
            this.Controls.Add(this.txtCustomerFName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zzzz);
            this.Name = "Movie";
            this.Text = "Movie";
            this.zzzz.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl zzzz;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCustomerFName;
        private System.Windows.Forms.TextBox txtCustomerLName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRentalCost;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton rdAllRented;
        private System.Windows.Forms.RadioButton rdOutRented;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtRentalID;
    }
}