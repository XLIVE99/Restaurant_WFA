using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantFormTest.Tables;
using RestaurantFormTest.Menu;
using RestaurantFormTest.Settings;
using RestaurantFormTest.Database;
using RestaurantFormTest.CustomDialogs;

namespace RestaurantFormTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            new database();
            database.instance.LoadMenus();
        }

        public void CreateTable(string prefix)
        {
            int count = database.instance.tables.Count;
            int fakeCount = count;
            string tableName = prefix + count.ToString();
            while(HasTable(tableName))
            {
                fakeCount++;
                tableName = prefix + fakeCount.ToString();
            }
            UCTable newT = new UCTable(tableName, count);
            newT.Parent = table_panel;

            database.instance.tables.Add(new db_table(prefix + count.ToString()));
            database.instance.SaveTables();
        }

        public void TableDeleted()
        {
            for (int i = 0; i < table_panel.Controls.Count; i++)
            {
                UCTable curTable = table_panel.Controls[i] as UCTable;
                curTable.ChangeIndex(i);
            }
        }

        private bool HasTable(string tableN)
        {
            for (int i = 0; i < table_panel.Controls.Count; i++)
            {
                UCTable curTable = table_panel.Controls[i] as UCTable;
                if (curTable.tName.Equals(tableN))
                {
                    return true;
                }
            }

            return false;
        }

        private void FillTables()
        {
            db_table[] tables = database.instance.tables.ToArray();
            for(int i = 0; i < tables.Length; i++)
            {
                UCTable newT = new UCTable(tables[i].tableN, i);
                newT.Parent = table_panel;
            }
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateTable(object sender, EventArgs e)
        {
            CreateTable(Properties.Settings.Default.Table_Prefix);
        }

        private void TableMany(object sender, EventArgs e)
        {
            var intDialog = new IntDialog("Create tables", "Table count", "Count", "Confirm", CreateMultipleTable);
            intDialog.ShowDialog();
        }

        private void CreateMultipleTable(int count)
        {
            for(int i = 0; i < count; i++)
            {
                CreateTable(Properties.Settings.Default.Table_Prefix);
            }
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            var menuForm = new MenuForm();
            menuForm.Show();
        }

        private void done_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table_panel.Controls.Count; i++)
            {
                UCTable curTable = table_panel.Controls[i] as UCTable;
                curTable.DeleteButtonState(false);
            }

            button_done.Visible = false;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database.instance.SaveTables();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void LoadTables()
        {
            database.instance.LoadTables();
            FillTables();
        }

        private void editTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table_panel.Controls.Count; i++)
            {
                UCTable curTable = table_panel.Controls[i] as UCTable;
                curTable.DeleteButtonState(true);
            }

            button_done.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Text = Properties.Settings.Default.Rest_Name;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
