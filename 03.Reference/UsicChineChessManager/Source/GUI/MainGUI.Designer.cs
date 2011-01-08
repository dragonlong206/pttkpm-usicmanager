namespace GUI
{
    partial class MainGUI
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
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.cậpNhậtTháchĐấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêXếpHạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýChungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtTháchĐấuToolStripMenuItem,
            this.thốngKêXếpHạngToolStripMenuItem,
            this.quảnLýChungToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(475, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // cậpNhậtTháchĐấuToolStripMenuItem
            // 
            this.cậpNhậtTháchĐấuToolStripMenuItem.AutoToolTip = true;
            this.cậpNhậtTháchĐấuToolStripMenuItem.CheckOnClick = true;
            this.cậpNhậtTháchĐấuToolStripMenuItem.Name = "cậpNhậtTháchĐấuToolStripMenuItem";
            this.cậpNhậtTháchĐấuToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.cậpNhậtTháchĐấuToolStripMenuItem.Text = "Cập Nhật Thách Đấu";
            this.cậpNhậtTháchĐấuToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtTháchĐấuToolStripMenuItem_Click);
            // 
            // thốngKêXếpHạngToolStripMenuItem
            // 
            this.thốngKêXếpHạngToolStripMenuItem.Name = "thốngKêXếpHạngToolStripMenuItem";
            this.thốngKêXếpHạngToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.thốngKêXếpHạngToolStripMenuItem.Text = "Thống Kê Xếp Hạng";
            this.thốngKêXếpHạngToolStripMenuItem.Click += new System.EventHandler(this.thốngKêXếpHạngToolStripMenuItem_Click);
            // 
            // quảnLýChungToolStripMenuItem
            // 
            this.quảnLýChungToolStripMenuItem.Name = "quảnLýChungToolStripMenuItem";
            this.quảnLýChungToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.quảnLýChungToolStripMenuItem.Text = "Quản Lý Chung";
            this.quảnLýChungToolStripMenuItem.Click += new System.EventHandler(this.quảnLýChungToolStripMenuItem_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 388);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phan Mem Xep Hang Co Tuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtTháchĐấuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêXếpHạngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýChungToolStripMenuItem;

    }
}