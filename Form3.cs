using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FacebookSeller
{
    public partial class Form3 : Form
    {
        private readonly FbPost _fbPost;
        private readonly List<FbGroup> _fbGroups;
        private readonly FbRequest _fbRequest;

        private readonly BackgroundWorker _bw;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(FbPost fbPost, List<FbGroup> fbGroups, FbRequest fbRequest) : this()
        {
            _fbPost = fbPost;
            _fbGroups = fbGroups;
            _fbRequest = fbRequest;

            _bw = new BackgroundWorker {WorkerSupportsCancellation = true, WorkerReportsProgress = true};
            _bw.DoWork += bw_DoWork;
            _bw.ProgressChanged += bw_ProgressChanged;
            _bw.RunWorkerCompleted += bw_RunWorkerCompleted;

            _bw.RunWorkerAsync();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                richTextBox1.Text += Environment.NewLine + @"CANCELED";
            }

            else if (e.Error != null)
            {
                richTextBox1.Text += Environment.NewLine + @"ERROR";
            }

            else
            {
                richTextBox1.Text += Environment.NewLine + @"DONE";
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                richTextBox1.Text += Environment.NewLine + (string) e.UserState;
            }
            else
            {
                richTextBox1.Text += Environment.NewLine + @"FAIL";
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;
            var checkedGroups = _fbGroups.Where(x => x.IsChecked);

            foreach (var fbGroup in checkedGroups)
            {
                String result;
                if(String.IsNullOrEmpty(_fbPost.Source))
                    result = _fbRequest.CreatePost(_fbPost, fbGroup);
                else
                    result = _fbRequest.CreatePostAndUploadPhoto(_fbPost, fbGroup);
                if (worker != null)
                {
                    if(result != null)
                        worker.ReportProgress(0, "Made new post at " + fbGroup.Name);
                    else
                        worker.ReportProgress(0, "Made new post at " + fbGroup.Name + " - FAIL");

                    if (worker.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                System.Threading.Thread.Sleep(1000);
            }
        }

        private void buttonStop_Click(object sender, System.EventArgs e)
        {
            _bw.CancelAsync();
        }

    }
}
