namespace Hotellityö
{
    partial class Huoneet
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
            this.Uusi = new System.Windows.Forms.Button();
            this.Päivitä = new System.Windows.Forms.Button();
            this.Poista = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.Label();
            this.Puhelinnumero = new System.Windows.Forms.Label();
            this.Onkovarattu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Puhelin = new System.Windows.Forms.TextBox();
            this.Num = new System.Windows.Forms.TextBox();
            this.Taulu = new System.Windows.Forms.DataGridView();
            this.Kyllä = new System.Windows.Forms.RadioButton();
            this.Ei = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Taulu)).BeginInit();
            this.SuspendLayout();
            // 
            // Uusi
            // 
            this.Uusi.Location = new System.Drawing.Point(299, 286);
            this.Uusi.Name = "Uusi";
            this.Uusi.Size = new System.Drawing.Size(75, 23);
            this.Uusi.TabIndex = 0;
            this.Uusi.Text = "Uusi";
            this.Uusi.UseVisualStyleBackColor = true;
            this.Uusi.Click += new System.EventHandler(this.Uusi_Click);
            // 
            // Päivitä
            // 
            this.Päivitä.Location = new System.Drawing.Point(381, 285);
            this.Päivitä.Name = "Päivitä";
            this.Päivitä.Size = new System.Drawing.Size(75, 23);
            this.Päivitä.TabIndex = 1;
            this.Päivitä.Text = "Päivitä";
            this.Päivitä.UseVisualStyleBackColor = true;
            this.Päivitä.Click += new System.EventHandler(this.Päivitä_Click);
            // 
            // Poista
            // 
            this.Poista.Location = new System.Drawing.Point(462, 286);
            this.Poista.Name = "Poista";
            this.Poista.Size = new System.Drawing.Size(75, 23);
            this.Poista.TabIndex = 2;
            this.Poista.Text = "Poista";
            this.Poista.UseVisualStyleBackColor = true;
            this.Poista.Click += new System.EventHandler(this.button3_Click);
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(89, 126);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(86, 13);
            this.Numero.TabIndex = 3;
            this.Numero.Text = "Huoneennumero";
            // 
            // Puhelinnumero
            // 
            this.Puhelinnumero.AutoSize = true;
            this.Puhelinnumero.Location = new System.Drawing.Point(98, 149);
            this.Puhelinnumero.Name = "Puhelinnumero";
            this.Puhelinnumero.Size = new System.Drawing.Size(77, 13);
            this.Puhelinnumero.TabIndex = 4;
            this.Puhelinnumero.Text = "Puhelinnumero";
            // 
            // Onkovarattu
            // 
            this.Onkovarattu.AutoSize = true;
            this.Onkovarattu.Location = new System.Drawing.Point(108, 174);
            this.Onkovarattu.Name = "Onkovarattu";
            this.Onkovarattu.Size = new System.Drawing.Size(66, 13);
            this.Onkovarattu.TabIndex = 5;
            this.Onkovarattu.Text = "Onkovarattu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Huonetyyppi";
            // 
            // Puhelin
            // 
            this.Puhelin.Location = new System.Drawing.Point(181, 149);
            this.Puhelin.Name = "Puhelin";
            this.Puhelin.Size = new System.Drawing.Size(100, 20);
            this.Puhelin.TabIndex = 8;
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(181, 123);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(100, 20);
            this.Num.TabIndex = 10;
            this.Num.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Taulu
            // 
            this.Taulu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Taulu.Location = new System.Drawing.Point(287, 53);
            this.Taulu.Name = "Taulu";
            this.Taulu.Size = new System.Drawing.Size(372, 226);
            this.Taulu.TabIndex = 11;
            // 
            // Kyllä
            // 
            this.Kyllä.AutoSize = true;
            this.Kyllä.Location = new System.Drawing.Point(181, 175);
            this.Kyllä.Name = "Kyllä";
            this.Kyllä.Size = new System.Drawing.Size(47, 17);
            this.Kyllä.TabIndex = 12;
            this.Kyllä.TabStop = true;
            this.Kyllä.Text = "Kyllä\r\n";
            this.Kyllä.UseVisualStyleBackColor = true;
            this.Kyllä.CheckedChanged += new System.EventHandler(this.Kyllä_CheckedChanged);
            // 
            // Ei
            // 
            this.Ei.AutoSize = true;
            this.Ei.Location = new System.Drawing.Point(181, 198);
            this.Ei.Name = "Ei";
            this.Ei.Size = new System.Drawing.Size(34, 17);
            this.Ei.TabIndex = 13;
            this.Ei.TabStop = true;
            this.Ei.Text = "Ei";
            this.Ei.UseVisualStyleBackColor = true;
            this.Ei.CheckedChanged += new System.EventHandler(this.Ei_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(181, 233);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yksiö";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(181, 257);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pari";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(181, 281);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(53, 17);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Perhe";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Huoneet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Ei);
            this.Controls.Add(this.Kyllä);
            this.Controls.Add(this.Taulu);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Puhelin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Onkovarattu);
            this.Controls.Add(this.Puhelinnumero);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Poista);
            this.Controls.Add(this.Päivitä);
            this.Controls.Add(this.Uusi);
            this.Name = "Huoneet";
            this.Text = "Huoneet";
            this.Load += new System.EventHandler(this.Huoneet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Taulu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Uusi;
        private System.Windows.Forms.Button Päivitä;
        private System.Windows.Forms.Button Poista;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label Puhelinnumero;
        private System.Windows.Forms.Label Onkovarattu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Puhelin;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.DataGridView Taulu;
        private System.Windows.Forms.RadioButton Kyllä;
        private System.Windows.Forms.RadioButton Ei;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}