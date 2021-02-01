using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Protocolo 
    {
        private static string[] dicionario = new string[] { "1P002", "1P103", "1P204", "1P305", "1P406", "1P507", "1P608", "1P709", "1P810", "1P911" };
        private bool[] statusSensor;

        public Protocolo()
        {
            statusSensor = new bool[10];
        }
        public bool traduzir(String mensagem)
        {
            char tipo = mensagem.ElementAt(1);
            if (mensagem.Length == 5 && tipo == 'P')
            {
                int sensor = (int)mensagem.ElementAt(2);
                int crc_calc = 1 + (int)mensagem.ElementAt(0) + sensor;
                int crc_rec = ((int)mensagem.ElementAt(3) * 10) + (int)mensagem.ElementAt(4);
                return crc_calc == crc_rec;
            }
            else if (tipo == 'C')
            {
                for (int i = 2; i < mensagem.Length - 2; i++)
                {
                    statusSensor[i - 2] = (mensagem.ElementAt(i) == '1');
                }
                formSerial form_serial = new formSerial();
                //ver processo dps
                //CoRAUI.sensorStatus(statusSensor);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool contem(String mensagem)
        {
            bool contem = false;
            foreach (String palavra in dicionario)
            {
                if (palavra.Equals(mensagem))
                {
                    contem = true;
                }
            }
            return contem;
        }
    }
}
