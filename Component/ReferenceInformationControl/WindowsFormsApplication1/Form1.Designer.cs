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
            this.specificReferenceInformation1 = new ObjectsReferenceInformationControl.SpecificReferenceInformation();
            this.userControl12 = new ObjectsReferenceInformationControl.SpecificReferenceInformation();
            this.userControl11 = new ObjectsReferenceInformationControl.SpecificReferenceInformation();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(571, 64);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown1.TabIndex = 2;
            // 
            // specificReferenceInformation1
            // 
            this.specificReferenceInformation1.Id = null;
            this.specificReferenceInformation1.Location = new System.Drawing.Point(156, 286);
            this.specificReferenceInformation1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.specificReferenceInformation1.MyText = "Объекты";
            this.specificReferenceInformation1.Name = "specificReferenceInformation1";
            this.specificReferenceInformation1.Size = new System.Drawing.Size(148, 41);
            this.specificReferenceInformation1.TabIndex = 5;
            this.specificReferenceInformation1.SetUser += new System.EventHandler(this.setUser);
            // 
            // userControl12
            // 
            this.userControl12.Id = null;
            this.userControl12.Location = new System.Drawing.Point(476, 290);
            this.userControl12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControl12.MyText = "Скважины";
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(164, 36);
            this.userControl12.TabIndex = 4;
            this.userControl12.Type = ObjectsReferenceInformationControl.SpecificReferenceInformation.Types.Скважины;
            this.userControl12.SetUser += new System.EventHandler(this.setUser);
            // 
            // userControl11
            // 
            this.userControl11.Id = null;
            this.userControl11.Location = new System.Drawing.Point(781, 290);
            this.userControl11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userControl11.MyText = "Участки";
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(139, 48);
            this.userControl11.TabIndex = 3;
            this.userControl11.Type = ObjectsReferenceInformationControl.SpecificReferenceInformation.Types.Участки;
            this.userControl11.SetUser += new System.EventHandler(this.setUser);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 716);
            this.Controls.Add(this.specificReferenceInformation1);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private ObjectsReferenceInformationControl.SpecificReferenceInformation userControl11;
        private ObjectsReferenceInformationControl.SpecificReferenceInformation userControl12;
        private ObjectsReferenceInformationControl.SpecificReferenceInformation specificReferenceInformation1;
    }
}

