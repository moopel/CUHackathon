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
            villainHeaderPanel.SuspendLayout();
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
            villainHeaderPanel.BackColor = Color.IndianRed;
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
            villainBodyPanel.BackColor = Color.Brown;
            villainBodyPanel.Dock = DockStyle.Top;
            villainBodyPanel.Location = new Point(0, 75);
            villainBodyPanel.Margin = new Padding(0);
            villainBodyPanel.Name = "villainBodyPanel";
            villainBodyPanel.Size = new Size(528, 475);
            villainBodyPanel.TabIndex = 2;
            // 
            // villainFooterPanel
            // 
            villainFooterPanel.BackColor = Color.LightCoral;
            villainFooterPanel.Dock = DockStyle.Bottom;
            villainFooterPanel.Location = new Point(0, 550);
            villainFooterPanel.Margin = new Padding(0);
            villainFooterPanel.Name = "villainFooterPanel";
            villainFooterPanel.Size = new Size(528, 338);
            villainFooterPanel.TabIndex = 3;
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
            ResumeLayout(false);
        }

        #endregion

        private Label villainLabel;
        private Panel villainHeaderPanel;
        private Panel villainBodyPanel;
        private Panel villainFooterPanel;
    }
}