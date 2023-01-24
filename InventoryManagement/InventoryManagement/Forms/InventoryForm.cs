using ProductManagement.Classes;
using ProductManagement.Classes.Subclasses;
using System.Data;

namespace InventoryManagement
{
    public partial class InventoryForm : Form
    {
        public FirstPageForm firstPageForm;
        private Store _store;
        private string _storeSelected;
        private string _username;

        public InventoryForm()
        {
            InitializeComponent();
        }
        public InventoryForm(string storeSelected, string username)
        {
            InitializeComponent();

            _storeSelected = storeSelected;
            _username = username;

            _store = new Store();
            _store.LoadProducts();

            RefreshProductList();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            //...
        }

        private bool CheckIfNullOrEmpty()
        {
            if (isPackage.Checked)
            {
                if(string.IsNullOrEmpty(nrInPackageTextBox.Text) || string.IsNullOrEmpty(packageWeightTextBox.Text))
                {
                    MessageBox.Show("All fields must be completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            if (string.IsNullOrEmpty(productNameTextBox.Text) || string.IsNullOrEmpty(productPriceTextBox.Text) || string.IsNullOrEmpty(productQuantityTextBox.Text))
            {
                MessageBox.Show("All fields must be completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void AddProduct()
        {
            int _nrInPackage;
            double _packageWeight;

            if (!CheckIfNullOrEmpty())
            {
                if (!double.TryParse(productPriceTextBox.Text, out double price))
                {
                    MessageBox.Show("Product Price must be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(productQuantityTextBox.Text, out int quantity))
                {
                    MessageBox.Show("Product Quantity must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isPackage.Checked)
                {
                    if (!int.TryParse(nrInPackageTextBox.Text, out int nrInPackage))
                    {
                        MessageBox.Show("Number of products in the package must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!double.TryParse(packageWeightTextBox.Text, out double packageWeight))
                    {
                        MessageBox.Show("Package weight must be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    _nrInPackage = nrInPackage;
                    _packageWeight = packageWeight;
                }
                else
                {
                    _nrInPackage = -1;
                    _packageWeight = -1;
                }

                try
                {
                    int id = _store.TotalProducts;
                    string name = productNameTextBox.Text;
                    PackageProduct prd = new PackageProduct { Store = _storeSelected, Id = id, Name = name, Price = price, Quantity = quantity, NumberInPackage = _nrInPackage, PackWeight = _packageWeight };
                    _store.AddProduct(prd);

                    RefreshProductList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RemoveProduct()
        {
            if (!int.TryParse(productIdTextBox.Text, out int id))
            {
                MessageBox.Show("Product Id must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _store.RemoveProduct(id);

                RefreshProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProduct()
        {
            if (!CheckIfNullOrEmpty() && !string.IsNullOrEmpty(productIdTextBox.Text))
            {
                if (!int.TryParse(productIdTextBox.Text, out int id))
                {
                    MessageBox.Show("Product Id must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(productPriceTextBox.Text, out double price))
                {
                    MessageBox.Show("Product Price must be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(productQuantityTextBox.Text, out int quantity))
                {
                    MessageBox.Show("Product Quantity must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(nrInPackageTextBox.Text, out int nrInPackage))
                {
                    MessageBox.Show("Number of products in the package must be a valid integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(packageWeightTextBox.Text, out double packageWeight))
                {
                    MessageBox.Show("Package weight must be a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string name = productNameTextBox.Text;
                    _store.UpdateProduct(id, name, price, quantity, nrInPackage, packageWeight);

                    RefreshProductList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshProductList()
        {
            try
            {
                productGridView.DataSource = null;
                var products = _store.GetAllProducts();
                products = products.OrderBy(p => p.Id).ToList();
                products = products.Where(p => p.Store.Equals(_storeSelected)).ToList();

                DataTable productTable = new DataTable();
                productTable.Columns.Add("Id", typeof(int));
                productTable.Columns.Add("Store", typeof(string));
                productTable.Columns.Add("Name", typeof(string));
                productTable.Columns.Add("Price", typeof(decimal));
                productTable.Columns.Add("Quantity", typeof(int));
                productTable.Columns.Add("NumberInPackage", typeof(int));
                productTable.Columns.Add("PackWeight", typeof(decimal));

                foreach (var product in products)
                {
                    productTable.Rows.Add(product.Id, product.Store, product.Name, product.Price, product.Quantity, product.NumberInPackage, product.PackWeight);
                }

                productGridView.DataSource = productTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            RemoveProduct();
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveProduct();
        }

        private void previousFormButton_Click(object sender, EventArgs e)
        {
            firstPageForm = new FirstPageForm(_username);
            firstPageForm.Show();
            this.Hide();
        }

        private void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void isPackage_CheckedChanged(object sender, EventArgs e)
        {
            if (isPackage.Checked)
            {
                nrInPackageTextBox.Enabled = true;
                packageWeightTextBox.Enabled = true;
            }
            else
            {
                nrInPackageTextBox.Enabled = false;
                packageWeightTextBox.Enabled = false;
            }
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            firstPageForm = new FirstPageForm(_username);
            firstPageForm.Show();
            this.Hide();
        }
    }
}
