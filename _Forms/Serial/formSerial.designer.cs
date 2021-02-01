
namespace Interface
{
    partial class formSerial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_monitor = new System.Windows.Forms.Label();
            this.picbox_fechar = new System.Windows.Forms.PictureBox();
            this.label_serial = new System.Windows.Forms.Label();
            this.button_conectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_enviar = new System.Windows.Forms.Button();
            this.textBox_enviar = new System.Windows.Forms.TextBox();
            this.textBox_receber = new System.Windows.Forms.TextBox();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_monitor
            // 
            this.label_monitor.AutoSize = true;
            this.label_monitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_monitor.ForeColor = System.Drawing.SystemColors.Control;
            this.label_monitor.Location = new System.Drawing.Point(24, 21);
            this.label_monitor.Name = "label_monitor";
            this.label_monitor.Size = new System.Drawing.Size(164, 29);
            this.label_monitor.TabIndex = 1;
            this.label_monitor.Text = "M O N I T O R";
            // 
            // picbox_fechar
            // 
            this.picbox_fechar.BackgroundImage = global::Interface.Properties.Resources.x_azul;
            this.picbox_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_fechar.Location = new System.Drawing.Point(674, 4);
            this.picbox_fechar.Name = "picbox_fechar";
            this.picbox_fechar.Size = new System.Drawing.Size(22, 22);
            this.picbox_fechar.TabIndex = 19;
            this.picbox_fechar.TabStop = false;
            this.picbox_fechar.Click += new System.EventHandler(this.picbox_fechar_Click);
            this.picbox_fechar.MouseEnter += new System.EventHandler(this.picbox_fechar_MouseEnter);
            this.picbox_fechar.MouseLeave += new System.EventHandler(this.picbox_fechar_MouseLeave);
            // 
            // label_serial
            // 
            this.label_serial.AutoSize = true;
            this.label_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_serial.ForeColor = System.Drawing.SystemColors.Control;
            this.label_serial.Location = new System.Drawing.Point(24, 50);
            this.label_serial.Name = "label_serial";
            this.label_serial.Size = new System.Drawing.Size(126, 29);
            this.label_serial.TabIndex = 20;
            this.label_serial.Text = "S E R I A L";
            // 
            // button_conectar
            // 
            this.button_conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_conectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_conectar.ForeColor = System.Drawing.Color.White;
            this.button_conectar.Location = new System.Drawing.Point(29, 112);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(198, 31);
            this.button_conectar.TabIndex = 21;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_conectar.UseVisualStyleBackColor = false;
            this.button_conectar.Click += new System.EventHandler(this.button_conectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // button_enviar
            // 
            this.button_enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enviar.ForeColor = System.Drawing.Color.White;
            this.button_enviar.Location = new System.Drawing.Point(29, 174);
            this.button_enviar.Name = "button_enviar";
            this.button_enviar.Size = new System.Drawing.Size(200, 31);
            this.button_enviar.TabIndex = 23;
            this.button_enviar.Text = "Enviar";
            this.button_enviar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_enviar.UseVisualStyleBackColor = false;
            this.button_enviar.Click += new System.EventHandler(this.button_enviar_Click);
            // 
            // textBox_enviar
            // 
            this.textBox_enviar.Location = new System.Drawing.Point(270, 181);
            this.textBox_enviar.Name = "textBox_enviar";
            this.textBox_enviar.Size = new System.Drawing.Size(198, 20);
            this.textBox_enviar.TabIndex = 24;
            // 
            // textBox_receber
            // 
            this.textBox_receber.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_receber.Location = new System.Drawing.Point(29, 229);
            this.textBox_receber.Multiline = true;
            this.textBox_receber.Name = "textBox_receber";
            this.textBox_receber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_receber.Size = new System.Drawing.Size(642, 261);
            this.textBox_receber.TabIndex = 25;
            // 
            // timerCOM
            // 
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // formSerial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.textBox_receber);
            this.Controls.Add(this.textBox_enviar);
            this.Controls.Add(this.button_enviar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_conectar);
            this.Controls.Add(this.label_serial);
            this.Controls.Add(this.picbox_fechar);
            this.Controls.Add(this.label_monitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSerial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "formSerial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSerial_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_monitor;
        private System.Windows.Forms.PictureBox picbox_fechar;
        private System.Windows.Forms.Label label_serial;
        private System.Windows.Forms.Button button_conectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_enviar;
        private System.Windows.Forms.TextBox textBox_enviar;
        private System.Windows.Forms.TextBox textBox_receber;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
    }
}