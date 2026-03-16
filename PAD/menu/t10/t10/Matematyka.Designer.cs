namespace t10
{
    partial class Matematyka
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            geometriaToolStripMenuItem = new ToolStripMenuItem();
            poilToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { geometriaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // geometriaToolStripMenuItem
            // 
            geometriaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { poilToolStripMenuItem });
            geometriaToolStripMenuItem.Name = "geometriaToolStripMenuItem";
            geometriaToolStripMenuItem.Size = new Size(74, 20);
            geometriaToolStripMenuItem.Text = "Geometria";
            // 
            // poilToolStripMenuItem
            // 
            poilToolStripMenuItem.Name = "poilToolStripMenuItem";
            poilToolStripMenuItem.Size = new Size(180, 22);
            poilToolStripMenuItem.Text = "Pole Prostokata";
            poilToolStripMenuItem.Click += poilToolStripMenuItem_Click;
            // 
            // Matematyka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Matematyka";
            Text = "Matematyka";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem geometriaToolStripMenuItem;
        private ToolStripMenuItem poilToolStripMenuItem;
    }
}
