using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantFormTest.CustomDialogs
{
    public partial class FailDialog : Form
    {
        public FailDialog()
        {
            InitializeComponent();
        }

        public FailDialog(string err)
        {
            InitializeComponent();

            label_error.Text = err;
        }

        private void CloseDialog(object sender, EventArgs e)
        {
            Close();
        }
    }
}
