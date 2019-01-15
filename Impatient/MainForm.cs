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
        private const float FONTINCR = 1f;
        private const int FONTMARGIN = 12;

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


        private void Set(Label lbl, ProgressBar bar, int val)
        {
            bar.Value = val;
            lbl.Text = string.Format("{0:000}", val);
            ResizeTextLabel(lbl);
        }

        private void BackgroundWorker_DoWork(object _, DoWorkEventArgs __)
        {
            Thread.Sleep(100);
        }

        private void BackgroundWorker_RunWorkerCompleted(
            object _, RunWorkerCompletedEventArgs __
        )
        {
            Color col = (
                (Logic.Now.Second == 59) ?
                SystemColors.ControlDark : SystemColors.Control
            );
            this.BackColor = col;
            this.statusStrip.BackColor = col;

            this.Set(
                this.firstLabel, this.firstProgressBar, this.logic.FirstNum
            );
            this.Set(
                this.secondLabel, this.secondProgressBar, this.logic.SecondNum
            );
            this.Set(
                this.thirdLabel, this.thirdProgressBar, this.logic.ThirdNum
            );
            this.Set(
                this.fourthLabel, this.fourthProgressBar, this.logic.FourthNum
            );

            this.statusStripLabel.Text = string.Format(
                "{0:HH:mm:ss}", Logic.Now
            );

            this.backgroundWorker.RunWorkerAsync();
        }

        private void ResizeTextLabel(Label lbl)
        {
            TableLayoutPanelCellPosition pos =
                this.mainTableLayoutPanel.GetCellPosition(lbl);
            Size boxSize = new Size(
                this.mainTableLayoutPanel.GetColumnWidths()[pos.Column],
                this.mainTableLayoutPanel.GetRowHeights()[pos.Row]
            );

            Size Resize(bool initial = false)
            {
                float fact = FONTINCR + (initial ? 0f : lbl.Font.Size);
                lbl.Font = new Font(lbl.Font.FontFamily, fact);
                return TextRenderer.MeasureText(lbl.Text, lbl.Font, boxSize);
            }

            Size size = Resize(true);
            while (
                FONTMARGIN + size.Width < boxSize.Width &&
                FONTMARGIN + size.Height < boxSize.Height
            )
            {
                size = Resize();
            }
        }

        private void MainForm_Resize(object _, EventArgs __)
        {
            foreach (Label lbl in Labels())
            {
                ResizeTextLabel(lbl);
            }
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
