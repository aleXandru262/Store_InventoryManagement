namespace InventoryManagement
{
    partial class FirstPageForm
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
            this.nextFormButton = new System.Windows.Forms.Button();
            this.usernameLoggedLabel = new System.Windows.Forms.Label();
            this.storeListBox = new System.Windows.Forms.ListBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextFormButton
            // 
            this.nextFormButton.Location = new System.Drawing.Point(48, 182);
            this.nextFormButton.Name = "nextFormButton";
            this.nextFormButton.Size = new System.Drawing.Size(235, 40);
            this.nextFormButton.TabIndex = 0;
            this.nextFormButton.Text = "Go to Inventory Management";
            this.nextFormButton.UseVisualStyleBackColor = true;
            this.nextFormButton.Click += new System.EventHandler(this.nextFormButton_Click);
            // 
            // usernameLoggedLabel
            // 
            this.usernameLoggedLabel.AutoSize = true;
            this.usernameLoggedLabel.Location = new System.Drawing.Point(12, 9);
            this.usernameLoggedLabel.Name = "usernameLoggedLabel";
            this.usernameLoggedLabel.Size = new System.Drawing.Size(73, 15);
            this.usernameLoggedLabel.TabIndex = 8;
            this.usernameLoggedLabel.Text = "User logged:";
            // 
            // storeListBox
            // 
            this.storeListBox.FormattingEnabled = true;
            this.storeListBox.ItemHeight = 15;
            this.storeListBox.Items.AddRange(new object[] {
            "Electronics Store",
            "Clothing Store",
            "Bookstore"});
            this.storeListBox.Location = new System.Drawing.Point(89, 85);
            this.storeListBox.Name = "storeListBox";
            this.storeListBox.Size = new System.Drawing.Size(165, 49);
            this.storeListBox.TabIndex = 9;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(125, 67);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(87, 15);
            this.selectLabel.TabIndex = 10;
            this.selectLabel.Text = "Select the store";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(125, 228);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Log Out ";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FirstPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 275);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.selectLabel);
            this.Controls.Add(this.storeListBox);
            this.Controls.Add(this.usernameLoggedLabel);
            this.Controls.Add(this.nextFormButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstPageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FirstPageForm_FormClosing);
            this.Load += new System.EventHandler(this.FirstPageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nextFormButton;
        private Label usernameLoggedLabel;
        private ListBox storeListBox;
        private Label selectLabel;
        private Button logoutButton;
    }
}