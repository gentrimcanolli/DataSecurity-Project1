namespace Detyra___FrequencyAnalysis
{
    partial class Forma
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
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(22, 28);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(470, 22);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(521, 22);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(93, 34);
            this.btnFilePath.TabIndex = 1;
            this.btnFilePath.Text = "Load File";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 147);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(643, 347);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(167, 79);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(111, 41);
            this.btnEncrypt.TabIndex = 3;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(323, 79);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(153, 41);
            this.btnAnalyse.TabIndex = 4;
            this.btnAnalyse.Text = "Analyse and Decrypt";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(34, 79);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(111, 41);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 506);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnAnalyse);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.txtFilePath);
            this.Name = "Forma";
            this.Text = "Caesar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Button btnRead;
    }
}

