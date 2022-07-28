namespace Activity_11
{
    partial class DieRollerForm
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
            this.opacityPanel = new System.Windows.Forms.Panel();
            this.amountRollsLabel = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.die2_SizeLabel = new System.Windows.Forms.Label();
            this.die2_Size = new System.Windows.Forms.NumericUpDown();
            this.die1_SizeLabel = new System.Windows.Forms.Label();
            this.die1_Size = new System.Windows.Forms.NumericUpDown();
            this.diceRollListLabel = new System.Windows.Forms.Label();
            this.rollsBox = new System.Windows.Forms.ListBox();
            this.opacityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.die2_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1_Size)).BeginInit();
            this.SuspendLayout();
            // 
            // opacityPanel
            // 
            this.opacityPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.opacityPanel.Controls.Add(this.amountRollsLabel);
            this.opacityPanel.Controls.Add(this.rollButton);
            this.opacityPanel.Controls.Add(this.die2_SizeLabel);
            this.opacityPanel.Controls.Add(this.die2_Size);
            this.opacityPanel.Controls.Add(this.die1_SizeLabel);
            this.opacityPanel.Controls.Add(this.die1_Size);
            this.opacityPanel.Controls.Add(this.diceRollListLabel);
            this.opacityPanel.Controls.Add(this.rollsBox);
            this.opacityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opacityPanel.Location = new System.Drawing.Point(0, 0);
            this.opacityPanel.Name = "opacityPanel";
            this.opacityPanel.Size = new System.Drawing.Size(614, 400);
            this.opacityPanel.TabIndex = 0;
            // 
            // amountRollsLabel
            // 
            this.amountRollsLabel.AutoSize = true;
            this.amountRollsLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountRollsLabel.Location = new System.Drawing.Point(205, 284);
            this.amountRollsLabel.Name = "amountRollsLabel";
            this.amountRollsLabel.Size = new System.Drawing.Size(269, 21);
            this.amountRollsLabel.TabIndex = 7;
            this.amountRollsLabel.Text = "Rolls taken until Snake Eyes:";
            // 
            // rollButton
            // 
            this.rollButton.BackgroundImage = global::Activity_11.Properties.Resources.image_from_rawpixel_id_6329843_png;
            this.rollButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rollButton.Location = new System.Drawing.Point(302, 140);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(140, 106);
            this.rollButton.TabIndex = 6;
            this.rollButton.Text = "Roll Until Snake Eyes!";
            this.rollButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // die2_SizeLabel
            // 
            this.die2_SizeLabel.AutoSize = true;
            this.die2_SizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.die2_SizeLabel.Location = new System.Drawing.Point(386, 66);
            this.die2_SizeLabel.Name = "die2_SizeLabel";
            this.die2_SizeLabel.Size = new System.Drawing.Size(197, 15);
            this.die2_SizeLabel.TabIndex = 5;
            this.die2_SizeLabel.Text = "How many sides for the second die?";
            // 
            // die2_Size
            // 
            this.die2_Size.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.die2_Size.Location = new System.Drawing.Point(425, 84);
            this.die2_Size.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.die2_Size.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.die2_Size.Name = "die2_Size";
            this.die2_Size.Size = new System.Drawing.Size(120, 23);
            this.die2_Size.TabIndex = 4;
            this.die2_Size.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // die1_SizeLabel
            // 
            this.die1_SizeLabel.AutoSize = true;
            this.die1_SizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.die1_SizeLabel.Location = new System.Drawing.Point(177, 66);
            this.die1_SizeLabel.Name = "die1_SizeLabel";
            this.die1_SizeLabel.Size = new System.Drawing.Size(179, 15);
            this.die1_SizeLabel.TabIndex = 3;
            this.die1_SizeLabel.Text = "How many sides for the first die?";
            // 
            // die1_Size
            // 
            this.die1_Size.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.die1_Size.Location = new System.Drawing.Point(205, 84);
            this.die1_Size.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.die1_Size.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.die1_Size.Name = "die1_Size";
            this.die1_Size.Size = new System.Drawing.Size(120, 23);
            this.die1_Size.TabIndex = 2;
            this.die1_Size.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // diceRollListLabel
            // 
            this.diceRollListLabel.AutoSize = true;
            this.diceRollListLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.diceRollListLabel.Location = new System.Drawing.Point(25, 4);
            this.diceRollListLabel.Name = "diceRollListLabel";
            this.diceRollListLabel.Size = new System.Drawing.Size(61, 15);
            this.diceRollListLabel.TabIndex = 1;
            this.diceRollListLabel.Text = "Dice Rolls:";
            // 
            // rollsBox
            // 
            this.rollsBox.FormattingEnabled = true;
            this.rollsBox.ItemHeight = 15;
            this.rollsBox.Items.AddRange(new object[] {
            " "});
            this.rollsBox.Location = new System.Drawing.Point(21, 20);
            this.rollsBox.Name = "rollsBox";
            this.rollsBox.Size = new System.Drawing.Size(120, 364);
            this.rollsBox.TabIndex = 0;
            // 
            // DieRollerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Activity_11.Properties.Resources.dicebackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 400);
            this.Controls.Add(this.opacityPanel);
            this.Name = "DieRollerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Die Roller";
            this.opacityPanel.ResumeLayout(false);
            this.opacityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.die2_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die1_Size)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel opacityPanel;
        private Label amountRollsLabel;
        private Button rollButton;
        private Label die2_SizeLabel;
        private NumericUpDown die2_Size;
        private Label die1_SizeLabel;
        private NumericUpDown die1_Size;
        private Label diceRollListLabel;
        private ListBox rollsBox;
    }
}