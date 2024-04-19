using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace appFrench
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
            //слово Регистрация
            LabelChanger reg = new LabelChanger("Регистрация");
            this.Controls.Add(reg);
            // Перемещаем элемент на передний план
            reg.BringToFront();
            Label[] labels = this.Controls.OfType<Label>().ToArray();
            LabelChanger.deleteBackgroundLabel(labels);//передаёт массив labels чтобы сделать фон прозрачным
        }

        private void regButton_Click(object sender, EventArgs e)
        {
           Boolean regAuth =  RegisterUser(textBoxLogin.Text, textBoxPassword.Text, "french", textBoxMail.Text, textBoxName.Text);
            if (regAuth)
            {
                MessageBox.Show("Регистрация прошла успешна");

            }
            else
            {
                MessageBox.Show("Вас не удалось зарегистрировать");
            }

        }
        public bool RegisterUser(string username, string password,string learn, string mail, string name) 
        {
            Db db = new Db();
            try
            {
                if (textBoxName.Text != "" & textBoxLogin.Text != "" & textBoxMail.Text != "" & textBoxPassword.Text != "" & textBoxOneMore.Text != "")
                {
                    db.openConnection();
                    string query = "INSERT INTO Users (Username, Password, LanguageLearning, Mail, UserFirstName) VALUES (@Username, @Password, @learn, @Mail, @Name)";
                    SqlCommand cmd = new SqlCommand(query, db.getConnection());
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@learn", learn);
                    cmd.Parameters.AddWithValue("@Mail", mail);
                    cmd.Parameters.AddWithValue("@Name", name);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true; // Успешно зарегистрирован
                    }
                }
                else {
                    MessageBox.Show("Вас не удалось зарегистрировать");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                db.closedConnection();
            }
            return false; // Ошибка при регистрации
        }
    }
}
