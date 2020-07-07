namespace Interface
{
    partial class formIncial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIncial));
            this.label_bemvindo = new System.Windows.Forms.Label();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picbox_fechar = new System.Windows.Forms.PictureBox();
            this.picbox_petee = new System.Windows.Forms.PictureBox();
            this.picbox_chronos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_petee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_chronos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_bemvindo
            // 
            this.label_bemvindo.AutoSize = true;
            this.label_bemvindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bemvindo.ForeColor = System.Drawing.Color.White;
            this.label_bemvindo.Location = new System.Drawing.Point(56, 97);
            this.label_bemvindo.Name = "label_bemvindo";
            this.label_bemvindo.Size = new System.Drawing.Size(159, 20);
            this.label_bemvindo.TabIndex = 0;
            this.label_bemvindo.Text = "Seja bem-vindo(a) ao";
            this.label_bemvindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_iniciar
            // 
            this.button_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iniciar.ForeColor = System.Drawing.Color.White;
            this.button_iniciar.Location = new System.Drawing.Point(71, 269);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(146, 54);
            this.button_iniciar.TabIndex = 3;
            this.button_iniciar.Text = "Iniciar";
            this.button_iniciar.UseVisualStyleBackColor = false;
            this.button_iniciar.Click += new System.EventHandler(this.button_iniciar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(81, 468);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 40);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // picbox_fechar
            // 
            this.picbox_fechar.BackgroundImage = global::Interface.Properties.Resources.x_azul;
            this.picbox_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_fechar.Location = new System.Drawing.Point(264, 4);
            this.picbox_fechar.Name = "picbox_fechar";
            this.picbox_fechar.Size = new System.Drawing.Size(22, 22);
            this.picbox_fechar.TabIndex = 6;
            this.picbox_fechar.TabStop = false;
            this.picbox_fechar.Click += new System.EventHandler(this.picbox_fechar_Click);
            this.picbox_fechar.MouseEnter += new System.EventHandler(this.picbox_fechar_MouseEnter);
            this.picbox_fechar.MouseLeave += new System.EventHandler(this.picbox_fechar_MouseLeave);
            // 
            // picbox_petee
            // 
            this.picbox_petee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_petee.BackgroundImage")));
            this.picbox_petee.Location = new System.Drawing.Point(128, 34);
            this.picbox_petee.Name = "picbox_petee";
            this.picbox_petee.Size = new System.Drawing.Size(34, 50);
            this.picbox_petee.TabIndex = 4;
            this.picbox_petee.TabStop = false;
            // 
            // picbox_chronos
            // 
            this.picbox_chronos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_chronos.BackgroundImage")));
            this.picbox_chronos.Location = new System.Drawing.Point(10, 137);
            this.picbox_chronos.Name = "picbox_chronos";
            this.picbox_chronos.Size = new System.Drawing.Size(270, 112);
            this.picbox_chronos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_chronos.TabIndex = 1;
            this.picbox_chronos.TabStop = false;
            // 
            // formIncial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(290, 520);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picbox_fechar);
            this.Controls.Add(this.picbox_petee);
            this.Controls.Add(this.button_iniciar);
            this.Controls.Add(this.picbox_chronos);
            this.Controls.Add(this.label_bemvindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formIncial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_petee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_chronos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_bemvindo;
        private System.Windows.Forms.PictureBox picbox_chronos;
        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.PictureBox picbox_petee;
        private System.Windows.Forms.PictureBox picbox_fechar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

