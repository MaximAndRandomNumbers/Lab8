namespace Lab8
{
    partial class SearchResultForm
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
            this.resultDisplayLabel = new System.Windows.Forms.Label();
            this.resultDisplayBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Результаты поиска:";
            // 
            // resultDisplayLabel
            // 
            this.resultDisplayLabel.AutoSize = true;
            this.resultDisplayLabel.Location = new System.Drawing.Point(47, 73);
            this.resultDisplayLabel.Name = "resultDisplayLabel";
            this.resultDisplayLabel.Size = new System.Drawing.Size(0, 17);
            this.resultDisplayLabel.TabIndex = 1;
            // 
            // resultDisplayBox
            // 
            this.resultDisplayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultDisplayBox.FormattingEnabled = true;
            this.resultDisplayBox.ItemHeight = 16;
            this.resultDisplayBox.Location = new System.Drawing.Point(41, 64);
            this.resultDisplayBox.Name = "resultDisplayBox";
            this.resultDisplayBox.Size = new System.Drawing.Size(725, 404);
            this.resultDisplayBox.TabIndex = 2;
            // 
            // SearchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.resultDisplayBox);
            this.Controls.Add(this.resultDisplayLabel);
            this.Controls.Add(this.label1);
            this.Name = "SearchResultForm";
            this.Text = "SerachResultForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultDisplayLabel;
        private System.Windows.Forms.ListBox resultDisplayBox;
    }
}