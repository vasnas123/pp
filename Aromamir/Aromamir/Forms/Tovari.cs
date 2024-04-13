using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aromamir.Forms
{
    public partial class Tovari : Form
    {
        public Tovari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zakaz z = new Zakaz();
            z.Show();
            this.Hide(); // Скрываем текущую форму
        }

        private void button2_Click(object sender, EventArgs e)
        {
            avtori a = new avtori();

            this.Hide();
            a.ShowDialog();
        }
    }
}
