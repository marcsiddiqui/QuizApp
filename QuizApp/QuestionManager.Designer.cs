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
            this.Marks = new System.Windows.Forms.TextBox();
            this.ClearAll_Fields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.Location = new System.Drawing.Point(13, 13);
            this.Question.Margin = new System.Windows.Forms.Padding(4);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(766, 41);
            this.Question.TabIndex = 0;
            // 
            // OptionA
            // 
            this.OptionA.Location = new System.Drawing.Point(54, 61);
            this.OptionA.Name = "OptionA";
            this.OptionA.Size = new System.Drawing.Size(387, 27);
            this.OptionA.TabIndex = 1;
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(12, 63);
            this.A.Name = "A";
            this.A.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.A.Size = new System.Drawing.Size(39, 23);
            this.A.TabIndex = 5;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.CheckedChanged += new System.EventHandler(this.A_CheckedChanged);
            // 
            // OptionB
            // 
            this.OptionB.Location = new System.Drawing.Point(54, 94);
            this.OptionB.Name = "OptionB";
            this.OptionB.Size = new System.Drawing.Size(387, 27);
            this.OptionB.TabIndex = 2;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(14, 96);
            this.B.Name = "B";
            this.B.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.B.Size = new System.Drawing.Size(37, 23);
            this.B.TabIndex = 6;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.CheckedChanged += new System.EventHandler(this.B_CheckedChanged);
            // 
            // OptionC
            // 
            this.OptionC.Location = new System.Drawing.Point(54, 127);
            this.OptionC.Name = "OptionC";
            this.OptionC.Size = new System.Drawing.Size(387, 27);
            this.OptionC.TabIndex = 3;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(13, 129);
            this.C.Name = "C";
            this.C.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.C.Size = new System.Drawing.Size(38, 23);
            this.C.TabIndex = 7;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.CheckedChanged += new System.EventHandler(this.C_CheckedChanged);
            // 
            // OptionD
            // 
            this.OptionD.Location = new System.Drawing.Point(54, 160);
            this.OptionD.Name = "OptionD";
            this.OptionD.Size = new System.Drawing.Size(387, 27);
            this.OptionD.TabIndex = 4;
            // 
            // D
            // 
            this.D.AutoSize = true;
            this.D.Location = new System.Drawing.Point(12, 162);
            this.D.Name = "D";
            this.D.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.D.Size = new System.Drawing.Size(39, 23);
            this.D.TabIndex = 8;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.CheckedChanged += new System.EventHandler(this.D_CheckedChanged);
            // 
            // SaveQuestion
            // 
            this.SaveQuestion.FlatAppearance.BorderSize = 2;
            this.SaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveQuestion.Image = global::QuizApp.Properties.Resources.icons8_save_button_35;
            this.SaveQuestion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveQuestion.Location = new System.Drawing.Point(12, 193);
            this.SaveQuestion.Name = "SaveQuestion";
            this.SaveQuestion.Size = new System.Drawing.Size(429, 41);
            this.SaveQuestion.TabIndex = 9;
            this.SaveQuestion.Text = "Save Question";
            this.SaveQuestion.UseVisualStyleBackColor = true;
            this.SaveQuestion.Click += new System.EventHandler(this.SaveQuestion_Click);
            // 
            // Marks
            // 
            this.Marks.Location = new System.Drawing.Point(787, 13);
            this.Marks.Multiline = true;
            this.Marks.Name = "Marks";
            this.Marks.Size = new System.Drawing.Size(47, 41);
            this.Marks.TabIndex = 10;
            this.Marks.Text = "0.5";
            this.Marks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClearAll_Fields
            // 
            this.ClearAll_Fields.Location = new System.Drawing.Point(744, 63);
            this.ClearAll_Fields.Name = "ClearAll_Fields";
            this.ClearAll_Fields.Size = new System.Drawing.Size(90, 35);
            this.ClearAll_Fields.TabIndex = 11;
            this.ClearAll_Fields.Text = "ClearAll";
            this.ClearAll_Fields.UseVisualStyleBackColor = true;
            this.ClearAll_Fields.Click += new System.EventHandler(this.ClearAll_Fields_Click);
            // 
            // QuestionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 444);
            this.Controls.Add(this.ClearAll_Fields);
            this.Controls.Add(this.Marks);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox Marks;
        private System.Windows.Forms.Button ClearAll_Fields;
    }
}