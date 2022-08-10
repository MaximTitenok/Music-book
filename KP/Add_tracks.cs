using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace KP
{
    public partial class Add_tracks : Form
    {
        Main main = new Main();
        public Add_tracks()
        {
            InitializeComponent();
        }

        private async void Add_singer_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(main.connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command1 = new SqlCommand($"SELECT * FROM Tracks WHERE cod_track='{Convert.ToInt32(add_tracks_code.Text)}'", connection);
                SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                if (reader1.HasRows) // если есть данные
                {
                    Error error = new Error();
                    error.Error_label.Text = "Вже є пісня з таким кодом!";
                    error.Show();
                    reader1.Close();
                }
                else
                {
                    reader1.Close();
                    SqlCommand command2 = new SqlCommand($"SELECT * FROM Albums WHERE cod_album='{Convert.ToInt32(add_tracks_code_album.Text)}'", connection);
                    SqlDataReader reader2 = await command2.ExecuteReaderAsync();
                    if (reader2.HasRows)
                    {

                        SqlCommand command3 = new SqlCommand($"INSERT INTO Tracks (cod_track, numtrack,track,lenght,cod_album) VALUES ('{Convert.ToInt32(add_tracks_code.Text)}','{Convert.ToInt32(add_tracks_numtrack.Text)}','{add_tracks_track.Text}', '{add_tracks_lenght.Text}', '{Convert.ToInt32(add_tracks_code_album.Text)}')", connection);
                        await command3.ExecuteNonQueryAsync();
                    }
                    else
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Нема альбому з таким кодом!";
                        error.Show();
                        reader1.Close();
                    }
                    reader2.Close();
                }
            }
            add_tracks_code.Text = "";
            add_tracks_numtrack.Text = "";
            add_tracks_track.Text = "";
            add_tracks_lenght.Text = "";
            add_tracks_code_album.Text = "";                
        }

        private async void Add_singer_delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(main.connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command1 = new SqlCommand($"SELECT * FROM Tracks WHERE cod_track='{Convert.ToInt32(add_tracks_code.Text)}'", connection);
                SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                if (!reader1.HasRows) // если есть данные
                {
                    Error error = new Error();
                    error.Error_label.Text = "Трек не знайдено!";
                    error.Show();
                    reader1.Close();
                }
                else
                {
                    reader1.Close();
                    SqlCommand command2 = new SqlCommand($"DELETE FROM Tracks WHERE cod_track='{Convert.ToInt32(add_tracks_code.Text)}'", connection);
                    await command2.ExecuteNonQueryAsync();
                }
                connection.Close();
            }
            add_tracks_code.Text = "";
            add_tracks_numtrack.Text = "";
            add_tracks_track.Text = "";
            add_tracks_lenght.Text = "";
            add_tracks_code_album.Text = "";
        }

        private void Add_singer_exit_Click(object sender, EventArgs e)
        {
            if (this != null) // Если форма существует, то изменяем свойства её объектов
            {
                this.Close();
            }
        }

        private async void Add_singer_change_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(main.connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command1 = new SqlCommand($"SELECT * FROM Tracks WHERE cod_track='{Convert.ToInt32(add_tracks_code.Text)}'", connection);
                SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                if (!reader1.HasRows) // если есть данные
                {
                    Error error = new Error();
                    error.Error_label.Text = "Трек не знайдено!";
                    error.Show();
                    reader1.Close();
                    await command1.ExecuteNonQueryAsync();
                }
                else
                {
                    reader1.Close();
                    await command1.ExecuteNonQueryAsync();
                    if (add_tracks_numtrack.Text != "" || add_tracks_track.Text != ""|| add_tracks_lenght.Text != ""|| add_tracks_code_album.Text != "")
                    {
                        string query = "";
                        if (add_tracks_numtrack.Text != "")
                        {
                            query = query + $"numtrack = '{Convert.ToInt32(add_tracks_numtrack.Text)}'";
                        }
                        if (add_tracks_track.Text != "")
                        {
                            query = query + $"track = '{add_tracks_track.Text}'";
                        }
                        if (add_tracks_lenght.Text != "")
                        {
                            query = query + $"lenght = '{Convert.ToInt32(add_tracks_lenght.Text)}'";
                        }
                        if (add_tracks_code_album.Text != "")
                        {
                            query = query + $"cod_album = '{Convert.ToInt32(add_tracks_code_album.Text)}'";
                        }
                        SqlCommand command2 = new SqlCommand($"UPDATE Tracks SET {query} WHERE cod_track='{Convert.ToInt32(add_tracks_code.Text)}'", connection);
                        await command2.ExecuteNonQueryAsync();
                    }
                    else
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Всі поля пусті!";
                        error.Show();
                    }

                }
            }
            add_tracks_code.Text = "";
            add_tracks_numtrack.Text = "";
            add_tracks_track.Text = "";
            add_tracks_lenght.Text = "";
            add_tracks_code_album.Text = "";
        }

    }
}
