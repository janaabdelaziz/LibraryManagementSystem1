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
    
    public partial class Form1 : Form
    {
        private int _currentUserId;
        private int _roleId;
        Controller controllerObj;
        public Form1(int userId, int roleId)
        {
            _currentUserId = userId;
            _roleId = roleId;
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void btnCountUsers_Click(object sender, EventArgs e)
        {
            int count = controllerObj.CountUsers();
            MessageBox.Show("Number of users = " + count);
        }

        private void btnOpenBookSearch_Click(object sender, EventArgs e)
        {
            BookSearchForm f = new BookSearchForm(_currentUserId);
            f.Show();
        }

        private void btnMyHistory_Click(object sender, EventArgs e)
        {
            BorrowingHistoryForm f = new BorrowingHistoryForm(_currentUserId);
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMyReservations_Click(object sender, EventArgs e)
        {
            MyReservationsForm f = new MyReservationsForm(_currentUserId);
            f.Show();
        }

        private void btnMyFines_Click(object sender, EventArgs e)
        {
            MyFinesForm f = new MyFinesForm(_currentUserId);
            f.Show();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            NotificationsForm f = new NotificationsForm(_currentUserId);
            f.Show();
        }
    }
}
