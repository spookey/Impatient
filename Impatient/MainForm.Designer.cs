namespace Impatient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.fourthLabel = new System.Windows.Forms.Label();
            this.firstProgressBar = new System.Windows.Forms.ProgressBar();
            this.secondProgressBar = new System.Windows.Forms.ProgressBar();
            this.thirdProgressBar = new System.Windows.Forms.ProgressBar();
            this.fourthProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // statusStrip
            //
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(624, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "Status";
            //
            // statusStripLabel
            //
            this.statusStripLabel.Name = "statusStripLabel";
            this.statusStripLabel.Size = new System.Drawing.Size(27, 17);
            this.statusStripLabel.Text = "null";
            this.statusStripLabel.Click += new System.EventHandler(this.StatusStripLabel_Click);
            //
            // mainTableLayoutPanel
            //
            this.mainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.mainTableLayoutPanel.Controls.Add(this.firstLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.secondLabel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.thirdLabel, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.fourthLabel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.firstProgressBar, 1, 0);
            this.mainTableLayoutPanel.Controls.Add(this.secondProgressBar, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.thirdProgressBar, 1, 2);
            this.mainTableLayoutPanel.Controls.Add(this.fourthProgressBar, 1, 3);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 4;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(624, 419);
            this.mainTableLayoutPanel.TabIndex = 0;
            //
            // firstLabel
            //
            this.firstLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstLabel.Location = new System.Drawing.Point(3, 0);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(150, 104);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "NaN";
            this.firstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // secondLabel
            //
            this.secondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondLabel.Location = new System.Drawing.Point(3, 104);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(150, 104);
            this.secondLabel.TabIndex = 0;
            this.secondLabel.Text = "NaN";
            this.secondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // thirdLabel
            //
            this.thirdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thirdLabel.Location = new System.Drawing.Point(3, 208);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(150, 104);
            this.thirdLabel.TabIndex = 0;
            this.thirdLabel.Text = "NaN";
            this.thirdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // fourthLabel
            //
            this.fourthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fourthLabel.Location = new System.Drawing.Point(3, 312);
            this.fourthLabel.Name = "fourthLabel";
            this.fourthLabel.Size = new System.Drawing.Size(150, 107);
            this.fourthLabel.TabIndex = 0;
            this.fourthLabel.Text = "NaN";
            this.fourthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // firstProgressBar
            //
            this.firstProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstProgressBar.Location = new System.Drawing.Point(159, 3);
            this.firstProgressBar.Name = "firstProgressBar";
            this.firstProgressBar.Size = new System.Drawing.Size(462, 98);
            this.firstProgressBar.TabIndex = 0;
            //
            // secondProgressBar
            //
            this.secondProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secondProgressBar.Location = new System.Drawing.Point(159, 107);
            this.secondProgressBar.Name = "secondProgressBar";
            this.secondProgressBar.Size = new System.Drawing.Size(462, 98);
            this.secondProgressBar.TabIndex = 0;
            //
            // thirdProgressBar
            //
            this.thirdProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thirdProgressBar.Location = new System.Drawing.Point(159, 211);
            this.thirdProgressBar.Name = "thirdProgressBar";
            this.thirdProgressBar.Size = new System.Drawing.Size(462, 98);
            this.thirdProgressBar.TabIndex = 0;
            //
            // fourthProgressBar
            //
            this.fourthProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fourthProgressBar.Location = new System.Drawing.Point(159, 315);
            this.fourthProgressBar.Name = "fourthProgressBar";
            this.fourthProgressBar.Size = new System.Drawing.Size(462, 101);
            this.fourthProgressBar.TabIndex = 0;
            //
            // backgroundWorker
            //
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            //
            // MainForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(320, 240);
            this.Name = "MainForm";
            this.Text = "Impatient";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label fourthLabel;
        private System.Windows.Forms.ProgressBar firstProgressBar;
        private System.Windows.Forms.ProgressBar secondProgressBar;
        private System.Windows.Forms.ProgressBar thirdProgressBar;
        private System.Windows.Forms.ProgressBar fourthProgressBar;
    }
}
