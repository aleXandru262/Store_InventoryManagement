using InventoryManagement.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagement
{
    public partial class FirstPageForm : Form
    {
        InventoryForm inventoryForm;
        private string _storeSelected;
        private string _username;

        public FirstPageForm()
        {
            InitializeComponent();
        }

        public FirstPageForm(string username)
        {
            InitializeComponent();

            _username = username;

            usernameLoggedLabel.Text = usernameLoggedLabel.Text + " " + _username;
        }

        private void nextFormButton_Click(object sender, EventArgs e)
        {
            if (storeListBox.SelectedIndex != -1)
            {
                _storeSelected = storeListBox.SelectedItem.ToString();
                inventoryForm = new InventoryForm(_storeSelected, _username);
                inventoryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a store", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FirstPageForm_Load(object sender, EventArgs e)
        {
            //...
        }

        private void FirstPageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }
    }
}