namespace NiehausResume
{
    partial class Explain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explain));
            this.lbl_ExplainHeader = new System.Windows.Forms.Label();
            this.btn_ExplainOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ExplainHeader
            // 
            this.lbl_ExplainHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ExplainHeader.Location = new System.Drawing.Point(12, 62);
            this.lbl_ExplainHeader.Name = "lbl_ExplainHeader";
            this.lbl_ExplainHeader.Size = new System.Drawing.Size(920, 261);
            this.lbl_ExplainHeader.TabIndex = 0;
            this.lbl_ExplainHeader.Text = "**text**";
            this.lbl_ExplainHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ExplainOK
            // 
            this.btn_ExplainOK.Location = new System.Drawing.Point(377, 372);
            this.btn_ExplainOK.Name = "btn_ExplainOK";
            this.btn_ExplainOK.Size = new System.Drawing.Size(190, 61);
            this.btn_ExplainOK.TabIndex = 1;
            this.btn_ExplainOK.Text = "OK";
            this.btn_ExplainOK.UseVisualStyleBackColor = true;
            this.btn_ExplainOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Explain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 477);
            this.Controls.Add(this.btn_ExplainOK);
            this.Controls.Add(this.lbl_ExplainHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Explain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Explain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ExplainHeader;
        private System.Windows.Forms.Button btn_ExplainOK;
    }
}