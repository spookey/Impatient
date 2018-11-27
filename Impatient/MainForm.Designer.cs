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
            this.components = new System.ComponentModel.Container();
            this.boxFst = new System.Windows.Forms.GroupBox();
            this.txtFst = new System.Windows.Forms.Label();
            this.barFst = new System.Windows.Forms.ProgressBar();
            this.boxScd = new System.Windows.Forms.GroupBox();
            this.txtScd = new System.Windows.Forms.Label();
            this.barScd = new System.Windows.Forms.ProgressBar();
            this.boxTrd = new System.Windows.Forms.GroupBox();
            this.txtTrd = new System.Windows.Forms.Label();
            this.barTrd = new System.Windows.Forms.ProgressBar();
            this.theTimer = new System.Windows.Forms.Timer(this.components);
            this.boxFst.SuspendLayout();
            this.boxScd.SuspendLayout();
            this.boxTrd.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxFst
            // 
            this.boxFst.Controls.Add(this.txtFst);
            this.boxFst.Controls.Add(this.barFst);
            this.boxFst.Location = new System.Drawing.Point(12, 12);
            this.boxFst.Name = "boxFst";
            this.boxFst.Size = new System.Drawing.Size(600, 135);
            this.boxFst.TabIndex = 0;
            this.boxFst.TabStop = false;
            this.boxFst.Text = "First";
            // 
            // txtFst
            // 
            this.txtFst.AutoSize = true;
            this.txtFst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtFst.Location = new System.Drawing.Point(6, 48);
            this.txtFst.Name = "txtFst";
            this.txtFst.Size = new System.Drawing.Size(35, 15);
            this.txtFst.TabIndex = 0;
            this.txtFst.Text = "NaN";
            // 
            // barFst
            // 
            this.barFst.Location = new System.Drawing.Point(6, 18);
            this.barFst.Name = "barFst";
            this.barFst.Size = new System.Drawing.Size(586, 24);
            this.barFst.TabIndex = 0;
            // 
            // boxScd
            // 
            this.boxScd.Controls.Add(this.txtScd);
            this.boxScd.Controls.Add(this.barScd);
            this.boxScd.Location = new System.Drawing.Point(12, 153);
            this.boxScd.Name = "boxScd";
            this.boxScd.Size = new System.Drawing.Size(600, 135);
            this.boxScd.TabIndex = 0;
            this.boxScd.TabStop = false;
            this.boxScd.Text = "Second";
            // 
            // txtScd
            // 
            this.txtScd.AutoSize = true;
            this.txtScd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtScd.Location = new System.Drawing.Point(6, 48);
            this.txtScd.Name = "txtScd";
            this.txtScd.Size = new System.Drawing.Size(35, 15);
            this.txtScd.TabIndex = 0;
            this.txtScd.Text = "NaN";
            // 
            // barScd
            // 
            this.barScd.Location = new System.Drawing.Point(6, 18);
            this.barScd.Name = "barScd";
            this.barScd.Size = new System.Drawing.Size(586, 24);
            this.barScd.TabIndex = 0;
            // 
            // boxTrd
            // 
            this.boxTrd.Controls.Add(this.txtTrd);
            this.boxTrd.Controls.Add(this.barTrd);
            this.boxTrd.Location = new System.Drawing.Point(12, 294);
            this.boxTrd.Name = "boxTrd";
            this.boxTrd.Size = new System.Drawing.Size(600, 135);
            this.boxTrd.TabIndex = 0;
            this.boxTrd.TabStop = false;
            this.boxTrd.Text = "Final";
            // 
            // txtTrd
            // 
            this.txtTrd.AutoSize = true;
            this.txtTrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtTrd.Location = new System.Drawing.Point(6, 48);
            this.txtTrd.Name = "txtTrd";
            this.txtTrd.Size = new System.Drawing.Size(35, 15);
            this.txtTrd.TabIndex = 0;
            this.txtTrd.Text = "NaN";
            // 
            // barTrd
            // 
            this.barTrd.Location = new System.Drawing.Point(6, 18);
            this.barTrd.Name = "barTrd";
            this.barTrd.Size = new System.Drawing.Size(586, 24);
            this.barTrd.TabIndex = 0;
            // 
            // theTimer
            // 
            this.theTimer.Interval = 125;
            this.theTimer.Tick += new System.EventHandler(this.TheTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.boxTrd);
            this.Controls.Add(this.boxScd);
            this.Controls.Add(this.boxFst);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Impatient";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.boxFst.ResumeLayout(false);
            this.boxFst.PerformLayout();
            this.boxScd.ResumeLayout(false);
            this.boxScd.PerformLayout();
            this.boxTrd.ResumeLayout(false);
            this.boxTrd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox boxFst;
        private System.Windows.Forms.GroupBox boxScd;
        private System.Windows.Forms.GroupBox boxTrd;
        private System.Windows.Forms.ProgressBar barFst;
        private System.Windows.Forms.ProgressBar barScd;
        private System.Windows.Forms.ProgressBar barTrd;
        private System.Windows.Forms.Label txtFst;
        private System.Windows.Forms.Label txtScd;
        private System.Windows.Forms.Label txtTrd;
        private System.Windows.Forms.Timer theTimer;
    }
}

