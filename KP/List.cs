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
    public partial class List : Form
    {
        Main main = new Main();
        public int list = 0;
        public List()
        {
            InitializeComponent();
            
            
        }
        private async void loadlist()
        {
            if (list == 4)
            {
                using (SqlConnection connection = new SqlConnection(main.connectionString)) // Пілкючення до БД
                {
                    await connection.OpenAsync();// Асинхронне відкриття з'єднання з БД

                    SqlCommand command = new SqlCommand($"SELECT * FROM Styles", connection); // запит у БД
                    SqlDataReader reader = await command.ExecuteReaderAsync(); // виконання запит
                    if (reader.HasRows) // якщо є данні
                    {

                        while (await reader.ReadAsync()) // порядкове читання даних
                        {
                            grid_styles.Rows.Add(reader.GetValue(0), reader.GetValue(1)); // додання даних до DataGrid
                        }
                        reader.Close(); // закриття запиту
                    }
                    await command.ExecuteNonQueryAsync();
                }
                
            }
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            if (this != null) // Если форма существует, то изменяем свойства её объектов
            {
                this.Close();
            }
        }

        private async void find_button_Click(object sender, EventArgs e)
        {
            string param = "";//очищення поля параметру, який буде використавний в запиті
            if (list == 1 && album_combo.Text == "К-сть пісень")//вибір параметру виходячи з того, з якої таблиці шукається та що в випадаючому списку
                param = "koltracks";
            else if (list == 1 && album_combo.Text == "Код альбому")
                param = "cod_album";
            else if (list == 1 && album_combo.Text == "Код виконавця")
                param = "cod_artist";
            else if (list == 1 && album_combo.Text == "Код стилю")
                param = "cod_style";
            else if (list == 1 && album_combo.Text == "Рік видання")
                param = "year";
            else if (list == 1 && album_combo.Text == "Студія")
                param = "musiclabel";
            else if (list == 1 && album_combo.Text == "Формат")
            { param = "format"; }
            if (list == 2 && artist_combo.Text == "Код виконавця")
                param = "cod_artist";
            else if (list == 2 && artist_combo.Text == "Країна")
                param = "strana";
            else if (list == 2 && artist_combo.Text == "Рік заснування")
            { param = "birthday"; }
            if (list == 3 && track_combo.Text == "Код пісні")
                param = "cod_track";
            else if (list == 3 && track_combo.Text == "Номер треку")
                param = "numtrack";
            else if (list == 3 && track_combo.Text == "Тривалість")
                param = "lenght";
            else if (list == 3 && track_combo.Text == "Код альбому")
            { param = "cod_album"; }

            grid_album.Rows.Clear();//очищення списків
            grid_artist.Rows.Clear();
            grid_track.Rows.Clear();
            grid_styles.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(main.connectionString))//підключення до ДБ
            {
                await connection.OpenAsync();//відкриття асинхронного з'єднання
                string req = "";
                if (list == 1)//вибір потрібного запиту виходячи з натиснутої кнопки в вікні "Головна"
                {
                    req = $"SELECT * FROM Albums WHERE {param}='{fill_search.Text}'";
                }
                else if (list == 2)
                {
                    req = $"SELECT * FROM Artists WHERE {param}='{fill_search.Text}'";
                }
                else if (list == 3)
                {
                    req = $"SELECT * FROM Tracks WHERE {param}='{fill_search.Text}'";
                }
                else if (list == 4)
                {
                    req = $"SELECT * FROM Styles";
                }

                SqlCommand command = new SqlCommand(req, connection);//запит в БД
                SqlDataReader reader = await command.ExecuteReaderAsync();//читання запиту
                if (reader.HasRows) // якщо є дані
                {
                    while (await reader.ReadAsync()) // порядково читання рядків
                    {
                        if (list == 1)//додання рядку в потрібний список з потрібною кількістю параметрів, виходячи з шукаємих об'єктів
                        {
                            grid_album.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7));
                        }
                        else if (list == 2)
                        {
                            grid_artist.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                        }
                        else if (list == 3)
                        {
                            grid_track.Rows.Add(reader.GetValue(0), reader.GetValue(2), reader.GetValue(1), reader.GetValue(3), reader.GetValue(4));
                        }
                        else if (list == 4)
                        {
                            grid_styles.Rows.Add(reader.GetValue(0), reader.GetValue(1));
                        }

                    }
                    reader.Close();
                }
            }
        }

        private void List_Load(object sender, EventArgs e)
        {
            loadlist();
        }
    }
}
