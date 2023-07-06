using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantFormTest.CustomDialogs;
using RestaurantFormTest.Database;
using RestaurantFormTest.Orders;

namespace RestaurantFormTest.Tables
{
    public partial class UCTable : UserControl
    {
        private UCTable()
        {
            InitializeComponent();
        }

        public string tName
        {
            get { return TableName.Text; }
            set { TableName.Text = value; }
        }

        public int dataIndex;

        public UCTable(string tableName, int data)
        {
            InitializeComponent();

            tName = tableName;
            dataIndex = data;
        }

        public void ChangeIndex(int ind)
        {
            dataIndex = ind;
        }

        public void DeleteButtonState(bool state)
        {
            button_delete.Visible = state;
        }

        private void button_orders_Click(object sender, EventArgs e)
        {
            var orderForm = new OrdersForm(dataIndex, tName);
            orderForm.Show();
        }

        private void button_delete_click(object sender, EventArgs e)
        {
            Form1 mainForm = Parent.FindForm() as Form1;
            database.instance.tables.RemoveAt(dataIndex);
            database.instance.SaveTables();
            Parent.Controls.RemoveAt(dataIndex);

            mainForm.TableDeleted();
        }

        private void change_table_name(object sender, EventArgs e)
        {
            var change_name_form = new StringDialog("Change table name", "New name", "Name", "Change", ChangeTableName);
            change_name_form.ShowDialog();
        }

        private void ChangeTableName(string newName)
        {
            tName = newName;
            database.instance.tables[dataIndex].tableN = newName;
            database.instance.SaveTables();
        }
    }
}
