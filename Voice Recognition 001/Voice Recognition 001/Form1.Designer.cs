
namespace Voice_Recognition_001
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.tmrSpeeking = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstCommands
            // 
            this.lstCommands.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCommands.ForeColor = System.Drawing.SystemColors.Info;
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.ItemHeight = 15;
            this.lstCommands.Location = new System.Drawing.Point(0, 0);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(898, 450);
            this.lstCommands.TabIndex = 0;
            this.lstCommands.Visible = false;
            // 
            // tmrSpeeking
            // 
            this.tmrSpeeking.Enabled = true;
            this.tmrSpeeking.Interval = 1000;
            this.tmrSpeeking.Tick += new System.EventHandler(this.tmrSpeeking_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.lstCommands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCommands;
        private System.Windows.Forms.Timer tmrSpeeking;
    }
}

