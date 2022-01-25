using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cancel_Token_Example
{
    public partial class Form1 : Form
    {

        CancellationTokenSource tokenSource; // Declare the cancellation token

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();    //Make a new instance
            Task.Run(() => RunSequence(tokenSource.Token)); //Run the task that we need to stop
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel(); // make the token a cancel token
        }

        private async void RunSequence(CancellationToken _ct)
        {
            int counter = 0;

            while (!_ct.IsCancellationRequested)
            {
                // show incrementing number but as we have a task watch for cross threading
                WriteUIData((counter++).ToString());

                try
                {
                    await Task.Delay(1000, _ct); //waits 1 second
                }
                catch
                {
                    // Do nothing just needed so we can exit without exceptions
                }

            }

            if (_ct.IsCancellationRequested)
            {
                //report we have cancelled
                WriteUIData("Cancelled");
            }

            tokenSource.Dispose(); //dispose of the token so we can reuse
        }

        private void WriteUIData(String data)
        {
            // Write data to UI but as we have a task watch for cross threading

            if (lbl_output.InvokeRequired)
            {
                lbl_output.BeginInvoke((MethodInvoker)delegate () { lbl_output.Text = data; });
            }
            else
            {
                lbl_output.Text = data;
            }
        }
    }
}
