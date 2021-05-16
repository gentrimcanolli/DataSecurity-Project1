namespace Detyra___FrequencyAnalysis
{
    partial class EncryptDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCelesi = new System.Windows.Forms.TextBox();
            this.btnDergo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the key:";
            // 
            // txtCelesi
            // 
            this.txtCelesi.Location = new System.Drawing.Point(95, 66);
            this.txtCelesi.Name = "txtCelesi";
            this.txtCelesi.Size = new System.Drawing.Size(117, 22);
            this.txtCelesi.TabIndex = 1;
            // 
            // btnDergo
            // 
            this.btnDergo.Location = new System.Drawing.Point(108, 106);
            this.btnDergo.Name = "btnDergo";
            this.btnDergo.Size = new System.Drawing.Size(86, 40);
            this.btnDergo.TabIndex = 2;
            this.btnDergo.Text = "Enter";
            this.btnDergo.UseVisualStyleBackColor = true;
            this.btnDergo.Click += new System.EventHandler(this.btnDergo_Click);
            // 
            // EncryptDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(295, 158);
            this.Controls.Add(this.btnDergo);
            this.Controls.Add(this.txtCelesi);
            this.Controls.Add(this.label1);
            this.Name = "EncryptDialog";
            this.Text = "Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCelesi;
        private System.Windows.Forms.Button btnDergo;
    }
}