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
    public partial class Add_albums : Form
    {
        Main form = new Main();
        public Add_albums()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void Add_album_add_Click(object sender, EventArgs e)
        {
            if (Add_album_code_album.Text == "")//якщо немає коду альбому -  видає помилку
            {
                Error error = new Error();
                error.Error_label.Text = "Некоректний код!";
                error.Show();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(form.connectionString))//підключення до бази даних
                {
                    await connection.OpenAsync();//асинхронне відкриття з'єднання з БД
                    SqlCommand command1 = new SqlCommand($"SELECT * FROM Albums WHERE cod_album='{Convert.ToInt32(Add_album_code_album.Text)}'", connection); //запит на перевірку наявності такого коду
                    SqlDataReader reader1 = await command1.ExecuteReaderAsync();//виконання запиту
                    if (reader1.HasRows) // якщо є данні - видає помилку
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Вже є альбом з таким кодом!";
                        error.Show();
                        reader1.Close();
                    }
                    else
                    {
                        reader1.Close();//якщо помилки немає - закриває читання та додає новий рядок
                        SqlCommand command2 = new SqlCommand($"INSERT INTO Albums (cod_album, album,cod_artist,cod_style,musiclabel,year,format,koltracks) VALUES ('{Convert.ToInt32(Add_album_code_album.Text)}','{Add_album_album_name.Text}','{Convert.ToInt32(Add_album_code_singer.Text)}','{Convert.ToInt32(Add_album_code_style.Text)}','{Add_album_label.Text}', '{Add_album_year.Text}', '{Add_album_format.Text}', '{Add_album_tracks.Text}')", connection); //запит
                        await command2.ExecuteNonQueryAsync();//виконання запиту
                    }
                }
            }
            //очищення всіх полів:
            Add_album_code_album.Text = "";
            Add_album_album_name.Text = "";
            Add_album_code_singer.Text = "";
            Add_album_code_style.Text = "";
            Add_album_label.Text = "";
            Add_album_year.Text = "";
            Add_album_format.Text = "";
            Add_album_tracks.Text = "";
        }

        private void Add_album_exit_Click(object sender, EventArgs e)
        {
            if (this != null) // Если форма существует, то изменяем свойства её объектов
            {
                this.Close();
            }
        }

        private async void Add_album_delete_Click(object sender, EventArgs e)
        {
            if (Add_album_code_album.Text == "")
            {
                Error error = new Error();
                error.Error_label.Text = "Некоректний код!";
                error.Show();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(form.connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand command1 = new SqlCommand($"SELECT * FROM Tracks WHERE cod_album='{Convert.ToInt32(Add_album_code_album.Text)}'", connection);
                    SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                    if (reader1.HasRows) // если есть данные
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Є пісні, що належать до альбому!";
                        error.Show();
                        reader1.Close();
                    }
                    else
                    {
                        reader1.Close();
                        SqlCommand command2 = new SqlCommand($"SELECT * FROM Albums WHERE cod_album='{Convert.ToInt32(Add_album_code_album.Text)}'", connection);
                        SqlDataReader reader2 = await command2.ExecuteReaderAsync();
                        if (!reader2.HasRows) // если есть данные
                        {
                            Error error = new Error();
                            error.Error_label.Text = "Виконавця не знайдено!";
                            error.Show();
                        }
                        else
                        {
                            reader2.Close();
                            SqlCommand command3 = new SqlCommand($"DELETE FROM Albums WHERE cod_album='{Convert.ToInt32(Add_album_code_album.Text)}'", connection);
                            await command3.ExecuteNonQueryAsync();
                        }
                        connection.Close();
                    }
                }
            }
            Add_album_code_album.Text = "";
            Add_album_album_name.Text = "";
            Add_album_code_singer.Text = "";
            Add_album_code_style.Text = "";
            Add_album_label.Text = "";
            Add_album_year.Text = "";
            Add_album_format.Text = "";
            Add_album_tracks.Text = "";
        }

        private async void Add_album_change_Click(object sender, EventArgs e)
        {
            if (Add_album_code_album.Text == "")
            {
                Error error = new Error();
                error.Error_label.Text = "Некоректний код!";
                error.Show();
            }
            else
            {
                bool errors = false;
                using (SqlConnection connection = new SqlConnection(form.connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand command1 = new SqlCommand($"SELECT * FROM Albums WHERE cod_album='{Convert.ToInt32(Add_album_code_album.Text)}'", connection);
                    SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                    if (!reader1.HasRows) // если есть данные
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Альбому не знайдено!";
                        error.Show();
                        reader1.Close();
                        await command1.ExecuteNonQueryAsync();
                    }
                    else
                    {
                        reader1.Close();
                        await command1.ExecuteNonQueryAsync();
                        if (Add_album_album_name.Text != "" || Add_album_code_singer.Text != "" || Add_album_code_style.Text != "" || Add_album_label.Text != "" || Add_album_year.Text != "" || Add_album_format.Text != "" || Add_album_tracks.Text != "")
                        {
                            string query = "";
                            if (Add_album_album_name.Text != "")
                            {
                                query = query + $"album = '{Add_album_album_name.Text}'";
                            }
                            if (Add_album_code_singer.Text != "")
                            {
                                SqlCommand command2 = new SqlCommand($"SELECT * FROM Artists WHERE cod_artist='{Convert.ToInt32(Add_album_code_singer.Text)}'", connection);
                                SqlDataReader reader2 = await command2.ExecuteReaderAsync();
                                if (reader2.HasRows) // если есть данные
                                {
                                    query = query + $"cod_artist = '{Convert.ToInt32(Add_album_code_singer.Text)}'";
                                }
                                else
                                {
                                    Error error = new Error();
                                    error.Error_label.Text = "Код виконавця не знайдено!";
                                    error.Show();
                                    errors = true;
                                }
                                reader2.Close();
                            }
                            if (Add_album_code_style.Text != "")
                            {
                                SqlCommand command3 = new SqlCommand($"SELECT * FROM Styles WHERE cod_style='{Convert.ToInt32(Add_album_code_style.Text)}'", connection);
                                SqlDataReader reader3 = await command3.ExecuteReaderAsync();
                                if (reader3.HasRows) // если есть данные
                                {
                                    query = query + $"cod_style = '{Convert.ToInt32(Add_album_code_style.Text)}'";
                                }
                                else
                                {
                                    Error error = new Error();
                                    error.Error_label.Text = "Код виконавця не знайдено!";
                                    error.Show();
                                    errors = true;
                                }
                                reader3.Close();
                            }
                            if (Add_album_label.Text != "")
                            {
                                query = query + $"musiclabel = '{Add_album_label.Text}'";
                            }
                            if (Add_album_year.Text != "")
                            {
                                query = query + $"year = '{Add_album_year.Text}'";
                            }
                            if (Add_album_format.Text != "")
                            {
                                query = query + $"format = '{Add_album_format.Text}'";
                            }
                            if (Add_album_tracks.Text != "")
                            {
                                query = query + $"koltracks = '{Convert.ToInt32(Add_album_tracks.Text)}'";
                            }
                            if (errors == false)
                            {
                                SqlCommand command4 = new SqlCommand($"UPDATE Albums SET {query} WHERE cod_album='{Convert.ToInt32(Add_album_code_album.Text)}'", connection);
                                await command4.ExecuteNonQueryAsync();
                            }
                        }
                        else
                        {
                            Error error = new Error();
                            error.Error_label.Text = "Всі поля пусті!";
                            error.Show();
                            errors = true;
                        }

                    }
                }
            }
            Add_album_code_album.Text = "";
            Add_album_album_name.Text = "";
            Add_album_code_singer.Text = "";
            Add_album_code_style.Text = "";
            Add_album_label.Text = "";
            Add_album_year.Text = "";
            Add_album_format.Text = "";
            Add_album_tracks.Text = "";
        }
    }
}
