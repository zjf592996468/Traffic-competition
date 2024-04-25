using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using MathWorks.MATLAB.NET.Arrays;
using Traffic_optimize_local;

namespace Traffic_competition
{
    public partial class Formstart : Form
    {
        public Formstart()
        {
            InitializeComponent();
            backgroundWorker.WorkerReportsProgress = true;
            panelprogress.Width = 0;
            backgroundWorker.RunWorkerAsync();
        }

        private void Timerprogress_Tick(object sender, EventArgs e)
        {
            if (panelprogress.Width < 547)
            {
                panelprogress.Width += 1;
            }
            else
            {
                if (backgroundWorker.IsBusy)
                {
                    labelinitial.Text = "请稍候...";
                }
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Class_Traffic traffic = new Class_Traffic();
            MWArray a = traffic.chushi();
            Thread.Sleep(500);
            worker.ReportProgress(100);
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            panelprogress.Width = 547;
            Thread.Sleep(500);
            DialogResult = DialogResult.OK;
            timerprogress.Stop();
        }
    }
}
