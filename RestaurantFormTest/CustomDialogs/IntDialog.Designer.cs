namespace RestaurantFormTest.CustomDialogs
{
    partial class IntDialog
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
            this.label_exp = new System.Windows.Forms.Label();
            this.numeric_input = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_warning = new System.Windows.Forms.Label();
            this.button_done = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_input)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_exp
            // 
            this.label_exp.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exp.Location = new System.Drawing.Point(0, 0);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(284, 23);
            this.label_exp.TabIndex = 0;
            this.label_exp.Text = "label1";
            this.label_exp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeric_input
            // 
            this.numeric_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_input.Location = new System.Drawing.Point(83, 26);
            this.numeric_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_input.Name = "numeric_input";
            this.numeric_input.Size = new System.Drawing.Size(120, 26);
            this.numeric_input.TabIndex = 1;
            this.numeric_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_warning);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 27);
            this.panel1.TabIndex = 2;
            // 
            // label_warning
            // 
            this.label_warning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(0, 0);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(260, 27);
            this.label_warning.TabIndex = 0;
            this.label_warning.Text = "label2";
            this.label_warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_warning.Visible = false;
            // 
            // button_done
            // 
            this.button_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_done.Location = new System.Drawing.Point(163, 103);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(109, 46);
            this.button_done.TabIndex = 3;
            this.button_done.Text = "button1";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_cancel_click);
            // 
            // IntDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numeric_input);
            this.Controls.Add(this.label_exp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(300, 200);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "IntDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntDialog";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_input)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_exp;
        private System.Windows.Forms.NumericUpDown numeric_input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Button button2;
    }
}