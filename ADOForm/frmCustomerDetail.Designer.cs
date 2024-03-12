namespace ADOForm
{
    partial class frmCustomerDetail
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
            btonClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tboxCustomerID = new TextBox();
            tboxCompanyName = new TextBox();
            tboxContactName = new TextBox();
            tboxCountry = new TextBox();
            btonSave = new Button();
            SuspendLayout();
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Font = new Font("Segoe UI", 14F);
            btonClose.Location = new Point(446, 297);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(94, 48);
            btonClose.TabIndex = 0;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 1;
            label1.Text = "CustomerID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 2;
            label2.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(30, 136);
            label3.Name = "label3";
            label3.Size = new Size(167, 32);
            label3.TabIndex = 3;
            label3.Text = "Contact Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(30, 191);
            label4.Name = "label4";
            label4.Size = new Size(99, 32);
            label4.TabIndex = 4;
            label4.Text = "Country";
            // 
            // tboxCustomerID
            // 
            tboxCustomerID.Font = new Font("Segoe UI", 14F);
            tboxCustomerID.Location = new Point(247, 27);
            tboxCustomerID.Name = "tboxCustomerID";
            tboxCustomerID.Size = new Size(125, 39);
            tboxCustomerID.TabIndex = 5;
            // 
            // tboxCompanyName
            // 
            tboxCompanyName.Font = new Font("Segoe UI", 14F);
            tboxCompanyName.Location = new Point(247, 80);
            tboxCompanyName.Name = "tboxCompanyName";
            tboxCompanyName.Size = new Size(289, 39);
            tboxCompanyName.TabIndex = 6;
            // 
            // tboxContactName
            // 
            tboxContactName.Font = new Font("Segoe UI", 14F);
            tboxContactName.Location = new Point(247, 136);
            tboxContactName.Name = "tboxContactName";
            tboxContactName.Size = new Size(289, 39);
            tboxContactName.TabIndex = 7;
            // 
            // tboxCountry
            // 
            tboxCountry.Font = new Font("Segoe UI", 14F);
            tboxCountry.Location = new Point(247, 188);
            tboxCountry.Name = "tboxCountry";
            tboxCountry.Size = new Size(170, 39);
            tboxCountry.TabIndex = 8;
            // 
            // btonSave
            // 
            btonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonSave.Font = new Font("Segoe UI", 14F);
            btonSave.Location = new Point(247, 251);
            btonSave.Name = "btonSave";
            btonSave.Size = new Size(125, 48);
            btonSave.TabIndex = 9;
            btonSave.Text = "Kaydet";
            btonSave.UseVisualStyleBackColor = true;
            btonSave.Click += btonSave_Click;
            // 
            // frmCustomerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 357);
            Controls.Add(btonSave);
            Controls.Add(tboxCountry);
            Controls.Add(tboxContactName);
            Controls.Add(tboxCompanyName);
            Controls.Add(tboxCustomerID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btonClose);
            Name = "frmCustomerDetail";
            Text = "frmCustomerDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btonClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btonSave;
        public TextBox tboxCustomerID;
        public TextBox tboxCompanyName;
        public TextBox tboxContactName;
        public TextBox tboxCountry;
    }
}