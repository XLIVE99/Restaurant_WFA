using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantFormTest.Database;
using RestaurantFormTest.CustomDialogs;

namespace RestaurantFormTest.Menu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void CreateNewGroup(string gN)
        {
            if(HasGroup(gN))
            {
                var errDialog = new FailDialog("Group already exist");
                errDialog.ShowDialog();
            }
            else
            {
                CreateNewGroupToControl(gN, database.instance.menus.Count);

                database.instance.menus.Add(new db_menu(gN));
                database.instance.SaveMenus();
            }
        }

        private void CreateNewGroupToControl(string gN, int dataId)
        {
            UCMenuGroup newGroup = new UCMenuGroup(gN, dataId);
            newGroup.Parent = menu_main_layout;
        }

        private void CreateNewGroupToControl(string gN, int dataId, db_menu_items[] items)
        {
            UCMenuGroup newGroup = new UCMenuGroup(gN, dataId, items);
            newGroup.Parent = menu_main_layout;
        }

        private bool HasGroup(string gName)
        {
            db_menu[] menus = database.instance.menus.ToArray();
            for(int i = 0; i < menus.Length; i++)
            {
                if (menus[i].groupName.Equals(gName))
                    return true;
            }
            return false;
        }

        private void SaveMenus(object sender, EventArgs e)
        {
            database.instance.SaveMenus();
        }

        private void LoadMenus(object sender, EventArgs e)
        {
            LoadMenus();
        }

        private void LoadMenus()
        {
            database.instance.LoadMenus();
            FillGroups();
        }

        private void CreateMenuGroup(object sender, EventArgs e)
        {
            var stringDialog = new StringDialog("New group", "Group name", "Group name", "Create", CreateNewGroup);
            stringDialog.ShowDialog();
        }

        private void FillGroups()
        {
            db_menu[] menus = database.instance.menus.ToArray();
            for(int i = 0; i < menus.Length; i++)
            {
                CreateNewGroupToControl(menus[i].groupName, i, menus[i].items);
            }
        }

        public void GroupDeleted()
        {
            for(int i = 0; i < menu_main_layout.Controls.Count; i++)
            {
                UCMenuGroup curGroup = menu_main_layout.Controls[i] as UCMenuGroup;
                curGroup.ChangeIndex(i);
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            FillGroups();
        }
    }
}
