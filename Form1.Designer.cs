namespace EncryptPDFs
{
    partial class EncryptPDFsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptPDFsApp));
            label1 = new Label();
            label2 = new Label();
            pdfBrowseBtn = new Button();
            folderBrowseBtn = new Button();
            encryptBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            ownerPasswordBox = new TextBox();
            userPasswordBox = new TextBox();
            progressBar1 = new ProgressBar();
            ppLabel = new Label();
            outputFilePrefixCheckbox = new CheckBox();
            outputFileSuffixCheckbox = new CheckBox();
            filePrefixBox = new TextBox();
            fileSuffixBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(301, 19);
            label1.TabIndex = 0;
            label1.Text = "CHOOSE TARGET PDFs TO ENCRYPT:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(305, 19);
            label2.TabIndex = 1;
            label2.Text = "CHOOSE OUTPUT FOLDER FOR PDFs:";
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
            encryptBtn.Location = new Point(192, 289);
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
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(212, 19);
            label3.TabIndex = 5;
            label3.Text = "SET OWNER PASSWORD:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(194, 19);
            label4.TabIndex = 6;
            label4.Text = "SET USER PASSWORD:";
            label4.Click += label4_Click;
            // 
            // ownerPasswordBox
            // 
            ownerPasswordBox.Font = new Font("Arial", 10.2F);
            ownerPasswordBox.Location = new Point(277, 105);
            ownerPasswordBox.Name = "ownerPasswordBox";
            ownerPasswordBox.Size = new Size(186, 27);
            ownerPasswordBox.TabIndex = 7;
            // 
            // userPasswordBox
            // 
            userPasswordBox.Font = new Font("Arial", 10.2F);
            userPasswordBox.Location = new Point(277, 145);
            userPasswordBox.Name = "userPasswordBox";
            userPasswordBox.Size = new Size(186, 27);
            userPasswordBox.TabIndex = 8;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(16, 265);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(446, 10);
            progressBar1.TabIndex = 9;
            // 
            // ppLabel
            // 
            ppLabel.AutoSize = true;
            ppLabel.Location = new Point(410, 289);
            ppLabel.Name = "ppLabel";
            ppLabel.Size = new Size(29, 20);
            ppLabel.TabIndex = 10;
            ppLabel.Text = "0%";
            // 
            // outputFilePrefixCheckbox
            // 
            outputFilePrefixCheckbox.AutoSize = true;
            outputFilePrefixCheckbox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputFilePrefixCheckbox.Location = new Point(17, 186);
            outputFilePrefixCheckbox.Name = "outputFilePrefixCheckbox";
            outputFilePrefixCheckbox.Size = new Size(254, 23);
            outputFilePrefixCheckbox.TabIndex = 11;
            outputFilePrefixCheckbox.Text = "OUTPUT FILE NAME PREFIX:";
            outputFilePrefixCheckbox.UseVisualStyleBackColor = true;
            outputFilePrefixCheckbox.CheckedChanged += outputFilePrefixCheckbox_CheckedChanged;
            // 
            // outputFileSuffixCheckbox
            // 
            outputFileSuffixCheckbox.AutoSize = true;
            outputFileSuffixCheckbox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputFileSuffixCheckbox.Location = new Point(17, 224);
            outputFileSuffixCheckbox.Name = "outputFileSuffixCheckbox";
            outputFileSuffixCheckbox.Size = new Size(253, 23);
            outputFileSuffixCheckbox.TabIndex = 12;
            outputFileSuffixCheckbox.Text = "OUTPUT FILE NAME SUFFIX:";
            outputFileSuffixCheckbox.UseVisualStyleBackColor = true;
            outputFileSuffixCheckbox.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // filePrefixBox
            // 
            filePrefixBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filePrefixBox.Location = new Point(277, 183);
            filePrefixBox.Name = "filePrefixBox";
            filePrefixBox.Size = new Size(186, 27);
            filePrefixBox.TabIndex = 13;
            // 
            // fileSuffixBox
            // 
            fileSuffixBox.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fileSuffixBox.Location = new Point(278, 221);
            fileSuffixBox.Name = "fileSuffixBox";
            fileSuffixBox.Size = new Size(186, 27);
            fileSuffixBox.TabIndex = 14;
            fileSuffixBox.TextChanged += textBox2_TextChanged;
            // 
            // EncryptPDFsApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 337);
            Controls.Add(fileSuffixBox);
            Controls.Add(filePrefixBox);
            Controls.Add(outputFileSuffixCheckbox);
            Controls.Add(outputFilePrefixCheckbox);
            Controls.Add(ppLabel);
            Controls.Add(progressBar1);
            Controls.Add(userPasswordBox);
            Controls.Add(ownerPasswordBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(encryptBtn);
            Controls.Add(folderBrowseBtn);
            Controls.Add(pdfBrowseBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(497, 291);
            Name = "EncryptPDFsApp";
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
        private ProgressBar progressBar1;
        private Label ppLabel;
        private CheckBox outputFilePrefixCheckbox;
        private CheckBox outputFileSuffixCheckbox;
        private TextBox filePrefixBox;
        private TextBox fileSuffixBox;
    }
}
