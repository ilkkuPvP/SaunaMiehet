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
            this.SuspendLayout();
            // 
            // Käyttäjätunnus
            // 
            this.Käyttäjätunnus.Location = new System.Drawing.Point(379, 214);
            this.Käyttäjätunnus.Name = "Käyttäjätunnus";
            this.Käyttäjätunnus.Size = new System.Drawing.Size(100, 20);
            this.Käyttäjätunnus.TabIndex = 0;
            this.Käyttäjätunnus.TextChanged += new System.EventHandler(this.Käyttäjätunnus_TextChanged);
            // 
            // Salasana
            // 
            this.Salasana.Location = new System.Drawing.Point(379, 240);
            this.Salasana.Name = "Salasana";
            this.Salasana.Size = new System.Drawing.Size(100, 20);
            this.Salasana.TabIndex = 1;
            this.Salasana.TextChanged += new System.EventHandler(this.Salasana_TextChanged);
            // 
            // Uusisalasana
            // 
            this.Uusisalasana.Location = new System.Drawing.Point(629, 210);
            this.Uusisalasana.Name = "Uusisalasana";
            this.Uusisalasana.Size = new System.Drawing.Size(81, 23);
            this.Uusisalasana.TabIndex = 2;
            this.Uusisalasana.Text = "Uusisalasana";
            this.Uusisalasana.UseVisualStyleBackColor = true;
            this.Uusisalasana.Click += new System.EventHandler(this.Uusisalasana_Click);
            // 
            // Tarkistus
            // 
            this.Tarkistus.Location = new System.Drawing.Point(635, 237);
            this.Tarkistus.Name = "Tarkistus";
            this.Tarkistus.Size = new System.Drawing.Size(75, 23);
            this.Tarkistus.TabIndex = 3;
            this.Tarkistus.Text = "Tarkistus";
            this.Tarkistus.UseVisualStyleBackColor = true;
            this.Tarkistus.Click += new System.EventHandler(this.Tarkistus_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tarkistus);
            this.Controls.Add(this.Uusisalasana);
            this.Controls.Add(this.Salasana);
            this.Controls.Add(this.Käyttäjätunnus);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Käyttäjätunnus;
        private System.Windows.Forms.TextBox Salasana;
        private System.Windows.Forms.Button Uusisalasana;
        private System.Windows.Forms.Button Tarkistus;
    }
}