namespace WindowsFormsApplication1
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
            this.userControl12 = new ObjectsReferenceInformationControl.UserControl1();
            this.userControl11 = new ReferenceInfoControl.UserControl1();
            this.SuspendLayout();
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(25, -30);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(148, 69);
            this.userControl12.TabIndex = 1;
            // 
            // userControl11
            // 
            this.userControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl11.Location = new System.Drawing.Point(3, 35);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(808, 546);
            this.userControl11.TabIndex = 0;
            this.userControl11.UserId = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 582);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ReferenceInfoControl.UserControl1 userControl11;
        private ObjectsReferenceInformationControl.UserControl1 userControl12;
    }
}

