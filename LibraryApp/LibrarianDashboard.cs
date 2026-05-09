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
    public partial class LibrarianDashboard : Form
    {
        private int _currentUserId;
        public LibrarianDashboard(int userId)
        {
            _currentUserId = userId;
            InitializeComponent();
        }

        private void LibrarianDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
