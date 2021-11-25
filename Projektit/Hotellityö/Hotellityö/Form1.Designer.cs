namespace Hotellityö
{
    partial class Form1
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
            this.Tyhjennä = new System.Windows.Forms.Button();
            this.Päivitä = new System.Windows.Forms.Button();
            this.Poista = new System.Windows.Forms.Button();
            this.Tallenna = new System.Windows.Forms.Button();
            this.Sukunimi = new System.Windows.Forms.TextBox();
            this.Etunimi = new System.Windows.Forms.TextBox();
            this.TietoTauluDG = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Puhelinnumero = new System.Windows.Forms.TextBox();
            this.Maa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TietoTauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // Tyhjennä
            // 
            this.Tyhjennä.Location = new System.Drawing.Point(504, 268);
            this.Tyhjennä.Name = "Tyhjennä";
            this.Tyhjennä.Size = new System.Drawing.Size(75, 23);
            this.Tyhjennä.TabIndex = 0;
            this.Tyhjennä.Text = "Tyhjennä";
            this.Tyhjennä.UseVisualStyleBackColor = true;
            this.Tyhjennä.Click += new System.EventHandler(this.button1_Click);
            // 
            // Päivitä
            // 
            this.Päivitä.Location = new System.Drawing.Point(423, 268);
            this.Päivitä.Name = "Päivitä";
            this.Päivitä.Size = new System.Drawing.Size(75, 23);
            this.Päivitä.TabIndex = 1;
            this.Päivitä.Text = "Päivitä";
            this.Päivitä.UseVisualStyleBackColor = true;
            this.Päivitä.Click += new System.EventHandler(this.button2_Click);
            // 
            // Poista
            // 
            this.Poista.Location = new System.Drawing.Point(342, 268);
            this.Poista.Name = "Poista";
            this.Poista.Size = new System.Drawing.Size(75, 23);
            this.Poista.TabIndex = 2;
            this.Poista.Text = "Poista";
            this.Poista.UseVisualStyleBackColor = true;
            this.Poista.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tallenna
            // 
            this.Tallenna.Location = new System.Drawing.Point(261, 268);
            this.Tallenna.Name = "Tallenna";
            this.Tallenna.Size = new System.Drawing.Size(75, 23);
            this.Tallenna.TabIndex = 3;
            this.Tallenna.Text = "Tallenna";
            this.Tallenna.UseVisualStyleBackColor = true;
            this.Tallenna.Click += new System.EventHandler(this.button4_Click);
            // 
            // Sukunimi
            // 
            this.Sukunimi.Location = new System.Drawing.Point(155, 112);
            this.Sukunimi.Name = "Sukunimi";
            this.Sukunimi.Size = new System.Drawing.Size(100, 20);
            this.Sukunimi.TabIndex = 4;
            // 
            // Etunimi
            // 
            this.Etunimi.Location = new System.Drawing.Point(155, 162);
            this.Etunimi.Name = "Etunimi";
            this.Etunimi.Size = new System.Drawing.Size(100, 20);
            this.Etunimi.TabIndex = 5;
            // 
            // TietoTauluDG
            // 
            this.TietoTauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietoTauluDG.Location = new System.Drawing.Point(261, 112);
            this.TietoTauluDG.Name = "TietoTauluDG";
            this.TietoTauluDG.Size = new System.Drawing.Size(318, 150);
            this.TietoTauluDG.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ID.Location = new System.Drawing.Point(389, 86);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sukunimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Etunimi";
            // 
            // Puhelinnumero
            // 
            this.Puhelinnumero.Location = new System.Drawing.Point(155, 209);
            this.Puhelinnumero.Name = "Puhelinnumero";
            this.Puhelinnumero.Size = new System.Drawing.Size(100, 20);
            this.Puhelinnumero.TabIndex = 10;
            // 
            // Maa
            // 
            this.Maa.Location = new System.Drawing.Point(155, 251);
            this.Maa.Name = "Maa";
            this.Maa.Size = new System.Drawing.Size(100, 20);
            this.Maa.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Puhelinnumero";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Maa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Maa);
            this.Controls.Add(this.Puhelinnumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.TietoTauluDG);
            this.Controls.Add(this.Etunimi);
            this.Controls.Add(this.Sukunimi);
            this.Controls.Add(this.Tallenna);
            this.Controls.Add(this.Poista);
            this.Controls.Add(this.Päivitä);
            this.Controls.Add(this.Tyhjennä);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TietoTauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Tyhjennä;
        private System.Windows.Forms.Button Päivitä;
        private System.Windows.Forms.Button Poista;
        private System.Windows.Forms.Button Tallenna;
        private System.Windows.Forms.TextBox Sukunimi;
        private System.Windows.Forms.TextBox Etunimi;
        private System.Windows.Forms.DataGridView TietoTauluDG;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Puhelinnumero;
        private System.Windows.Forms.TextBox Maa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

