namespace WFA23100508
{
    partial class FrmMain
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
            this.lblUI01 = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.pnlMatrixContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblUI01
            // 
            this.lblUI01.AutoSize = true;
            this.lblUI01.Location = new System.Drawing.Point(13, 24);
            this.lblUI01.Name = "lblUI01";
            this.lblUI01.Size = new System.Drawing.Size(73, 20);
            this.lblUI01.TabIndex = 0;
            this.lblUI01.Text = "Karakter:";
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(92, 21);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(49, 26);
            this.txtLetter.TabIndex = 1;
            // 
            // pnlMatrixContainer
            // 
            this.pnlMatrixContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMatrixContainer.AutoSize = true;
            this.pnlMatrixContainer.Location = new System.Drawing.Point(12, 68);
            this.pnlMatrixContainer.Name = "pnlMatrixContainer";
            this.pnlMatrixContainer.Size = new System.Drawing.Size(129, 57);
            this.pnlMatrixContainer.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(153, 137);
            this.Controls.Add(this.pnlMatrixContainer);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.lblUI01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Karakter-dekódoló GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUI01;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Panel pnlMatrixContainer;
    }
}

