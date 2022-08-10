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
    public partial class Add_singers : Form
    {
        Main main = new Main();
        public Add_singers()
        {
            InitializeComponent();
        }

        private async void Add_album_add_Click(object sender, EventArgs e)
        {
            if (add_singer_code.Text == "")
            {
                Error error = new Error();
                error.Error_label.Text = "Некоректний код!";
                error.Show();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(main.connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand command1 = new SqlCommand($"SELECT * FROM Artists WHERE cod_artist='{Convert.ToInt32(add_singer_code.Text)}'", connection);
                    SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                    if (reader1.HasRows) // если есть данные
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Вже є альбом з таким кодом!";
                        error.Show();
                        reader1.Close();
                    }
                    else
                    {
                        reader1.Close();
                        SqlCommand command2 = new SqlCommand($"INSERT INTO Artists (cod_artist, nameartist,strana,birthday) VALUES ('{Convert.ToInt32(add_singer_code.Text)}','{add_singer_singer.Text}','{add_singer_country.Text}', '{add_singer_birthday.Text}')", connection);
                        await command2.ExecuteNonQueryAsync();
                    }
                }
            }
            add_singer_singer.Text = "";
            add_singer_code.Text = "";
            add_singer_country.Text = "";
            add_singer_birthday.Text = "";
        }

        private void Add_singer_exit_Click(object sender, EventArgs e)
        {
            if (this != null) // Если форма существует, то изменяем свойства её объектов
            {
                this.Close();
            }
        }

        private async void Add_singer_delete_Click(object sender, EventArgs e)
        {
            if (add_singer_code.Text == "")
            {
                Error error = new Error();
                error.Error_label.Text = "Некоректний код!";
                error.Show();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(main.connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand command1 = new SqlCommand($"SELECT * FROM Albums WHERE cod_artist='{Convert.ToInt32(add_singer_code.Text)}'", connection);
                    SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                    if (reader1.HasRows) // если есть данные
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Є альбом з таким виконавцем!";
                        error.Show();
                        reader1.Close();
                    }
                    else
                    {
                        reader1.Close();
                        SqlCommand command2 = new SqlCommand($"SELECT * FROM Artists WHERE cod_artist='{Convert.ToInt32(add_singer_code.Text)}'", connection);
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
                            SqlCommand command3 = new SqlCommand($"DELETE FROM Artists WHERE cod_artist='{Convert.ToInt32(add_singer_code.Text)}'", connection);
                            await command3.ExecuteNonQueryAsync();
                        }
                        connection.Close();
                    }
                }
            }
            add_singer_singer.Text = "";
            add_singer_code.Text = "";
            add_singer_country.Text = "";
            add_singer_birthday.Text = "";
        }

        private async void Add_singer_change_Click(object sender, EventArgs e)
        {
            if (add_singer_code.Text == "")
            {
                Error error = new Error();
                error.Error_label.Text = "Некоректний код!";
                error.Show();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(main.connectionString))
                {
                    await connection.OpenAsync();
                    SqlCommand command1 = new SqlCommand($"SELECT * FROM Artists WHERE cod_artist='{Convert.ToInt32(add_singer_code.Text)}'", connection);
                    SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                    if (!reader1.HasRows) // если есть данные
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Виконавця не знайдено!";
                        error.Show();
                        reader1.Close();
                        await command1.ExecuteNonQueryAsync();
                    }
                    else
                    {
                        reader1.Close();
                        await command1.ExecuteNonQueryAsync();
                        if (add_singer_singer.Text != "" || add_singer_country.Text != "" || add_singer_birthday.Text != "")
                        {

                            string query = "";
                            if (add_singer_singer.Text != "")
                            {
                                query = query + $"nameartist = '{add_singer_singer.Text}'";
                            }
                            if (add_singer_country.Text != "")
                            {
                                query = query + $"strana = '{add_singer_country.Text}'";
                            }
                            if (add_singer_birthday.Text != "")
                            {
                                query = query + $"birthday = '{add_singer_birthday.Text}'";
                            }
                            SqlCommand command2 = new SqlCommand($"UPDATE Artists SET {query} WHERE cod_artist='{Convert.ToInt32(add_singer_code.Text)}'", connection);
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
            }
            add_singer_singer.Text = "";
            add_singer_code.Text = "";
            add_singer_country.Text = "";
            add_singer_birthday.Text = "";

        }
    }
}
