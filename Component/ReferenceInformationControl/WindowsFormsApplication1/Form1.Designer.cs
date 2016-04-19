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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.userControl11 = new ObjectsReferenceInformationControl.UserControl1();
            this.userControl12 = new ReferenceInfoControl.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(428, 52);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(222, 52);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(76, 22);
            this.userControl11.TabIndex = 3;
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(21, 80);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(814, 534);
            this.userControl12.TabIndex = 4;
            this.userControl12.UserId = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 582);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private ObjectsReferenceInformationControl.UserControl1 userControl11;
        private ReferenceInfoControl.UserControl1 userControl12;
    }
}

