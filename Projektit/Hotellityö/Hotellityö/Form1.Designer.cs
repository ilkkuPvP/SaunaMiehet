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
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TietoTauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // Tyhjennä
            // 
            this.Tyhjennä.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tyhjennä.Location = new System.Drawing.Point(660, 325);
            this.Tyhjennä.Name = "Tyhjennä";
            this.Tyhjennä.Size = new System.Drawing.Size(128, 54);
            this.Tyhjennä.TabIndex = 0;
            this.Tyhjennä.Text = "Tyhjennä";
            this.Tyhjennä.UseVisualStyleBackColor = true;
            this.Tyhjennä.Click += new System.EventHandler(this.button1_Click);
            // 
            // Päivitä
            // 
            this.Päivitä.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Päivitä.Location = new System.Drawing.Point(526, 325);
            this.Päivitä.Name = "Päivitä";
            this.Päivitä.Size = new System.Drawing.Size(128, 54);
            this.Päivitä.TabIndex = 1;
            this.Päivitä.Text = "Päivitä";
            this.Päivitä.UseVisualStyleBackColor = true;
            this.Päivitä.Click += new System.EventHandler(this.button2_Click);
            // 
            // Poista
            // 
            this.Poista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Poista.Location = new System.Drawing.Point(300, 325);
            this.Poista.Name = "Poista";
            this.Poista.Size = new System.Drawing.Size(128, 54);
            this.Poista.TabIndex = 2;
            this.Poista.Text = "Poista";
            this.Poista.UseVisualStyleBackColor = true;
            this.Poista.Click += new System.EventHandler(this.button3_Click);
            // 
            // Tallenna
            // 
            this.Tallenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tallenna.Location = new System.Drawing.Point(166, 325);
            this.Tallenna.Name = "Tallenna";
            this.Tallenna.Size = new System.Drawing.Size(128, 54);
            this.Tallenna.TabIndex = 3;
            this.Tallenna.Text = "Tallenna";
            this.Tallenna.UseVisualStyleBackColor = true;
            this.Tallenna.Click += new System.EventHandler(this.button4_Click);
            // 
            // Sukunimi
            // 
            this.Sukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sukunimi.Location = new System.Drawing.Point(34, 137);
            this.Sukunimi.Name = "Sukunimi";
            this.Sukunimi.Size = new System.Drawing.Size(100, 26);
            this.Sukunimi.TabIndex = 4;
            this.Sukunimi.TextChanged += new System.EventHandler(this.Sukunimi_TextChanged);
            // 
            // Etunimi
            // 
            this.Etunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etunimi.Location = new System.Drawing.Point(34, 189);
            this.Etunimi.Name = "Etunimi";
            this.Etunimi.Size = new System.Drawing.Size(100, 26);
            this.Etunimi.TabIndex = 5;
            // 
            // TietoTauluDG
            // 
            this.TietoTauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietoTauluDG.Location = new System.Drawing.Point(166, 80);
            this.TietoTauluDG.Name = "TietoTauluDG";
            this.TietoTauluDG.Size = new System.Drawing.Size(622, 239);
            this.TietoTauluDG.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ID.Location = new System.Drawing.Point(34, 91);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sukunimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Etunimi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Puhelinnumero
            // 
            this.Puhelinnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puhelinnumero.Location = new System.Drawing.Point(34, 241);
            this.Puhelinnumero.Name = "Puhelinnumero";
            this.Puhelinnumero.Size = new System.Drawing.Size(100, 26);
            this.Puhelinnumero.TabIndex = 10;
            // 
            // Maa
            // 
            this.Maa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maa.Location = new System.Drawing.Point(34, 293);
            this.Maa.Name = "Maa";
            this.Maa.Size = new System.Drawing.Size(100, 26);
            this.Maa.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Puhelinnumero";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Maa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.label5);
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
        private System.Windows.Forms.Label label5;
    }
}

