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
    public partial class IntDialog : Form
    {
        public IntDialog()
        {
            InitializeComponent();
        }

        Action<int> storedAction;

        public IntDialog(string formName, string labelName, string warnName, string buttonName, Action<int> completeAction)
        {
            InitializeComponent();

            Text = formName;
            label_exp.Text = labelName;
            label_warning.Text = warnName + " must be positive";
            button_done.Text = buttonName;

            storedAction = completeAction;
        }

        private void button_cancel_click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            if (numeric_input.Value <= 0)
            {
                label_warning.Visible = true;
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Enabled = true;
                timer.Start();
                timer.Tick += warning_timer;

                numeric_input.Focus();
            }
            else
            {
                storedAction((int)numeric_input.Value);
                Close();
            }
        }

        private void warning_timer(object sender, EventArgs e)
        {
            label_warning.Visible = false;
        }
    }
}
