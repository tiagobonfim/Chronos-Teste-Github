using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class formIncial : Form
    {
        public formIncial()
        {
            InitializeComponent();
            this.Location = new Point(200, 150);
        }

        private void picbox_fechar_MouseLeave(object sender, EventArgs e)
        {
            picbox_fechar.BackgroundImage = Properties.Resources.x_azul;
        }

        private void button_iniciar_Click(object sender, EventArgs e)
        {
            formMenu form2 = new formMenu(this);
            form2.Show();
            this.Hide();
        }

        private void picbox_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picbox_fechar_MouseEnter(object sender, EventArgs e)
        {
            picbox_fechar.BackgroundImage = Properties.Resources.x_branco;
        }
    }
}
