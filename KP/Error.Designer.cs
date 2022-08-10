
namespace KP
{
    partial class Error
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
            this.label1 = new System.Windows.Forms.Label();
            this.Error_label = new System.Windows.Forms.Label();
            this.Error_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(351, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Помилка!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Error_label
            // 
            this.Error_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Error_label.Location = new System.Drawing.Point(0, 21);
            this.Error_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Error_label.Name = "Error_label";
            this.Error_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Error_label.Size = new System.Drawing.Size(351, 90);
            this.Error_label.TabIndex = 1;
            this.Error_label.Text = "-";
            this.Error_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Error_button
            // 
            this.Error_button.Location = new System.Drawing.Point(126, 70);
            this.Error_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Error_button.Name = "Error_button";
            this.Error_button.Size = new System.Drawing.Size(100, 28);
            this.Error_button.TabIndex = 2;
            this.Error_button.Text = "Ок";
            this.Error_button.UseVisualStyleBackColor = true;
            this.Error_button.Click += new System.EventHandler(this.Error_button_Click);
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 111);
            this.Controls.Add(this.Error_button);
            this.Controls.Add(this.Error_label);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Error_button;
        public System.Windows.Forms.Label Error_label;
    }
}