using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recreationapp
{
    public partial class LoginForm : Form
    {
        List<Price> priceRateList;
        String csvfileLocation;

        public LoginForm()
        {
            InitializeComponent();
        }

        public  void ValidateCredentials()
        {
            if(usernameTxtField.Text == "")
            {
                usernameError.ForeColor = Color.Red;
                usernameError.Text = "Please enter username";
            }
            else
            {
                usernameError.Text = "";
            }
            if (passwordTxtField.Text == "")
            {
                passwordError.ForeColor = Color.Red;
                passwordError.Text = "Please enter password";
            }
            else
            {
                passwordError.Text = "";
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            ValidateCredentials();
            if (usernameTxtField.Text == "admin" && passwordTxtField.Text == "admin")
            {
                this.Hide();
                AdminForm form = new AdminForm();
                form.ShowDialog();
            }
            else if (usernameTxtField.Text == "staff" && passwordTxtField.Text == "staff" && priceRateList == null)
            {
                MessageBox.Show("Please Import the Price Rate First From the Admin Panel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(usernameTxtField.Text == "staff" && passwordTxtField.Text == "staff" && priceRateList!=null)
            {
                this.Hide();
                StaffForm form = new StaffForm();
                form.Receive(priceRateList, csvfileLocation);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect credentials", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTxtField.PasswordChar = '\0';
        }

        public void Receive(List<Price> priceRate, String fileLocation)
        {
            priceRateList = priceRate;
            csvfileLocation = fileLocation;
        }
    }
}
