namespace Lab8
{
    partial class SubjectsForm
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
            this.chooseFile = new System.Windows.Forms.OpenFileDialog();
            this.chooseFileBtn = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.loadDataBtn = new System.Windows.Forms.Button();
            this.findRecordsBtn = new System.Windows.Forms.Button();
            this.addRecordBtn = new System.Windows.Forms.Button();
            this.deleteRecordBtn = new System.Windows.Forms.Button();
            this.records = new System.Windows.Forms.Label();
            this.recordsList = new System.Windows.Forms.ListBox();
            this.File = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.File.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseFileBtn
            // 
            this.chooseFileBtn.Location = new System.Drawing.Point(12, 47);
            this.chooseFileBtn.Name = "chooseFileBtn";
            this.chooseFileBtn.Size = new System.Drawing.Size(215, 36);
            this.chooseFileBtn.TabIndex = 0;
            this.chooseFileBtn.Text = "Выбрать файл с данными";
            this.chooseFileBtn.UseVisualStyleBackColor = true;
            this.chooseFileBtn.Click += new System.EventHandler(this.chooseFileClick);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFile.Location = new System.Drawing.Point(28, 95);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(173, 24);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "Выбранный файл: ";
            // 
            // loadDataBtn
            // 
            this.loadDataBtn.Location = new System.Drawing.Point(246, 47);
            this.loadDataBtn.Name = "loadDataBtn";
            this.loadDataBtn.Size = new System.Drawing.Size(228, 36);
            this.loadDataBtn.TabIndex = 2;
            this.loadDataBtn.Text = "Загрузить данные из файла";
            this.loadDataBtn.UseVisualStyleBackColor = true;
            this.loadDataBtn.Click += new System.EventHandler(this.loadDataBtn_Click);
            // 
            // findRecordsBtn
            // 
            this.findRecordsBtn.Location = new System.Drawing.Point(501, 47);
            this.findRecordsBtn.Name = "findRecordsBtn";
            this.findRecordsBtn.Size = new System.Drawing.Size(228, 36);
            this.findRecordsBtn.TabIndex = 3;
            this.findRecordsBtn.Text = "Поиск записей";
            this.findRecordsBtn.UseVisualStyleBackColor = true;
            this.findRecordsBtn.Click += new System.EventHandler(this.findRecordsBtn_Click);
            // 
            // addRecordBtn
            // 
            this.addRecordBtn.Location = new System.Drawing.Point(19, 147);
            this.addRecordBtn.Name = "addRecordBtn";
            this.addRecordBtn.Size = new System.Drawing.Size(228, 36);
            this.addRecordBtn.TabIndex = 4;
            this.addRecordBtn.Text = "Добавить запись";
            this.addRecordBtn.UseVisualStyleBackColor = true;
            this.addRecordBtn.Click += new System.EventHandler(this.addRecordBtn_Click);
            // 
            // deleteRecordBtn
            // 
            this.deleteRecordBtn.Location = new System.Drawing.Point(283, 147);
            this.deleteRecordBtn.Name = "deleteRecordBtn";
            this.deleteRecordBtn.Size = new System.Drawing.Size(228, 36);
            this.deleteRecordBtn.TabIndex = 5;
            this.deleteRecordBtn.Text = "Удалить запись";
            this.deleteRecordBtn.UseVisualStyleBackColor = true;
            this.deleteRecordBtn.Click += new System.EventHandler(this.deleteRecordBtn_Click);
            // 
            // records
            // 
            this.records.AutoSize = true;
            this.records.Location = new System.Drawing.Point(16, 171);
            this.records.Name = "records";
            this.records.Size = new System.Drawing.Size(0, 17);
            this.records.TabIndex = 6;
            // 
            // recordsList
            // 
            this.recordsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordsList.FormattingEnabled = true;
            this.recordsList.ItemHeight = 16;
            this.recordsList.Location = new System.Drawing.Point(12, 210);
            this.recordsList.Name = "recordsList";
            this.recordsList.Size = new System.Drawing.Size(690, 372);
            this.recordsList.TabIndex = 7;
            // 
            // File
            // 
            this.File.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.File.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.File.Location = new System.Drawing.Point(0, 0);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(729, 28);
            this.File.TabIndex = 8;
            this.File.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFileMenu});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // chooseFileMenu
            // 
            this.chooseFileMenu.Name = "chooseFileMenu";
            this.chooseFileMenu.Size = new System.Drawing.Size(216, 26);
            this.chooseFileMenu.Text = "Выбрать";
            this.chooseFileMenu.Click += new System.EventHandler(this.chooseFileMenuClick);
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 594);
            this.Controls.Add(this.recordsList);
            this.Controls.Add(this.records);
            this.Controls.Add(this.deleteRecordBtn);
            this.Controls.Add(this.addRecordBtn);
            this.Controls.Add(this.findRecordsBtn);
            this.Controls.Add(this.loadDataBtn);
            this.Controls.Add(this.labelFile);
            this.Controls.Add(this.chooseFileBtn);
            this.Controls.Add(this.File);
            this.MainMenuStrip = this.File;
            this.MinimumSize = new System.Drawing.Size(747, 572);
            this.Name = "SubjectsForm";
            this.Text = "Subjects";
            this.File.ResumeLayout(false);
            this.File.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog chooseFile;
        private System.Windows.Forms.Button chooseFileBtn;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Button loadDataBtn;
        private System.Windows.Forms.Button findRecordsBtn;
        private System.Windows.Forms.Button addRecordBtn;
        private System.Windows.Forms.Button deleteRecordBtn;
        private System.Windows.Forms.Label records;
        public System.Windows.Forms.ListBox recordsList;
        private System.Windows.Forms.MenuStrip File;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chooseFileMenu;
    }
}

