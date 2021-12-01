namespace Omaprojekti
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
            this.KäyttäjäTB = new System.Windows.Forms.TextBox();
            this.KirjauduBT = new System.Windows.Forms.Button();
            this.RekisteröityminenBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.RekisteröidyPanel = new System.Windows.Forms.Panel();
            this.KäyttäjäPanelTB = new System.Windows.Forms.TextBox();
            this.RekisteröidyPanelBT = new System.Windows.Forms.Button();
            this.TakaisinPanelBT = new System.Windows.Forms.Button();
            this.SalasanaPanelTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RekisteröidyPanel.SuspendLayout();
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
            this.RekisteröityminenBT.Location = new System.Drawing.Point(316, 306);
            this.RekisteröityminenBT.Name = "RekisteröityminenBT";
            this.RekisteröityminenBT.Size = new System.Drawing.Size(155, 47);
            this.RekisteröityminenBT.TabIndex = 3;
            this.RekisteröityminenBT.Text = "Rekisteröidy";
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
            // RekisteröidyPanel
            // 
            this.RekisteröidyPanel.Controls.Add(this.KäyttäjäPanelTB);
            this.RekisteröidyPanel.Controls.Add(this.RekisteröidyPanelBT);
            this.RekisteröidyPanel.Controls.Add(this.TakaisinPanelBT);
            this.RekisteröidyPanel.Controls.Add(this.SalasanaPanelTB);
            this.RekisteröidyPanel.Controls.Add(this.label3);
            this.RekisteröidyPanel.Controls.Add(this.label4);
            this.RekisteröidyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RekisteröidyPanel.Location = new System.Drawing.Point(0, 0);
            this.RekisteröidyPanel.Name = "RekisteröidyPanel";
            this.RekisteröidyPanel.Size = new System.Drawing.Size(800, 450);
            this.RekisteröidyPanel.TabIndex = 4;
            this.RekisteröidyPanel.Visible = false;
            // 
            // KäyttäjäPanelTB
            // 
            this.KäyttäjäPanelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KäyttäjäPanelTB.Location = new System.Drawing.Point(293, 198);
            this.KäyttäjäPanelTB.Name = "KäyttäjäPanelTB";
            this.KäyttäjäPanelTB.PasswordChar = '*';
            this.KäyttäjäPanelTB.Size = new System.Drawing.Size(205, 35);
            this.KäyttäjäPanelTB.TabIndex = 16;
            // 
            // RekisteröidyPanelBT
            // 
            this.RekisteröidyPanelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RekisteröidyPanelBT.Location = new System.Drawing.Point(316, 252);
            this.RekisteröidyPanelBT.Name = "RekisteröidyPanelBT";
            this.RekisteröidyPanelBT.Size = new System.Drawing.Size(155, 47);
            this.RekisteröidyPanelBT.TabIndex = 18;
            this.RekisteröidyPanelBT.Text = "Rekisteröidy";
            this.RekisteröidyPanelBT.UseVisualStyleBackColor = true;
            // 
            // TakaisinPanelBT
            // 
            this.TakaisinPanelBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TakaisinPanelBT.Location = new System.Drawing.Point(329, 306);
            this.TakaisinPanelBT.Name = "TakaisinPanelBT";
            this.TakaisinPanelBT.Size = new System.Drawing.Size(129, 48);
            this.TakaisinPanelBT.TabIndex = 17;
            this.TakaisinPanelBT.Text = "Takaisin";
            this.TakaisinPanelBT.UseVisualStyleBackColor = true;
            // 
            // SalasanaPanelTB
            // 
            this.SalasanaPanelTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaPanelTB.Location = new System.Drawing.Point(293, 129);
            this.SalasanaPanelTB.Name = "SalasanaPanelTB";
            this.SalasanaPanelTB.Size = new System.Drawing.Size(205, 35);
            this.SalasanaPanelTB.TabIndex = 15;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RekisteröidyPanel);
            this.Controls.Add(this.SalasanaTB);
            this.Controls.Add(this.RekisteröityminenBT);
            this.Controls.Add(this.KirjauduBT);
            this.Controls.Add(this.KäyttäjäTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RekisteröidyPanel.ResumeLayout(false);
            this.RekisteröidyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KäyttäjäTB;
        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.Button RekisteröityminenBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.Panel RekisteröidyPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KäyttäjäPanelTB;
        private System.Windows.Forms.Button RekisteröidyPanelBT;
        private System.Windows.Forms.Button TakaisinPanelBT;
        private System.Windows.Forms.TextBox SalasanaPanelTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

