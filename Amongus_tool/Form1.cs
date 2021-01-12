using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Amongus_tool
{
    public partial class Form1 : Form
    {
        public Mem m = new Mem();

        public Form1()
        {
            InitializeComponent();
        }

        bool ProcOpen = false;

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!m.OpenProcess("Among Us"))
            {
                Thread.Sleep(1000);
                return;
            }

            ProcOpen = true;
            Thread.Sleep(1000);
            BGWorker.ReportProgress(0);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.Text = "YES";
                ProcOpenLabel.ForeColor = Color.FromArgb(40, 193, 0); //GREEN
            }
                
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        private void ApplyMaxPlayers_Click(object sender, EventArgs e)
        {
            //m.WriteMemory("GameAssembly.dll+01C5803C,64,178,20,24,5C,34,8", "byte",MaxPlayers.Text);
        }
    }
}
