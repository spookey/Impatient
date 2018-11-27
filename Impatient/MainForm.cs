using System;
using System.Drawing;
using System.Windows.Forms;

namespace Impatient
{
    public partial class MainForm : Form
    {
        private Logic logic = null;

        public MainForm()
        {
            this.InitializeComponent();
            this.OnResize();

            this.Initialize();
        }

        private void Initialize()
        {
            this.logic = new Logic();
            this.SetupBars();
            this.theTimer.Enabled = true;
        }

        private void MainForm_Resize(object _, EventArgs __)
        {
            this.OnResize();
        }

        private void TheTimer_Tick(object _, EventArgs __)
        {
            this.Tick();
        }

        private void ResetColor()
        {
            this.BackColor = SystemColors.Control;
        }
        private void SetDColor()
        {
            this.BackColor = SystemColors.ControlDark;
        }

        #region "cycle"

        private const string APP_NAME = "Impatient";

        private void Tick()
        {
            if (this.logic.HardReset) { this.Initialize(); }

            if (this.logic.Divider) { this.SetDColor(); }
            else { this.ResetColor(); }

            int fst = this.logic.Fst;
            int scd = this.logic.Scd;
            int trd = this.logic.Trd;

            this.barFst.Value = fst;
            this.barScd.Value = scd;
            this.barTrd.Value = trd;

            this.txtFst.Text = string.Format("{0:000}", fst);
            this.txtScd.Text = string.Format("{0:000}", scd);
            this.txtTrd.Text = string.Format("{0:000}", trd);
        }

        private void SetupBars()
        {
            this.barFst.Minimum = 0;
            this.barFst.Maximum = this.logic.Fst;
            this.barScd.Minimum = 0;
            this.barScd.Maximum = this.logic.Scd;
            this.barTrd.Minimum = 0;
            this.barTrd.Maximum = this.logic.Trd;
        }

        #endregion

        #region "fluid layout"

        private const int SPAN_X = 12;
        private const int SPAN_Y = 12;

        private Font SizedFont(float size)
        {
            return new Font(
                "Microsoft Sans Serif", size,
                FontStyle.Bold, GraphicsUnit.Pixel
            );
        }

        private void OnResize()
        {
            int boxW = this.ClientSize.Width - (SPAN_X * 2);
            int boxH = (this.ClientSize.Height - (SPAN_Y * 4)) / 3;

            this.boxFst.Size = new Size(boxW, boxH);
            this.boxScd.Size = new Size(boxW, boxH);
            this.boxTrd.Size = new Size(boxW, boxH);

            int boxX = SPAN_X;
            int boxY = SPAN_Y;

            this.boxFst.Location = new Point(boxX, boxY);
            boxY += boxH + SPAN_Y;
            this.boxScd.Location = new Point(boxX, boxY);
            boxY += boxH + SPAN_Y;
            this.boxTrd.Location = new Point(boxX, boxY);

            int barW = boxW - SPAN_X;
            int barH = SPAN_Y * 2;

            this.barFst.Size = new Size(barW, barH);
            this.barScd.Size = new Size(barW, barH);
            this.barTrd.Size = new Size(barW, barH);

            int barX = SPAN_X / 2;
            int barY = (SPAN_Y / 2) * 3;

            this.barFst.Location = new Point(barX, barY);
            this.barScd.Location = new Point(barX, barY);
            this.barTrd.Location = new Point(barX, barY);

            float txtHeight = boxH - barH - (SPAN_Y * 4) - (SPAN_Y / 2);

            this.txtFst.Font = SizedFont(txtHeight);
            this.txtScd.Font = SizedFont(txtHeight);
            this.txtTrd.Font = SizedFont(txtHeight);

            int txtX = SPAN_X / 2;
            int txtY = SPAN_X * 4;

            this.txtFst.Location = new Point(txtX, txtY);
            this.txtScd.Location = new Point(txtX, txtY);
            this.txtTrd.Location = new Point(txtX, txtY);
        }

        #endregion

    }
}
