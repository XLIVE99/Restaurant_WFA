namespace RestaurantFormTest.CustomDialogs
{
    partial class IntOrFloatAndStringDialog
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
            this.label_string = new System.Windows.Forms.Label();
            this.textBox_string = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_float = new System.Windows.Forms.Label();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_warning = new System.Windows.Forms.Label();
            this.button_done = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_string
            // 
            this.label_string.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_string.Location = new System.Drawing.Point(0, 0);
            this.label_string.Name = "label_string";
            this.label_string.Size = new System.Drawing.Size(284, 23);
            this.label_string.TabIndex = 0;
            this.label_string.Text = "main";
            this.label_string.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_string
            // 
            this.textBox_string.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_string.Location = new System.Drawing.Point(12, 26);
            this.textBox_string.Name = "textBox_string";
            this.textBox_string.Size = new System.Drawing.Size(260, 26);
            this.textBox_string.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_float);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 37);
            this.panel1.TabIndex = 2;
            // 
            // label_float
            // 
            this.label_float.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_float.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_float.Location = new System.Drawing.Point(0, 0);
            this.label_float.Name = "label_float";
            this.label_float.Size = new System.Drawing.Size(260, 37);
            this.label_float.TabIndex = 0;
            this.label_float.Text = "label1";
            this.label_float.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_number
            // 
            this.textBox_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_number.Location = new System.Drawing.Point(12, 99);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(260, 26);
            this.textBox_number.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_warning);
            this.panel2.Location = new System.Drawing.Point(12, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 37);
            this.panel2.TabIndex = 3;
            // 
            // label_warning
            // 
            this.label_warning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(0, 0);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(260, 37);
            this.label_warning.TabIndex = 0;
            this.label_warning.Text = "label2";
            this.label_warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_warning.Visible = false;
            // 
            // button_done
            // 
            this.button_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_done.Location = new System.Drawing.Point(163, 201);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(108, 48);
            this.button_done.TabIndex = 4;
            this.button_done.Text = "button1";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_cancel_click);
            // 
            // IntOrFloatAndStringDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_string);
            this.Controls.Add(this.label_string);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "IntOrFloatAndStringDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntAndStringDialog";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_string;
        private System.Windows.Forms.TextBox textBox_string;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_float;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Button button2;
    }
}