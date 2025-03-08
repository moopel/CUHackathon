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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VillainForm));
            villainLabel = new Label();
            villainHeaderPanel = new Panel();
            villainBodyPanel = new Panel();
            generateVillainButton = new Button();
            villainBodyBox = new TextBox();
            villainFooterPanel = new Panel();
            villainFooterBox = new TextBox();
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
            villainLabel.Size = new Size(578, 75);
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
            villainHeaderPanel.Size = new Size(578, 75);
            villainHeaderPanel.TabIndex = 1;
            // 
            // villainBodyPanel
            // 
            villainBodyPanel.BackColor = Color.FromArgb(187, 33, 62);
            villainBodyPanel.Controls.Add(generateVillainButton);
            villainBodyPanel.Controls.Add(villainBodyBox);
            villainBodyPanel.Dock = DockStyle.Top;
            villainBodyPanel.Location = new Point(0, 75);
            villainBodyPanel.Margin = new Padding(0);
            villainBodyPanel.Name = "villainBodyPanel";
            villainBodyPanel.Size = new Size(578, 642);
            villainBodyPanel.TabIndex = 2;
            // 
            // generateVillainButton
            // 
            generateVillainButton.BackColor = Color.Black;
            generateVillainButton.FlatStyle = FlatStyle.Flat;
            generateVillainButton.Font = new Font("Showcard Gothic", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            generateVillainButton.ForeColor = Color.White;
            generateVillainButton.Image = (Image)resources.GetObject("generateVillainButton.Image");
            generateVillainButton.ImageAlign = ContentAlignment.MiddleRight;
            generateVillainButton.Location = new Point(152, 10);
            generateVillainButton.Margin = new Padding(0);
            generateVillainButton.Name = "generateVillainButton";
            generateVillainButton.Size = new Size(286, 39);
            generateVillainButton.TabIndex = 4;
            generateVillainButton.Text = "Generate Random";
            generateVillainButton.UseVisualStyleBackColor = false;
            generateVillainButton.Click += GenerateVillainButton_Click;
            // 
            // villainBodyBox
            // 
            villainBodyBox.BackColor = SystemColors.Info;
            villainBodyBox.Location = new Point(19, 59);
            villainBodyBox.Margin = new Padding(10);
            villainBodyBox.Multiline = true;
            villainBodyBox.Name = "villainBodyBox";
            villainBodyBox.Size = new Size(540, 573);
            villainBodyBox.TabIndex = 0;
            // 
            // villainFooterPanel
            // 
            villainFooterPanel.BackColor = Color.FromArgb(187, 33, 62);
            villainFooterPanel.Controls.Add(villainFooterBox);
            villainFooterPanel.Dock = DockStyle.Fill;
            villainFooterPanel.Location = new Point(0, 717);
            villainFooterPanel.Margin = new Padding(0);
            villainFooterPanel.Name = "villainFooterPanel";
            villainFooterPanel.Size = new Size(578, 171);
            villainFooterPanel.TabIndex = 3;
            // 
            // villainFooterBox
            // 
            villainFooterBox.BackColor = SystemColors.Info;
            villainFooterBox.Location = new Point(19, 10);
            villainFooterBox.Margin = new Padding(10);
            villainFooterBox.Multiline = true;
            villainFooterBox.Name = "villainFooterBox";
            villainFooterBox.Size = new Size(540, 151);
            villainFooterBox.TabIndex = 0;
            // 
            // VillainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 888);
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
        private Button generateVillainButton;
    }
}