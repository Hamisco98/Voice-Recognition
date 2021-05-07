
namespace Voice_Recgnition_000
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
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.screen = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDisable
            // 
            this.btnDisable.Enabled = false;
            this.btnDisable.Location = new System.Drawing.Point(263, 326);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(208, 43);
            this.btnDisable.TabIndex = 0;
            this.btnDisable.Text = "Disable Voice";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Location = new System.Drawing.Point(39, 326);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(209, 43);
            this.btnEnable.TabIndex = 1;
            this.btnEnable.Text = "Enable Voice";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(39, 49);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(432, 244);
            this.screen.TabIndex = 2;
            this.screen.Text = " ==> Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 419);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.btnEnable);
            this.Controls.Add(this.btnDisable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voice Recognition 000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.RichTextBox screen;
    }
}

