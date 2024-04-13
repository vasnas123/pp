using Aromamir.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aromamir
{
    public partial class avtori : Form
    {
        public avtori()
        {
            InitializeComponent();
        }

        private void avtori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            // Проверка логина и пароля (здесь можно добавить проверку в базе данных)
            if (login == "a" && password == "123")
            {
                // Если логин и пароль верные, открываем Form3
               Tovari t = new Tovari();
                t.Show();
                this.Hide(); // Скрываем текущую форму
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль. Попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
