namespace CuHackathon.Forms
{
    partial class VillainForm
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
            villainLabel = new Label();
            villainHeaderPanel = new Panel();
            villainBodyPanel = new Panel();
            villainFooterPanel = new Panel();
            villainBodyBox = new TextBox();
            villainFooterBox = new TextBox();
            comboBox1 = new ComboBox();
            villainHeaderPanel.SuspendLayout();
            villainBodyPanel.SuspendLayout();
            villainFooterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // villainLabel
            // 
            villainLabel.BackColor = Color.Transparent;
            villainLabel.Dock = DockStyle.Fill;
            villainLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            villainLabel.ForeColor = Color.White;
            villainLabel.Location = new Point(0, 0);
            villainLabel.Name = "villainLabel";
            villainLabel.Size = new Size(528, 75);
            villainLabel.TabIndex = 0;
            villainLabel.Text = "Choose Your Villain";
            villainLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // villainHeaderPanel
            // 
            villainHeaderPanel.BackColor = Color.Black;
            villainHeaderPanel.Controls.Add(villainLabel);
            villainHeaderPanel.Dock = DockStyle.Top;
            villainHeaderPanel.Location = new Point(0, 0);
            villainHeaderPanel.Margin = new Padding(0);
            villainHeaderPanel.Name = "villainHeaderPanel";
            villainHeaderPanel.Size = new Size(528, 75);
            villainHeaderPanel.TabIndex = 1;
            // 
            // villainBodyPanel
            // 
            villainBodyPanel.BackColor = Color.FromArgb(187, 33, 62);
            villainBodyPanel.Controls.Add(comboBox1);
            villainBodyPanel.Controls.Add(villainBodyBox);
            villainBodyPanel.Dock = DockStyle.Top;
            villainBodyPanel.Location = new Point(0, 75);
            villainBodyPanel.Margin = new Padding(0);
            villainBodyPanel.Name = "villainBodyPanel";
            villainBodyPanel.Size = new Size(528, 475);
            villainBodyPanel.TabIndex = 2;
            // 
            // villainFooterPanel
            // 
            villainFooterPanel.BackColor = Color.FromArgb(187, 33, 62);
            villainFooterPanel.Controls.Add(villainFooterBox);
            villainFooterPanel.Dock = DockStyle.Fill;
            villainFooterPanel.Location = new Point(0, 550);
            villainFooterPanel.Margin = new Padding(0);
            villainFooterPanel.Name = "villainFooterPanel";
            villainFooterPanel.Size = new Size(528, 338);
            villainFooterPanel.TabIndex = 3;
            // 
            // villainBodyBox
            // 
            villainBodyBox.BackColor = SystemColors.Info;
            villainBodyBox.Location = new Point(19, 63);
            villainBodyBox.Margin = new Padding(10);
            villainBodyBox.Multiline = true;
            villainBodyBox.Name = "villainBodyBox";
            villainBodyBox.Size = new Size(499, 402);
            villainBodyBox.TabIndex = 0;
            // 
            // villainFooterBox
            // 
            villainFooterBox.BackColor = SystemColors.Info;
            villainFooterBox.Location = new Point(19, 23);
            villainFooterBox.Margin = new Padding(10);
            villainFooterBox.Multiline = true;
            villainFooterBox.Name = "villainFooterBox";
            villainFooterBox.Size = new Size(499, 296);
            villainFooterBox.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 10);
            comboBox1.Margin = new Padding(25, 10, 25, 10);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(460, 33);
            comboBox1.TabIndex = 1;
            // 
            // VillainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 888);
            Controls.Add(villainFooterPanel);
            Controls.Add(villainBodyPanel);
            Controls.Add(villainHeaderPanel);
            Name = "VillainForm";
            villainHeaderPanel.ResumeLayout(false);
            villainBodyPanel.ResumeLayout(false);
            villainBodyPanel.PerformLayout();
            villainFooterPanel.ResumeLayout(false);
            villainFooterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label villainLabel;
        private Panel villainHeaderPanel;
        private Panel villainBodyPanel;
        private Panel villainFooterPanel;
        private TextBox villainBodyBox;
        private TextBox villainFooterBox;
        private ComboBox comboBox1;
    }
}