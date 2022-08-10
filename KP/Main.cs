using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();

        }


        public string connectionString = "Server=localhost;Database=KP;Integrated Security=True;Initial Catalog=KP; Connect Timeout=30;Encrypt=False;";
   


        private void альбомиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_albums add_albums = new Add_albums();
            add_albums.Show();
        }

        private void виконавціToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_singers add_singers = new Add_singers();
            add_singers.Show();
        }

        private void пісніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_tracks add_tracks = new Add_tracks();
            add_tracks.Show();
        }
        private void додатиСтильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_styles add_styles = new Add_styles();
            add_styles.Show();
        }
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this != null) // Если форма существует, то изменяем свойства её объектов
            {
                this.Close();
            }
        }

        private void add_album_Click(object sender, EventArgs e)
        {
            Add_albums add_albums = new Add_albums(); //посилання на об'єкт
            add_albums.Show();//показ форми додання альбому
        }

        private void add_artist_Click(object sender, EventArgs e)
        {
            Add_singers add_singers = new Add_singers(); //посилання на об'єкт
            add_singers.Show();//показ форми додання виконавця
        }

        private void add_track_Click(object sender, EventArgs e)
        {
            Add_tracks add_tracks = new Add_tracks(); //посилання на об'єкт
            add_tracks.Show();//показ форми додання пісні
        }

        private void find_album_Click(object sender, EventArgs e)
        {
            
            Search search = new Search();//посилання на об'єкт
            search.find = 1;//поле, яке визначає, які саме запити виконувати в вікнах пошуку
            search.grid_album.Show();//показ списку альбомів
            search.grid_artist.Hide();//закриття списку виконавців
            search.grid_track.Hide();//закриття списку пісень
            search.find_text.Text = "Пошук альбому";//виведення потрібного тексту
            search.enter_text.Text = "Введіть назву альбому або її частину";//виведення потрібного тексту
            search.Show();//показ форми
        }

        private void find_artist_Click(object sender, EventArgs e)
        {
            
            Search search = new Search();//посилання на об'єкт
            search.find = 2; //поле, яке визначає, які саме запити виконувати в вікнах пошуку
            search.grid_album.Hide();//закриття списку альбомів
            search.grid_artist.Show();//показ списку виконавців
            search.grid_track.Hide();//закриття списку пісень
            search.find_text.Text = "Пошук виконавця";//виведення потрібного тексту
            search.enter_text.Text = "Введіть назву виконавця або її частину";//виведення потрібного тексту
            search.Show();//показ форми
        }

        private void find_track_Click(object sender, EventArgs e)
        {
            
            Search search = new Search();//посилання на об'єкт
            search.find = 3;//поле, яке визначає, які саме запити виконувати в вікнах пошуку
            search.grid_album.Hide();//закриття списку альбомів
            search.grid_artist.Hide();//закриття списку виконавців
            search.grid_track.Show();//показ списку пісні
            search.find_text.Text = "Пошук пісні";//виведення потрібного тексту
            search.enter_text.Text = "Введіть назву пісні або її частину";//виведення потрібного тексту
            search.Show();
        }

        private void альбомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.find = 1;
            search.grid_album.Show();
            search.grid_artist.Hide();
            search.grid_track.Hide();
            search.find_text.Text = "Пошук альбому";
            search.enter_text.Text = "Введіть назву альбому або її частину";
            search.Show();
        }

        private void виконавецьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.find = 2;
            search.grid_album.Hide();
            search.grid_artist.Show();
            search.grid_track.Hide();
            search.find_text.Text = "Пошук виконавця";
            search.enter_text.Text = "Введіть назву виконавця або її частину";
            search.Show();
        }

        private void пісняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.find = 3;
            search.grid_album.Hide();
            search.grid_artist.Hide();
            search.grid_track.Show();
            search.find_text.Text = "Пошук пісні";
            search.enter_text.Text = "Введіть назву пісні або її частину";
            search.Show();
        }

        private void list_album_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.list = 1;
            list.album_combo.Show();
            list.artist_combo.Hide();
            list.track_combo.Hide();
            list.grid_album.Show();
            list.grid_artist.Hide();
            list.grid_track.Hide();
            list.grid_styles.Hide();
            list.enter_text.Show();
            list.fill_search.Enabled = true;
            list.find_button.Text = "Пошук";
            list.find_text.Text = "Пошук альбому";
            list.Show();
        }

        private void list_artist_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.list = 2;
            list.album_combo.Hide();
            list.artist_combo.Show();
            list.track_combo.Hide();
            list.grid_album.Hide();
            list.grid_artist.Show();
            list.grid_track.Hide();
            list.grid_styles.Hide();
            list.enter_text.Show();
            list.fill_search.Enabled = true;
            list.find_button.Text = "Пошук";
            list.find_text.Text = "Пошук виконавця";
            list.Show();
        }

        private void list_track_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.list = 3;
            list.album_combo.Hide();
            list.artist_combo.Hide();
            list.track_combo.Show();
            list.grid_album.Hide();
            list.grid_artist.Hide();
            list.grid_track.Show();
            list.grid_styles.Hide();
            list.enter_text.Show();
            list.fill_search.Enabled = true;
            list.find_button.Text = "Пошук";
            list.find_text.Text = "Пошук пісні";
            list.Show();
        }

        private void альбомToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.list = 1;
            list.album_combo.Show();
            list.artist_combo.Hide();
            list.track_combo.Hide();
            list.grid_album.Show();
            list.grid_artist.Hide();
            list.grid_track.Hide();
            list.grid_styles.Hide();
            list.enter_text.Show();
            list.fill_search.Enabled = true;
            list.find_button.Text = "Пошук";
            list.find_text.Text = "Пошук альбому";
            list.Show();
        }

        private void виконавецьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.list = 2;
            list.album_combo.Hide();
            list.artist_combo.Show();
            list.track_combo.Hide();
            list.grid_album.Hide();
            list.grid_artist.Show();
            list.grid_track.Hide();
            list.grid_styles.Hide();
            list.enter_text.Show();
            list.fill_search.Enabled = true;
            list.find_button.Text = "Пошук";
            list.find_text.Text = "Пошук виконавця";
            list.Show();
        }

        private void пісняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.list = 3;
            list.album_combo.Hide();
            list.artist_combo.Hide();
            list.track_combo.Show();
            list.grid_album.Hide();
            list.grid_artist.Hide();
            list.grid_track.Show();
            list.grid_styles.Hide();
            list.enter_text.Show();
            list.fill_search.Enabled = true;
            list.find_button.Text = "Пошук";
            list.find_text.Text = "Пошук пісні";
            list.Show();
        }

        private void стильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List list = new List();
            list.list = 4;
            list.album_combo.Hide();
            list.artist_combo.Hide();
            list.track_combo.Hide();
            list.grid_album.Hide();
            list.grid_artist.Hide();
            list.grid_track.Hide();
            list.grid_styles.Show();
            list.enter_text.Hide();
            list.fill_search.Enabled = false;
            list.find_text.Text = "Стилі";
            list.find_button.Text = "Обновити";
            list.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
