
namespace Voice_Recognition_002
{
    partial class Ema
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
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCommands
            // 
            this.lstCommands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lstCommands.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.ItemHeight = 15;
            this.lstCommands.Location = new System.Drawing.Point(658, 0);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(242, 450);
            this.lstCommands.TabIndex = 0;
            this.lstCommands.Visible = false;
            // 
            // Ema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.lstCommands);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ema";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCommands;
    }
}

