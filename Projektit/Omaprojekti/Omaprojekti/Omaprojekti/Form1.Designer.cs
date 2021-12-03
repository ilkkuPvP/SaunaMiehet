namespace Omaprojekti
{
    partial class KirjauduForm
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
            this.KäyttäjäTB = new System.Windows.Forms.TextBox();
            this.KirjauduBT = new System.Windows.Forms.Button();
            this.RekisteröityminenBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.RegPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SalasanaRegPanelTB = new System.Windows.Forms.TextBox();
            this.RegPanelBT = new System.Windows.Forms.Button();
            this.TakaisinRegPanelBT = new System.Windows.Forms.Button();
            this.KäyttäjäRegPanelTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PoistaTunnuksiaPanelBT = new System.Windows.Forms.Button();
            this.PoistaTuPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SalasanaPoistaTuPanelLB = new System.Windows.Forms.TextBox();
            this.PoistaTunnusBT = new System.Windows.Forms.Button();
            this.KäyttäjäPoistaTuPanelLB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TakaisinPoistaTuPanelBT = new System.Windows.Forms.Button();
            this.SalasanaNaytaBT = new System.Windows.Forms.Button();
            this.RegPanel.SuspendLayout();
            this.PoistaTuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KäyttäjäTB
            // 
            this.KäyttäjäTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KäyttäjäTB.Location = new System.Drawing.Point(293, 129);
            this.KäyttäjäTB.Name = "KäyttäjäTB";
            this.KäyttäjäTB.Size = new System.Drawing.Size(205, 35);
            this.KäyttäjäTB.TabIndex = 0;
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KirjauduBT.Location = new System.Drawing.Point(329, 252);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(129, 48);
            this.KirjauduBT.TabIndex = 2;
            this.KirjauduBT.Text = "Kirjaudu";
            this.KirjauduBT.UseVisualStyleBackColor = true;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // RekisteröityminenBT
            // 
            this.RekisteröityminenBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RekisteröityminenBT.Location = new System.Drawing.Point(309, 306);
            this.RekisteröityminenBT.Name = "RekisteröityminenBT";
            this.RekisteröityminenBT.Size = new System.Drawing.Size(169, 47);
            this.RekisteröityminenBT.TabIndex = 3;
            this.RekisteröityminenBT.Text = "Rekisteröityminen";
            this.RekisteröityminenBT.UseVisualStyleBackColor = true;
            this.RekisteröityminenBT.Click += new System.EventHandler(this.RekisteröityminenBT_Click);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(293, 198);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.PasswordChar = '*';
            this.SalasanaTB.Size = new System.Drawing.Size(205, 35);
            this.SalasanaTB.TabIndex = 1;
            // 
            // RegPanel
            // 
            this.RegPanel.Controls.Add(this.label5);
            this.RegPanel.Controls.Add(this.SalasanaRegPanelTB);
            this.RegPanel.Controls.Add(this.RegPanelBT);
            this.RegPanel.Controls.Add(this.TakaisinRegPanelBT);
            this.RegPanel.Controls.Add(this.KäyttäjäRegPanelTB);
            this.RegPanel.Controls.Add(this.label3);
            this.RegPanel.Controls.Add(this.label4);
            this.RegPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegPanel.Location = new System.Drawing.Point(0, 0);
            this.RegPanel.Name = "RegPanel";
            this.RegPanel.Size = new System.Drawing.Size(784, 411);
            this.RegPanel.TabIndex = 4;
            this.RegPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(778, 42);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rekisteröityminen";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SalasanaRegPanelTB
            // 
            this.SalasanaRegPanelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaRegPanelTB.Location = new System.Drawing.Point(293, 198);
            this.SalasanaRegPanelTB.Name = "SalasanaRegPanelTB";
            this.SalasanaRegPanelTB.PasswordChar = '*';
            this.SalasanaRegPanelTB.Size = new System.Drawing.Size(205, 35);
            this.SalasanaRegPanelTB.TabIndex = 16;
            // 
            // RegPanelBT
            // 
            this.RegPanelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegPanelBT.Location = new System.Drawing.Point(316, 252);
            this.RegPanelBT.Name = "RegPanelBT";
            this.RegPanelBT.Size = new System.Drawing.Size(155, 47);
            this.RegPanelBT.TabIndex = 18;
            this.RegPanelBT.Text = "Rekisteröidy";
            this.RegPanelBT.UseVisualStyleBackColor = true;
            this.RegPanelBT.Click += new System.EventHandler(this.RegPanelBT_Click);
            // 
            // TakaisinRegPanelBT
            // 
            this.TakaisinRegPanelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakaisinRegPanelBT.Location = new System.Drawing.Point(329, 306);
            this.TakaisinRegPanelBT.Name = "TakaisinRegPanelBT";
            this.TakaisinRegPanelBT.Size = new System.Drawing.Size(129, 48);
            this.TakaisinRegPanelBT.TabIndex = 17;
            this.TakaisinRegPanelBT.Text = "Takaisin";
            this.TakaisinRegPanelBT.UseVisualStyleBackColor = true;
            this.TakaisinRegPanelBT.Click += new System.EventHandler(this.TakaisinRegPanelBT_Click);
            // 
            // KäyttäjäRegPanelTB
            // 
            this.KäyttäjäRegPanelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KäyttäjäRegPanelTB.Location = new System.Drawing.Point(293, 129);
            this.KäyttäjäRegPanelTB.Name = "KäyttäjäRegPanelTB";
            this.KäyttäjäRegPanelTB.Size = new System.Drawing.Size(205, 35);
            this.KäyttäjäRegPanelTB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Käyttäjätunnus:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salasana:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(778, 42);
            this.label6.TabIndex = 22;
            this.label6.Text = "Kirjautuminen";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PoistaTunnuksiaPanelBT
            // 
            this.PoistaTunnuksiaPanelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaTunnuksiaPanelBT.Location = new System.Drawing.Point(316, 359);
            this.PoistaTunnuksiaPanelBT.Name = "PoistaTunnuksiaPanelBT";
            this.PoistaTunnuksiaPanelBT.Size = new System.Drawing.Size(156, 47);
            this.PoistaTunnuksiaPanelBT.TabIndex = 23;
            this.PoistaTunnuksiaPanelBT.Text = "Poista tunnuksia";
            this.PoistaTunnuksiaPanelBT.UseVisualStyleBackColor = true;
            this.PoistaTunnuksiaPanelBT.Click += new System.EventHandler(this.PoistaTunnuksiaPanelBT_Click);
            // 
            // PoistaTuPanel
            // 
            this.PoistaTuPanel.Controls.Add(this.label7);
            this.PoistaTuPanel.Controls.Add(this.SalasanaPoistaTuPanelLB);
            this.PoistaTuPanel.Controls.Add(this.PoistaTunnusBT);
            this.PoistaTuPanel.Controls.Add(this.KäyttäjäPoistaTuPanelLB);
            this.PoistaTuPanel.Controls.Add(this.label8);
            this.PoistaTuPanel.Controls.Add(this.label9);
            this.PoistaTuPanel.Controls.Add(this.TakaisinPoistaTuPanelBT);
            this.PoistaTuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PoistaTuPanel.Location = new System.Drawing.Point(0, 0);
            this.PoistaTuPanel.Name = "PoistaTuPanel";
            this.PoistaTuPanel.Size = new System.Drawing.Size(784, 411);
            this.PoistaTuPanel.TabIndex = 24;
            this.PoistaTuPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(778, 42);
            this.label7.TabIndex = 28;
            this.label7.Text = "Poista tunnuksia";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SalasanaPoistaTuPanelLB
            // 
            this.SalasanaPoistaTuPanelLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaPoistaTuPanelLB.Location = new System.Drawing.Point(293, 198);
            this.SalasanaPoistaTuPanelLB.Name = "SalasanaPoistaTuPanelLB";
            this.SalasanaPoistaTuPanelLB.PasswordChar = '*';
            this.SalasanaPoistaTuPanelLB.Size = new System.Drawing.Size(205, 35);
            this.SalasanaPoistaTuPanelLB.TabIndex = 23;
            // 
            // PoistaTunnusBT
            // 
            this.PoistaTunnusBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoistaTunnusBT.Location = new System.Drawing.Point(316, 252);
            this.PoistaTunnusBT.Name = "PoistaTunnusBT";
            this.PoistaTunnusBT.Size = new System.Drawing.Size(155, 47);
            this.PoistaTunnusBT.TabIndex = 25;
            this.PoistaTunnusBT.Text = "Poista tunnus";
            this.PoistaTunnusBT.UseVisualStyleBackColor = true;
            this.PoistaTunnusBT.Click += new System.EventHandler(this.PoistaTunnusBT_Click);
            // 
            // KäyttäjäPoistaTuPanelLB
            // 
            this.KäyttäjäPoistaTuPanelLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KäyttäjäPoistaTuPanelLB.Location = new System.Drawing.Point(293, 129);
            this.KäyttäjäPoistaTuPanelLB.Name = "KäyttäjäPoistaTuPanelLB";
            this.KäyttäjäPoistaTuPanelLB.Size = new System.Drawing.Size(205, 35);
            this.KäyttäjäPoistaTuPanelLB.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(293, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Käyttäjätunnus:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(293, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Salasana:";
            // 
            // TakaisinPoistaTuPanelBT
            // 
            this.TakaisinPoistaTuPanelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakaisinPoistaTuPanelBT.Location = new System.Drawing.Point(329, 306);
            this.TakaisinPoistaTuPanelBT.Name = "TakaisinPoistaTuPanelBT";
            this.TakaisinPoistaTuPanelBT.Size = new System.Drawing.Size(129, 48);
            this.TakaisinPoistaTuPanelBT.TabIndex = 18;
            this.TakaisinPoistaTuPanelBT.Text = "Takaisin";
            this.TakaisinPoistaTuPanelBT.UseVisualStyleBackColor = true;
            this.TakaisinPoistaTuPanelBT.Click += new System.EventHandler(this.TakaisinPoistaTuPanelBT_Click);
            // 
            // SalasanaNaytaBT
            // 
            this.SalasanaNaytaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaNaytaBT.Location = new System.Drawing.Point(504, 198);
            this.SalasanaNaytaBT.Name = "SalasanaNaytaBT";
            this.SalasanaNaytaBT.Size = new System.Drawing.Size(68, 35);
            this.SalasanaNaytaBT.TabIndex = 30;
            this.SalasanaNaytaBT.Text = "Näytä";
            this.SalasanaNaytaBT.UseVisualStyleBackColor = true;
            this.SalasanaNaytaBT.Click += new System.EventHandler(this.SalasanaNaytaBT_Click);
            // 
            // KirjauduForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.SalasanaNaytaBT);
            this.Controls.Add(this.PoistaTuPanel);
            this.Controls.Add(this.RegPanel);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.RekisteröityminenBT);
            this.Controls.Add(this.KirjauduBT);
            this.Controls.Add(this.KäyttäjäTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PoistaTunnuksiaPanelBT);
            this.Name = "KirjauduForm";
            this.Text = "Kirjaudu";
            this.RegPanel.ResumeLayout(false);
            this.RegPanel.PerformLayout();
            this.PoistaTuPanel.ResumeLayout(false);
            this.PoistaTuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KäyttäjäTB;
        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.Button RekisteröityminenBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Panel RegPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SalasanaRegPanelTB;
        private System.Windows.Forms.Button RegPanelBT;
        private System.Windows.Forms.Button TakaisinRegPanelBT;
        private System.Windows.Forms.TextBox KäyttäjäRegPanelTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PoistaTunnuksiaPanelBT;
        private System.Windows.Forms.Panel PoistaTuPanel;
        private System.Windows.Forms.Button TakaisinPoistaTuPanelBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SalasanaPoistaTuPanelLB;
        private System.Windows.Forms.Button PoistaTunnusBT;
        private System.Windows.Forms.TextBox KäyttäjäPoistaTuPanelLB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SalasanaNaytaBT;
    }
}

