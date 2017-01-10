namespace WForms2___Millionaire_
{
    partial class DelForm
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
            this.numericUpDownDelQues = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDelQuestion = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelQues)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownDelQues
            // 
            this.numericUpDownDelQues.Location = new System.Drawing.Point(108, 16);
            this.numericUpDownDelQues.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownDelQues.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelQues.Name = "numericUpDownDelQues";
            this.numericUpDownDelQues.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownDelQues.TabIndex = 0;
            this.numericUpDownDelQues.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelQues.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер вопроса:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вопрос для удаления:";
            // 
            // textBoxDelQuestion
            // 
            this.textBoxDelQuestion.Location = new System.Drawing.Point(11, 84);
            this.textBoxDelQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDelQuestion.Name = "textBoxDelQuestion";
            this.textBoxDelQuestion.ReadOnly = true;
            this.textBoxDelQuestion.Size = new System.Drawing.Size(366, 20);
            this.textBoxDelQuestion.TabIndex = 3;
            this.textBoxDelQuestion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(90, 122);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(82, 31);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Удалить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(213, 122);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 31);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 170);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxDelQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDelQues);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DelForm";
            this.Text = "Удаление вопроса";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelQues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownDelQues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDelQuestion;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}