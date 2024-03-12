namespace ADOForm
{
    partial class frmCustomers
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
            label1 = new Label();
            btonClose = new Button();
            dgrdCustomers = new DataGridView();
            btonAdd = new Button();
            btonUpdate = new Button();
            btonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgrdCustomers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 0;
            label1.Text = "Customers Data";
            // 
            // btonClose
            // 
            btonClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btonClose.Font = new Font("Segoe UI", 14F);
            btonClose.Location = new Point(844, 421);
            btonClose.Name = "btonClose";
            btonClose.Size = new Size(99, 48);
            btonClose.TabIndex = 1;
            btonClose.Text = "Kapat";
            btonClose.UseVisualStyleBackColor = true;
            btonClose.Click += btonClose_Click;
            // 
            // dgrdCustomers
            // 
            dgrdCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrdCustomers.Location = new Point(30, 83);
            dgrdCustomers.Name = "dgrdCustomers";
            dgrdCustomers.RowHeadersWidth = 51;
            dgrdCustomers.Size = new Size(849, 273);
            dgrdCustomers.TabIndex = 2;
            // 
            // btonAdd
            // 
            btonAdd.Font = new Font("Segoe UI", 12F);
            btonAdd.Location = new Point(36, 377);
            btonAdd.Name = "btonAdd";
            btonAdd.Size = new Size(112, 44);
            btonAdd.TabIndex = 3;
            btonAdd.Text = "Ekle";
            btonAdd.UseVisualStyleBackColor = true;
            btonAdd.Click += btonAdd_Click;
            // 
            // btonUpdate
            // 
            btonUpdate.Font = new Font("Segoe UI", 12F);
            btonUpdate.Location = new Point(174, 377);
            btonUpdate.Name = "btonUpdate";
            btonUpdate.Size = new Size(112, 44);
            btonUpdate.TabIndex = 4;
            btonUpdate.Text = "Güncelle";
            btonUpdate.UseVisualStyleBackColor = true;
            btonUpdate.Click += btonUpdate_Click;
            // 
            // btonDelete
            // 
            btonDelete.Font = new Font("Segoe UI", 12F);
            btonDelete.Location = new Point(308, 377);
            btonDelete.Name = "btonDelete";
            btonDelete.Size = new Size(112, 44);
            btonDelete.TabIndex = 5;
            btonDelete.Text = "Sil";
            btonDelete.UseVisualStyleBackColor = true;
            btonDelete.Click += btonDelete_Click;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 481);
            Controls.Add(btonDelete);
            Controls.Add(btonUpdate);
            Controls.Add(btonAdd);
            Controls.Add(dgrdCustomers);
            Controls.Add(btonClose);
            Controls.Add(label1);
            Name = "frmCustomers";
            Text = "frmCustomers";
            Load += frmCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgrdCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btonClose;
        private DataGridView dgrdCustomers;
        private Button btonAdd;
        private Button btonUpdate;
        private Button btonDelete;
    }
}