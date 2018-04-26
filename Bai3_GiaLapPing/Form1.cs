using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Bai3_GiaLapPing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Arguments = "/C ping " + txtIPWeb.Text;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.CreateNoWindow = true;
            info.FileName = "cmd.exe";
            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            using (Process process = Process.Start(info))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    txtOut.Text += result;
                }
            }
        }

        private void txtIPWeb_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIPWeb.Text) || txtIPWeb.Text == "")
                MessageBox.Show("Nhap dia chi web hoac IP!","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
