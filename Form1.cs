using iText;
using iText.Forms.Form.Element;
using iText.Kernel.Pdf;
using iText.Layout;

namespace EncryptPDFs
{
    public partial class Form1 : Form
    {
        private List<string> pdfFiles = new List<string>();
        private int numOfPdfsToEncrypt = 0;
        private string targetFolder = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

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
                    numOfPdfsToEncrypt = pdfFiles.Count;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string ownerPass = ownerPasswordBox.Text;
            string userPass = userPasswordBox.Text;
            if (ownerPass == string.Empty)
            {
                MessageBox.Show("Please set the owner password!", "Invalid Input");
                return;
            }
            if (userPass == string.Empty)
            {
                MessageBox.Show("Please set the user password!", "Invalid Input");
                return;
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
            foreach (string f in pdfFiles)
            {
                try
                {
                    encrptThisPdf(f, targetFolder, userPass, ownerPass);
                } catch(Exception ex) 
                {
                    MessageBox.Show($"PDF encryption Error Message: {ex.Message}", "Error");
                    if(numOfPdfsToEncrypt > 0) {
                        DialogResult userWant = MessageBox.Show("Do you want to proceed for rest of the pdfs? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if(userWant != DialogResult.Yes)
                        {
                            return;
                        }
                    }
                } finally
                {
                    numOfPdfsToEncrypt--;
                }
            }
            int totalPdfsToBeEncrypted = pdfFiles.Count;
            int numberOfPdfsEncrypted = totalPdfsToBeEncrypted - numOfPdfsToEncrypt;
            numberOfPdfsEncrypted=pdfFiles.Count; //setting it back to original as if user re run the program.
            MessageBox.Show($"Encryption successful for ({numberOfPdfsEncrypted}/{totalPdfsToBeEncrypted}) files!", "Success");
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
            string outputFilePath = Path.Combine(outputPath, Path.GetFileName(fileName));
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
    }
}
