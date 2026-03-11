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
    public partial class FormBook : Form
    {
        // 1. Объявляем поле для TextBox
        private TextBox txtOutput;

        public FormBook()
        {
            InitializeComponent(); 

            // 2. Создаём TextBox программно
            txtOutput = new TextBox
            {
                Location = new System.Drawing.Point(12, 12),
                Size = new System.Drawing.Size(360, 200),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                ReadOnly = true
            };
            this.Controls.Add(txtOutput);

            Button btnTestBooks = new Button
            {
                Text = "Тест книги",
                Location = new System.Drawing.Point(12, 220),
                Size = new System.Drawing.Size(150, 30)
            };
            btnTestBooks.Click += btnTestBooks_Click;
            this.Controls.Add(btnTestBooks);
        }

        // Обработчик кнопки 
        private void btnTestBooks_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            Book myBook = new Book();
            myBook.title = "Война и мир";
            myBook.author = "Лев Толстой";
            myBook.year = 1869;

            txtOutput.AppendText(myBook.GetInfo() + Environment.NewLine);

            Book unknownBook = new Book();
            txtOutput.AppendText(unknownBook.GetInfo() + Environment.NewLine);
        }
    }
}
