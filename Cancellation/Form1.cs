using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cancellation
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            var token = cts.Token;

            Task.Run(() =>
            {
                long max = -1;
                this.Invoke((Action)(() => 
                {
                    largestPrimeTxt.Clear();
                    calculateBtn.Enabled = false;
                    cancelBtn.Enabled = true;
                    calculatingLbl.Visible = true;
                    max = long.Parse(this.maxValueTxt.Text);
                }));

                long prime = -1;
                try
                {
                    prime = FindLargestPrimeNumber(max, token);
                }
                catch (OperationCanceledException)
                { }

                this.Invoke((Action) (() =>
                {
                    calculateBtn.Enabled = true;
                    cancelBtn.Enabled = false;
                    calculatingLbl.Visible = false;

                    if (prime != -1)
                    {
                        largestPrimeTxt.Text = prime.ToString();
                    }
                }));

                cts.Dispose();
            }, token);
        }

        private long FindLargestPrimeNumber(long max, CancellationToken token = default(CancellationToken))
        {
            var result = 1;
            for (int i = 2; i <= max; i++)
            {
                token.ThrowIfCancellationRequested();
                if (IsPrime(i, token))
                {
                    result = i;
                }
            }
            return result;
        }

        private bool IsPrime(int num, CancellationToken token = default(CancellationToken))
        {
            for (int i = 2; i < num; i++)
            {
                token.ThrowIfCancellationRequested();
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
