; Inno Setup Script for EncryptPDFsSetup
; This script installs the application at the user level without requiring admin permissions.

[Setup]
; Basic Setup Information
AppName=EncryptPDFsSetup
AppVersion=1.0.2
DefaultDirName={localappdata}\EncryptPDFsSetup
DefaultGroupName=EncryptPDFsSetup
OutputBaseFilename=EncryptPDFs_v1.0.2_x64_Setup.exe
OutputDir=.
PrivilegesRequired=lowest
Compression=lzma2
SolidCompression=yes
UninstallDisplayIcon={app}\icon.ico
SetupIconFile=..\icon.ico
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible

[Files]
; Application Files
Source: "..\bin\Release\net8.0-windows\publish\win-x64\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "..\icon.ico"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
; Desktop Shortcut
Name: "{userdesktop}\EncryptPDFs"; Filename: "{app}\EncryptPDFs.exe"; IconFilename: "{app}\icon.ico"

; Start Menu Shortcut
Name: "{group}\EncryptPDFs"; Filename: "{app}\EncryptPDFs.exe"; IconFilename: "{app}\icon.ico"

[Run]
; Optional: Run the application after installation
Filename: "{app}\EncryptPDFs.exe"; Description: "Launch EncryptPDFs"; Flags: nowait postinstall skipifsilent

[UninstallDelete]
; Optional: Clean up additional files if needed
Type: files; Name: "{app}\*"
Type: dirifempty; Name: "{app}"

[Code]
// Optional: Custom Pascal Script code can be added here if needed
