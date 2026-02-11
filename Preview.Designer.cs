using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DS_Game_Maker
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Preview : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            PreviewPanel = new Panel();
            MainTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)MainTimer).BeginInit();
            SuspendLayout();
            // 
            // PreviewPanel
            // 
            PreviewPanel.BackColor = Color.White;
            PreviewPanel.BackgroundImageLayout = ImageLayout.Center;
            PreviewPanel.Location = new Point(47, 36);
            PreviewPanel.Name = "PreviewPanel";
            PreviewPanel.Size = new Size(64, 64);
            PreviewPanel.TabIndex = 0;
            // 
            // MainTimer
            // 
            MainTimer.Enabled = true;
            MainTimer.Interval = 2D;
            MainTimer.SynchronizingObject = this;
            MainTimer.Elapsed += MainTimer_Tick;
            // 
            // Preview
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(158, 136);
            Controls.Add(PreviewPanel);
            Font = new Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Preview";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sprite Preview";
            Load += Preview_Load;
            ((System.ComponentModel.ISupportInitialize)MainTimer).EndInit();
            ResumeLayout(false);

        }
        internal Panel PreviewPanel;
        internal System.Timers.Timer MainTimer;
    }
}