using System.Xml.Serialization;

namespace InventoryManagement.Forms
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            //...
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                string username = usernameTextBox.Text;
                string password = passwordTextBox.Text;

                if (CheckCredentials(username, password))
                {
                    FirstPageForm firstPageForm = new FirstPageForm(username);
                    firstPageForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields must be completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private bool CheckCredentials(string username, string password)
        {
            string path = "C:\\Users\\rusal\\source\\repos\\InventoryManagement\\InventoryManagement\\Resources\\credentials.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<AdministrativeManagement.Classes.User>), new XmlRootAttribute("Users"));
            using (FileStream stream = File.OpenRead(path))
            {
                List<AdministrativeManagement.Classes.User> users = serializer.Deserialize(stream) as List<AdministrativeManagement.Classes.User>;
                return users.Any(u => u.Username == username && u.Password == password);
            }
        }
    }
}
