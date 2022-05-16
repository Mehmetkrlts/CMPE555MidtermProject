namespace MidtermProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.answerA = new System.Windows.Forms.RadioButton();
            this.answerB = new System.Windows.Forms.RadioButton();
            this.answerC = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Button();
            this.answerD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // answerA
            // 
            this.answerA.AutoSize = true;
            this.answerA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerA.Location = new System.Drawing.Point(324, 288);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(40, 24);
            this.answerA.TabIndex = 0;
            this.answerA.TabStop = true;
            this.answerA.Text = "A";
            this.answerA.UseVisualStyleBackColor = true;
            this.answerA.CheckedChanged += new System.EventHandler(this.answerA_CheckedChanged);
            // 
            // answerB
            // 
            this.answerB.AutoSize = true;
            this.answerB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerB.Location = new System.Drawing.Point(562, 288);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(39, 24);
            this.answerB.TabIndex = 1;
            this.answerB.TabStop = true;
            this.answerB.Text = "B";
            this.answerB.UseVisualStyleBackColor = true;
            this.answerB.CheckedChanged += new System.EventHandler(this.answerB_CheckedChanged);
            // 
            // answerC
            // 
            this.answerC.AutoSize = true;
            this.answerC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerC.Location = new System.Drawing.Point(319, 363);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(39, 24);
            this.answerC.TabIndex = 3;
            this.answerC.TabStop = true;
            this.answerC.Text = "C";
            this.answerC.UseVisualStyleBackColor = true;
            this.answerC.CheckedChanged += new System.EventHandler(this.answerC_CheckedChanged);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(264, 203);
            this.questionLabel.MaximumSize = new System.Drawing.Size(450, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(444, 56);
            this.questionLabel.TabIndex = 4;
            this.questionLabel.Text = "1-Which Disney character famously leaves a glass slipper behind at a royal ball?";
            this.questionLabel.Click += new System.EventHandler(this.questionLabel_Click);
            // 
            // Answer
            // 
            this.Answer.Location = new System.Drawing.Point(412, 418);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(102, 31);
            this.Answer.TabIndex = 5;
            this.Answer.Text = "Answer It!";
            this.Answer.UseVisualStyleBackColor = true;
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // answerD
            // 
            this.answerD.AutoSize = true;
            this.answerD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerD.Location = new System.Drawing.Point(560, 363);
            this.answerD.MaximumSize = new System.Drawing.Size(120, 0);
            this.answerD.Name = "answerD";
            this.answerD.Size = new System.Drawing.Size(120, 24);
            this.answerD.TabIndex = 6;
            this.answerD.TabStop = true;
            this.answerD.Text = "TESTQWEWQEQWWQEWEQ";
            this.answerD.UseVisualStyleBackColor = true;
            this.answerD.CheckedChanged += new System.EventHandler(this.answerD_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.answerD);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.answerC);
            this.Controls.Add(this.answerB);
            this.Controls.Add(this.answerA);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton answerA;
        private RadioButton answerB;
        private RadioButton answerC;
        private Label questionLabel;
        private Button Answer;
        private RadioButton answerD;
    }
}