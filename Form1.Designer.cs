namespace EncryptPDFs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            pdfBrowseBtn = new Button();
            folderBrowseBtn = new Button();
            encryptBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            ownerPasswordBox = new TextBox();
            userPasswordBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(301, 24);
            label1.TabIndex = 0;
            label1.Text = "Choose the target PDF files to enrypt:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(281, 24);
            label2.TabIndex = 1;
            label2.Text = "Choose the output folder for PDFs:";
            // 
            // pdfBrowseBtn
            // 
            pdfBrowseBtn.Location = new Point(346, 18);
            pdfBrowseBtn.Name = "pdfBrowseBtn";
            pdfBrowseBtn.Size = new Size(117, 29);
            pdfBrowseBtn.TabIndex = 2;
            pdfBrowseBtn.Text = "Browse";
            pdfBrowseBtn.UseVisualStyleBackColor = true;
            pdfBrowseBtn.Click += button1_Click;
            // 
            // folderBrowseBtn
            // 
            folderBrowseBtn.Location = new Point(346, 61);
            folderBrowseBtn.Name = "folderBrowseBtn";
            folderBrowseBtn.Size = new Size(117, 29);
            folderBrowseBtn.TabIndex = 3;
            folderBrowseBtn.Text = "Browse";
            folderBrowseBtn.UseVisualStyleBackColor = true;
            folderBrowseBtn.Click += folderBrowseBtn_Click;
            // 
            // encryptBtn
            // 
            encryptBtn.Location = new Point(192, 196);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(94, 36);
            encryptBtn.TabIndex = 4;
            encryptBtn.Text = "Encrypt!";
            encryptBtn.UseVisualStyleBackColor = true;
            encryptBtn.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(259, 24);
            label3.TabIndex = 5;
            label3.Text = "Set password for owner access:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(245, 24);
            label4.TabIndex = 6;
            label4.Text = "Set password for user access:";
            label4.Click += label4_Click;
            // 
            // ownerPasswordBox
            // 
            ownerPasswordBox.Location = new Point(277, 105);
            ownerPasswordBox.Name = "ownerPasswordBox";
            ownerPasswordBox.Size = new Size(186, 27);
            ownerPasswordBox.TabIndex = 7;
            // 
            // userPasswordBox
            // 
            userPasswordBox.Location = new Point(277, 145);
            userPasswordBox.Name = "userPasswordBox";
            userPasswordBox.Size = new Size(186, 27);
            userPasswordBox.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 244);
            Controls.Add(userPasswordBox);
            Controls.Add(ownerPasswordBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(encryptBtn);
            Controls.Add(folderBrowseBtn);
            Controls.Add(pdfBrowseBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(497, 291);
            MinimumSize = new Size(497, 291);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EncryptPDFs";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button pdfBrowseBtn;
        private Button folderBrowseBtn;
        private Button encryptBtn;
        private Label label3;
        private Label label4;
        private TextBox ownerPasswordBox;
        private TextBox userPasswordBox;
    }
}
