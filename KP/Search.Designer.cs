
namespace KP
{
    partial class Search
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
            this.find_text = new System.Windows.Forms.Label();
            this.enter_text = new System.Windows.Forms.Label();
            this.find_button = new System.Windows.Forms.Button();
            this.grid_album = new System.Windows.Forms.DataGridView();
            this.cod_album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_cod_artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_cod_style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_musiclabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_koltracks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exit_button = new System.Windows.Forms.Button();
            this.fill_search = new System.Windows.Forms.TextBox();
            this.grid_artist = new System.Windows.Forms.DataGridView();
            this.list_cod_artist_root = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_name_artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_track = new System.Windows.Forms.DataGridView();
            this.list_cod_track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_name_track = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_numtrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_lenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_cod_album_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_album)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_artist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_track)).BeginInit();
            this.SuspendLayout();
            // 
            // find_text
            // 
            this.find_text.Location = new System.Drawing.Point(16, 11);
            this.find_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.find_text.Name = "find_text";
            this.find_text.Size = new System.Drawing.Size(1119, 25);
            this.find_text.TabIndex = 0;
            this.find_text.Text = "-";
            this.find_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enter_text
            // 
            this.enter_text.Location = new System.Drawing.Point(20, 36);
            this.enter_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enter_text.Name = "enter_text";
            this.enter_text.Size = new System.Drawing.Size(1115, 26);
            this.enter_text.TabIndex = 1;
            this.enter_text.Text = "-";
            this.enter_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // find_button
            // 
            this.find_button.Location = new System.Drawing.Point(652, 59);
            this.find_button.Margin = new System.Windows.Forms.Padding(4);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(100, 28);
            this.find_button.TabIndex = 2;
            this.find_button.Text = "Пошук";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // grid_album
            // 
            this.grid_album.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_album.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_album.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_album,
            this.list_album,
            this.list_cod_artist,
            this.list_cod_style,
            this.list_musiclabel,
            this.list_year,
            this.list_format,
            this.list_koltracks});
            this.grid_album.Location = new System.Drawing.Point(16, 94);
            this.grid_album.Margin = new System.Windows.Forms.Padding(4);
            this.grid_album.Name = "grid_album";
            this.grid_album.RowHeadersWidth = 51;
            this.grid_album.Size = new System.Drawing.Size(1119, 379);
            this.grid_album.TabIndex = 3;
            // 
            // cod_album
            // 
            this.cod_album.HeaderText = "Код альбому";
            this.cod_album.MinimumWidth = 6;
            this.cod_album.Name = "cod_album";
            this.cod_album.ReadOnly = true;
            // 
            // list_album
            // 
            this.list_album.HeaderText = "Назва";
            this.list_album.MinimumWidth = 6;
            this.list_album.Name = "list_album";
            this.list_album.ReadOnly = true;
            // 
            // list_cod_artist
            // 
            this.list_cod_artist.HeaderText = "Код виконавця";
            this.list_cod_artist.MinimumWidth = 6;
            this.list_cod_artist.Name = "list_cod_artist";
            this.list_cod_artist.ReadOnly = true;
            // 
            // list_cod_style
            // 
            this.list_cod_style.HeaderText = "Код стилю";
            this.list_cod_style.MinimumWidth = 6;
            this.list_cod_style.Name = "list_cod_style";
            this.list_cod_style.ReadOnly = true;
            // 
            // list_musiclabel
            // 
            this.list_musiclabel.HeaderText = "Студія";
            this.list_musiclabel.MinimumWidth = 6;
            this.list_musiclabel.Name = "list_musiclabel";
            this.list_musiclabel.ReadOnly = true;
            // 
            // list_year
            // 
            this.list_year.HeaderText = "Рік";
            this.list_year.MinimumWidth = 6;
            this.list_year.Name = "list_year";
            this.list_year.ReadOnly = true;
            // 
            // list_format
            // 
            this.list_format.HeaderText = "Формат";
            this.list_format.MinimumWidth = 6;
            this.list_format.Name = "list_format";
            this.list_format.ReadOnly = true;
            // 
            // list_koltracks
            // 
            this.list_koltracks.HeaderText = "К-сть пісень";
            this.list_koltracks.MinimumWidth = 6;
            this.list_koltracks.Name = "list_koltracks";
            this.list_koltracks.ReadOnly = true;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(1035, 15);
            this.exit_button.Margin = new System.Windows.Forms.Padding(4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(100, 28);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Вихід";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // fill_search
            // 
            this.fill_search.Location = new System.Drawing.Point(511, 62);
            this.fill_search.Margin = new System.Windows.Forms.Padding(4);
            this.fill_search.Name = "fill_search";
            this.fill_search.Size = new System.Drawing.Size(132, 22);
            this.fill_search.TabIndex = 5;
            // 
            // grid_artist
            // 
            this.grid_artist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_artist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_artist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.list_cod_artist_root,
            this.list_name_artist,
            this.list_country,
            this.list_birthday});
            this.grid_artist.Location = new System.Drawing.Point(16, 95);
            this.grid_artist.Margin = new System.Windows.Forms.Padding(4);
            this.grid_artist.Name = "grid_artist";
            this.grid_artist.RowHeadersWidth = 51;
            this.grid_artist.Size = new System.Drawing.Size(1119, 378);
            this.grid_artist.TabIndex = 6;
            // 
            // list_cod_artist_root
            // 
            this.list_cod_artist_root.HeaderText = "Код виконавця";
            this.list_cod_artist_root.MinimumWidth = 6;
            this.list_cod_artist_root.Name = "list_cod_artist_root";
            this.list_cod_artist_root.ReadOnly = true;
            // 
            // list_name_artist
            // 
            this.list_name_artist.HeaderText = "Виконавець";
            this.list_name_artist.MinimumWidth = 6;
            this.list_name_artist.Name = "list_name_artist";
            this.list_name_artist.ReadOnly = true;
            // 
            // list_country
            // 
            this.list_country.HeaderText = "Країна";
            this.list_country.MinimumWidth = 6;
            this.list_country.Name = "list_country";
            this.list_country.ReadOnly = true;
            // 
            // list_birthday
            // 
            this.list_birthday.HeaderText = "Рік заснування";
            this.list_birthday.MinimumWidth = 6;
            this.list_birthday.Name = "list_birthday";
            this.list_birthday.ReadOnly = true;
            // 
            // grid_track
            // 
            this.grid_track.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_track.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_track.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.list_cod_track,
            this.list_name_track,
            this.list_numtrack,
            this.list_lenght,
            this.list_cod_album_});
            this.grid_track.Location = new System.Drawing.Point(16, 94);
            this.grid_track.Margin = new System.Windows.Forms.Padding(4);
            this.grid_track.Name = "grid_track";
            this.grid_track.RowHeadersWidth = 51;
            this.grid_track.Size = new System.Drawing.Size(1119, 379);
            this.grid_track.TabIndex = 7;
            // 
            // list_cod_track
            // 
            this.list_cod_track.HeaderText = "Код пісні";
            this.list_cod_track.MinimumWidth = 6;
            this.list_cod_track.Name = "list_cod_track";
            this.list_cod_track.ReadOnly = true;
            // 
            // list_name_track
            // 
            this.list_name_track.HeaderText = "Назва пісні";
            this.list_name_track.MinimumWidth = 6;
            this.list_name_track.Name = "list_name_track";
            this.list_name_track.ReadOnly = true;
            // 
            // list_numtrack
            // 
            this.list_numtrack.HeaderText = "Номер треку";
            this.list_numtrack.MinimumWidth = 6;
            this.list_numtrack.Name = "list_numtrack";
            this.list_numtrack.ReadOnly = true;
            // 
            // list_lenght
            // 
            this.list_lenght.HeaderText = "Тривалість";
            this.list_lenght.MinimumWidth = 6;
            this.list_lenght.Name = "list_lenght";
            this.list_lenght.ReadOnly = true;
            // 
            // list_cod_album_
            // 
            this.list_cod_album_.HeaderText = "Код альбому";
            this.list_cod_album_.MinimumWidth = 6;
            this.list_cod_album_.Name = "list_cod_album_";
            this.list_cod_album_.ReadOnly = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 484);
            this.Controls.Add(this.grid_track);
            this.Controls.Add(this.grid_artist);
            this.Controls.Add(this.fill_search);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.grid_album);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.enter_text);
            this.Controls.Add(this.find_text);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Search";
            this.Text = "Пошук";
            ((System.ComponentModel.ISupportInitialize)(this.grid_album)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_artist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_track)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label find_text;
        public System.Windows.Forms.Label enter_text;
        private System.Windows.Forms.Button find_button;
        public System.Windows.Forms.DataGridView grid_album;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox fill_search;
        public System.Windows.Forms.DataGridView grid_artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_cod_artist_root;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_name_artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_birthday;
        public System.Windows.Forms.DataGridView grid_track;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_cod_track;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_name_track;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_numtrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_lenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_cod_album_;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_album;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_album;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_cod_artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_cod_style;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_musiclabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_format;
        private System.Windows.Forms.DataGridViewTextBoxColumn list_koltracks;
    }
}