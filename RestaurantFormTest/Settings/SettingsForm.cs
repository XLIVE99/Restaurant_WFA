using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantFormTest.Settings
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fileD = new FolderBrowserDialog())
            {
                if(fileD.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fileD.SelectedPath))
                {
                    textBox_save.Text = fileD.SelectedPath;
                    Properties.Settings.Default.Save_location = fileD.SelectedPath;
                }
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textBox_save.Text = Properties.Settings.Default.Save_location;
            textBox_prefix.Text = Properties.Settings.Default.Table_Prefix;
            textBox_rest_name.Text = Properties.Settings.Default.Rest_Name;
        }

        private void textBox_prefix_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Table_Prefix = textBox_prefix.Text;
        }

        private void Apply_click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Close();
        }

        private void Cancel_click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_rest_name_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Rest_Name = textBox_rest_name.Text;
        }
    }
}
