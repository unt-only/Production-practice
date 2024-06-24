using System;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username == "admin" && password == "123")
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте ещё раз.");
            }
        }
    }
}
