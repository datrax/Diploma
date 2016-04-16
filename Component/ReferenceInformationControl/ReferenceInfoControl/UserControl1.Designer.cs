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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.objectsButton = new System.Windows.Forms.Button();
            this.sectorButton = new System.Windows.Forms.Button();
            this.wellsButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.objectListView2 = new BrightIdeasSoftware.ObjectListView();
            this.NameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AuthorColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.VersionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(650, 20);
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
            this.objectListView1.EmptyListMsg = "Ничего не найдено";
            this.objectListView1.FullRowSelect = true;
            this.objectListView1.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView1.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView1.Location = new System.Drawing.Point(6, 68);
            this.objectListView1.MultiSelect = false;
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(730, 413);
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
            this.objectsButton.Location = new System.Drawing.Point(263, 6);
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
            this.sectorButton.Location = new System.Drawing.Point(356, 6);
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
            this.wellsButton.Location = new System.Drawing.Point(451, 6);
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
            this.button4.Location = new System.Drawing.Point(661, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 20);
            this.button4.TabIndex = 5;
            this.button4.Text = "Применить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 513);
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
            this.tabPage1.Size = new System.Drawing.Size(742, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.objectListView2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(90, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(648, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Открыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(648, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // objectListView2
            // 
            this.objectListView2.AllColumns.Add(this.NameColumn);
            this.objectListView2.AllColumns.Add(this.AuthorColumn);
            this.objectListView2.AllColumns.Add(this.VersionColumn);
            this.objectListView2.AllColumns.Add(this.DateColumn);
            this.objectListView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView2.CellEditUseWholeCell = false;
            this.objectListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.AuthorColumn,
            this.VersionColumn,
            this.DateColumn});
            this.objectListView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView2.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.objectListView2.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.objectListView2.LargeImageList = this.imageList1;
            this.objectListView2.Location = new System.Drawing.Point(7, 38);
            this.objectListView2.Name = "objectListView2";
            this.objectListView2.ShowGroups = false;
            this.objectListView2.ShowImagesOnSubItems = true;
            this.objectListView2.Size = new System.Drawing.Size(626, 443);
            this.objectListView2.SmallImageList = this.imageList1;
            this.objectListView2.TabIndex = 1;
            this.objectListView2.UseCompatibleStateImageBehavior = false;
            this.objectListView2.View = System.Windows.Forms.View.Tile;
            this.objectListView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.objectListView2_ColumnClick);
            this.objectListView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListView2_MouseDoubleClick);
            // 
            // NameColumn
            // 
            this.NameColumn.AspectName = "Name";
            this.NameColumn.IsTileViewColumn = true;
            this.NameColumn.Text = "Имя";
            // 
            // AuthorColumn
            // 
            this.AuthorColumn.AspectName = "AuthorName";
            this.AuthorColumn.IsTileViewColumn = true;
            this.AuthorColumn.Text = "Автор";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "common.ico");
            this.imageList1.Images.SetKeyName(1, "txt.ico");
            this.imageList1.Images.SetKeyName(2, "doc.ico");
            this.imageList1.Images.SetKeyName(3, "docx.ico");
            this.imageList1.Images.SetKeyName(4, "img.ico");
            this.imageList1.Images.SetKeyName(5, "pdf.ico");
            this.imageList1.Images.SetKeyName(6, "video.ico");
            this.imageList1.Images.SetKeyName(7, "audio.ico");
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
            // VersionColumn
            // 
            this.VersionColumn.AspectName = "Version";
            this.VersionColumn.IsTileViewColumn = true;
            this.VersionColumn.Text = "Версия";
            // 
            // DateColumn
            // 
            this.DateColumn.AspectName = "dateTime";
            this.DateColumn.Text = "Дата";
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
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView2)).EndInit();
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
        private BrightIdeasSoftware.ObjectListView objectListView2;
        private BrightIdeasSoftware.OLVColumn NameColumn;
        private BrightIdeasSoftware.OLVColumn AuthorColumn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private BrightIdeasSoftware.OLVColumn VersionColumn;
        private BrightIdeasSoftware.OLVColumn DateColumn;
    }
}
