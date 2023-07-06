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
    public partial class StringDialog : Form
    {
        public StringDialog()
        {
            InitializeComponent();
        }

        Action<string> storedAction;

        public StringDialog(string formName, string labelName, string warnName, string buttonName, Action<string> completeAction)
        {
            InitializeComponent();

            Text = formName;
            label_exp.Text = labelName;
            label_warning.Text = warnName + " cannot be empty";
            button_done.Text = buttonName;

            storedAction = completeAction;
        }

        private void button_cancel_click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox_Result.Text))
            {
                label_warning.Visible = true;
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Enabled = true;
                timer.Start();
                timer.Tick += warning_timer;

                textBox_Result.Focus();
            }
            else
            {
                storedAction(textBox_Result.Text);
                Close();
            }
        }

        private void warning_timer(object sender, EventArgs e)
        {
            label_warning.Visible = false;
        }
    }
}
