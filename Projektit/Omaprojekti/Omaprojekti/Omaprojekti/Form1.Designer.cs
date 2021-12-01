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
            this.SalasanaPanelTB = new System.Windows.Forms.TextBox();
            this.KäyttäjäPanelTB = new System.Windows.Forms.TextBox();
            this.TakaisinPanelBT = new System.Windows.Forms.Button();
            this.RekisteröidyPanelBT = new System.Windows.Forms.Button();
            this.RekisteröidyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // KäyttäjäTB
            // 
            this.KäyttäjäTB.Location = new System.Drawing.Point(343, 145);
            this.KäyttäjäTB.Name = "KäyttäjäTB";
            this.KäyttäjäTB.Size = new System.Drawing.Size(100, 20);
            this.KäyttäjäTB.TabIndex = 0;
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.Location = new System.Drawing.Point(343, 209);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(75, 23);
            this.KirjauduBT.TabIndex = 1;
            this.KirjauduBT.Text = "Kirjaudu";
            this.KirjauduBT.UseVisualStyleBackColor = true;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // RekisteröityminenBT
            // 
            this.RekisteröityminenBT.Location = new System.Drawing.Point(343, 238);
            this.RekisteröityminenBT.Name = "RekisteröityminenBT";
            this.RekisteröityminenBT.Size = new System.Drawing.Size(75, 23);
            this.RekisteröityminenBT.TabIndex = 2;
            this.RekisteröityminenBT.Text = "Rekisteröidy";
            this.RekisteröityminenBT.UseVisualStyleBackColor = true;
            this.RekisteröityminenBT.Click += new System.EventHandler(this.RekisteröityminenBT_Click);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(343, 171);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(100, 20);
            this.SalasanaTB.TabIndex = 3;
            // 
            // RekisteröidyPanel
            // 
            this.RekisteröidyPanel.Controls.Add(this.SalasanaPanelTB);
            this.RekisteröidyPanel.Controls.Add(this.KäyttäjäPanelTB);
            this.RekisteröidyPanel.Controls.Add(this.TakaisinPanelBT);
            this.RekisteröidyPanel.Controls.Add(this.RekisteröidyPanelBT);
            this.RekisteröidyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RekisteröidyPanel.Location = new System.Drawing.Point(0, 0);
            this.RekisteröidyPanel.Name = "RekisteröidyPanel";
            this.RekisteröidyPanel.Size = new System.Drawing.Size(800, 450);
            this.RekisteröidyPanel.TabIndex = 4;
            this.RekisteröidyPanel.Visible = false;
            // 
            // SalasanaPanelTB
            // 
            this.SalasanaPanelTB.Location = new System.Drawing.Point(371, 133);
            this.SalasanaPanelTB.Name = "SalasanaPanelTB";
            this.SalasanaPanelTB.Size = new System.Drawing.Size(100, 20);
            this.SalasanaPanelTB.TabIndex = 3;
            // 
            // KäyttäjäPanelTB
            // 
            this.KäyttäjäPanelTB.Location = new System.Drawing.Point(371, 107);
            this.KäyttäjäPanelTB.Name = "KäyttäjäPanelTB";
            this.KäyttäjäPanelTB.Size = new System.Drawing.Size(100, 20);
            this.KäyttäjäPanelTB.TabIndex = 2;
            // 
            // TakaisinPanelBT
            // 
            this.TakaisinPanelBT.Location = new System.Drawing.Point(49, 394);
            this.TakaisinPanelBT.Name = "TakaisinPanelBT";
            this.TakaisinPanelBT.Size = new System.Drawing.Size(75, 23);
            this.TakaisinPanelBT.TabIndex = 1;
            this.TakaisinPanelBT.Text = "Takaisin";
            this.TakaisinPanelBT.UseVisualStyleBackColor = true;
            this.TakaisinPanelBT.Click += new System.EventHandler(this.TakaisinPanelBT_Click);
            // 
            // RekisteröidyPanelBT
            // 
            this.RekisteröidyPanelBT.Location = new System.Drawing.Point(383, 159);
            this.RekisteröidyPanelBT.Name = "RekisteröidyPanelBT";
            this.RekisteröidyPanelBT.Size = new System.Drawing.Size(75, 23);
            this.RekisteröidyPanelBT.TabIndex = 0;
            this.RekisteröidyPanelBT.Text = "Rekisteröidy";
            this.RekisteröidyPanelBT.UseVisualStyleBackColor = true;
            this.RekisteröidyPanelBT.Click += new System.EventHandler(this.RekisteröidyPanelBT_Click);
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
        private System.Windows.Forms.TextBox SalasanaPanelTB;
        private System.Windows.Forms.TextBox KäyttäjäPanelTB;
        private System.Windows.Forms.Button TakaisinPanelBT;
        private System.Windows.Forms.Button RekisteröidyPanelBT;
    }
}

