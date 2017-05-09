namespace GZipProject
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
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.DownloadBtn = new System.Windows.Forms.Button();
      this.GZipFileLbl = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(12, 74);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(552, 206);
      this.richTextBox1.TabIndex = 0;
      this.richTextBox1.Text = "";
      // 
      // DownloadBtn
      // 
      this.DownloadBtn.Location = new System.Drawing.Point(412, 34);
      this.DownloadBtn.Name = "DownloadBtn";
      this.DownloadBtn.Size = new System.Drawing.Size(152, 23);
      this.DownloadBtn.TabIndex = 1;
      this.DownloadBtn.Text = "Display";
      this.DownloadBtn.UseVisualStyleBackColor = true;
      this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
      // 
      // GZipFileLbl
      // 
      this.GZipFileLbl.AutoSize = true;
      this.GZipFileLbl.Location = new System.Drawing.Point(12, 34);
      this.GZipFileLbl.Name = "GZipFileLbl";
      this.GZipFileLbl.Size = new System.Drawing.Size(135, 13);
      this.GZipFileLbl.TabIndex = 2;
      this.GZipFileLbl.Text = "Файл: GZipFileExample.gz";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(576, 292);
      this.Controls.Add(this.GZipFileLbl);
      this.Controls.Add(this.DownloadBtn);
      this.Controls.Add(this.richTextBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Button DownloadBtn;
    private System.Windows.Forms.Label GZipFileLbl;
  }
}

