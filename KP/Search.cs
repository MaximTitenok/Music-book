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

namespace KP//Попытки организовать в строках исполнителя и стиля вместо кода названия были, но безуспешно
{

    public partial class Search : Form
    {
        public int find = 0;

        Main main = new Main();
        public Search()
        {

            InitializeComponent();

            grid_album.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_album.AllowUserToAddRows = false;
            grid_artist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_artist.AllowUserToAddRows = false;
            grid_track.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid_track.AllowUserToAddRows = false;

            
        }

        private async void find_button_Click(object sender, EventArgs e)
        {

            grid_album.Rows.Clear();//очищення списку альбому
            grid_artist.Rows.Clear();//очищення списку виконавців
            grid_track.Rows.Clear();//очищення списку пісень
            if (fill_search.Text != "")
            {
                using (SqlConnection connection = new SqlConnection(main.connectionString))//підключення до БД
                {
                    await connection.OpenAsync();//асинхронне відкриття з'єднання до БД
                    string req = "";//очищення від будь-якого минулого запиту
                    if (find == 1)
                    {
                        req = $"SELECT * FROM Albums WHERE album LIKE '%{fill_search.Text}%'";//запит, якщо була натиснута кнопка пошуку альбому
                    }
                    else if (find == 2)
                    {
                        req = $"SELECT * FROM Artists WHERE nameartist LIKE '%{fill_search.Text}%'";//запит, якщо була натиснута кнопка пошуку виконавця
                    }
                    else if (find == 3)
                    {
                        req = $"SELECT * FROM Tracks WHERE track LIKE '%{fill_search.Text}%'";//запит, якщо була натиснута кнопка пошуку пісні
                    }

                    // CONTAINS(album,'{fill_search.Text}' - був варіант зробити такий запит, але питання повнотекстового індексу залишилося відкритим, функціонал запиту через Like влаштовує потреби програми
                    SqlCommand command = new SqlCommand(req, connection);//запит
                    SqlDataReader reader = await command.ExecuteReaderAsync();//читання запиту
                    if (reader.HasRows) // якщо є рядки
                    {
                        while (await reader.ReadAsync()) // порядкове читання даних
                        {
                            if (find == 1)//додання рядку в потрібний список з потрібною кількістю параметрів, виходячи з шукаємих об'єктів
                            {
                                grid_album.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4), reader.GetValue(5), reader.GetValue(6), reader.GetValue(7));
                            }
                            else if (find == 2)
                            {
                                grid_artist.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                            }
                            else if (find == 3)
                            {
                                grid_track.Rows.Add(reader.GetValue(0), reader.GetValue(2), reader.GetValue(1), reader.GetValue(3), reader.GetValue(4));
                            }

                        }
                        reader.Close();//закиття читання
                    }
                }
            }
            else//якщо поле пошуку пусте - видає вікно з помилкою
            {
                Error error = new Error();
                error.Error_label.Text = "Поле не заповнено!";
                error.Show();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if (this != null) // Если форма существует, то изменяем свойства её объектов
            {
                this.Close();
            }
        }
    }
}
