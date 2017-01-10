namespace WForms2___Millionaire_
{
    partial class PlayForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администраторскийРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВопросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеВопросаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1WinSum = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHelpPeople = new System.Windows.Forms.Button();
            this.buttonCallFriend = new System.Windows.Forms.Button();
            this.button50to50 = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonAnswer1 = new System.Windows.Forms.Button();
            this.buttonAnswer2 = new System.Windows.Forms.Button();
            this.buttonAnswer3 = new System.Windows.Forms.Button();
            this.buttonAnswer4 = new System.Windows.Forms.Button();
            this.labelAnswerPresenter = new System.Windows.Forms.Label();
            this.pictureBoxPresenter = new System.Windows.Forms.PictureBox();
            this.labelAnswerFriend = new System.Windows.Forms.Label();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.progressBarD = new System.Windows.Forms.ProgressBar();
            this.groupBoxHelpPeople = new System.Windows.Forms.GroupBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.правилаИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.groupBoxHelpPeople.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.администраторскийРежимToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьИгруToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // начатьИгруToolStripMenuItem
            // 
            this.начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            this.начатьИгруToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.начатьИгруToolStripMenuItem.Text = "Начать игру";
            this.начатьИгруToolStripMenuItem.Click += new System.EventHandler(this.начатьИгруToolStripMenuItem_Click_1);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // администраторскийРежимToolStripMenuItem
            // 
            this.администраторскийРежимToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВопросToolStripMenuItem,
            this.удалитьВопросToolStripMenuItem,
            this.редактированиеВопросаToolStripMenuItem});
            this.администраторскийРежимToolStripMenuItem.Name = "администраторскийРежимToolStripMenuItem";
            this.администраторскийРежимToolStripMenuItem.Size = new System.Drawing.Size(173, 20);
            this.администраторскийРежимToolStripMenuItem.Text = "Администраторский режим";
            this.администраторскийРежимToolStripMenuItem.Click += new System.EventHandler(this.администраторскийРежимToolStripMenuItem_Click);
            // 
            // добавитьВопросToolStripMenuItem
            // 
            this.добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            this.добавитьВопросToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            this.добавитьВопросToolStripMenuItem.Click += new System.EventHandler(this.добавитьВопросToolStripMenuItem_Click);
            // 
            // удалитьВопросToolStripMenuItem
            // 
            this.удалитьВопросToolStripMenuItem.Name = "удалитьВопросToolStripMenuItem";
            this.удалитьВопросToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.удалитьВопросToolStripMenuItem.Text = "Удалить вопрос";
            this.удалитьВопросToolStripMenuItem.Click += new System.EventHandler(this.удалитьВопросToolStripMenuItem_Click);
            // 
            // редактированиеВопросаToolStripMenuItem
            // 
            this.редактированиеВопросаToolStripMenuItem.Name = "редактированиеВопросаToolStripMenuItem";
            this.редактированиеВопросаToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.редактированиеВопросаToolStripMenuItem.Text = "Редактирование вопроса";
            this.редактированиеВопросаToolStripMenuItem.Click += new System.EventHandler(this.редактированиеВопросаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правилаИгрыToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // listBox1WinSum
            // 
            this.listBox1WinSum.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox1WinSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1WinSum.ForeColor = System.Drawing.Color.Yellow;
            this.listBox1WinSum.FormattingEnabled = true;
            this.listBox1WinSum.ItemHeight = 37;
            this.listBox1WinSum.Items.AddRange(new object[] {
            "15 - 1 000 000",
            "14 - 500 000",
            "13 - 250 000",
            "12 - 125 000",
            "11 - 64 000",
            "10 - 32 000",
            "9 - 16 000",
            "8 - 8 000",
            "7 - 4 000",
            "6 - 2 000",
            "5 - 1 000",
            "4 - 500",
            "3 - 300",
            "2 - 200",
            "1 - 100"});
            this.listBox1WinSum.Location = new System.Drawing.Point(919, 99);
            this.listBox1WinSum.Name = "listBox1WinSum";
            this.listBox1WinSum.Size = new System.Drawing.Size(269, 670);
            this.listBox1WinSum.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.buttonHelpPeople);
            this.groupBox1.Controls.Add(this.buttonCallFriend);
            this.groupBox1.Controls.Add(this.button50to50);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(919, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 78);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подсказки";
            // 
            // buttonHelpPeople
            // 
            this.buttonHelpPeople.BackgroundImage = global::WForms2___Millionaire_.Properties.Resources._3;
            this.buttonHelpPeople.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonHelpPeople.Location = new System.Drawing.Point(166, 19);
            this.buttonHelpPeople.Name = "buttonHelpPeople";
            this.buttonHelpPeople.Size = new System.Drawing.Size(62, 41);
            this.buttonHelpPeople.TabIndex = 2;
            this.buttonHelpPeople.UseVisualStyleBackColor = true;
            this.buttonHelpPeople.Click += new System.EventHandler(this.buttonHelpPeople_Click);
            // 
            // buttonCallFriend
            // 
            this.buttonCallFriend.BackgroundImage = global::WForms2___Millionaire_.Properties.Resources._2;
            this.buttonCallFriend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCallFriend.Location = new System.Drawing.Point(98, 19);
            this.buttonCallFriend.Name = "buttonCallFriend";
            this.buttonCallFriend.Size = new System.Drawing.Size(62, 41);
            this.buttonCallFriend.TabIndex = 1;
            this.buttonCallFriend.UseVisualStyleBackColor = true;
            this.buttonCallFriend.Click += new System.EventHandler(this.buttonCallFriend_Click);
            // 
            // button50to50
            // 
            this.button50to50.BackgroundImage = global::WForms2___Millionaire_.Properties.Resources._1;
            this.button50to50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button50to50.Location = new System.Drawing.Point(30, 19);
            this.button50to50.Name = "button50to50";
            this.button50to50.Size = new System.Drawing.Size(62, 41);
            this.button50to50.TabIndex = 0;
            this.button50to50.UseVisualStyleBackColor = true;
            this.button50to50.Click += new System.EventHandler(this.button50to50_Click_1);
            // 
            // buttonStart
            // 
            this.buttonStart.Image = global::WForms2___Millionaire_.Properties.Resources._new;
            this.buttonStart.Location = new System.Drawing.Point(3, 27);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(62, 41);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::WForms2___Millionaire_.Properties.Resources.Exit;
            this.buttonExit.Location = new System.Drawing.Point(68, 27);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(62, 41);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.ForeColor = System.Drawing.Color.Yellow;
            this.buttonStop.Location = new System.Drawing.Point(136, 27);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 41);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelQuestion
            // 
            this.labelQuestion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.ForeColor = System.Drawing.Color.Yellow;
            this.labelQuestion.Location = new System.Drawing.Point(12, 459);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(895, 88);
            this.labelQuestion.TabIndex = 6;
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestion.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAnswer1
            // 
            this.buttonAnswer1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswer1.ForeColor = System.Drawing.Color.Yellow;
            this.buttonAnswer1.Location = new System.Drawing.Point(12, 582);
            this.buttonAnswer1.Name = "buttonAnswer1";
            this.buttonAnswer1.Size = new System.Drawing.Size(437, 56);
            this.buttonAnswer1.TabIndex = 7;
            this.buttonAnswer1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswer1.UseVisualStyleBackColor = false;
            this.buttonAnswer1.Click += new System.EventHandler(this.button7_ClickAswer1);
            // 
            // buttonAnswer2
            // 
            this.buttonAnswer2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswer2.ForeColor = System.Drawing.Color.Yellow;
            this.buttonAnswer2.Location = new System.Drawing.Point(470, 581);
            this.buttonAnswer2.Name = "buttonAnswer2";
            this.buttonAnswer2.Size = new System.Drawing.Size(437, 56);
            this.buttonAnswer2.TabIndex = 8;
            this.buttonAnswer2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswer2.UseVisualStyleBackColor = false;
            this.buttonAnswer2.Click += new System.EventHandler(this.button7_ClickAswer1);
            // 
            // buttonAnswer3
            // 
            this.buttonAnswer3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswer3.ForeColor = System.Drawing.Color.Yellow;
            this.buttonAnswer3.Location = new System.Drawing.Point(12, 659);
            this.buttonAnswer3.Name = "buttonAnswer3";
            this.buttonAnswer3.Size = new System.Drawing.Size(437, 56);
            this.buttonAnswer3.TabIndex = 9;
            this.buttonAnswer3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswer3.UseVisualStyleBackColor = false;
            this.buttonAnswer3.Click += new System.EventHandler(this.button7_ClickAswer1);
            // 
            // buttonAnswer4
            // 
            this.buttonAnswer4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswer4.ForeColor = System.Drawing.Color.Yellow;
            this.buttonAnswer4.Location = new System.Drawing.Point(470, 659);
            this.buttonAnswer4.Name = "buttonAnswer4";
            this.buttonAnswer4.Size = new System.Drawing.Size(437, 56);
            this.buttonAnswer4.TabIndex = 10;
            this.buttonAnswer4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnswer4.UseVisualStyleBackColor = false;
            this.buttonAnswer4.Click += new System.EventHandler(this.button7_ClickAswer1);
            // 
            // labelAnswerPresenter
            // 
            this.labelAnswerPresenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelAnswerPresenter.ForeColor = System.Drawing.Color.Yellow;
            this.labelAnswerPresenter.Location = new System.Drawing.Point(591, 329);
            this.labelAnswerPresenter.Name = "labelAnswerPresenter";
            this.labelAnswerPresenter.Size = new System.Drawing.Size(163, 45);
            this.labelAnswerPresenter.TabIndex = 11;
            this.labelAnswerPresenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAnswerPresenter.Visible = false;
            this.labelAnswerPresenter.Click += new System.EventHandler(this.labelAnswerPresenter_Click);
            // 
            // pictureBoxPresenter
            // 
            this.pictureBoxPresenter.Image = global::WForms2___Millionaire_.Properties.Resources.Безымянный;
            this.pictureBoxPresenter.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPresenter.InitialImage")));
            this.pictureBoxPresenter.Location = new System.Drawing.Point(755, 274);
            this.pictureBoxPresenter.Name = "pictureBoxPresenter";
            this.pictureBoxPresenter.Size = new System.Drawing.Size(79, 100);
            this.pictureBoxPresenter.TabIndex = 12;
            this.pictureBoxPresenter.TabStop = false;
            this.pictureBoxPresenter.Visible = false;
            this.pictureBoxPresenter.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelAnswerFriend
            // 
            this.labelAnswerFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelAnswerFriend.ForeColor = System.Drawing.Color.Yellow;
            this.labelAnswerFriend.Location = new System.Drawing.Point(169, 147);
            this.labelAnswerFriend.Name = "labelAnswerFriend";
            this.labelAnswerFriend.Size = new System.Drawing.Size(280, 49);
            this.labelAnswerFriend.TabIndex = 13;
            this.labelAnswerFriend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAnswerFriend.Visible = false;
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Image = global::WForms2___Millionaire_.Properties.Resources.zvonok;
            this.pictureBoxFriend.Location = new System.Drawing.Point(33, 147);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(139, 109);
            this.pictureBoxFriend.TabIndex = 14;
            this.pictureBoxFriend.TabStop = false;
            this.pictureBoxFriend.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBarA
            // 
            this.progressBarA.ForeColor = System.Drawing.Color.Red;
            this.progressBarA.Location = new System.Drawing.Point(70, 24);
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(79, 20);
            this.progressBarA.TabIndex = 15;
            // 
            // progressBarB
            // 
            this.progressBarB.ForeColor = System.Drawing.Color.Red;
            this.progressBarB.Location = new System.Drawing.Point(70, 56);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(79, 20);
            this.progressBarB.TabIndex = 16;
            // 
            // progressBarC
            // 
            this.progressBarC.ForeColor = System.Drawing.Color.Red;
            this.progressBarC.Location = new System.Drawing.Point(70, 88);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(79, 20);
            this.progressBarC.TabIndex = 17;
            // 
            // progressBarD
            // 
            this.progressBarD.ForeColor = System.Drawing.Color.Red;
            this.progressBarD.Location = new System.Drawing.Point(70, 120);
            this.progressBarD.Name = "progressBarD";
            this.progressBarD.Size = new System.Drawing.Size(79, 20);
            this.progressBarD.TabIndex = 18;
            // 
            // groupBoxHelpPeople
            // 
            this.groupBoxHelpPeople.BackColor = System.Drawing.Color.Blue;
            this.groupBoxHelpPeople.Controls.Add(this.labelD);
            this.groupBoxHelpPeople.Controls.Add(this.labelC);
            this.groupBoxHelpPeople.Controls.Add(this.labelB);
            this.groupBoxHelpPeople.Controls.Add(this.labelA);
            this.groupBoxHelpPeople.Controls.Add(this.progressBarA);
            this.groupBoxHelpPeople.Controls.Add(this.progressBarD);
            this.groupBoxHelpPeople.Controls.Add(this.progressBarB);
            this.groupBoxHelpPeople.Controls.Add(this.progressBarC);
            this.groupBoxHelpPeople.ForeColor = System.Drawing.Color.White;
            this.groupBoxHelpPeople.Location = new System.Drawing.Point(721, 61);
            this.groupBoxHelpPeople.Name = "groupBoxHelpPeople";
            this.groupBoxHelpPeople.Size = new System.Drawing.Size(160, 153);
            this.groupBoxHelpPeople.TabIndex = 19;
            this.groupBoxHelpPeople.TabStop = false;
            this.groupBoxHelpPeople.Text = "Помощь зала";
            this.groupBoxHelpPeople.Visible = false;
            // 
            // labelD
            // 
            this.labelD.Location = new System.Drawing.Point(8, 123);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(57, 17);
            this.labelD.TabIndex = 22;
            this.labelD.Text = "D:   ";
            // 
            // labelC
            // 
            this.labelC.Location = new System.Drawing.Point(8, 91);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(57, 17);
            this.labelC.TabIndex = 21;
            this.labelC.Text = "C:   ";
            // 
            // labelB
            // 
            this.labelB.Location = new System.Drawing.Point(7, 59);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(57, 17);
            this.labelB.TabIndex = 20;
            this.labelB.Text = "B:   ";
            // 
            // labelA
            // 
            this.labelA.Location = new System.Drawing.Point(7, 27);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(57, 17);
            this.labelA.TabIndex = 19;
            this.labelA.Text = "A:   ";
            // 
            // labelGameOver
            // 
            this.labelGameOver.BackColor = System.Drawing.Color.Yellow;
            this.labelGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Red;
            this.labelGameOver.Location = new System.Drawing.Point(15, 377);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(892, 72);
            this.labelGameOver.TabIndex = 20;
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameOver.Visible = false;
            // 
            // правилаИгрыToolStripMenuItem
            // 
            this.правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            this.правилаИгрыToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.правилаИгрыToolStripMenuItem.Text = "Правила игры";
            this.правилаИгрыToolStripMenuItem.Click += new System.EventHandler(this.правилаИгрыToolStripMenuItem_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WForms2___Millionaire_.Properties.Resources._7;
            this.ClientSize = new System.Drawing.Size(1188, 733);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.groupBoxHelpPeople);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.labelAnswerFriend);
            this.Controls.Add(this.pictureBoxPresenter);
            this.Controls.Add(this.labelAnswerPresenter);
            this.Controls.Add(this.buttonAnswer4);
            this.Controls.Add(this.buttonAnswer3);
            this.Controls.Add(this.buttonAnswer2);
            this.Controls.Add(this.buttonAnswer1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1WinSum);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PlayForm";
            this.Text = "Кто хочет стать миллионером";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPresenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.groupBoxHelpPeople.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администраторскийРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВопросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеВопросаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1WinSum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button50to50;
        private System.Windows.Forms.Button buttonHelpPeople;
        private System.Windows.Forms.Button buttonCallFriend;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonAnswer1;
        private System.Windows.Forms.Button buttonAnswer2;
        private System.Windows.Forms.Button buttonAnswer3;
        private System.Windows.Forms.Button buttonAnswer4;
        private System.Windows.Forms.Label labelAnswerPresenter;
        private System.Windows.Forms.PictureBox pictureBoxPresenter;
        private System.Windows.Forms.Label labelAnswerFriend;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBarA;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.ProgressBar progressBarD;
        private System.Windows.Forms.GroupBox groupBoxHelpPeople;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.ToolStripMenuItem правилаИгрыToolStripMenuItem;
    }
}

