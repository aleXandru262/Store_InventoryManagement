namespace InventoryManagement
{
    partial class InventoryForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.addProductButton = new System.Windows.Forms.Button();
            this.removeProductButton = new System.Windows.Forms.Button();
            this.updateProductButton = new System.Windows.Forms.Button();
            this.previousFormButton = new System.Windows.Forms.Button();
            this.isPackage = new System.Windows.Forms.CheckBox();
            this.nrInPackageLabel = new System.Windows.Forms.Label();
            this.nrInPackageTextBox = new System.Windows.Forms.TextBox();
            this.packageWeightLabel = new System.Windows.Forms.Label();
            this.packageWeightTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.homePageToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.homePageToolStripMenuItem.Text = "Home Page";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(150, 52);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(89, 23);
            this.productIdTextBox.TabIndex = 1;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(26, 52);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 15);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 97);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Name:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(150, 97);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(89, 23);
            this.productNameTextBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(26, 142);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 15);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "Price:";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(150, 142);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(89, 23);
            this.productPriceTextBox.TabIndex = 5;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(26, 187);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(56, 15);
            this.quantityLabel.TabIndex = 8;
            this.quantityLabel.Text = "Quantity:";
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(150, 187);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(89, 23);
            this.productQuantityTextBox.TabIndex = 7;
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(264, 52);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 25;
            this.productGridView.Size = new System.Drawing.Size(732, 248);
            this.productGridView.TabIndex = 10;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(264, 383);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(75, 23);
            this.addProductButton.TabIndex = 11;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // removeProductButton
            // 
            this.removeProductButton.Location = new System.Drawing.Point(345, 383);
            this.removeProductButton.Name = "removeProductButton";
            this.removeProductButton.Size = new System.Drawing.Size(75, 23);
            this.removeProductButton.TabIndex = 12;
            this.removeProductButton.Text = "Remove";
            this.removeProductButton.UseVisualStyleBackColor = true;
            this.removeProductButton.Click += new System.EventHandler(this.removeProductButton_Click);
            // 
            // updateProductButton
            // 
            this.updateProductButton.Location = new System.Drawing.Point(426, 383);
            this.updateProductButton.Name = "updateProductButton";
            this.updateProductButton.Size = new System.Drawing.Size(75, 23);
            this.updateProductButton.TabIndex = 13;
            this.updateProductButton.Text = "Update";
            this.updateProductButton.UseVisualStyleBackColor = true;
            this.updateProductButton.Click += new System.EventHandler(this.updateProductButton_Click);
            // 
            // previousFormButton
            // 
            this.previousFormButton.Location = new System.Drawing.Point(880, 375);
            this.previousFormButton.Name = "previousFormButton";
            this.previousFormButton.Size = new System.Drawing.Size(116, 31);
            this.previousFormButton.TabIndex = 14;
            this.previousFormButton.Text = "Go to Home Page";
            this.previousFormButton.UseVisualStyleBackColor = true;
            this.previousFormButton.Click += new System.EventHandler(this.previousFormButton_Click);
            // 
            // isPackage
            // 
            this.isPackage.AutoSize = true;
            this.isPackage.Location = new System.Drawing.Point(26, 331);
            this.isPackage.Name = "isPackage";
            this.isPackage.Size = new System.Drawing.Size(198, 19);
            this.isPackage.TabIndex = 15;
            this.isPackage.Text = "The product comes as a package";
            this.isPackage.UseVisualStyleBackColor = true;
            this.isPackage.CheckedChanged += new System.EventHandler(this.isPackage_CheckedChanged);
            // 
            // nrInPackageLabel
            // 
            this.nrInPackageLabel.AutoSize = true;
            this.nrInPackageLabel.Location = new System.Drawing.Point(26, 232);
            this.nrInPackageLabel.Name = "nrInPackageLabel";
            this.nrInPackageLabel.Size = new System.Drawing.Size(119, 15);
            this.nrInPackageLabel.TabIndex = 17;
            this.nrInPackageLabel.Text = "Numbers in package:";
            // 
            // nrInPackageTextBox
            // 
            this.nrInPackageTextBox.Enabled = false;
            this.nrInPackageTextBox.Location = new System.Drawing.Point(150, 232);
            this.nrInPackageTextBox.Name = "nrInPackageTextBox";
            this.nrInPackageTextBox.Size = new System.Drawing.Size(89, 23);
            this.nrInPackageTextBox.TabIndex = 16;
            // 
            // packageWeightLabel
            // 
            this.packageWeightLabel.AutoSize = true;
            this.packageWeightLabel.Location = new System.Drawing.Point(26, 277);
            this.packageWeightLabel.Name = "packageWeightLabel";
            this.packageWeightLabel.Size = new System.Drawing.Size(93, 15);
            this.packageWeightLabel.TabIndex = 19;
            this.packageWeightLabel.Text = "Package weight:";
            // 
            // packageWeightTextBox
            // 
            this.packageWeightTextBox.Enabled = false;
            this.packageWeightTextBox.Location = new System.Drawing.Point(150, 277);
            this.packageWeightTextBox.Name = "packageWeightTextBox";
            this.packageWeightTextBox.Size = new System.Drawing.Size(89, 23);
            this.packageWeightTextBox.TabIndex = 18;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.packageWeightLabel);
            this.Controls.Add(this.packageWeightTextBox);
            this.Controls.Add(this.nrInPackageLabel);
            this.Controls.Add(this.nrInPackageTextBox);
            this.Controls.Add(this.isPackage);
            this.Controls.Add(this.previousFormButton);
            this.Controls.Add(this.updateProductButton);
            this.Controls.Add(this.removeProductButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.productQuantityTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryForm_FormClosing);
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private TextBox productIdTextBox;
        private Label idLabel;
        private Label nameLabel;
        private TextBox productNameTextBox;
        private Label priceLabel;
        private TextBox productPriceTextBox;
        private Label quantityLabel;
        private TextBox productQuantityTextBox;
        private DataGridView productGridView;
        private Button addProductButton;
        private Button removeProductButton;
        private Button updateProductButton;
        private Button previousFormButton;
        private CheckBox isPackage;
        private Label nrInPackageLabel;
        private TextBox nrInPackageTextBox;
        private Label packageWeightLabel;
        private TextBox packageWeightTextBox;
        private ToolStripMenuItem homePageToolStripMenuItem;
    }
}