
namespace KP
{
    partial class Add_singers
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
            this.label13 = new System.Windows.Forms.Label();
            this.add_singer_birthday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_singer_country = new System.Windows.Forms.TextBox();
            this.add_singer_singer = new System.Windows.Forms.TextBox();
            this.add_singer_code = new System.Windows.Forms.TextBox();
            this.Add_singer_exit = new System.Windows.Forms.Button();
            this.Add_singer_delete = new System.Windows.Forms.Button();
            this.Add_singer_change = new System.Windows.Forms.Button();
            this.Add_singer_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Рік заснування";
            // 
            // add_singer_birthday
            // 
            this.add_singer_birthday.Location = new System.Drawing.Point(101, 84);
            this.add_singer_birthday.Name = "add_singer_birthday";
            this.add_singer_birthday.Size = new System.Drawing.Size(100, 20);
            this.add_singer_birthday.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Країна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Виконавець";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Код виконавця";
            // 
            // add_singer_country
            // 
            this.add_singer_country.Location = new System.Drawing.Point(101, 58);
            this.add_singer_country.Name = "add_singer_country";
            this.add_singer_country.Size = new System.Drawing.Size(100, 20);
            this.add_singer_country.TabIndex = 31;
            // 
            // add_singer_singer
            // 
            this.add_singer_singer.Location = new System.Drawing.Point(101, 32);
            this.add_singer_singer.Name = "add_singer_singer";
            this.add_singer_singer.Size = new System.Drawing.Size(100, 20);
            this.add_singer_singer.TabIndex = 30;
            // 
            // add_singer_code
            // 
            this.add_singer_code.Location = new System.Drawing.Point(101, 6);
            this.add_singer_code.Name = "add_singer_code";
            this.add_singer_code.Size = new System.Drawing.Size(100, 20);
            this.add_singer_code.TabIndex = 29;
            // 
            // Add_singer_exit
            // 
            this.Add_singer_exit.Location = new System.Drawing.Point(369, 84);
            this.Add_singer_exit.Name = "Add_singer_exit";
            this.Add_singer_exit.Size = new System.Drawing.Size(75, 23);
            this.Add_singer_exit.TabIndex = 40;
            this.Add_singer_exit.Text = "Вийти";
            this.Add_singer_exit.UseVisualStyleBackColor = true;
            this.Add_singer_exit.Click += new System.EventHandler(this.Add_singer_exit_Click);
            // 
            // Add_singer_delete
            // 
            this.Add_singer_delete.Location = new System.Drawing.Point(369, 6);
            this.Add_singer_delete.Name = "Add_singer_delete";
            this.Add_singer_delete.Size = new System.Drawing.Size(75, 23);
            this.Add_singer_delete.TabIndex = 39;
            this.Add_singer_delete.Text = "Видалити";
            this.Add_singer_delete.UseVisualStyleBackColor = true;
            this.Add_singer_delete.Click += new System.EventHandler(this.Add_singer_delete_Click);
            // 
            // Add_singer_change
            // 
            this.Add_singer_change.Location = new System.Drawing.Point(288, 6);
            this.Add_singer_change.Name = "Add_singer_change";
            this.Add_singer_change.Size = new System.Drawing.Size(75, 23);
            this.Add_singer_change.TabIndex = 38;
            this.Add_singer_change.Text = "Змінити";
            this.Add_singer_change.UseVisualStyleBackColor = true;
            this.Add_singer_change.Click += new System.EventHandler(this.Add_singer_change_Click);
            // 
            // Add_singer_add
            // 
            this.Add_singer_add.Location = new System.Drawing.Point(207, 6);
            this.Add_singer_add.Name = "Add_singer_add";
            this.Add_singer_add.Size = new System.Drawing.Size(75, 23);
            this.Add_singer_add.TabIndex = 37;
            this.Add_singer_add.Text = "Додати";
            this.Add_singer_add.UseVisualStyleBackColor = true;
            this.Add_singer_add.Click += new System.EventHandler(this.Add_album_add_Click);
            // 
            // Add_singers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 113);
            this.Controls.Add(this.Add_singer_exit);
            this.Controls.Add(this.Add_singer_delete);
            this.Controls.Add(this.Add_singer_change);
            this.Controls.Add(this.Add_singer_add);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.add_singer_birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_singer_country);
            this.Controls.Add(this.add_singer_singer);
            this.Controls.Add(this.add_singer_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_singers";
            this.Text = "Додання виконавця";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox add_singer_birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox add_singer_country;
        private System.Windows.Forms.TextBox add_singer_singer;
        private System.Windows.Forms.TextBox add_singer_code;
        private System.Windows.Forms.Button Add_singer_exit;
        private System.Windows.Forms.Button Add_singer_delete;
        private System.Windows.Forms.Button Add_singer_change;
        private System.Windows.Forms.Button Add_singer_add;
    }
}