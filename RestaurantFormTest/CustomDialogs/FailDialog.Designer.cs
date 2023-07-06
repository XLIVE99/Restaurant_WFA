namespace RestaurantFormTest.CustomDialogs
{
    partial class FailDialog
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
            this.button_done = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_done
            // 
            this.button_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_done.Location = new System.Drawing.Point(119, 84);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(88, 32);
            this.button_done.TabIndex = 0;
            this.button_done.Text = "OK";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.CloseDialog);
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.Location = new System.Drawing.Point(12, 9);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(195, 63);
            this.label_error.TabIndex = 1;
            this.label_error.Text = "label1";
            this.label_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FailDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 128);
            this.ControlBox = false;
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_done);
            this.Name = "FailDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task failed successfully";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Label label_error;
    }
}