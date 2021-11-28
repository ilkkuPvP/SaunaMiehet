namespace Hotellityö
{
    partial class Pää
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ihmistentiedotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.huoneetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ihmistentiedotToolStripMenuItem,
            this.huoneetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ihmistentiedotToolStripMenuItem
            // 
            this.ihmistentiedotToolStripMenuItem.Name = "ihmistentiedotToolStripMenuItem";
            this.ihmistentiedotToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.ihmistentiedotToolStripMenuItem.Text = "Asiakastiedot";
            this.ihmistentiedotToolStripMenuItem.Click += new System.EventHandler(this.ihmistentiedotToolStripMenuItem_Click);
            // 
            // huoneetToolStripMenuItem
            // 
            this.huoneetToolStripMenuItem.Name = "huoneetToolStripMenuItem";
            this.huoneetToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.huoneetToolStripMenuItem.Text = "Huoneet";
            this.huoneetToolStripMenuItem.Click += new System.EventHandler(this.huoneetToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            this.label1.Visible = false;
            // 
            // Pää
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Pää";
            this.Text = "Päävalikko";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pää_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ihmistentiedotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem huoneetToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}