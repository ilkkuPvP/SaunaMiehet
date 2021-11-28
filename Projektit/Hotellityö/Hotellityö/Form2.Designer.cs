namespace Hotellityö
{
    partial class Form2
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
            this.Käyttäjätunnus = new System.Windows.Forms.TextBox();
            this.Salasana = new System.Windows.Forms.TextBox();
            this.Uusisalasana = new System.Windows.Forms.Button();
            this.Tarkistus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Käyttäjätunnus
            // 
            this.Käyttäjätunnus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Käyttäjätunnus.Location = new System.Drawing.Point(127, 83);
            this.Käyttäjätunnus.Name = "Käyttäjätunnus";
            this.Käyttäjätunnus.Size = new System.Drawing.Size(271, 35);
            this.Käyttäjätunnus.TabIndex = 0;
            // 
            // Salasana
            // 
            this.Salasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salasana.Location = new System.Drawing.Point(127, 145);
            this.Salasana.Name = "Salasana";
            this.Salasana.PasswordChar = '*';
            this.Salasana.Size = new System.Drawing.Size(271, 35);
            this.Salasana.TabIndex = 1;
            this.Salasana.TextChanged += new System.EventHandler(this.Salasana_TextChanged);
            // 
            // Uusisalasana
            // 
            this.Uusisalasana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uusisalasana.Location = new System.Drawing.Point(184, 249);
            this.Uusisalasana.Name = "Uusisalasana";
            this.Uusisalasana.Size = new System.Drawing.Size(152, 48);
            this.Uusisalasana.TabIndex = 2;
            this.Uusisalasana.Text = "Rekisteröidy";
            this.Uusisalasana.UseVisualStyleBackColor = true;
            this.Uusisalasana.Click += new System.EventHandler(this.Uusisalasana_Click);
            // 
            // Tarkistus
            // 
            this.Tarkistus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tarkistus.Location = new System.Drawing.Point(199, 195);
            this.Tarkistus.Name = "Tarkistus";
            this.Tarkistus.Size = new System.Drawing.Size(123, 48);
            this.Tarkistus.TabIndex = 3;
            this.Tarkistus.Text = "Kirjaudu";
            this.Tarkistus.UseVisualStyleBackColor = true;
            this.Tarkistus.Click += new System.EventHandler(this.Tarkistus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salasana:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tarkistus);
            this.Controls.Add(this.Uusisalasana);
            this.Controls.Add(this.Salasana);
            this.Controls.Add(this.Käyttäjätunnus);
            this.Name = "Form2";
            this.Text = "Kirjautuminen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Käyttäjätunnus;
        private System.Windows.Forms.TextBox Salasana;
        private System.Windows.Forms.Button Uusisalasana;
        private System.Windows.Forms.Button Tarkistus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}