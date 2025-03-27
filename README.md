# EncryptPDFs

EncryptPDFs is a Windows Forms application developed in C# that enables users to encrypt multiple PDF files simultaneously.

## Features

- **Batch Encryption**: Encrypt multiple PDF files in one operation, enhancing productivity.
- **User-Friendly Interface**: Intuitive design ensures ease of use for individuals with varying technical expertise.
- **Secure Encryption**: Utilizes robust encryption methods to protect the contents of your PDF files.

## Requirements

- **Operating System**: Windows 7 or later (64-bit)

## Building the Project in Visual Studio

To build EncryptPDFs from the source code:

1. **Clone the Repository**: Download or clone the repository from GitHub:

   ```bash
   git clone https://github.com/BHUTUU/EncryptPDFs.git
   ```

2. **Open the Solution**: Launch the `EncryptPDFs.sln` solution file in Visual Studio.

3. **Restore NuGet Packages**: Ensure all necessary NuGet packages are restored. This can typically be done by right-clicking the solution in the Solution Explorer and selecting "Restore NuGet Packages."

4. **Build the Solution**: Compile the application by selecting "Build Solution" from the "Build" menu.

5. **Run the Application**: After a successful build, run the application by pressing `F5` or selecting "Start Debugging" from the "Debug" menu.

## Usage

1. **Launch the Application**: Open the EncryptPDFs application.

2. **Select PDF Files**: Click the "Browse" button to choose the PDF files you wish to encrypt.

3. **Choose Output Folder**: Click the "Browse" button to select the folder where the encrypted PDFs will be saved.

4. **Set Passwords**: Enter strong passwords for both owner and user to ensure encryption security. User password is optional if you are using version greater than v1.0.0.
6. **Set Prefix or/and Suffix**: This an optional feature start from version v1.0.2 for adding prifix or/and suffix in the output, i.e., encrypted file name.
7. **Start Encryption**: Click the "Encrypt" button to begin the encryption process. A progress bar will indicate the status of the operation.

8. **Completion**: Once the process is complete, a confirmation message will appear. The encrypted PDFs will be saved in the designated output folder with the same filenames as the original files.

## Contributing

Contributions to EncryptPDFs are welcome. To contribute:

1. **Fork the Repository**: Click the "Fork" button at the top right corner of the repository page.

2. **Create a New Branch**: Use a descriptive name for your branch:

   ```bash
   git checkout -b feature/YourFeatureName
   ```

3. **Commit Your Changes**: Provide clear and concise commit messages:

   ```bash
   git commit -m "Add feature: YourFeatureName"
   ```

4. **Push to the Branch**:

   ```bash
   git push origin feature/YourFeatureName
   ```

5. **Open a Pull Request**: Navigate to the original repository and click the "New Pull Request" button. Provide a detailed description of your changes.

## License

This project is licensed under the MIT License. See the `LICENSE.txt` file for more information.

## Acknowledgements

- **iText Library**: EncryptPDFs utilizes the iText library for PDF manipulation.

For any questions or support, please open an issue in this repository.

## Installation

To install EncryptPDFs using the provided setup file:

1. **Download the Installer**: Obtain the `EncryptPDFs_v<x>.<y>.<z>_x64_Setup.exe` file from the [Releases](https://github.com/BHUTUU/EncryptPDFs/releases) section on GitHub.

2. **Run the Installer**: Double-click the downloaded file and follow the on-screen prompts to complete the installation.

3. **Launch the Application**: After installation, open EncryptPDFs from the Start Menu or desktop shortcut.
