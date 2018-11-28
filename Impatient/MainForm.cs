using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Impatient
{
    public partial class MainForm : Form
    {
        private Logic logic = new Logic();

        public MainForm()
        {
            this.InitializeComponent();

            this.firstProgressBar.Minimum = 0;
            this.firstProgressBar.Maximum = this.logic.FirstMax;
            this.secondProgressBar.Minimum = 0;
            this.secondProgressBar.Maximum = this.logic.SecondMax;
            this.thirdProgressBar.Minimum = 0;
            this.thirdProgressBar.Maximum = this.logic.ThirdMax;
            this.fourthProgressBar.Minimum = 0;
            this.fourthProgressBar.Maximum = this.logic.FourthMax;

            this.backgroundWorker.RunWorkerAsync();
        }
         
        private IEnumerable<Label> Labels()
        {
            yield return this.firstLabel;
            yield return this.secondLabel;
            yield return this.thirdLabel;
            yield return this.fourthLabel;
        }
         
        private void Set(ProgressBar bar, Label lbl, int val)
        {
            bar.Value = val;
            lbl.Text = string.Format("{0:000}", val);
        }

        private void BackgroundWorker_DoWork(object _, DoWorkEventArgs __)
        {
            Thread.Sleep(100);
        }

        private void BackgroundWorker_RunWorkerCompleted(
            object _, RunWorkerCompletedEventArgs __
        )
        {
            this.BackColor = (
                (Logic.Now.Second == 59) ?
                SystemColors.ControlDark : SystemColors.Control
            );

            this.Set(
                this.firstProgressBar, this.firstLabel,
                this.logic.FirstNum
            );
            this.Set(
                this.secondProgressBar, this.secondLabel,
                this.logic.SecondNum
            );
            this.Set(
                this.thirdProgressBar, this.thirdLabel,
                this.logic.ThirdNum
            );
            this.Set(
                this.fourthProgressBar, this.fourthLabel,
                this.logic.FourthNum
            );

            this.statusStripLabel.Text = string.Format(
                "{0:HH:mm:ss}", Logic.Now
            );

            this.backgroundWorker.RunWorkerAsync();
        }

        private void StatusStripLabel_Click(object _, EventArgs __)
        {
            foreach (Label lbl in this.Labels())
            {
                lbl.Text = "💩";
            }
        }

    }
}
