using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FitStore
{
    public partial class Form1 : Form
    {
        // Статический список пользователей с логинами и паролями
        private static List<User> users = new List<User>
        {
            new User { Email = "m4ic8j5qgstw@gmail.com", Password = "2L6KZG", RoleCode = "1", FullName = "Admin User" },
            new User { Email = "d43zfg9tlsyv@gmail.com", Password = "uzWC67", RoleCode = "2", FullName = "Client User" },
            new User { Email = "8ohgisf6k45w@outlook.com", Password = "8ntwUp", RoleCode = "3", FullName = "Manager User" },
            new User { Email = "hi1brwj46czx@mail.com", Password = "YOyhfR", RoleCode = "2", FullName = "Client User" },
            new User { Email = "fvkbcamhlj52@gmail.com", Password = "RSbvHv", RoleCode = "3", FullName = "Manager User" },
            new User { Email = "9qxnce8jwruv@gmail.com", Password = "rwVDh9", RoleCode = "1", FullName = "Admin User" },
            new User { Email = "dotiex942p1r@gmail.com", Password = "LdNyos", RoleCode = "2", FullName = "Client User" },
            new User { Email = "n0bmi2h1xral@tutanota.com", Password = "gynQMT", RoleCode = "3", FullName = "Manager User" },
            new User { Email = "sfm3t278kdvz@yahoo.com", Password = "AtnDjr", RoleCode = "1", FullName = "Admin User" },
            new User { Email = "ilb8rdut0v7e@mail.com", Password = "JlFRCZ", RoleCode = "2", FullName = "Client User" }
        };

        // Создаём элемент PictureBox для логотипа
        private PictureBox pictureBoxLogo;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Вход в систему";
            this.Size = new Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // Устанавливаем шрифт и цвета для формы
            this.BackColor = Color.White;
            this.Font = new Font("Comic Sans MS", 12);

            // Создаём и настраиваем PictureBox для логотипа
            pictureBoxLogo = new PictureBox();
            pictureBoxLogo.Image = Image.FromFile(@"C:\Users\Outsider\source\repos\FitStore\FitStore\logo.png"); // Путь к изображению
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom; // Режим масштабирования
            pictureBoxLogo.Size = new Size(100, 100); // Размер логотипа
            pictureBoxLogo.Location = new Point((this.ClientSize.Width - pictureBoxLogo.Width) / 2, 10); // Размещение по центру сверху

            // Добавляем PictureBox на форму
            this.Controls.Add(pictureBoxLogo);

            // Настроим шрифт для текстовых полей
            textBox1.Font = new Font("Comic Sans MS", 12);
            textBox2.Font = new Font("Comic Sans MS", 12);

            // Устанавливаем цвета для текстовых полей
            textBox1.BackColor = Color.FromArgb(118, 227, 131);
            textBox2.BackColor = Color.FromArgb(118, 227, 131);

            // Настроим кнопки
            button1.Text = "Войти";
            button1.Font = new Font("Comic Sans MS", 12);
            button1.BackColor = Color.FromArgb(73, 140, 81);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;

            // Настроим подписи (Label)
            label1.Text = "Введите логин:";
            label1.Font = new Font("Comic Sans MS", 12);
            label1.ForeColor = Color.Black;

            label2.Text = "Введите пароль:";
            label2.Font = new Font("Comic Sans MS", 12);
            label2.ForeColor = Color.Black;

            // Центрируем элементы на форме
            label1.Location = new Point((this.ClientSize.Width - label1.Width) / 2, 120);
            textBox1.Location = new Point((this.ClientSize.Width - textBox1.Width) / 2, 150);
            label2.Location = new Point((this.ClientSize.Width - label2.Width) / 2, 190);
            textBox2.Location = new Point((this.ClientSize.Width - textBox2.Width) / 2, 220);
            button1.Location = new Point((this.ClientSize.Width - button1.Width) / 2, 260);

            // Устанавливаем фиксированный размер формы
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Кнопка для входа
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;  // Почта как логин
            string password = textBox2.Text;  // Пароль

            // Поиск пользователя в статическом списке
            User user = users.Find(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                Form nextForm = GetNextFormByRole(user.RoleCode);
                if (nextForm != null)
                {
                    nextForm.Text = $"Добро пожаловать, {user.FullName}";
                    nextForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Form GetNextFormByRole(string roleCode)
        {
            switch (roleCode)
            {
                case "1": // Администратор
                    return new AdminMenu();
                case "2": // Клиент
                    return new ClientMenu();
                case "3": // Менеджер
                    return new ManagerMenu();
                default:
                    MessageBox.Show("Неизвестный код роли", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }

        // Другие методы можно оставить без изменений

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить обработку изменения текста в поле логина (если нужно)
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно добавить обработку изменения текста в поле пароля (если нужно)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Этот метод можно удалить, так как он не используется
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Этот метод можно удалить, так как он не используется
        }
    }

    // Класс для хранения данных пользователей
    public class User
    {
        public string Email { get; set; } // Логин
        public string Password { get; set; } // Пароль
        public string RoleCode { get; set; } // Роль пользователя
        public string FullName { get; set; } // ФИО пользователя
    }
}
