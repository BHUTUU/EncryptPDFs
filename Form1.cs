using iText.Kernel.Pdf;

namespace EncryptPDFs
{
    public partial class EncryptPDFsApp : Form
    {
        private List<string> pdfFiles = new List<string>();
        private int numOfPdfsToEncrypt = 0;
        private string targetFolder = string.Empty;
        private bool outputFileNamePrefixIsChecked = false;
        private bool outputFileNameSuffixIsChecked = false;
        private string outputFilePrefixValue = string.Empty;
        private string outputFileSuffixValue = string.Empty;
        public EncryptPDFsApp()
        {
            InitializeComponent();
            hideProgressBar();
        }
        private void progressbarValue(int val)
        {
            progressBar1.Value = val;
            ppLabel.Text = val.ToString() + "%";
        }
        private void showProgressBar() { progressBar1.Visible = true; ppLabel.Visible = true; }
        private void hideProgressBar() { progressBar1.Visible = false; ppLabel.Visible = false; }
        private void resetProgressBar() { progressBar1.Value = 0; ppLabel.Text = "0%"; }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files|*.pdf";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pdfFiles.Clear();
                    pdfFiles.AddRange(openFileDialog.FileNames);
                    MessageBox.Show("Selected PDFs: " + string.Join(", ", pdfFiles));
                }
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            string ownerPass = ownerPasswordBox.Text;
            string userPass = userPasswordBox.Text;
            outputFilePrefixValue = filePrefixBox.Text;
            outputFileSuffixValue = fileSuffixBox.Text;
            if (outputFileNamePrefixIsChecked == true)
            {
                if (outputFilePrefixValue.Length == 0)
                {
                    MessageBox.Show("Please provide prefix for the ouput file name or uncheck that option to continue without it.", "Invalid input");
                    return;
                }
            }
            if (outputFileNameSuffixIsChecked == true)
            {
                if (outputFileSuffixValue.Length == 0)
                {
                    MessageBox.Show("Please provide suffix for the output file name or uncheck that option to continue without it.", "Invalid input");
                    return;
                }
            }
            outputFilePrefixCheckbox.Enabled = false;
            outputFileSuffixCheckbox.Enabled = false;
            filePrefixBox.Enabled = false;
            fileSuffixBox.Enabled = false;
            if (ownerPass == string.Empty)
            {
                MessageBox.Show("Please set the owner password!", "Invalid Input");
                return;
            }
            if (userPass == string.Empty)
            {
                DialogResult userAccessAllowed = MessageBox.Show("Are you sure to continue without user password?", "User Access Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (userAccessAllowed != DialogResult.Yes)
                {
                    MessageBox.Show("Please enter the user password and try again.");
                    return;
                }
            }
            if (targetFolder == string.Empty)
            {
                MessageBox.Show("Please select a folder for the output of the encrypted files!", "Output Error");
                return;

            }
            if (pdfFiles.Count == 0)
            {
                MessageBox.Show("Please select pdf(s) to be encrypted!", "Input Error");
                return;
            }
            numOfPdfsToEncrypt = pdfFiles.Count;
            showProgressBar();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = (int)(100 / (double)pdfFiles.Count);
            progressbarValue(0);
            int percentCompleted = 0;
            int count = 0;
            await Task.Run(() =>
            {
                foreach (string f in pdfFiles)
                {
                    try
                    {
                        encrptThisPdf(f, targetFolder, userPass, ownerPass);
                    }
                    catch (Exception ex)
                    {
                        numOfPdfsToEncrypt++;
                        MessageBox.Show($"PDF encryption Error Message: {ex.Message} PDF path: {f}", "Error");
                        if (numOfPdfsToEncrypt > 0)
                        {
                            DialogResult userWant = MessageBox.Show("Do you want to proceed for rest of the pdfs? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (userWant != DialogResult.Yes)
                            {
                                return;
                            }
                        }
                    }
                    finally
                    {
                        numOfPdfsToEncrypt--;
                        count++;
                        this.Invoke((Action)(() =>
                        {
                            percentCompleted = (int)((count / (double)pdfFiles.Count) * 100);
                            progressbarValue(percentCompleted);
                        }));
                    }
                }
            });
            count = 0;
            percentCompleted = 0;
            hideProgressBar();
            resetProgressBar();
            int totalPdfsToBeEncrypted = pdfFiles.Count;
            int numberOfPdfsEncrypted = totalPdfsToBeEncrypted - numOfPdfsToEncrypt;
            MessageBox.Show($"Encryption successful for ({numberOfPdfsEncrypted}/{totalPdfsToBeEncrypted}) files!", "Success");
            numberOfPdfsEncrypted = pdfFiles.Count; //setting it back to original as if user re run the program.
            outputFilePrefixCheckbox.Enabled = true;
            outputFileSuffixCheckbox.Enabled = true;
            filePrefixBox.Enabled = true;
            fileSuffixBox.Enabled = true;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void folderBrowseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    targetFolder = folderDialog.SelectedPath;
                    MessageBox.Show("Selected Folder: " + targetFolder);
                }
            }
        }
        public void encrptThisPdf(string fileName, string outputPath, string userPass, string ownerPass)
        {
            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }
            string outputFileName = Path.GetFileName(fileName);
            if(outputFileNamePrefixIsChecked)
            {
                outputFileName = outputFilePrefixValue + outputFileName;
            }
            if(outputFileNameSuffixIsChecked)
            {
                outputFileName = outputFileName.Replace(".pdf", "") + outputFileSuffixValue + ".pdf";
            }
            string outputFilePath = Path.Combine(outputPath, outputFileName);
            WriterProperties writerProperties = new WriterProperties()
                .SetStandardEncryption(
                    System.Text.Encoding.UTF8.GetBytes(userPass),
                    System.Text.Encoding.UTF8.GetBytes(ownerPass),
                    EncryptionConstants.ALLOW_PRINTING,
                    EncryptionConstants.ENCRYPTION_AES_256
                );
            using (PdfReader reader = new PdfReader(fileName))
            using (PdfWriter writer = new PdfWriter(outputFilePath, writerProperties))
            using (PdfDocument pdfDoc = new PdfDocument(reader, writer)) { }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            outputFileNameSuffixIsChecked = !outputFileNameSuffixIsChecked;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void outputFilePrefixCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            outputFileNamePrefixIsChecked = !outputFileNamePrefixIsChecked;
        }
    }
}
