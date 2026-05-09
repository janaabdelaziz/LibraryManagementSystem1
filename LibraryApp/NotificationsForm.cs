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
    public partial class NotificationsForm : Form
    {

        private Controller controllerObj;
        private int _currentUserId;

        public NotificationsForm(int userId)
        {
            InitializeComponent();
            controllerObj = new Controller();
            _currentUserId = userId;
        }

        private void NotificationsForm_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetNotificationsForUser(_currentUserId);
            dgvNotifications.DataSource = dt;

        }

        private void dgvNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
