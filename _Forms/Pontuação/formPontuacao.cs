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
    public partial class formPontuacao : Form
    {
        public formPontuacao()
        {
            InitializeComponent();
        }

        private void picbox_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
