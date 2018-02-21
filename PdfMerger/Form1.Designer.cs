namespace PdfMerger
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnMergeAndSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(12, 12);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(131, 44);
            this.btnChoose.TabIndex = 0;
            this.btnChoose.Text = "Choose PDF Files";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnMergeAndSave
            // 
            this.btnMergeAndSave.Location = new System.Drawing.Point(159, 12);
            this.btnMergeAndSave.Name = "btnMergeAndSave";
            this.btnMergeAndSave.Size = new System.Drawing.Size(131, 44);
            this.btnMergeAndSave.TabIndex = 1;
            this.btnMergeAndSave.Text = "Merge And Save";
            this.btnMergeAndSave.UseVisualStyleBackColor = true;
            this.btnMergeAndSave.Click += new System.EventHandler(this.btnMergeAndSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 68);
            this.Controls.Add(this.btnMergeAndSave);
            this.Controls.Add(this.btnChoose);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Merger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnMergeAndSave;
    }
}

