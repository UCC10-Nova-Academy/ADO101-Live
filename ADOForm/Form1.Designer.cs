namespace ADOForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tboxEmployeeID = new TextBox();
            tboxFName = new TextBox();
            tboxLName = new TextBox();
            tboxTitle = new TextBox();
            tboxCity = new TextBox();
            tboxCountry = new TextBox();
            btonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 37);
            label1.Name = "label1";
            label1.Size = new Size(108, 25);
            label1.TabIndex = 0;
            label1.Text = "EmployeeID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 74);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 111);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 148);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 185);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 224);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 5;
            label6.Text = "Country";
            // 
            // tboxEmployeeID
            // 
            tboxEmployeeID.Location = new Point(158, 34);
            tboxEmployeeID.Name = "tboxEmployeeID";
            tboxEmployeeID.Size = new Size(65, 31);
            tboxEmployeeID.TabIndex = 6;
            // 
            // tboxFName
            // 
            tboxFName.Location = new Point(158, 71);
            tboxFName.Name = "tboxFName";
            tboxFName.Size = new Size(190, 31);
            tboxFName.TabIndex = 7;
            // 
            // tboxLName
            // 
            tboxLName.Location = new Point(158, 108);
            tboxLName.Name = "tboxLName";
            tboxLName.Size = new Size(190, 31);
            tboxLName.TabIndex = 8;
            // 
            // tboxTitle
            // 
            tboxTitle.Location = new Point(158, 145);
            tboxTitle.Name = "tboxTitle";
            tboxTitle.Size = new Size(190, 31);
            tboxTitle.TabIndex = 9;
            // 
            // tboxCity
            // 
            tboxCity.Location = new Point(158, 182);
            tboxCity.Name = "tboxCity";
            tboxCity.Size = new Size(190, 31);
            tboxCity.TabIndex = 10;
            // 
            // tboxCountry
            // 
            tboxCountry.Location = new Point(158, 221);
            tboxCountry.Name = "tboxCountry";
            tboxCountry.Size = new Size(190, 31);
            tboxCountry.TabIndex = 11;
            // 
            // btonExit
            // 
            btonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonExit.Location = new Point(401, 395);
            btonExit.Name = "btonExit";
            btonExit.Size = new Size(112, 34);
            btonExit.TabIndex = 12;
            btonExit.Text = "Çıkış";
            btonExit.UseVisualStyleBackColor = true;
            btonExit.Click += btonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 441);
            Controls.Add(btonExit);
            Controls.Add(tboxCountry);
            Controls.Add(tboxCity);
            Controls.Add(tboxTitle);
            Controls.Add(tboxLName);
            Controls.Add(tboxFName);
            Controls.Add(tboxEmployeeID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tboxEmployeeID;
        private TextBox tboxFName;
        private TextBox tboxLName;
        private TextBox tboxTitle;
        private TextBox tboxCity;
        private TextBox tboxCountry;
        private Button btonExit;
    }
}
