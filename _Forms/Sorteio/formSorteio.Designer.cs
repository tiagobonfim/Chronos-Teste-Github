namespace Interface
{
    partial class formSorteio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSorteio));
            this.label_selecioneEquipes = new System.Windows.Forms.Label();
            this.label_sortear = new System.Windows.Forms.Label();
            this.dgv_selecioneEquipes = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecione = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button_sortear = new System.Windows.Forms.Button();
            this.button_selecionarTodas = new System.Windows.Forms.Button();
            this.button_apagarSelecao = new System.Windows.Forms.Button();
            this.dgv_resultadoSorteio = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picbox_fechar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecioneEquipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultadoSorteio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_selecioneEquipes
            // 
            this.label_selecioneEquipes.AutoSize = true;
            this.label_selecioneEquipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.6F);
            this.label_selecioneEquipes.ForeColor = System.Drawing.SystemColors.Control;
            this.label_selecioneEquipes.Location = new System.Drawing.Point(25, 59);
            this.label_selecioneEquipes.Name = "label_selecioneEquipes";
            this.label_selecioneEquipes.Size = new System.Drawing.Size(298, 18);
            this.label_selecioneEquipes.TabIndex = 3;
            this.label_selecioneEquipes.Text = "Selecione as equipes nas caixas de seleção";
            // 
            // label_sortear
            // 
            this.label_sortear.AutoSize = true;
            this.label_sortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sortear.ForeColor = System.Drawing.SystemColors.Control;
            this.label_sortear.Location = new System.Drawing.Point(24, 20);
            this.label_sortear.Name = "label_sortear";
            this.label_sortear.Size = new System.Drawing.Size(343, 29);
            this.label_sortear.TabIndex = 2;
            this.label_sortear.Text = "S O R T E A R      E Q U I P E S";
            // 
            // dgv_selecioneEquipes
            // 
            this.dgv_selecioneEquipes.AllowUserToAddRows = false;
            this.dgv_selecioneEquipes.AllowUserToDeleteRows = false;
            this.dgv_selecioneEquipes.AllowUserToResizeColumns = false;
            this.dgv_selecioneEquipes.AllowUserToResizeRows = false;
            this.dgv_selecioneEquipes.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_selecioneEquipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_selecioneEquipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selecioneEquipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nomeEquipe,
            this.Selecione});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_selecioneEquipes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_selecioneEquipes.Location = new System.Drawing.Point(29, 124);
            this.dgv_selecioneEquipes.Name = "dgv_selecioneEquipes";
            this.dgv_selecioneEquipes.RowHeadersVisible = false;
            this.dgv_selecioneEquipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_selecioneEquipes.ShowEditingIcon = false;
            this.dgv_selecioneEquipes.Size = new System.Drawing.Size(320, 368);
            this.dgv_selecioneEquipes.TabIndex = 18;
            // 
            // codigo
            // 
            this.codigo.FillWeight = 46.04317F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigo.Width = 64;
            // 
            // nomeEquipe
            // 
            this.nomeEquipe.FillWeight = 150.396F;
            this.nomeEquipe.HeaderText = "Nome da equipe";
            this.nomeEquipe.Name = "nomeEquipe";
            this.nomeEquipe.ReadOnly = true;
            this.nomeEquipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeEquipe.Width = 168;
            // 
            // Selecione
            // 
            this.Selecione.HeaderText = "Selecione";
            this.Selecione.Name = "Selecione";
            this.Selecione.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Selecione.Width = 85;
            // 
            // button_sortear
            // 
            this.button_sortear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_sortear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sortear.ForeColor = System.Drawing.Color.White;
            this.button_sortear.Location = new System.Drawing.Point(395, 87);
            this.button_sortear.Name = "button_sortear";
            this.button_sortear.Size = new System.Drawing.Size(300, 31);
            this.button_sortear.TabIndex = 19;
            this.button_sortear.Text = "Sortear";
            this.button_sortear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_sortear.UseVisualStyleBackColor = false;
            this.button_sortear.Click += new System.EventHandler(this.button_sortear_Click);
            // 
            // button_selecionarTodas
            // 
            this.button_selecionarTodas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_selecionarTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_selecionarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selecionarTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selecionarTodas.ForeColor = System.Drawing.Color.White;
            this.button_selecionarTodas.Location = new System.Drawing.Point(29, 87);
            this.button_selecionarTodas.Name = "button_selecionarTodas";
            this.button_selecionarTodas.Size = new System.Drawing.Size(157, 31);
            this.button_selecionarTodas.TabIndex = 20;
            this.button_selecionarTodas.Text = "Selecionar todas";
            this.button_selecionarTodas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_selecionarTodas.UseVisualStyleBackColor = false;
            this.button_selecionarTodas.Click += new System.EventHandler(this.button_selecionarTodas_Click);
            // 
            // button_apagarSelecao
            // 
            this.button_apagarSelecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_apagarSelecao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_apagarSelecao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_apagarSelecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_apagarSelecao.ForeColor = System.Drawing.Color.White;
            this.button_apagarSelecao.Location = new System.Drawing.Point(192, 87);
            this.button_apagarSelecao.Name = "button_apagarSelecao";
            this.button_apagarSelecao.Size = new System.Drawing.Size(157, 31);
            this.button_apagarSelecao.TabIndex = 21;
            this.button_apagarSelecao.Text = "Apagar seleção";
            this.button_apagarSelecao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_apagarSelecao.UseVisualStyleBackColor = false;
            this.button_apagarSelecao.Click += new System.EventHandler(this.button_apagarSelecao_Click);
            // 
            // dgv_resultadoSorteio
            // 
            this.dgv_resultadoSorteio.AllowUserToAddRows = false;
            this.dgv_resultadoSorteio.AllowUserToDeleteRows = false;
            this.dgv_resultadoSorteio.AllowUserToResizeColumns = false;
            this.dgv_resultadoSorteio.AllowUserToResizeRows = false;
            this.dgv_resultadoSorteio.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultadoSorteio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_resultadoSorteio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultadoSorteio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Ordem});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultadoSorteio.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_resultadoSorteio.Location = new System.Drawing.Point(395, 124);
            this.dgv_resultadoSorteio.Name = "dgv_resultadoSorteio";
            this.dgv_resultadoSorteio.RowHeadersVisible = false;
            this.dgv_resultadoSorteio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultadoSorteio.ShowEditingIcon = false;
            this.dgv_resultadoSorteio.Size = new System.Drawing.Size(300, 368);
            this.dgv_resultadoSorteio.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 46.04317F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 64;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 150.396F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome da equipe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 168;
            // 
            // Ordem
            // 
            this.Ordem.HeaderText = "Ordem";
            this.Ordem.Name = "Ordem";
            this.Ordem.ReadOnly = true;
            this.Ordem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Ordem.Width = 64;
            // 
            // picbox_fechar
            // 
            this.picbox_fechar.BackgroundImage = global::Interface.Properties.Resources.x_azul;
            this.picbox_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_fechar.Location = new System.Drawing.Point(699, 4);
            this.picbox_fechar.Name = "picbox_fechar";
            this.picbox_fechar.Size = new System.Drawing.Size(22, 22);
            this.picbox_fechar.TabIndex = 23;
            this.picbox_fechar.TabStop = false;
            this.picbox_fechar.Click += new System.EventHandler(this.picbox_fechar_Click);
            this.picbox_fechar.MouseEnter += new System.EventHandler(this.picbox_fechar_MouseEnter);
            this.picbox_fechar.MouseLeave += new System.EventHandler(this.picbox_fechar_MouseLeave);
            // 
            // formSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(725, 520);
            this.Controls.Add(this.picbox_fechar);
            this.Controls.Add(this.dgv_resultadoSorteio);
            this.Controls.Add(this.button_apagarSelecao);
            this.Controls.Add(this.button_selecionarTodas);
            this.Controls.Add(this.button_sortear);
            this.Controls.Add(this.dgv_selecioneEquipes);
            this.Controls.Add(this.label_selecioneEquipes);
            this.Controls.Add(this.label_sortear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formSorteio";
            this.Text = "formSorteio";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecioneEquipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultadoSorteio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_selecioneEquipes;
        private System.Windows.Forms.Label label_sortear;
        private System.Windows.Forms.DataGridView dgv_selecioneEquipes;
        private System.Windows.Forms.Button button_sortear;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEquipe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecione;
        private System.Windows.Forms.Button button_selecionarTodas;
        private System.Windows.Forms.Button button_apagarSelecao;
        private System.Windows.Forms.DataGridView dgv_resultadoSorteio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
        private System.Windows.Forms.PictureBox picbox_fechar;
    }
}