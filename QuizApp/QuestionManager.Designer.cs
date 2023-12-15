namespace QuizApp
{
    partial class QuestionManager
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
            this.Question = new System.Windows.Forms.TextBox();
            this.OptionA = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.CheckBox();
            this.OptionB = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.CheckBox();
            this.OptionC = new System.Windows.Forms.TextBox();
            this.C = new System.Windows.Forms.CheckBox();
            this.OptionD = new System.Windows.Forms.TextBox();
            this.D = new System.Windows.Forms.CheckBox();
            this.SaveQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(13, 13);
            this.Question.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(820, 41);
            this.Question.TabIndex = 0;
            // 
            // OptionA
            // 
            this.OptionA.Location = new System.Drawing.Point(38, 61);
            this.OptionA.Name = "OptionA";
            this.OptionA.Size = new System.Drawing.Size(387, 27);
            this.OptionA.TabIndex = 1;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(15, 67);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(15, 14);
            this.A.TabIndex = 2;
            this.A.UseVisualStyleBackColor = true;
            // 
            // OptionB
            // 
            this.OptionB.Location = new System.Drawing.Point(38, 94);
            this.OptionB.Name = "OptionB";
            this.OptionB.Size = new System.Drawing.Size(387, 27);
            this.OptionB.TabIndex = 1;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(15, 100);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(15, 14);
            this.B.TabIndex = 2;
            this.B.UseVisualStyleBackColor = true;
            // 
            // OptionC
            // 
            this.OptionC.Location = new System.Drawing.Point(38, 127);
            this.OptionC.Name = "OptionC";
            this.OptionC.Size = new System.Drawing.Size(387, 27);
            this.OptionC.TabIndex = 1;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(15, 133);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(15, 14);
            this.C.TabIndex = 2;
            this.C.UseVisualStyleBackColor = true;
            // 
            // OptionD
            // 
            this.OptionD.Location = new System.Drawing.Point(38, 160);
            this.OptionD.Name = "OptionD";
            this.OptionD.Size = new System.Drawing.Size(387, 27);
            this.OptionD.TabIndex = 1;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(15, 166);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(15, 14);
            this.D.TabIndex = 2;
            this.D.UseVisualStyleBackColor = true;
            // 
            // SaveQuestion
            // 
            this.SaveQuestion.FlatAppearance.BorderSize = 2;
            this.SaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveQuestion.Image = global::QuizApp.Properties.Resources.icons8_save_button_35;
            this.SaveQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveQuestion.Location = new System.Drawing.Point(15, 193);
            this.SaveQuestion.Name = "SaveQuestion";
            this.SaveQuestion.Size = new System.Drawing.Size(410, 41);
            this.SaveQuestion.TabIndex = 3;
            this.SaveQuestion.Text = "Save Question";
            this.SaveQuestion.UseVisualStyleBackColor = true;
            this.SaveQuestion.Click += new System.EventHandler(this.SaveQuestion_Click);
            // 
            // QuestionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 444);
            this.Controls.Add(this.SaveQuestion);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.OptionD);
            this.Controls.Add(this.OptionC);
            this.Controls.Add(this.OptionB);
            this.Controls.Add(this.OptionA);
            this.Controls.Add(this.Question);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuestionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.TextBox OptionA;
        private System.Windows.Forms.CheckBox A;
        private System.Windows.Forms.TextBox OptionB;
        private System.Windows.Forms.CheckBox B;
        private System.Windows.Forms.TextBox OptionC;
        private System.Windows.Forms.CheckBox C;
        private System.Windows.Forms.TextBox OptionD;
        private System.Windows.Forms.CheckBox D;
        private System.Windows.Forms.Button SaveQuestion;
    }
}