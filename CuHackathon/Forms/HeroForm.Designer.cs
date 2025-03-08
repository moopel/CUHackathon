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
            textBox1 = new TextBox();
            heroBodyBox = new TextBox();
            panel1 = new Panel();
            heroFooterBox = new TextBox();
            heroHeaderPanel.SuspendLayout();
            heroBodyPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // heroLabel
            // 
            heroLabel.BackColor = Color.Transparent;
            heroLabel.Dock = DockStyle.Fill;
            heroLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            heroLabel.ForeColor = Color.Black;
            heroLabel.Location = new Point(0, 0);
            heroLabel.Name = "heroLabel";
            heroLabel.Size = new Size(578, 75);
            heroLabel.TabIndex = 0;
            heroLabel.Text = "Choose Your Hero";
            heroLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heroHeaderPanel
            // 
            heroHeaderPanel.BackColor = Color.Gainsboro;
            heroHeaderPanel.Controls.Add(heroLabel);
            heroHeaderPanel.Dock = DockStyle.Top;
            heroHeaderPanel.Location = new Point(0, 0);
            heroHeaderPanel.Name = "heroHeaderPanel";
            heroHeaderPanel.Size = new Size(578, 75);
            heroHeaderPanel.TabIndex = 1;
            // 
            // heroBodyPanel
            // 
            heroBodyPanel.BackColor = Color.ForestGreen;
            heroBodyPanel.BackgroundImageLayout = ImageLayout.None;
            heroBodyPanel.Controls.Add(textBox1);
            heroBodyPanel.Controls.Add(heroBodyBox);
            heroBodyPanel.Dock = DockStyle.Top;
            heroBodyPanel.Location = new Point(0, 75);
            heroBodyPanel.Margin = new Padding(0);
            heroBodyPanel.Name = "heroBodyPanel";
            heroBodyPanel.Size = new Size(578, 657);
            heroBodyPanel.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(10, 688);
            textBox1.Margin = new Padding(10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(508, 115);
            textBox1.TabIndex = 1;
            // 
            // heroBodyBox
            // 
            heroBodyBox.BackColor = SystemColors.Info;
            heroBodyBox.Location = new Point(10, 10);
            heroBodyBox.Margin = new Padding(10);
            heroBodyBox.Multiline = true;
            heroBodyBox.Name = "heroBodyBox";
            heroBodyBox.Size = new Size(558, 637);
            heroBodyBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(heroFooterBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 732);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 156);
            panel1.TabIndex = 3;
            // 
            // heroFooterBox
            // 
            heroFooterBox.BackColor = SystemColors.Info;
            heroFooterBox.Location = new Point(8, 6);
            heroFooterBox.Multiline = true;
            heroFooterBox.Name = "heroFooterBox";
            heroFooterBox.Size = new Size(558, 140);
            heroFooterBox.TabIndex = 0;
            // 
            // HeroForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 888);
            Controls.Add(panel1);
            Controls.Add(heroBodyPanel);
            Controls.Add(heroHeaderPanel);
            Name = "HeroForm";
            heroHeaderPanel.ResumeLayout(false);
            heroBodyPanel.ResumeLayout(false);
            heroBodyPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label heroLabel;
        private Panel heroHeaderPanel;
        private Panel heroBodyPanel;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox heroBodyBox;
        private TextBox heroFooterBox;
    }
}