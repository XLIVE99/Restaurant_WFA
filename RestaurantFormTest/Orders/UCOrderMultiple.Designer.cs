namespace RestaurantFormTest.Orders
{
    partial class UCOrderMultiple
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
            this.item_quantity = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label_item = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // item_quantity
            // 
            this.item_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.item_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity.Location = new System.Drawing.Point(3, 26);
            this.item_quantity.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.item_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(143, 26);
            this.item_quantity.TabIndex = 0;
            this.item_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(4, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.done_Click);
            // 
            // label_item
            // 
            this.label_item.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_item.Location = new System.Drawing.Point(0, 0);
            this.label_item.Name = "label_item";
            this.label_item.Size = new System.Drawing.Size(150, 23);
            this.label_item.TabIndex = 2;
            this.label_item.Text = "label1";
            this.label_item.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCOrderMultiple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_item);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.item_quantity);
            this.Name = "UCOrderMultiple";
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown item_quantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_item;
    }
}
