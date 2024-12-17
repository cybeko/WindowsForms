namespace MillionaireGame
{
    partial class FormGame
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
            textBoxQuestion = new TextBox();
            buttonAnswerA = new Button();
            buttonAnswerB = new Button();
            buttonAnswerD = new Button();
            buttonAnswerC = new Button();
            listBoxPoints = new ListBox();
            menuStrip1 = new MenuStrip();
            startGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            textBoxCurrentSum = new TextBox();
            textBoxSafeAmount = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.BackColor = SystemColors.ActiveCaptionText;
            textBoxQuestion.Font = new Font("Segoe UI", 15F);
            textBoxQuestion.ForeColor = Color.Yellow;
            textBoxQuestion.Location = new Point(114, 265);
            textBoxQuestion.Margin = new Padding(4, 3, 4, 3);
            textBoxQuestion.Multiline = true;
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.ReadOnly = true;
            textBoxQuestion.Size = new Size(372, 79);
            textBoxQuestion.TabIndex = 0;
            textBoxQuestion.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAnswerA
            // 
            buttonAnswerA.BackColor = SystemColors.ActiveCaptionText;
            buttonAnswerA.ForeColor = Color.Yellow;
            buttonAnswerA.Location = new Point(114, 364);
            buttonAnswerA.Margin = new Padding(4, 3, 4, 3);
            buttonAnswerA.Name = "buttonAnswerA";
            buttonAnswerA.Size = new Size(180, 34);
            buttonAnswerA.TabIndex = 1;
            buttonAnswerA.Text = " ";
            buttonAnswerA.UseVisualStyleBackColor = false;
            buttonAnswerA.Click += buttonAnswer_Click;
            // 
            // buttonAnswerB
            // 
            buttonAnswerB.BackColor = SystemColors.ActiveCaptionText;
            buttonAnswerB.ForeColor = Color.Yellow;
            buttonAnswerB.Location = new Point(306, 364);
            buttonAnswerB.Margin = new Padding(4, 3, 4, 3);
            buttonAnswerB.Name = "buttonAnswerB";
            buttonAnswerB.Size = new Size(180, 34);
            buttonAnswerB.TabIndex = 2;
            buttonAnswerB.UseVisualStyleBackColor = false;
            // 
            // buttonAnswerD
            // 
            buttonAnswerD.BackColor = SystemColors.ActiveCaptionText;
            buttonAnswerD.ForeColor = Color.Yellow;
            buttonAnswerD.Location = new Point(306, 414);
            buttonAnswerD.Margin = new Padding(4, 3, 4, 3);
            buttonAnswerD.Name = "buttonAnswerD";
            buttonAnswerD.Size = new Size(180, 34);
            buttonAnswerD.TabIndex = 3;
            buttonAnswerD.UseVisualStyleBackColor = false;
            // 
            // buttonAnswerC
            // 
            buttonAnswerC.BackColor = SystemColors.ActiveCaptionText;
            buttonAnswerC.ForeColor = Color.Yellow;
            buttonAnswerC.Location = new Point(114, 414);
            buttonAnswerC.Margin = new Padding(4, 3, 4, 3);
            buttonAnswerC.Name = "buttonAnswerC";
            buttonAnswerC.Size = new Size(180, 34);
            buttonAnswerC.TabIndex = 4;
            buttonAnswerC.UseVisualStyleBackColor = false;
            // 
            // listBoxPoints
            // 
            listBoxPoints.BackColor = Color.Black;
            listBoxPoints.Font = new Font("Segoe UI", 13F);
            listBoxPoints.ForeColor = Color.Yellow;
            listBoxPoints.FormattingEnabled = true;
            listBoxPoints.ItemHeight = 23;
            listBoxPoints.Location = new Point(554, 30);
            listBoxPoints.Margin = new Padding(4, 3, 4, 3);
            listBoxPoints.Name = "listBoxPoints";
            listBoxPoints.RightToLeft = RightToLeft.Yes;
            listBoxPoints.Size = new Size(128, 418);
            listBoxPoints.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { startGameToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(695, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // startGameToolStripMenuItem
            // 
            startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
            startGameToolStripMenuItem.Size = new Size(77, 20);
            startGameToolStripMenuItem.Text = "Start Game";
            startGameToolStripMenuItem.Click += startGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // textBoxCurrentSum
            // 
            textBoxCurrentSum.BackColor = SystemColors.InactiveCaptionText;
            textBoxCurrentSum.ForeColor = Color.Yellow;
            textBoxCurrentSum.HideSelection = false;
            textBoxCurrentSum.Location = new Point(203, 27);
            textBoxCurrentSum.Name = "textBoxCurrentSum";
            textBoxCurrentSum.Size = new Size(100, 23);
            textBoxCurrentSum.TabIndex = 7;
            // 
            // textBoxSafeAmount
            // 
            textBoxSafeAmount.BackColor = SystemColors.InactiveCaptionText;
            textBoxSafeAmount.ForeColor = Color.DarkOrange;
            textBoxSafeAmount.Location = new Point(309, 27);
            textBoxSafeAmount.Name = "textBoxSafeAmount";
            textBoxSafeAmount.Size = new Size(100, 23);
            textBoxSafeAmount.TabIndex = 8;
            // 
            // FormGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = hw8.Properties.Resources.mil;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(695, 465);
            Controls.Add(textBoxSafeAmount);
            Controls.Add(textBoxCurrentSum);
            Controls.Add(listBoxPoints);
            Controls.Add(buttonAnswerC);
            Controls.Add(buttonAnswerD);
            Controls.Add(buttonAnswerB);
            Controls.Add(buttonAnswerA);
            Controls.Add(textBoxQuestion);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGame";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxQuestion;
        private Button buttonAnswerA;
        private Button buttonAnswerB;
        private Button buttonAnswerD;
        private Button buttonAnswerC;
        private ListBox listBoxPoints;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TextBox textBoxCurrentSum;
        private TextBox textBoxSafeAmount;
    }
}
