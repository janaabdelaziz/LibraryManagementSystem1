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
    public partial class MyFinesForm : Form
    {

        private Controller controllerObj;
        private int _currentUserId;

        public MyFinesForm(int userId)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _currentUserId = userId;
        }

        private void MyFinesForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetFinesForUser(_currentUserId);
            dgvFines.DataSource = dt;

        }
    }
}
