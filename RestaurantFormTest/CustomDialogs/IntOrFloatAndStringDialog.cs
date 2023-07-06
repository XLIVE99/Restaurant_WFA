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
    public partial class IntOrFloatAndStringDialog : Form
    {
        public IntOrFloatAndStringDialog()
        {
            InitializeComponent();
        }

        Action<string, float> storedAction;

        public IntOrFloatAndStringDialog(string formName, string labelSName, string labelIName, string buttonName, Action<string, float> completeAction)
        {
            InitializeComponent();

            Text = formName;
            label_string.Text = labelSName;
            label_float.Text = labelIName;
            button_done.Text = buttonName;

            storedAction = completeAction;
        }

        public IntOrFloatAndStringDialog(string formName, string labelSName, string labelIName, string buttonName, string defStringValue, float defFloatValue, Action<string, float> completeAction)
        {
            InitializeComponent();

            Text = formName;
            label_string.Text = labelSName;
            label_float.Text = labelIName;
            button_done.Text = buttonName;

            textBox_string.Text = defStringValue;
            textBox_number.Text = defFloatValue.ToString();

            storedAction = completeAction;
        }

        private void button_cancel_click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            float result = 0;
            if (String.IsNullOrWhiteSpace(textBox_string.Text))
            {
                label_warning.Text = label_string.Text + " cannot be empty";
                label_warning.Visible = true;
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Enabled = true;
                timer.Start();
                timer.Tick += warning_timer;

                textBox_string.Focus();
            }
            else if(!float.TryParse(textBox_number.Text, out result))
            {
                label_warning.Text = label_float + " must be a number";
                label_warning.Visible = true;
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Enabled = true;
                timer.Start();
                timer.Tick += warning_timer;

                textBox_string.Focus();
            }
            else
            {
                storedAction(textBox_string.Text, result);
                Close();
            }
        }

        private void warning_timer(object sender, EventArgs e)
        {
            label_warning.Visible = false;
        }
    }
}
