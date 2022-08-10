namespace KP
{
    partial class Add_styles
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_style_style = new System.Windows.Forms.TextBox();
            this.Add_style_code_style = new System.Windows.Forms.TextBox();
            this.Add_album_delete = new System.Windows.Forms.Button();
            this.Add_album_change = new System.Windows.Forms.Button();
            this.Add_album_add = new System.Windows.Forms.Button();
            this.Add_album_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Назва стилю";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Код стилю";
            // 
            // Add_style_style
            // 
            this.Add_style_style.Location = new System.Drawing.Point(102, 45);
            this.Add_style_style.Margin = new System.Windows.Forms.Padding(4);
            this.Add_style_style.Name = "Add_style_style";
            this.Add_style_style.Size = new System.Drawing.Size(132, 22);
            this.Add_style_style.TabIndex = 25;
            // 
            // Add_style_code_style
            // 
            this.Add_style_code_style.Location = new System.Drawing.Point(102, 13);
            this.Add_style_code_style.Margin = new System.Windows.Forms.Padding(4);
            this.Add_style_code_style.Name = "Add_style_code_style";
            this.Add_style_code_style.Size = new System.Drawing.Size(132, 22);
            this.Add_style_code_style.TabIndex = 24;
            // 
            // Add_album_delete
            // 
            this.Add_album_delete.Location = new System.Drawing.Point(459, 10);
            this.Add_album_delete.Margin = new System.Windows.Forms.Padding(4);
            this.Add_album_delete.Name = "Add_album_delete";
            this.Add_album_delete.Size = new System.Drawing.Size(100, 28);
            this.Add_album_delete.TabIndex = 23;
            this.Add_album_delete.Text = "Видалити";
            this.Add_album_delete.UseVisualStyleBackColor = true;
            this.Add_album_delete.Click += new System.EventHandler(this.Add_album_delete_Click);
            // 
            // Add_album_change
            // 
            this.Add_album_change.Location = new System.Drawing.Point(351, 10);
            this.Add_album_change.Margin = new System.Windows.Forms.Padding(4);
            this.Add_album_change.Name = "Add_album_change";
            this.Add_album_change.Size = new System.Drawing.Size(100, 28);
            this.Add_album_change.TabIndex = 22;
            this.Add_album_change.Text = "Змінити";
            this.Add_album_change.UseVisualStyleBackColor = true;
            this.Add_album_change.Click += new System.EventHandler(this.Add_album_change_Click);
            // 
            // Add_album_add
            // 
            this.Add_album_add.Location = new System.Drawing.Point(243, 10);
            this.Add_album_add.Margin = new System.Windows.Forms.Padding(4);
            this.Add_album_add.Name = "Add_album_add";
            this.Add_album_add.Size = new System.Drawing.Size(100, 28);
            this.Add_album_add.TabIndex = 21;
            this.Add_album_add.Text = "Додати";
            this.Add_album_add.UseVisualStyleBackColor = true;
            this.Add_album_add.Click += new System.EventHandler(this.Add_album_add_Click);
            // 
            // Add_album_exit
            // 
            this.Add_album_exit.Location = new System.Drawing.Point(459, 42);
            this.Add_album_exit.Margin = new System.Windows.Forms.Padding(4);
            this.Add_album_exit.Name = "Add_album_exit";
            this.Add_album_exit.Size = new System.Drawing.Size(100, 28);
            this.Add_album_exit.TabIndex = 28;
            this.Add_album_exit.Text = "Вийти";
            this.Add_album_exit.UseVisualStyleBackColor = true;
            this.Add_album_exit.Click += new System.EventHandler(this.Add_album_exit_Click);
            // 
            // Add_styles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 79);
            this.Controls.Add(this.Add_album_exit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Add_style_style);
            this.Controls.Add(this.Add_style_code_style);
            this.Controls.Add(this.Add_album_delete);
            this.Controls.Add(this.Add_album_change);
            this.Controls.Add(this.Add_album_add);
            this.Name = "Add_styles";
            this.Text = "Додання стилю";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Add_style_style;
        private System.Windows.Forms.TextBox Add_style_code_style;
        private System.Windows.Forms.Button Add_album_delete;
        private System.Windows.Forms.Button Add_album_change;
        private System.Windows.Forms.Button Add_album_add;
        private System.Windows.Forms.Button Add_album_exit;
    }
}