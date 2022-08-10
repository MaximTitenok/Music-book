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
    public partial class Add_styles : Form
    {
        Main form = new Main();
        public Add_styles()
        {
            InitializeComponent();
        }

        private async void Add_album_add_Click(object sender, EventArgs e)
        {
            if (Add_style_code_style.Text == "")
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
                    SqlCommand command1 = new SqlCommand($"SELECT * FROM Styles WHERE cod_style='{Convert.ToInt32(Add_style_code_style.Text)}'", connection);
                    SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                    if (reader1.HasRows) // если есть данные
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Вже є стиль з таким кодом!";
                        error.Show();
                        reader1.Close();
                    }
                    else
                    {
                        reader1.Close();
                        SqlCommand command2 = new SqlCommand($"INSERT INTO Styles (cod_style, style) VALUES ('{Convert.ToInt32(Add_style_code_style.Text)}','{Add_style_style.Text}')", connection);
                        await command2.ExecuteNonQueryAsync();
                    }
                }
            }
            Add_style_code_style.Text = "";
            Add_style_style.Text = "";
        }

        private async void Add_album_change_Click(object sender, EventArgs e)
        {
            if (Add_style_code_style.Text == "")
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
                    SqlCommand command1 = new SqlCommand($"SELECT * FROM Styles WHERE cod_style='{Convert.ToInt32(Add_style_code_style.Text)}'", connection);
                    SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                    if (!reader1.HasRows) // если есть данные
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Стилю не знайдено!";
                        error.Show();
                        reader1.Close();
                        await command1.ExecuteNonQueryAsync();
                    }
                    else
                    {
                        reader1.Close();
                        await command1.ExecuteNonQueryAsync();
                        if (Add_style_style.Text != "")
                        {
                            SqlCommand command4 = new SqlCommand($"UPDATE Styles SET style = '{Add_style_style.Text}' WHERE cod_style='{Convert.ToInt32(Add_style_code_style.Text)}'", connection);
                            await command4.ExecuteNonQueryAsync();
                        }
                            

                    }
                }
            }
            Add_style_code_style.Text = "";
            Add_style_style.Text = "";
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
            if (Add_style_code_style.Text == "")
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
                    SqlCommand command1 = new SqlCommand($"SELECT * FROM Albums WHERE cod_style='{Convert.ToInt32(Add_style_code_style.Text)}'", connection);
                    SqlDataReader reader1 = await command1.ExecuteReaderAsync();
                    if (reader1.HasRows) // если есть данные
                    {
                        Error error = new Error();
                        error.Error_label.Text = "Є альбоми з таким стилем!";
                        error.Show();
                        reader1.Close();
                    }
                    else
                    {
                        reader1.Close();
                        SqlCommand command2 = new SqlCommand($"SELECT * FROM Styles WHERE cod_style='{Convert.ToInt32(Add_style_code_style.Text)}'", connection);
                        SqlDataReader reader2 = await command2.ExecuteReaderAsync();
                        if (!reader2.HasRows) // если есть данные
                        {
                            Error error = new Error();
                            error.Error_label.Text = "Стиль не знайдено!";
                            error.Show();
                        }
                        else
                        {
                            reader2.Close();
                            SqlCommand command3 = new SqlCommand($"DELETE FROM Styles WHERE cod_style='{Convert.ToInt32(Add_style_code_style.Text)}'", connection);
                            await command3.ExecuteNonQueryAsync();
                        }
                        connection.Close();
                    }
                }
            }
            Add_style_code_style.Text = "";
            Add_style_style.Text = "";
        }
    }
}
