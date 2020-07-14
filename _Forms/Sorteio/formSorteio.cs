using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Interface
{
    public partial class formSorteio : Form
    {
        // Especifica o folder no qual será armazenado as informações salvas
        static string equipes_dataPath = @"./ChronosData/Equipes";
        // Essa variável especifica o arquivo no qual será armazenado as informações salvas
        string equipes_filePath = Path.Combine(equipes_dataPath, "lista_de_equipes.txt");
        public formSorteio()
        {
            InitializeComponent();

            if (!Directory.Exists(equipes_dataPath))
            {
                Directory.CreateDirectory(equipes_dataPath);
            }
            if (!File.Exists(equipes_filePath))
            {
                using (File.Create(equipes_filePath)) { }
            }

            // Preenche a tabela com as equipes já cadastradas
            List<string> linhas = File.ReadLines(equipes_filePath).ToList();
            
            foreach (string linha in linhas)
            {
                
                string[] fields = linha.Split(';');
                dgv_selecioneEquipes.Rows.Add(fields[0], fields[1]);
            }

        }
    }
}
