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
            this.userControl12 = new ObjectsReferenceInformationControl.SpecificReferenceInformation();
            this.userControl11 = new ObjectsReferenceInformationControl.SpecificReferenceInformation();
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
            // userControl12
            // 
            this.userControl12.Id = null;
            this.userControl12.Location = new System.Drawing.Point(213, 43);
            this.userControl12.MyText = "Скважины";
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(123, 29);
            this.userControl12.TabIndex = 4;
            this.userControl12.Type = ObjectsReferenceInformationControl.SpecificReferenceInformation.Types.Скважины;
            // 
            // userControl11
            // 
            this.userControl11.Id = null;
            this.userControl11.Location = new System.Drawing.Point(54, 33);
            this.userControl11.MyText = "Участки";
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(104, 39);
            this.userControl11.TabIndex = 3;
            this.userControl11.Type = ObjectsReferenceInformationControl.SpecificReferenceInformation.Types.Участки;
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
        private ObjectsReferenceInformationControl.SpecificReferenceInformation userControl11;
        private ObjectsReferenceInformationControl.SpecificReferenceInformation userControl12;
    }
}

