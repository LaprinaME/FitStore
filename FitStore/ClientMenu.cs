using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FitStore
{
    public partial class ClientMenu : Form
    {
        private List<Product> filteredProducts;

        // Создаём элемент PictureBox для логотипа
        private PictureBox pictureBoxLogo;

        // Создаём объект ToolTip для подсказки
        private ToolTip toolTip;

        public ClientMenu()
        {
            InitializeComponent();
            // Настройка шрифта формы
            this.Font = new Font("Comic Sans MS", 10);

            // Настройка фона
            this.BackColor = Color.White;

            // Инициализация ToolTip
            toolTip = new ToolTip();

            // Создание PictureBox для логотипа и настройка его свойств
            pictureBoxLogo = new PictureBox
            {
                Image = Image.FromFile(@"C:\Users\Outsider\source\repos\FitStore\FitStore\logo.png"), // Путь к изображению
                SizeMode = PictureBoxSizeMode.StretchImage, // Растягиваем изображение по размеру
                Size = new Size(100, 100), // Размер логотипа
                Location = new Point(10, 10) // Позиция логотипа на форме
            };

            // Добавляем PictureBox на форму
            this.Controls.Add(pictureBoxLogo);

            // Установка заголовка формы
            this.Text = "FitStore - Клиентский Меню"; // Заголовок формы

            // Настройка подсказки для label1
            toolTip.SetToolTip(label1, "Количество товаров, отображаемых в списке");
        }

        private void ClientMenu_Load(object sender, EventArgs e)
        {
            // Инициализация списка товаров
            filteredProducts = ProductRepository.Products;
            UpdateProductList();
        }

        private void UpdateProductList()
        {
            listBox1.Items.Clear();

            foreach (var product in filteredProducts)
            {
                var item = $"{product.Name} ({product.ArticleNumber}) - {product.Cost:C}";

                if (product.QuantityInStock == 0)
                {
                    // Если товар отсутствует на складе, отображаем серым цветом
                    listBox1.Items.Add(new { Text = item, ForeColor = Color.Gray });
                }
                else
                {
                    listBox1.Items.Add(new { Text = item, ForeColor = Color.Black });
                }
            }

            // Показываем общее количество товаров
            label1.Text = $"{filteredProducts.Count} из {ProductRepository.Products.Count}";
        }

        // Поиск товаров
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var searchText = textBox1.Text.ToLower();
            filteredProducts = ProductRepository.Products
                .Where(p => p.Name.ToLower().Contains(searchText) ||
                            p.ArticleNumber.Contains(searchText) ||
                            p.Manufacturer.ToLower().Contains(searchText))
                .ToList();
            UpdateProductList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Можно добавить обработчик выбора элемента в ListBox, если необходимо
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
