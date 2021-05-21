
namespace OSLab2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileStartRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileStartTextBox = new System.Windows.Forms.TextBox();
            this.ClusterTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClusterRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InputButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.FragmentationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileStartRichTextBox
            // 
            this.FileStartRichTextBox.Location = new System.Drawing.Point(16, 71);
            this.FileStartRichTextBox.Name = "FileStartRichTextBox";
            this.FileStartRichTextBox.ReadOnly = true;
            this.FileStartRichTextBox.Size = new System.Drawing.Size(109, 261);
            this.FileStartRichTextBox.TabIndex = 0;
            this.FileStartRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начала файлов";
            // 
            // FileStartTextBox
            // 
            this.FileStartTextBox.Location = new System.Drawing.Point(152, 58);
            this.FileStartTextBox.Name = "FileStartTextBox";
            this.FileStartTextBox.Size = new System.Drawing.Size(456, 22);
            this.FileStartTextBox.TabIndex = 2;
            this.FileStartTextBox.Text = "2 7 12 11";
            // 
            // ClusterTextBox
            // 
            this.ClusterTextBox.Location = new System.Drawing.Point(16, 115);
            this.ClusterTextBox.Name = "ClusterTextBox";
            this.ClusterTextBox.Size = new System.Drawing.Size(741, 22);
            this.ClusterTextBox.TabIndex = 3;
            this.ClusterTextBox.Text = "-1 -1 3 4 5 -2 -2 16 -2 8 -3 13 13 20 -1 -3 9 -1 -1 -1 6 -1 -1 -1 25 26 -2 -1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Кластеры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цепочки";
            // 
            // ClusterRichTextBox
            // 
            this.ClusterRichTextBox.Location = new System.Drawing.Point(162, 71);
            this.ClusterRichTextBox.Name = "ClusterRichTextBox";
            this.ClusterRichTextBox.ReadOnly = true;
            this.ClusterRichTextBox.Size = new System.Drawing.Size(163, 261);
            this.ClusterRichTextBox.TabIndex = 6;
            this.ClusterRichTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.InputButton);
            this.groupBox1.Controls.Add(this.ClusterTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FileStartTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 277);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходные данные";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.FragmentationRichTextBox);
            this.groupBox2.Controls.Add(this.StartButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ChainRichTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ClusterRichTextBox);
            this.groupBox2.Controls.Add(this.FileStartRichTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 405);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Начала файлов";
            // 
            // ChainRichTextBox
            // 
            this.ChainRichTextBox.Location = new System.Drawing.Point(347, 71);
            this.ChainRichTextBox.Name = "ChainRichTextBox";
            this.ChainRichTextBox.ReadOnly = true;
            this.ChainRichTextBox.Size = new System.Drawing.Size(191, 261);
            this.ChainRichTextBox.TabIndex = 8;
            this.ChainRichTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Кластеры";
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(311, 218);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(138, 38);
            this.InputButton.TabIndex = 5;
            this.InputButton.Text = "Ввести данные";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(311, 348);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(138, 38);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Запуск";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // FragmentationRichTextBox
            // 
            this.FragmentationRichTextBox.Location = new System.Drawing.Point(559, 71);
            this.FragmentationRichTextBox.Name = "FragmentationRichTextBox";
            this.FragmentationRichTextBox.ReadOnly = true;
            this.FragmentationRichTextBox.Size = new System.Drawing.Size(198, 261);
            this.FragmentationRichTextBox.TabIndex = 10;
            this.FragmentationRichTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(611, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Фрагментация";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(248, 51);
            this.label7.TabIndex = 6;
            this.label7.Text = "Свободный кластер = -1\r\nПоследний кластер файла (eof) = -2\r\nДефектный кластер (ba" +
    "d) = -3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Работа с фрагментацией файлов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox FileStartRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileStartTextBox;
        private System.Windows.Forms.TextBox ClusterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ClusterRichTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox FragmentationRichTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox ChainRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}

