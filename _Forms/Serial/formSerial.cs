using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Interface
{
    public partial class formSerial : Form
    {
        Protocolo protocolo = new Protocolo();
        string RxString;
        public formSerial()
        {
            this.Location = new Point(510, 150);
            InitializeComponent();
            timerCOM.Enabled = true;
        }

        private void atualizalistaCOMs()
        {
            int i;
            bool quantDiferente;

            i = 0;
            quantDiferente = false;

            if(comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if(comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            if(quantDiferente == false)
            {
                return;
            }

            comboBox1.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }

            comboBox1.SelectedIndex = 0;
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

        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizalistaCOMs();
        }

        private void button_conectar_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == false)
            {
                try 
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();
                }
                catch
                {
                    return;
                }
                if(serialPort1.IsOpen)
                {
                    button_conectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                    textBox_receber.Text = "Conexão Iniciada";
                }
            }
            else 
            {
                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    button_conectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void formSerial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();
        }

        private void button_enviar_Click(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string resposta;
            try
            {
                string mensagem = serialPort1.ReadExisting();
                textBox_receber.AppendText("Mensagem recebida:" + mensagem + "\n");
                if (protocolo.traduzir(mensagem))
                {
                    if (mensagem.ElementAt(1) == 'P')
                    {
                        //coRAUI.sensorAtivado(Character.getNumericValue(mensagem.charAt(2)));
                        //Criar Processo de identificação de qual sensor foi ativado
                    }
                    resposta = "0A002";
                }
                else
                {
                    resposta = "0N002";
                }
                textBox_receber.AppendText("Mensagem enviada:" + resposta + "\n");
                resposta = string.Concat(resposta, "\n");
                byte[] byteresp = Encoding.UTF8.GetBytes(resposta);
                string result = System.Text.Encoding.UTF8.GetString(byteresp);
                serialPort1.Write(result);
            }
            catch (Exception)
            {
                //Tratar erro
            }
        }
    }
}
