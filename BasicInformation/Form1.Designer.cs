namespace BasicInformation
{
    partial class Form1
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
            this.btndisplay = new System.Windows.Forms.Button();
            this.rtxtshow = new System.Windows.Forms.RichTextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndisplay
            // 
            this.btndisplay.Location = new System.Drawing.Point(83, 12);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(75, 23);
            this.btndisplay.TabIndex = 0;
            this.btndisplay.Text = "DISPLAY";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // rtxtshow
            // 
            this.rtxtshow.Location = new System.Drawing.Point(12, 42);
            this.rtxtshow.Name = "rtxtshow";
            this.rtxtshow.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtxtshow.Size = new System.Drawing.Size(287, 145);
            this.rtxtshow.TabIndex = 1;
            this.rtxtshow.Text = "";
            this.rtxtshow.TextChanged += new System.EventHandler(this.rtxtshow_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(83, 193);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 268);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.rtxtshow);
            this.Controls.Add(this.btndisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.RichTextBox rtxtshow;
        private System.Windows.Forms.Button btnsave;
    }
}

