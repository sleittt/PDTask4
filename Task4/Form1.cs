using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        // Поля для кнопок (можно не создавать, если подписка делается через лямбды)
        private Button btnOpenBookForm;
        private Button btnOpenVisitorForm;

        public Form1()
        {
            // Если форма создавалась через дизайнер, этот вызов можно оставить (он ничего не сломает)
            // Если вы хотите полностью отказаться от дизайнера, просто удалите или закомментируйте эту строку.
            InitializeComponent();

            // Создаём и настраиваем кнопки
            CreateButtons();
        }

        private void CreateButtons()
        {
            // Кнопка для задачи 1 (книжная полка)
            btnOpenBookForm = new Button
            {
                Text = "Задача 1: Книжная полка",
                Location = new System.Drawing.Point(30, 30),
                Size = new System.Drawing.Size(200, 40),
                Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular)
            };
            btnOpenBookForm.Click += BtnOpenBookForm_Click; // подключаем обработчик
            this.Controls.Add(btnOpenBookForm);

            // Кнопка для задачи 2 (умный счетчик)
            btnOpenVisitorForm = new Button
            {
                Text = "Задача 2: Умный счетчик",
                Location = new System.Drawing.Point(30, 90),
                Size = new System.Drawing.Size(200, 40),
                Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular)
            };
            btnOpenVisitorForm.Click += BtnOpenVisitorForm_Click;
            this.Controls.Add(btnOpenVisitorForm);

            // Дополнительно: установим заголовок и размер формы
            this.Text = "Библиотека";
            this.Size = new System.Drawing.Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Обработчик для первой кнопки
        private void BtnOpenBookForm_Click(object sender, EventArgs e)
        {
            FormBook bookForm = new FormBook();
            bookForm.ShowDialog();
        }

        // Обработчик для второй кнопки
        private void BtnOpenVisitorForm_Click(object sender, EventArgs e)
        {
            FormVisitor visitorForm = new FormVisitor();
            visitorForm.ShowDialog();
        }
    }
}
