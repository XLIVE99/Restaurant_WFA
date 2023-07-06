namespace RestaurantFormTest.Tables
{
    partial class UCTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TableStatic = new System.Windows.Forms.Label();
            this.TableName = new System.Windows.Forms.Label();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TableStatic
            // 
            this.TableStatic.AutoSize = true;
            this.TableStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableStatic.Location = new System.Drawing.Point(22, 27);
            this.TableStatic.MinimumSize = new System.Drawing.Size(55, 20);
            this.TableStatic.Name = "TableStatic";
            this.TableStatic.Size = new System.Drawing.Size(55, 20);
            this.TableStatic.TabIndex = 0;
            this.TableStatic.Text = "Table:";
            this.TableStatic.DoubleClick += new System.EventHandler(this.change_table_name);
            // 
            // TableName
            // 
            this.TableName.AutoSize = true;
            this.TableName.CausesValidation = false;
            this.TableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableName.Location = new System.Drawing.Point(76, 27);
            this.TableName.MinimumSize = new System.Drawing.Size(100, 20);
            this.TableName.Name = "TableName";
            this.TableName.Size = new System.Drawing.Size(100, 20);
            this.TableName.TabIndex = 1;
            this.TableName.Text = "ABC1";
            this.TableName.DoubleClick += new System.EventHandler(this.change_table_name);
            // 
            // button_orders
            // 
            this.button_orders.BackColor = System.Drawing.SystemColors.Control;
            this.button_orders.Location = new System.Drawing.Point(26, 71);
            this.button_orders.MinimumSize = new System.Drawing.Size(150, 50);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(150, 50);
            this.button_orders.TabIndex = 2;
            this.button_orders.Text = "ORDERS";
            this.button_orders.UseVisualStyleBackColor = false;
            this.button_orders.Click += new System.EventHandler(this.button_orders_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(173, -1);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(25, 25);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "X";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Visible = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_click);
            // 
            // UCTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.TableName);
            this.Controls.Add(this.TableStatic);
            this.Name = "UCTable";
            this.Size = new System.Drawing.Size(198, 148);
            this.DoubleClick += new System.EventHandler(this.change_table_name);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TableStatic;
        private System.Windows.Forms.Label TableName;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.Button button_delete;
    }
}
