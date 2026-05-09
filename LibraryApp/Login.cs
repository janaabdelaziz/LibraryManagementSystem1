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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            DataTable dt = controller.Login(usertxt.Text, passtxt.Text);

            if (dt.Rows.Count == 0)
            {

                MessageBox.Show("Wrong username or password");
                return;
            }

            string status = dt.Rows[0]["Status"].ToString();

            if (status != "Active")
            {
                MessageBox.Show("Account is not active");
                return;
            }

            int userId = Convert.ToInt32(dt.Rows[0]["UserID"]);
            int roleId = Convert.ToInt32(dt.Rows[0]["RoleID"]);

            string role = dt.Rows[0]["RoleID"].ToString();

            //////////roles
            if (roleId == 1)
            {
                AdminDashboard form = new AdminDashboard(userId);
                form.Show();
            }
            else if (roleId == 3 || roleId == 4)
            {
                Form1 form = new Form1(userId, roleId);
                form.Show();
            }
            else if (roleId == 2)
            {
                LibrarianDashboard form = new LibrarianDashboard(userId);
                form.Show();
            }



            //this.Hide();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
        }

        private void forgotbtn_Click(object sender, EventArgs e)
        {
            ChangePassword chpass = new ChangePassword();
            chpass.Show();
        }

        private void btnGuestRegister_Click(object sender, EventArgs e)
        {
            GuestRegisterForm f = new GuestRegisterForm();
            f.Show();
        }

        private void btnGuestSearch_Click(object sender, EventArgs e)
        {
            int guestUserId = 0;   // or any value you use to mean 'guest'
            BookSearchForm f = new BookSearchForm(guestUserId);
            f.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}