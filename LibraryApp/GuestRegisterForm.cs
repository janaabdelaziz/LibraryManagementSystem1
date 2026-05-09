using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp
{
    public partial class GuestRegisterForm : Form
    {

        private Controller controllerObj;
        public GuestRegisterForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void GuestRegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterGuest_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // Basic validation
            if (name == "" || email == "" || password == "")
            {
                MessageBox.Show("Name, Email, and Password are required.");
                return;
            }

            int result = controllerObj.RegisterGuest(name, email, password, phone);

            if (result > 0)
            {
                MessageBox.Show("Registration successful! You can now log in as a member/guest.");
                this.Close();  // or clear fields if you prefer
            }
            else
            {
                MessageBox.Show("Registration failed. Email might already be used.");
            }
        }
    }
}
