namespace RestaurantFormTest.Orders
{
    partial class OrdersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_group = new System.Windows.Forms.GroupBox();
            this.button_back = new System.Windows.Forms.Button();
            this.menu_layout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView_order = new System.Windows.Forms.ListView();
            this.label_table_name = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_pay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_complete_order = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_change = new System.Windows.Forms.Label();
            this.menu_group.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_group
            // 
            this.menu_group.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_group.Controls.Add(this.button_back);
            this.menu_group.Controls.Add(this.menu_layout);
            this.menu_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_group.Location = new System.Drawing.Point(317, 12);
            this.menu_group.Name = "menu_group";
            this.menu_group.Size = new System.Drawing.Size(454, 465);
            this.menu_group.TabIndex = 0;
            this.menu_group.TabStop = false;
            this.menu_group.Text = "Menu";
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(7, 24);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(32, 34);
            this.button_back.TabIndex = 1;
            this.button_back.Text = "<";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.GetBackPage);
            // 
            // menu_layout
            // 
            this.menu_layout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_layout.AutoScroll = true;
            this.menu_layout.Location = new System.Drawing.Point(6, 64);
            this.menu_layout.Name = "menu_layout";
            this.menu_layout.Size = new System.Drawing.Size(443, 395);
            this.menu_layout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.listView_order);
            this.panel1.Controls.Add(this.label_table_name);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 465);
            this.panel1.TabIndex = 1;
            // 
            // listView_order
            // 
            this.listView_order.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_order.HideSelection = false;
            this.listView_order.Location = new System.Drawing.Point(4, 35);
            this.listView_order.MultiSelect = false;
            this.listView_order.Name = "listView_order";
            this.listView_order.Size = new System.Drawing.Size(290, 424);
            this.listView_order.TabIndex = 1;
            this.listView_order.UseCompatibleStateImageBehavior = false;
            this.listView_order.View = System.Windows.Forms.View.Details;
            this.listView_order.DoubleClick += new System.EventHandler(this.EditOrder);
            // 
            // label_table_name
            // 
            this.label_table_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_table_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_table_name.Location = new System.Drawing.Point(0, 0);
            this.label_table_name.Name = "label_table_name";
            this.label_table_name.Size = new System.Drawing.Size(298, 31);
            this.label_table_name.TabIndex = 0;
            this.label_table_name.Text = "label1";
            this.label_table_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_remove
            // 
            this.button_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(18, 489);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(70, 60);
            this.button_remove.TabIndex = 2;
            this.button_remove.Text = "Remove order";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.RemoveOrder);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_price
            // 
            this.label_price.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_price.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_price.Location = new System.Drawing.Point(172, 493);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(134, 59);
            this.label_price.TabIndex = 4;
            this.label_price.Text = "0";
            this.label_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_pay
            // 
            this.textBox_pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pay.Location = new System.Drawing.Point(317, 523);
            this.textBox_pay.Name = "textBox_pay";
            this.textBox_pay.Size = new System.Drawing.Size(100, 26);
            this.textBox_pay.TabIndex = 5;
            this.textBox_pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_pay.TextChanged += new System.EventHandler(this.textBox_pay_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paid amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_complete_order
            // 
            this.button_complete_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_complete_order.Location = new System.Drawing.Point(678, 489);
            this.button_complete_order.Name = "button_complete_order";
            this.button_complete_order.Size = new System.Drawing.Size(87, 62);
            this.button_complete_order.TabIndex = 7;
            this.button_complete_order.Text = "Remove all order";
            this.button_complete_order.UseVisualStyleBackColor = true;
            this.button_complete_order.Click += new System.EventHandler(this.RemoveAllOrder);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 56);
            this.label3.TabIndex = 8;
            this.label3.Text = "Change:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_change
            // 
            this.label_change.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_change.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_change.Location = new System.Drawing.Point(538, 490);
            this.label_change.Name = "label_change";
            this.label_change.Size = new System.Drawing.Size(134, 59);
            this.label_change.TabIndex = 9;
            this.label_change.Text = "0";
            this.label_change.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label_change);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_complete_order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_pay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_group);
            this.Controls.Add(this.button_remove);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "OrdersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.menu_group.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox menu_group;
        private System.Windows.Forms.FlowLayoutPanel menu_layout;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_table_name;
        private System.Windows.Forms.ListView listView_order;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_pay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_complete_order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_change;
    }
}