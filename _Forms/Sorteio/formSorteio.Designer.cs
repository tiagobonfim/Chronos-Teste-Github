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
            this.label_selecioneEquipes = new System.Windows.Forms.Label();
            this.label_sortear = new System.Windows.Forms.Label();
            this.dgv_selecioneEquipes = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecione = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button_sortear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecioneEquipes)).BeginInit();
            this.SuspendLayout();
            // 
            // label_selecioneEquipes
            // 
            this.label_selecioneEquipes.AutoSize = true;
            this.label_selecioneEquipes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selecioneEquipes.ForeColor = System.Drawing.SystemColors.Control;
            this.label_selecioneEquipes.Location = new System.Drawing.Point(25, 58);
            this.label_selecioneEquipes.Name = "label_selecioneEquipes";
            this.label_selecioneEquipes.Size = new System.Drawing.Size(170, 21);
            this.label_selecioneEquipes.TabIndex = 3;
            this.label_selecioneEquipes.Text = "Selecione as equipes";
            // 
            // label_sortear
            // 
            this.label_sortear.AutoSize = true;
            this.label_sortear.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sortear.ForeColor = System.Drawing.SystemColors.Control;
            this.label_sortear.Location = new System.Drawing.Point(24, 21);
            this.label_sortear.Name = "label_sortear";
            this.label_sortear.Size = new System.Drawing.Size(327, 27);
            this.label_sortear.TabIndex = 2;
            this.label_sortear.Text = "S O R T E A R     E Q U I P E S";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_selecioneEquipes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_selecioneEquipes.Location = new System.Drawing.Point(29, 90);
            this.dgv_selecioneEquipes.Name = "dgv_selecioneEquipes";
            this.dgv_selecioneEquipes.RowHeadersVisible = false;
            this.dgv_selecioneEquipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_selecioneEquipes.ShowEditingIcon = false;
            this.dgv_selecioneEquipes.Size = new System.Drawing.Size(315, 372);
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
            this.Selecione.Width = 80;
            // 
            // button_sortear
            // 
            this.button_sortear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_sortear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_sortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sortear.ForeColor = System.Drawing.Color.White;
            this.button_sortear.Location = new System.Drawing.Point(29, 468);
            this.button_sortear.Name = "button_sortear";
            this.button_sortear.Size = new System.Drawing.Size(315, 31);
            this.button_sortear.TabIndex = 19;
            this.button_sortear.Text = "Sortear";
            this.button_sortear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_sortear.UseVisualStyleBackColor = false;
            // 
            // formSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.button_sortear);
            this.Controls.Add(this.dgv_selecioneEquipes);
            this.Controls.Add(this.label_selecioneEquipes);
            this.Controls.Add(this.label_sortear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSorteio";
            this.Text = "formSorteio";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecioneEquipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_selecioneEquipes;
        private System.Windows.Forms.Label label_sortear;
        private System.Windows.Forms.DataGridView dgv_selecioneEquipes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEquipe;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecione;
        private System.Windows.Forms.Button button_sortear;
    }
}