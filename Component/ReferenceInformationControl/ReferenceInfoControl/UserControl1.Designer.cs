namespace ReferenceInfoControl
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.objectsButton = new System.Windows.Forms.Button();
            this.sectorButton = new System.Windows.Forms.Button();
            this.wellsButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(609, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // objectListView1
            // 
            this.objectListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView1.CellEditUseWholeCell = false;
            this.objectListView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView1.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView1.Location = new System.Drawing.Point(6, 68);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(689, 413);
            this.objectListView1.TabIndex = 0;
            this.objectListView1.UseAlternatingBackColors = true;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.UseFiltering = true;
            this.objectListView1.UseHotItem = true;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListView1_MouseDoubleClick);
            // 
            // objectsButton
            // 
            this.objectsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.objectsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.objectsButton.Location = new System.Drawing.Point(242, 6);
            this.objectsButton.Name = "objectsButton";
            this.objectsButton.Size = new System.Drawing.Size(75, 23);
            this.objectsButton.TabIndex = 2;
            this.objectsButton.Text = "Объекты";
            this.objectsButton.UseVisualStyleBackColor = false;
            this.objectsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sectorButton
            // 
            this.sectorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sectorButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sectorButton.Location = new System.Drawing.Point(335, 6);
            this.sectorButton.Name = "sectorButton";
            this.sectorButton.Size = new System.Drawing.Size(75, 23);
            this.sectorButton.TabIndex = 3;
            this.sectorButton.Text = "Участки";
            this.sectorButton.UseVisualStyleBackColor = false;
            this.sectorButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // wellsButton
            // 
            this.wellsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wellsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.wellsButton.Location = new System.Drawing.Point(430, 6);
            this.wellsButton.Name = "wellsButton";
            this.wellsButton.Size = new System.Drawing.Size(75, 23);
            this.wellsButton.TabIndex = 4;
            this.wellsButton.Text = "Скважины";
            this.wellsButton.UseVisualStyleBackColor = false;
            this.wellsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(620, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 5;
            this.button4.Text = "Применить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, -21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 540);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.sectorButton);
            this.tabPage1.Controls.Add(this.wellsButton);
            this.tabPage1.Controls.Add(this.objectListView1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.objectsButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(701, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(756, 519);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objectListView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button objectsButton;
        private System.Windows.Forms.Button sectorButton;
        private System.Windows.Forms.Button wellsButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
    }
}
