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
    public partial class FormVisitor : Form
    {
        // 1. Объявляем поле для TextBox (доступно во всех методах)
        private TextBox txtOutput;

        public FormVisitor()
        {
            InitializeComponent(); // если используется дизайнер, оставляем

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

            // 3. Создаём кнопку
            Button btn = new Button
            {
                Text = "Создать посетителей",
                Location = new System.Drawing.Point(12, 220),
                Size = new System.Drawing.Size(150, 30)
            };
            btn.Click += btnCreateVisitors_Click; // подключаем обработчик
            this.Controls.Add(btn);
        }

        // 4. Обработчик клика (теперь txtOutput доступен)
        private void btnCreateVisitors_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            Visitor v1 = new Visitor("Анна");
            Visitor v2 = new Visitor("Борис");
            Visitor v3 = new Visitor("Виктор");

            txtOutput.AppendText(v1.PrintInfo() + Environment.NewLine);
            txtOutput.AppendText(v2.PrintInfo() + Environment.NewLine);
            txtOutput.AppendText(v3.PrintInfo() + Environment.NewLine);

            txtOutput.AppendText(Visitor.ShowTotalVisitors() + Environment.NewLine);
        }
    }
}
