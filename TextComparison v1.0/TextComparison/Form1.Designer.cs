namespace TextComparison
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFirstFile = new System.Windows.Forms.Label();
            this.labelSecondFile = new System.Windows.Forms.Label();
            this.buttonSelectFirstFile = new System.Windows.Forms.Button();
            this.buttonSelectSecondFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFirstFile
            // 
            this.labelFirstFile.AutoSize = true;
            this.labelFirstFile.ForeColor = System.Drawing.Color.White;
            this.labelFirstFile.Location = new System.Drawing.Point(15, 59);
            this.labelFirstFile.Name = "labelFirstFile";
            this.labelFirstFile.Size = new System.Drawing.Size(67, 18);
            this.labelFirstFile.TabIndex = 2;
            this.labelFirstFile.Text = "1. Dosya";
            // 
            // labelSecondFile
            // 
            this.labelSecondFile.AutoSize = true;
            this.labelSecondFile.ForeColor = System.Drawing.Color.White;
            this.labelSecondFile.Location = new System.Drawing.Point(18, 59);
            this.labelSecondFile.Name = "labelSecondFile";
            this.labelSecondFile.Size = new System.Drawing.Size(67, 18);
            this.labelSecondFile.TabIndex = 2;
            this.labelSecondFile.Text = "2. Dosya";
            // 
            // buttonSelectFirstFile
            // 
            this.buttonSelectFirstFile.Location = new System.Drawing.Point(18, 13);
            this.buttonSelectFirstFile.Name = "buttonSelectFirstFile";
            this.buttonSelectFirstFile.Size = new System.Drawing.Size(127, 43);
            this.buttonSelectFirstFile.TabIndex = 3;
            this.buttonSelectFirstFile.Text = "1. Dosyayı Seçin";
            this.buttonSelectFirstFile.UseVisualStyleBackColor = true;
            this.buttonSelectFirstFile.Click += new System.EventHandler(this.buttonSelectFirstFile_Click);
            // 
            // buttonSelectSecondFile
            // 
            this.buttonSelectSecondFile.Enabled = false;
            this.buttonSelectSecondFile.Location = new System.Drawing.Point(21, 13);
            this.buttonSelectSecondFile.Name = "buttonSelectSecondFile";
            this.buttonSelectSecondFile.Size = new System.Drawing.Size(127, 43);
            this.buttonSelectSecondFile.TabIndex = 3;
            this.buttonSelectSecondFile.Text = "2. Dosyayı Seçin";
            this.buttonSelectSecondFile.UseVisualStyleBackColor = true;
            this.buttonSelectSecondFile.Click += new System.EventHandler(this.buttonSelectSecondFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.Silver;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(18, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(888, 832);
            this.listBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.Silver;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(21, 81);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(888, 832);
            this.listBox2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.labelFirstFile);
            this.panel1.Controls.Add(this.buttonSelectFirstFile);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 932);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.labelSecondFile);
            this.panel2.Controls.Add(this.buttonSelectSecondFile);
            this.panel2.Location = new System.Drawing.Point(945, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 932);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1890, 961);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelFirstFile;
        private System.Windows.Forms.Label labelSecondFile;
        private System.Windows.Forms.Button buttonSelectFirstFile;
        private System.Windows.Forms.Button buttonSelectSecondFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

