namespace Lab8
{
    partial class SearchRecordsForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameCheck = new System.Windows.Forms.CheckBox();
            this.groupCheck = new System.Windows.Forms.CheckBox();
            this.courseCheck = new System.Windows.Forms.CheckBox();
            this.finalTestCheck = new System.Windows.Forms.CheckBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.groupCodeTextBox = new System.Windows.Forms.TextBox();
            this.courseText = new System.Windows.Forms.ComboBox();
            this.finalTestText = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия преподавателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Код группы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наличие курсовой";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вид итогового контроля";
            // 
            // surnameCheck
            // 
            this.surnameCheck.AutoSize = true;
            this.surnameCheck.Location = new System.Drawing.Point(306, 53);
            this.surnameCheck.Name = "surnameCheck";
            this.surnameCheck.Size = new System.Drawing.Size(18, 17);
            this.surnameCheck.TabIndex = 4;
            this.surnameCheck.UseVisualStyleBackColor = true;
            this.surnameCheck.CheckedChanged += new System.EventHandler(this.surnameChangeCheck);
            // 
            // groupCheck
            // 
            this.groupCheck.AutoSize = true;
            this.groupCheck.Location = new System.Drawing.Point(306, 136);
            this.groupCheck.Name = "groupCheck";
            this.groupCheck.Size = new System.Drawing.Size(18, 17);
            this.groupCheck.TabIndex = 5;
            this.groupCheck.UseVisualStyleBackColor = true;
            this.groupCheck.CheckedChanged += new System.EventHandler(this.groupCodeCheck);
            // 
            // courseCheck
            // 
            this.courseCheck.AutoSize = true;
            this.courseCheck.Location = new System.Drawing.Point(306, 223);
            this.courseCheck.Name = "courseCheck";
            this.courseCheck.Size = new System.Drawing.Size(18, 17);
            this.courseCheck.TabIndex = 6;
            this.courseCheck.UseVisualStyleBackColor = true;
            this.courseCheck.CheckedChanged += new System.EventHandler(this.courseChecked);
            // 
            // finalTestCheck
            // 
            this.finalTestCheck.AutoSize = true;
            this.finalTestCheck.Location = new System.Drawing.Point(306, 296);
            this.finalTestCheck.Name = "finalTestCheck";
            this.finalTestCheck.Size = new System.Drawing.Size(18, 17);
            this.finalTestCheck.TabIndex = 7;
            this.finalTestCheck.UseVisualStyleBackColor = true;
            this.finalTestCheck.CheckedChanged += new System.EventHandler(this.finalTestChecked);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Enabled = false;
            this.surnameTextBox.Location = new System.Drawing.Point(399, 48);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(275, 22);
            this.surnameTextBox.TabIndex = 8;
            // 
            // groupCodeTextBox
            // 
            this.groupCodeTextBox.Enabled = false;
            this.groupCodeTextBox.Location = new System.Drawing.Point(399, 136);
            this.groupCodeTextBox.Name = "groupCodeTextBox";
            this.groupCodeTextBox.Size = new System.Drawing.Size(275, 22);
            this.groupCodeTextBox.TabIndex = 9;
            // 
            // courseText
            // 
            this.courseText.Enabled = false;
            this.courseText.FormattingEnabled = true;
            this.courseText.Items.AddRange(new object[] {
            "Нет",
            "Да"});
            this.courseText.Location = new System.Drawing.Point(420, 223);
            this.courseText.Name = "courseText";
            this.courseText.Size = new System.Drawing.Size(203, 24);
            this.courseText.TabIndex = 10;
            this.courseText.Text = "Нет";
            // 
            // finalTestText
            // 
            this.finalTestText.Enabled = false;
            this.finalTestText.FormattingEnabled = true;
            this.finalTestText.Items.AddRange(new object[] {
            "Зачёт",
            "Экзамен"});
            this.finalTestText.Location = new System.Drawing.Point(420, 289);
            this.finalTestText.Name = "finalTestText";
            this.finalTestText.Size = new System.Drawing.Size(203, 24);
            this.finalTestText.TabIndex = 11;
            this.finalTestText.Text = "Зачёт";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Найти записи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 452);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finalTestText);
            this.Controls.Add(this.courseText);
            this.Controls.Add(this.groupCodeTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.finalTestCheck);
            this.Controls.Add(this.courseCheck);
            this.Controls.Add(this.groupCheck);
            this.Controls.Add(this.surnameCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(754, 499);
            this.MinimumSize = new System.Drawing.Size(754, 499);
            this.Name = "SearchRecordsForm";
            this.Text = "SearchRecords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox surnameCheck;
        private System.Windows.Forms.CheckBox groupCheck;
        private System.Windows.Forms.CheckBox courseCheck;
        private System.Windows.Forms.CheckBox finalTestCheck;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox groupCodeTextBox;
        private System.Windows.Forms.ComboBox courseText;
        private System.Windows.Forms.ComboBox finalTestText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}