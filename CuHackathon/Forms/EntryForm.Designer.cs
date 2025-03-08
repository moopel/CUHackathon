namespace CuHackathon.Forms
{
    partial class EntryForm
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
            heroPanel = new Panel();
            villainPanel = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // heroPanel
            // 
            heroPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            heroPanel.BackColor = SystemColors.ActiveCaption;
            heroPanel.Dock = DockStyle.Left;
            heroPanel.Location = new Point(0, 0);
            heroPanel.Margin = new Padding(0);
            heroPanel.Name = "heroPanel";
            heroPanel.Size = new Size(550, 944);
            heroPanel.TabIndex = 0;
            // 
            // villainPanel
            // 
            villainPanel.BackColor = Color.IndianRed;
            villainPanel.Dock = DockStyle.Right;
            villainPanel.Location = new Point(700, 0);
            villainPanel.Margin = new Padding(0);
            villainPanel.Name = "villainPanel";
            villainPanel.Size = new Size(548, 944);
            villainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(550, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 944);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 944);
            Controls.Add(panel2);
            Controls.Add(villainPanel);
            Controls.Add(heroPanel);
            Name = "EntryForm";
            Text = "Entry";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel heroPanel;
        private Panel villainPanel;
        private Panel panel2;
    }
}
