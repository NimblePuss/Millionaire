namespace WForms2___Millionaire_
{
    partial class EditForm
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
            this.numericUpDownEditQues = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEditQuestion = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswer1 = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswer3 = new System.Windows.Forms.TextBox();
            this.textBoxEditAnswer4 = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditQues)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownEditQues
            // 
            this.numericUpDownEditQues.Location = new System.Drawing.Point(107, 15);
            this.numericUpDownEditQues.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownEditQues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEditQues.Name = "numericUpDownEditQues";
            this.numericUpDownEditQues.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownEditQues.TabIndex = 0;
            this.numericUpDownEditQues.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEditQues.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер вопроса:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите вопрос:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите второй вариант ответа:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите первый вариант ответа (правильный):";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Введите третий вариант ответа:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Введите четвертый вариант ответа:";
            // 
            // textBoxEditQuestion
            // 
            this.textBoxEditQuestion.Location = new System.Drawing.Point(12, 67);
            this.textBoxEditQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditQuestion.Name = "textBoxEditQuestion";
            this.textBoxEditQuestion.Size = new System.Drawing.Size(368, 20);
            this.textBoxEditQuestion.TabIndex = 7;
            this.textBoxEditQuestion.TextChanged += new System.EventHandler(this.textBoxEditQuestion_TextChanged);
            // 
            // textBoxEditAnswer1
            // 
            this.textBoxEditAnswer1.Location = new System.Drawing.Point(12, 114);
            this.textBoxEditAnswer1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditAnswer1.Name = "textBoxEditAnswer1";
            this.textBoxEditAnswer1.Size = new System.Drawing.Size(368, 20);
            this.textBoxEditAnswer1.TabIndex = 8;
            this.textBoxEditAnswer1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxEditAnswer2
            // 
            this.textBoxEditAnswer2.Location = new System.Drawing.Point(10, 162);
            this.textBoxEditAnswer2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditAnswer2.Name = "textBoxEditAnswer2";
            this.textBoxEditAnswer2.Size = new System.Drawing.Size(368, 20);
            this.textBoxEditAnswer2.TabIndex = 9;
            // 
            // textBoxEditAnswer3
            // 
            this.textBoxEditAnswer3.Location = new System.Drawing.Point(12, 210);
            this.textBoxEditAnswer3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditAnswer3.Name = "textBoxEditAnswer3";
            this.textBoxEditAnswer3.Size = new System.Drawing.Size(368, 20);
            this.textBoxEditAnswer3.TabIndex = 10;
            // 
            // textBoxEditAnswer4
            // 
            this.textBoxEditAnswer4.Location = new System.Drawing.Point(10, 256);
            this.textBoxEditAnswer4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEditAnswer4.Name = "textBoxEditAnswer4";
            this.textBoxEditAnswer4.Size = new System.Drawing.Size(368, 20);
            this.textBoxEditAnswer4.TabIndex = 11;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(58, 294);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(106, 30);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "Изменить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(201, 294);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(106, 30);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 341);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxEditAnswer4);
            this.Controls.Add(this.textBoxEditAnswer3);
            this.Controls.Add(this.textBoxEditAnswer2);
            this.Controls.Add(this.textBoxEditAnswer1);
            this.Controls.Add(this.textBoxEditQuestion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownEditQues);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditForm";
            this.Text = "Редактирование вопроса";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEditQues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownEditQues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEditQuestion;
        private System.Windows.Forms.TextBox textBoxEditAnswer1;
        private System.Windows.Forms.TextBox textBoxEditAnswer2;
        private System.Windows.Forms.TextBox textBoxEditAnswer3;
        private System.Windows.Forms.TextBox textBoxEditAnswer4;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}