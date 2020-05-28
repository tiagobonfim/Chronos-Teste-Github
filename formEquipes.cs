using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class formEquipes : Form
    {
        public formEquipes()
        {
            InitializeComponent();
            this.Location = new Point(510, 150);
        }

        string calouro=""; // string que vai ser usada para controlar o que tá marcado nos radiobuttons
            
        private void button_adicionar_Click(object sender, EventArgs e)
        {

            if (calouro!="" && tbox_nomeEquipe.Text!="") // checa se tem algo marcado nos radiobuttons e texto na textbox
            {
                dgv_tabelaEquipes.Rows.Add(dgv_tabelaEquipes.Rows.Count + 1, tbox_nomeEquipe.Text, calouro);
                tbox_nomeEquipe.Clear();
                tbox_nomeEquipe.Focus(); // coloca o cursor na textbox
            }
        }

        private void rButton_sim_CheckedChanged(object sender, EventArgs e)
        {
            calouro = "Sim";
        }

        private void rButton_nao_CheckedChanged(object sender, EventArgs e)
        {
            calouro = "Não";
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_tabelaEquipes.SelectedRows.Count!=0) // confere se tem alguma linha selecionada
            {
                DataGridViewRow selectedRow = dgv_tabelaEquipes.SelectedRows[0];
                dgv_tabelaEquipes.Rows.Remove(selectedRow);

                // o foreach abaixo faz com que os índices das linhas se reorganizem depois que alguma linha foi excluida

                int contador = 1;
                foreach (DataGridViewRow row in dgv_tabelaEquipes.Rows)
                {
                    row.Cells[0].Value = contador;
                    contador++;
                }
            }
        }

        private void button_resetar_Click(object sender, EventArgs e)
        {
            dgv_tabelaEquipes.Rows.Clear();
        }

        private void picbox_fechar_MouseEnter(object sender, EventArgs e)
        {
            picbox_fechar.BackgroundImage = Properties.Resources.x_branco;
        }

        private void picbox_fechar_MouseLeave(object sender, EventArgs e)
        {
            picbox_fechar.BackgroundImage = Properties.Resources.x_azul;
        }

        private void picbox_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
