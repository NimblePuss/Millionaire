namespace WForms2___Millionaire_
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer3 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer4 = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вопрос:";
            this.label1.Click += new System.EventHandler(this.AddQueslabel1_Click);
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(12, 37);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(416, 20);
            this.textBoxQuestion.TabIndex = 1;
            this.textBoxQuestion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите первый вариант ответа (правильный):";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите второй вариант ответа:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите третий вариант ответа:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Введите четвертый вариант ответа:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.Location = new System.Drawing.Point(13, 96);
            this.textBoxAnswer1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(416, 20);
            this.textBoxAnswer1.TabIndex = 6;
            this.textBoxAnswer1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.Location = new System.Drawing.Point(12, 155);
            this.textBoxAnswer2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(416, 20);
            this.textBoxAnswer2.TabIndex = 7;
            this.textBoxAnswer2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxAnswer3
            // 
            this.textBoxAnswer3.Location = new System.Drawing.Point(12, 210);
            this.textBoxAnswer3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAnswer3.Name = "textBoxAnswer3";
            this.textBoxAnswer3.Size = new System.Drawing.Size(416, 20);
            this.textBoxAnswer3.TabIndex = 8;
            this.textBoxAnswer3.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxAnswer4
            // 
            this.textBoxAnswer4.Location = new System.Drawing.Point(12, 258);
            this.textBoxAnswer4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAnswer4.Name = "textBoxAnswer4";
            this.textBoxAnswer4.Size = new System.Drawing.Size(416, 20);
            this.textBoxAnswer4.TabIndex = 9;
            this.textBoxAnswer4.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(64, 292);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(134, 38);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(230, 292);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 38);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.Addbutton2_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 346);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxAnswer4);
            this.Controls.Add(this.textBoxAnswer3);
            this.Controls.Add(this.textBoxAnswer2);
            this.Controls.Add(this.textBoxAnswer1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Добавление вопроса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer3;
        private System.Windows.Forms.TextBox textBoxAnswer4;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}