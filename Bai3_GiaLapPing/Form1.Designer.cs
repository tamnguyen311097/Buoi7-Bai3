namespace Bai3_GiaLapPing
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPWeb = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap dia chi web hoac IP";
            // 
            // txtIPWeb
            // 
            this.txtIPWeb.Location = new System.Drawing.Point(12, 54);
            this.txtIPWeb.Name = "txtIPWeb";
            this.txtIPWeb.Size = new System.Drawing.Size(378, 22);
            this.txtIPWeb.TabIndex = 1;
            this.txtIPWeb.Validated += new System.EventHandler(this.txtIPWeb_Validated);
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(439, 50);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(107, 31);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(12, 104);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtOut.Size = new System.Drawing.Size(801, 230);
            this.txtOut.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 394);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.txtIPWeb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPWeb;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.TextBox txtOut;
    }
}

