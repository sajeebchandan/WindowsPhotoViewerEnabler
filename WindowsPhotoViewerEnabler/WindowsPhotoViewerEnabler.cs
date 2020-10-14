using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPhotoViewerEnabler
{
    public partial class WindowsPhotoViewerEnabler : Form
    {
        private readonly string enable = @"Windows Registry Editor Version 5.00

; created by Walter Glenn
; for How-To Geek
; article: https://www.howtogeek.com/225844/how-to-make-windows-photo-viewer-your-default-image-viewer-on-windows-10/

[-HKEY_CLASSES_ROOT\Applications\photoviewer.dll]

"";
        private string disable = @""Windows Registry Editor Version 5.00

; created by Walter Glenn
; for How-To Geek
; article: https://www.howtogeek.com/225844/how-to-make-windows-photo-viewer-your-default-image-viewer-on-windows-10/

[HKEY_CLASSES_ROOT\Applications\photoviewer.dll]

[HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell]

[HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\open]
""MuiVerb""=""@photoviewer.dll,-3043""

[HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\open\command]
@=hex(2):25,00,53,00,79,00,73,00,74,00,65,00,6d,00,52,00,6f,00,6f,00,74,00,25,\
00,5c,00,53,00,79,00,73,00,74,00,65,00,6d,00,33,00,32,00,5c,00,72,00,75,00,\
6e,00,64,00,6c,00,6c,00,33,00,32,00,2e,00,65,00,78,00,65,00,20,00,22,00,25,\
00,50,00,72,00,6f,00,67,00,72,00,61,00,6d,00,46,00,69,00,6c,00,65,00,73,00,\
25,00,5c,00,57,00,69,00,6e,00,64,00,6f,00,77,00,73,00,20,00,50,00,68,00,6f,\
00,74,00,6f,00,20,00,56,00,69,00,65,00,77,00,65,00,72,00,5c,00,50,00,68,00,\
6f,00,74,00,6f,00,56,00,69,00,65,00,77,00,65,00,72,00,2e,00,64,00,6c,00,6c,\
00,22,00,2c,00,20,00,49,00,6d,00,61,00,67,00,65,00,56,00,69,00,65,00,77,00,\
5f,00,46,00,75,00,6c,00,6c,00,73,00,63,00,72,00,65,00,65,00,6e,00,20,00,25,\
00,31,00,00,00

[HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\open\DropTarget]
""Clsid""=""{FFE2A43C-56B9-4bf5-9A79-CC6D4285608A}""

[HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\print]

[HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\print\command]
@=hex(2):25,00,53,00,79,00,73,00,74,00,65,00,6d,00,52,00,6f,00,6f,00,74,00,25,\
00,5c,00,53,00,79,00,73,00,74,00,65,00,6d,00,33,00,32,00,5c,00,72,00,75,00,\
6e,00,64,00,6c,00,6c,00,33,00,32,00,2e,00,65,00,78,00,65,00,20,00,22,00,25,\
00,50,00,72,00,6f,00,67,00,72,00,61,00,6d,00,46,00,69,00,6c,00,65,00,73,00,\
25,00,5c,00,57,00,69,00,6e,00,64,00,6f,00,77,00,73,00,20,00,50,00,68,00,6f,\
00,74,00,6f,00,20,00,56,00,69,00,65,00,77,00,65,00,72,00,5c,00,50,00,68,00,\
6f,00,74,00,6f,00,56,00,69,00,65,00,77,00,65,00,72,00,2e,00,64,00,6c,00,6c,\
00,22,00,2c,00,20,00,49,00,6d,00,61,00,67,00,65,00,56,00,69,00,65,00,77,00,\
5f,00,46,00,75,00,6c,00,6c,00,73,00,63,00,72,00,65,00,65,00,6e,00,20,00,25,\
00,31,00,00,00

[HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\print\DropTarget]
""Clsid""=""{60fd46de-f830-4894-a628-6fa81bc0190d}""";
        private readonly string disable = @"Windows Registry Editor Version 5.00

; created by Walter Glenn
; for How-To Geek
; article: https://www.howtogeek.com/225844/how-to-make-windows-photo-viewer-your-default-image-viewer-on-windows-10/

[-HKEY_CLASSES_ROOT\Applications\photoviewer.dll]

";
        public WindowsPhotoViewerEnabler()
        {
            InitializeComponent();
        }

        private void buttonEnable_Click(object sender, EventArgs e)
        {
            string myTempFile = Path.Combine(Path.GetTempPath(), "enable.reg");
            using (StreamWriter sw = new StreamWriter(myTempFile))
            {
                sw.Write(enable);
            }
            CreateProcess(myTempFile);
        }

        private void CreateProcess(string filepath)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = "regedit.exe",
                Arguments = filepath
            };
            process.Start();
            process.OutputDataReceived += RegeditProcess_OutputDataReceived;
            process.ErrorDataReceived += RegeditProcess_ErrorDataReceived;
            process.Exited += RegeditProcess_Exited;
        }

        private void RegeditProcess_Exited(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void RegeditProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            MessageBox.Show(e.Data);
        }

        private void RegeditProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            MessageBox.Show(e.Data);
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            string myTempFile = Path.Combine(Path.GetTempPath(), "disable.reg");
            using (StreamWriter sw = new StreamWriter(myTempFile))
            {
                sw.Write(disable);
            }
            CreateProcess(myTempFile);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            using (About about = new About())
            {
                about.StartPosition = FormStartPosition.CenterParent;
                DialogResult dr = about.ShowDialog();
            }
        }
    }
}
