namespace Pot_Plant_the_Game
{
    partial class Form1
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
            this.interfaceBox = new System.Windows.Forms.GroupBox();
            this.nextDayButton = new System.Windows.Forms.Button();
            this.changePotButton = new System.Windows.Forms.RadioButton();
            this.changePotsButton = new System.Windows.Forms.Button();
            this.waterButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.daysSurvivedBox = new System.Windows.Forms.TextBox();
            this.daysSinceWaterBox = new System.Windows.Forms.TextBox();
            this.aliveBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plantBox = new System.Windows.Forms.GroupBox();
            this.chooseDaliaButton = new System.Windows.Forms.Button();
            this.chooseRoseButton = new System.Windows.Forms.Button();
            this.chooseYourPlantLabel = new System.Windows.Forms.Label();
            this.supremePictureBox = new System.Windows.Forms.PictureBox();
            this.interfaceBox.SuspendLayout();
            this.plantBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supremePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // interfaceBox
            // 
            this.interfaceBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.interfaceBox.Controls.Add(this.nextDayButton);
            this.interfaceBox.Controls.Add(this.changePotButton);
            this.interfaceBox.Controls.Add(this.changePotsButton);
            this.interfaceBox.Controls.Add(this.waterButton);
            this.interfaceBox.Controls.Add(this.resetButton);
            this.interfaceBox.Controls.Add(this.daysSurvivedBox);
            this.interfaceBox.Controls.Add(this.daysSinceWaterBox);
            this.interfaceBox.Controls.Add(this.aliveBox);
            this.interfaceBox.Controls.Add(this.label3);
            this.interfaceBox.Controls.Add(this.label2);
            this.interfaceBox.Controls.Add(this.label1);
            this.interfaceBox.Location = new System.Drawing.Point(735, 51);
            this.interfaceBox.MaximumSize = new System.Drawing.Size(896, 669);
            this.interfaceBox.MinimumSize = new System.Drawing.Size(896, 669);
            this.interfaceBox.Name = "interfaceBox";
            this.interfaceBox.Size = new System.Drawing.Size(896, 669);
            this.interfaceBox.TabIndex = 1;
            this.interfaceBox.TabStop = false;
            this.interfaceBox.Text = "Interface";
            // 
            // nextDayButton
            // 
            this.nextDayButton.BackColor = System.Drawing.Color.DarkGreen;
            this.nextDayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nextDayButton.Location = new System.Drawing.Point(48, 455);
            this.nextDayButton.MaximumSize = new System.Drawing.Size(196, 167);
            this.nextDayButton.MinimumSize = new System.Drawing.Size(196, 167);
            this.nextDayButton.Name = "nextDayButton";
            this.nextDayButton.Size = new System.Drawing.Size(196, 167);
            this.nextDayButton.TabIndex = 11;
            this.nextDayButton.Text = "Next Day";
            this.nextDayButton.UseVisualStyleBackColor = false;
            this.nextDayButton.Click += new System.EventHandler(this.nextDayButton_Click);
            // 
            // changePotButton
            // 
            this.changePotButton.AutoSize = true;
            this.changePotButton.Enabled = false;
            this.changePotButton.Location = new System.Drawing.Point(265, 366);
            this.changePotButton.Name = "changePotButton";
            this.changePotButton.Size = new System.Drawing.Size(225, 36);
            this.changePotButton.TabIndex = 10;
            this.changePotButton.Text = "Change Pot Alert";
            this.changePotButton.UseVisualStyleBackColor = true;
            // 
            // changePotsButton
            // 
            this.changePotsButton.BackColor = System.Drawing.SystemColors.Info;
            this.changePotsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePotsButton.Location = new System.Drawing.Point(265, 455);
            this.changePotsButton.MaximumSize = new System.Drawing.Size(196, 167);
            this.changePotsButton.MinimumSize = new System.Drawing.Size(196, 167);
            this.changePotsButton.Name = "changePotsButton";
            this.changePotsButton.Size = new System.Drawing.Size(196, 167);
            this.changePotsButton.TabIndex = 9;
            this.changePotsButton.Text = "Change Pots";
            this.changePotsButton.UseVisualStyleBackColor = false;
            this.changePotsButton.Click += new System.EventHandler(this.changePotsButton_Click);
            // 
            // waterButton
            // 
            this.waterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.waterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.waterButton.Location = new System.Drawing.Point(479, 455);
            this.waterButton.MaximumSize = new System.Drawing.Size(196, 167);
            this.waterButton.MinimumSize = new System.Drawing.Size(196, 167);
            this.waterButton.Name = "waterButton";
            this.waterButton.Size = new System.Drawing.Size(196, 167);
            this.waterButton.TabIndex = 8;
            this.waterButton.Text = "Water the Plant";
            this.waterButton.UseVisualStyleBackColor = false;
            this.waterButton.Click += new System.EventHandler(this.waterButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Red;
            this.resetButton.Location = new System.Drawing.Point(693, 477);
            this.resetButton.MaximumSize = new System.Drawing.Size(173, 128);
            this.resetButton.MinimumSize = new System.Drawing.Size(173, 128);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(173, 128);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset Game";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // daysSurvivedBox
            // 
            this.daysSurvivedBox.Location = new System.Drawing.Point(427, 179);
            this.daysSurvivedBox.Name = "daysSurvivedBox";
            this.daysSurvivedBox.ReadOnly = true;
            this.daysSurvivedBox.Size = new System.Drawing.Size(226, 39);
            this.daysSurvivedBox.TabIndex = 5;
            this.daysSurvivedBox.Text = "asda";
            this.daysSurvivedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // daysSinceWaterBox
            // 
            this.daysSinceWaterBox.Location = new System.Drawing.Point(427, 279);
            this.daysSinceWaterBox.Name = "daysSinceWaterBox";
            this.daysSinceWaterBox.ReadOnly = true;
            this.daysSinceWaterBox.Size = new System.Drawing.Size(226, 39);
            this.daysSinceWaterBox.TabIndex = 4;
            this.daysSinceWaterBox.Text = "asda";
            this.daysSinceWaterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aliveBox
            // 
            this.aliveBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.aliveBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aliveBox.Location = new System.Drawing.Point(427, 78);
            this.aliveBox.Name = "aliveBox";
            this.aliveBox.ReadOnly = true;
            this.aliveBox.Size = new System.Drawing.Size(226, 39);
            this.aliveBox.TabIndex = 3;
            this.aliveBox.Text = "asda";
            this.aliveBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Days Since Water";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(67, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Days Survived:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plant Condition:";
            // 
            // plantBox
            // 
            this.plantBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.plantBox.Controls.Add(this.chooseDaliaButton);
            this.plantBox.Controls.Add(this.chooseRoseButton);
            this.plantBox.Controls.Add(this.chooseYourPlantLabel);
            this.plantBox.Controls.Add(this.supremePictureBox);
            this.plantBox.ForeColor = System.Drawing.Color.Yellow;
            this.plantBox.Location = new System.Drawing.Point(27, 51);
            this.plantBox.MinimumSize = new System.Drawing.Size(681, 669);
            this.plantBox.Name = "plantBox";
            this.plantBox.Size = new System.Drawing.Size(681, 669);
            this.plantBox.TabIndex = 2;
            this.plantBox.TabStop = false;
            this.plantBox.Text = "Plantbox";
            // 
            // chooseDaliaButton
            // 
            this.chooseDaliaButton.ForeColor = System.Drawing.Color.Teal;
            this.chooseDaliaButton.Location = new System.Drawing.Point(404, 230);
            this.chooseDaliaButton.MaximumSize = new System.Drawing.Size(208, 136);
            this.chooseDaliaButton.MinimumSize = new System.Drawing.Size(208, 136);
            this.chooseDaliaButton.Name = "chooseDaliaButton";
            this.chooseDaliaButton.Size = new System.Drawing.Size(208, 136);
            this.chooseDaliaButton.TabIndex = 3;
            this.chooseDaliaButton.Text = "Dahlia";
            this.chooseDaliaButton.UseVisualStyleBackColor = true;
            this.chooseDaliaButton.Click += new System.EventHandler(this.chooseDaliaButton_Click);
            // 
            // chooseRoseButton
            // 
            this.chooseRoseButton.ForeColor = System.Drawing.Color.Red;
            this.chooseRoseButton.Location = new System.Drawing.Point(37, 230);
            this.chooseRoseButton.MaximumSize = new System.Drawing.Size(208, 136);
            this.chooseRoseButton.MinimumSize = new System.Drawing.Size(208, 136);
            this.chooseRoseButton.Name = "chooseRoseButton";
            this.chooseRoseButton.Size = new System.Drawing.Size(208, 136);
            this.chooseRoseButton.TabIndex = 2;
            this.chooseRoseButton.Text = "Rose";
            this.chooseRoseButton.UseVisualStyleBackColor = true;
            this.chooseRoseButton.Click += new System.EventHandler(this.chooseRoseButton_Click);
            // 
            // chooseYourPlantLabel
            // 
            this.chooseYourPlantLabel.AutoSize = true;
            this.chooseYourPlantLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseYourPlantLabel.Location = new System.Drawing.Point(183, 129);
            this.chooseYourPlantLabel.Name = "chooseYourPlantLabel";
            this.chooseYourPlantLabel.Size = new System.Drawing.Size(288, 45);
            this.chooseYourPlantLabel.TabIndex = 1;
            this.chooseYourPlantLabel.Text = "Choose your Plant!";
            // 
            // supremePictureBox
            // 
            this.supremePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supremePictureBox.Image = global::Pot_Plant_the_Game.Properties.Resources.RoseA31;
            this.supremePictureBox.Location = new System.Drawing.Point(251, 75);
            this.supremePictureBox.MaximumSize = new System.Drawing.Size(147, 530);
            this.supremePictureBox.MinimumSize = new System.Drawing.Size(147, 530);
            this.supremePictureBox.Name = "supremePictureBox";
            this.supremePictureBox.Size = new System.Drawing.Size(147, 530);
            this.supremePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.supremePictureBox.TabIndex = 0;
            this.supremePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1677, 769);
            this.Controls.Add(this.plantBox);
            this.Controls.Add(this.interfaceBox);
            this.MinimumSize = new System.Drawing.Size(1703, 840);
            this.Name = "Form1";
            this.Text = "Pot Plant the Game by Eric Malmström";
            this.interfaceBox.ResumeLayout(false);
            this.interfaceBox.PerformLayout();
            this.plantBox.ResumeLayout(false);
            this.plantBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supremePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox interfaceBox;
        private GroupBox plantBox;
        private Label label1;
        private Button resetButton;
        private TextBox daysSurvivedBox;
        private TextBox daysSinceWaterBox;
        private TextBox aliveBox;
        private Label label3;
        private Label label2;
        private Button waterButton;
        private Button changePotsButton;
        private RadioButton changePotButton;
        private Button nextDayButton;
        private PictureBox supremePictureBox;
        private Button chooseDaliaButton;
        private Button chooseRoseButton;
        private Label chooseYourPlantLabel;
    }
}