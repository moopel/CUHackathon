namespace CuHackathon.Forms
{
    partial class HeroForm
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
            heroLabel = new Label();
            heroHeaderPanel = new Panel();
            heroBodyPanel = new Panel();
            panel1 = new Panel();
            heroHeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // heroLabel
            // 
            heroLabel.BackColor = Color.Transparent;
            heroLabel.Dock = DockStyle.Fill;
            heroLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            heroLabel.ForeColor = Color.White;
            heroLabel.Location = new Point(0, 0);
            heroLabel.Name = "heroLabel";
            heroLabel.Size = new Size(528, 75);
            heroLabel.TabIndex = 0;
            heroLabel.Text = "Choose Your Hero";
            heroLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heroHeaderPanel
            // 
            heroHeaderPanel.BackColor = Color.MediumSeaGreen;
            heroHeaderPanel.Controls.Add(heroLabel);
            heroHeaderPanel.Dock = DockStyle.Top;
            heroHeaderPanel.Location = new Point(0, 0);
            heroHeaderPanel.Name = "heroHeaderPanel";
            heroHeaderPanel.Size = new Size(528, 75);
            heroHeaderPanel.TabIndex = 1;
            // 
            // heroBodyPanel
            // 
            heroBodyPanel.BackColor = Color.ForestGreen;
            heroBodyPanel.Dock = DockStyle.Top;
            heroBodyPanel.Location = new Point(0, 75);
            heroBodyPanel.Margin = new Padding(0);
            heroBodyPanel.Name = "heroBodyPanel";
            heroBodyPanel.Size = new Size(528, 657);
            heroBodyPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 732);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 156);
            panel1.TabIndex = 3;
            // 
            // HeroForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 888);
            Controls.Add(panel1);
            Controls.Add(heroBodyPanel);
            Controls.Add(heroHeaderPanel);
            Name = "HeroForm";
            heroHeaderPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label heroLabel;
        private Panel heroHeaderPanel;
        private Panel heroBodyPanel;
        private Panel panel1;
    }
}