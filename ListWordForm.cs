using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appFrench
{
    public partial class ListWordForm : Form
    {
        public ListWordForm()
        {
            InitializeComponent();
            LabelChanger listLabel = new LabelChanger("Название список");
            this.Controls.Add(listLabel);
            // Перемещаем элемент на передний план
            listLabel.BringToFront();
            listLabel.BackColor = Color.Transparent;
            FillDataGridView();
        }

        private void ListWordForm_Load(object sender, EventArgs e)
        {

        }
        private void FillDataGridView()
        {
            Db db = new Db();
            try
            {
                string query = "SELECT Word, Translation FROM Words WHERE IsCorrect = 1 AND LanguagePair != 'RU-FR';";

                SqlConnection connection = db.getConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    wordsList.Items.Clear();
                    while (reader.Read())
                    {
                        string word = reader["Word"].ToString();
                        string translation = reader["Translation"].ToString();

                        wordsList.Items.Add($"Слово: {word}    Перевод: {translation}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("данные не переданы");
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.closedConnection();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
