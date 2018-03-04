namespace ReferenceInfoControl
{
    partial class GeneralReferenceInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralReferenceInformation));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.objectsButton = new System.Windows.Forms.Button();
            this.sectorButton = new System.Windows.Forms.Button();
            this.wellsButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.generalListView = new BrightIdeasSoftware.ObjectListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.uploadButton = new System.Windows.Forms.Button();
            this.fileInfoPanel = new System.Windows.Forms.Panel();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.fileVersionTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.chengedRadioButton = new System.Windows.Forms.RadioButton();
            this.privateRadioButton = new System.Windows.Forms.RadioButton();
            this.readonlyRadioButton = new System.Windows.Forms.RadioButton();
            this.editButton = new System.Windows.Forms.Button();
            this.cloneButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileListView = new BrightIdeasSoftware.ObjectListView();
            this.NameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AuthorColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.VersionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.DateColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.LastChange = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ExtendedSearch = new System.Windows.Forms.Button();
            this.ExtendedSearchField = new System.Windows.Forms.TextBox();
            this.searchFilesListView = new BrightIdeasSoftware.ObjectListView();
            this.NameColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalListView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.fileInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileListView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFilesListView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(939, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_Enter);
            this.textBox1.TextChanged += new System.EventHandler(this.FilterTextBoxTextChanged);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_Leave);
            // 
            // objectsButton
            // 
            this.objectsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.objectsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.objectsButton.Location = new System.Drawing.Point(249, 8);
            this.objectsButton.Margin = new System.Windows.Forms.Padding(4);
            this.objectsButton.Name = "objectsButton";
            this.objectsButton.Size = new System.Drawing.Size(100, 28);
            this.objectsButton.TabIndex = 2;
            this.objectsButton.Text = "Объекты";
            this.objectsButton.UseVisualStyleBackColor = false;
            this.objectsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sectorButton
            // 
            this.sectorButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sectorButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sectorButton.Location = new System.Drawing.Point(404, 8);
            this.sectorButton.Margin = new System.Windows.Forms.Padding(4);
            this.sectorButton.Name = "sectorButton";
            this.sectorButton.Size = new System.Drawing.Size(100, 28);
            this.sectorButton.TabIndex = 3;
            this.sectorButton.Text = "Участки";
            this.sectorButton.UseVisualStyleBackColor = false;
            this.sectorButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // wellsButton
            // 
            this.wellsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.wellsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.wellsButton.Location = new System.Drawing.Point(548, 8);
            this.wellsButton.Margin = new System.Windows.Forms.Padding(4);
            this.wellsButton.Name = "wellsButton";
            this.wellsButton.Size = new System.Drawing.Size(100, 28);
            this.wellsButton.TabIndex = 4;
            this.wellsButton.Text = "Скважины";
            this.wellsButton.UseVisualStyleBackColor = false;
            this.wellsButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(956, 43);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 25);
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1075, 680);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.sectorButton);
            this.tabPage1.Controls.Add(this.wellsButton);
            this.tabPage1.Controls.Add(this.generalListView);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.objectsButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1067, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button6.Location = new System.Drawing.Point(691, 8);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 28);
            this.button6.TabIndex = 21;
            this.button6.Text = "Искать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button5_Click);
            // 
            // generalListView
            // 
            this.generalListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalListView.CellEditUseWholeCell = false;
            this.generalListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.generalListView.EmptyListMsg = "Ничего не найдено";
            this.generalListView.FullRowSelect = true;
            this.generalListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.generalListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.generalListView.Location = new System.Drawing.Point(9, 76);
            this.generalListView.Margin = new System.Windows.Forms.Padding(4);
            this.generalListView.MultiSelect = false;
            this.generalListView.Name = "generalListView";
            this.generalListView.ShowGroups = false;
            this.generalListView.Size = new System.Drawing.Size(1047, 567);
            this.generalListView.TabIndex = 0;
            this.generalListView.UseAlternatingBackColors = true;
            this.generalListView.UseCompatibleStateImageBehavior = false;
            this.generalListView.UseFiltering = true;
            this.generalListView.UseHotItem = true;
            this.generalListView.View = System.Windows.Forms.View.Details;
            this.generalListView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.objectListView1_KeyDown);
            this.generalListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListView1_MouseDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.editPanel);
            this.tabPage2.Controls.Add(this.fileInfoPanel);
            this.tabPage2.Controls.Add(this.editButton);
            this.tabPage2.Controls.Add(this.cloneButton);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.deleteButton);
            this.tabPage2.Controls.Add(this.openButton);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.fileListView);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1067, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(475, 48);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Группировать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.GroupsTextBoxCheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(604, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Искать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(705, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 18;
            // 
            // editPanel
            // 
            this.editPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPanel.Controls.Add(this.cancelButton);
            this.editPanel.Controls.Add(this.uploadButton);
            this.editPanel.Enabled = false;
            this.editPanel.Location = new System.Drawing.Point(928, 245);
            this.editPanel.Margin = new System.Windows.Forms.Padding(4);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(136, 78);
            this.editPanel.TabIndex = 17;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(0, 36);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(129, 28);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(1, 0);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(4);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(128, 28);
            this.uploadButton.TabIndex = 15;
            this.uploadButton.Text = " На сервер";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.UploadButtonClick);
            // 
            // fileInfoPanel
            // 
            this.fileInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInfoPanel.Controls.Add(this.saveEditButton);
            this.fileInfoPanel.Controls.Add(this.fileVersionTextBox);
            this.fileInfoPanel.Controls.Add(this.fileNameTextBox);
            this.fileInfoPanel.Controls.Add(this.chengedRadioButton);
            this.fileInfoPanel.Controls.Add(this.privateRadioButton);
            this.fileInfoPanel.Controls.Add(this.readonlyRadioButton);
            this.fileInfoPanel.Location = new System.Drawing.Point(929, 366);
            this.fileInfoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.fileInfoPanel.Name = "fileInfoPanel";
            this.fileInfoPanel.Size = new System.Drawing.Size(143, 226);
            this.fileInfoPanel.TabIndex = 14;
            this.fileInfoPanel.Visible = false;
            // 
            // saveEditButton
            // 
            this.saveEditButton.Location = new System.Drawing.Point(1, 164);
            this.saveEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(120, 28);
            this.saveEditButton.TabIndex = 16;
            this.saveEditButton.Text = "Сохранить";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.SaveEditPanelClick);
            // 
            // fileVersionTextBox
            // 
            this.fileVersionTextBox.Location = new System.Drawing.Point(1, 132);
            this.fileVersionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileVersionTextBox.Name = "fileVersionTextBox";
            this.fileVersionTextBox.Size = new System.Drawing.Size(119, 22);
            this.fileVersionTextBox.TabIndex = 15;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(1, 100);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(119, 22);
            this.fileNameTextBox.TabIndex = 14;
            // 
            // chengedRadioButton
            // 
            this.chengedRadioButton.AutoSize = true;
            this.chengedRadioButton.Location = new System.Drawing.Point(3, 15);
            this.chengedRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.chengedRadioButton.Name = "chengedRadioButton";
            this.chengedRadioButton.Size = new System.Drawing.Size(114, 21);
            this.chengedRadioButton.TabIndex = 11;
            this.chengedRadioButton.TabStop = true;
            this.chengedRadioButton.Text = "Изменяемый";
            this.chengedRadioButton.UseVisualStyleBackColor = true;
            // 
            // privateRadioButton
            // 
            this.privateRadioButton.AutoSize = true;
            this.privateRadioButton.Location = new System.Drawing.Point(3, 71);
            this.privateRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.privateRadioButton.Name = "privateRadioButton";
            this.privateRadioButton.Size = new System.Drawing.Size(103, 21);
            this.privateRadioButton.TabIndex = 13;
            this.privateRadioButton.TabStop = true;
            this.privateRadioButton.Text = "Приватный";
            this.privateRadioButton.UseVisualStyleBackColor = true;
            // 
            // readonlyRadioButton
            // 
            this.readonlyRadioButton.AutoSize = true;
            this.readonlyRadioButton.Location = new System.Drawing.Point(3, 43);
            this.readonlyRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.readonlyRadioButton.Name = "readonlyRadioButton";
            this.readonlyRadioButton.Size = new System.Drawing.Size(127, 21);
            this.readonlyRadioButton.TabIndex = 12;
            this.readonlyRadioButton.TabStop = true;
            this.readonlyRadioButton.Text = "Только чтение";
            this.readonlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Location = new System.Drawing.Point(929, 194);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(129, 28);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.EditButtonClick);
            // 
            // cloneButton
            // 
            this.cloneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cloneButton.Location = new System.Drawing.Point(929, 159);
            this.cloneButton.Margin = new System.Windows.Forms.Padding(4);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(129, 28);
            this.cloneButton.TabIndex = 8;
            this.cloneButton.Text = "Клонировать";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(475, 30);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 21);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Плитки";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.TileCheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 39);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(370, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_Enter);
            this.textBox2.TextChanged += new System.EventHandler(this.FileFilterTextBoxTextChanged);
            this.textBox2.MouseEnter += new System.EventHandler(this.textBox1_Enter);
            this.textBox2.MouseLeave += new System.EventHandler(this.textBox1_Leave);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(931, 330);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(129, 28);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(929, 69);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(129, 28);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Открыть";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButtonClick);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(929, 123);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddFileButtonClick);
            // 
            // fileListView
            // 
            this.fileListView.AllColumns.Add(this.NameColumn);
            this.fileListView.AllColumns.Add(this.AuthorColumn);
            this.fileListView.AllColumns.Add(this.VersionColumn);
            this.fileListView.AllColumns.Add(this.DateColumn);
            this.fileListView.AllColumns.Add(this.LastChange);
            this.fileListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileListView.CellEditUseWholeCell = false;
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn,
            this.AuthorColumn,
            this.VersionColumn,
            this.DateColumn,
            this.LastChange});
            this.fileListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileListView.EmptyListMsg = "Нет файлов";
            this.fileListView.FullRowSelect = true;
            this.fileListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.fileListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.fileListView.LargeImageList = this.imageList1;
            this.fileListView.Location = new System.Drawing.Point(9, 69);
            this.fileListView.Margin = new System.Windows.Forms.Padding(4);
            this.fileListView.Name = "fileListView";
            this.fileListView.ShowGroups = false;
            this.fileListView.ShowImagesOnSubItems = true;
            this.fileListView.Size = new System.Drawing.Size(911, 521);
            this.fileListView.SmallImageList = this.imageList1;
            this.fileListView.TabIndex = 1;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.UseFiltering = true;
            this.fileListView.View = System.Windows.Forms.View.Details;
            this.fileListView.SelectionChanged += new System.EventHandler(this.FileListView_SelectionChanged);
            this.fileListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.FileListColumnClick);
            this.fileListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.objectListView2_MouseDoubleClick);
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
            // LastChange
            // 
            this.LastChange.AspectName = "LastChangeUserName";
            this.LastChange.IsTileViewColumn = true;
            this.LastChange.Text = "Посл. Изм.";
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
            this.button1.Location = new System.Drawing.Point(9, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoBackButtonClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Controls.Add(this.ExtendedSearch);
            this.tabPage3.Controls.Add(this.ExtendedSearchField);
            this.tabPage3.Controls.Add(this.searchFilesListView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1067, 651);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 38);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 26);
            this.button3.TabIndex = 4;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(111, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(465, 84);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ExtendedSearch
            // 
            this.ExtendedSearch.Location = new System.Drawing.Point(857, 39);
            this.ExtendedSearch.Name = "ExtendedSearch";
            this.ExtendedSearch.Size = new System.Drawing.Size(75, 23);
            this.ExtendedSearch.TabIndex = 1;
            this.ExtendedSearch.Text = "Искать";
            this.ExtendedSearch.UseVisualStyleBackColor = true;
            this.ExtendedSearch.Click += new System.EventHandler(this.ExtendedSearch_Click);
            // 
            // ExtendedSearchField
            // 
            this.ExtendedSearchField.Location = new System.Drawing.Point(111, 40);
            this.ExtendedSearchField.Name = "ExtendedSearchField";
            this.ExtendedSearchField.Size = new System.Drawing.Size(740, 22);
            this.ExtendedSearchField.TabIndex = 0;
            this.ExtendedSearchField.TextChanged += new System.EventHandler(this.ExtendedSearchField_TextChanged);
            // 
            // searchFilesListView
            // 
            this.searchFilesListView.AllColumns.Add(this.NameColumn2);
            this.searchFilesListView.AllColumns.Add(this.olvColumn6);
            this.searchFilesListView.AllColumns.Add(this.olvColumn2);
            this.searchFilesListView.AllColumns.Add(this.olvColumn3);
            this.searchFilesListView.AllColumns.Add(this.olvColumn4);
            this.searchFilesListView.AllColumns.Add(this.olvColumn5);
            this.searchFilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFilesListView.CellEditUseWholeCell = false;
            this.searchFilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameColumn2,
            this.olvColumn6,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.searchFilesListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchFilesListView.EmptyListMsg = "Нет файлов";
            this.searchFilesListView.FullRowSelect = true;
            this.searchFilesListView.HighlightBackgroundColor = System.Drawing.Color.Empty;
            this.searchFilesListView.HighlightForegroundColor = System.Drawing.Color.Empty;
            this.searchFilesListView.LargeImageList = this.imageList1;
            this.searchFilesListView.Location = new System.Drawing.Point(4, 69);
            this.searchFilesListView.Margin = new System.Windows.Forms.Padding(4);
            this.searchFilesListView.Name = "searchFilesListView";
            this.searchFilesListView.ShowGroups = false;
            this.searchFilesListView.ShowImagesOnSubItems = true;
            this.searchFilesListView.Size = new System.Drawing.Size(1044, 578);
            this.searchFilesListView.SmallImageList = this.imageList1;
            this.searchFilesListView.TabIndex = 3;
            this.searchFilesListView.UseCompatibleStateImageBehavior = false;
            this.searchFilesListView.UseFiltering = true;
            this.searchFilesListView.View = System.Windows.Forms.View.Details;
            this.searchFilesListView.SelectedIndexChanged += new System.EventHandler(this.searchFilesListView_SelectedIndexChanged);
            // 
            // NameColumn2
            // 
            this.NameColumn2.AspectName = "Name";
            this.NameColumn2.IsTileViewColumn = true;
            this.NameColumn2.Text = "Имя";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Path";
            this.olvColumn6.Text = "Путь";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "AuthorName";
            this.olvColumn2.IsTileViewColumn = true;
            this.olvColumn2.Text = "Автор";
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Version";
            this.olvColumn3.IsTileViewColumn = true;
            this.olvColumn3.Text = "Версия";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "dateTime";
            this.olvColumn4.Text = "Дата";
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "LastChangeUserName";
            this.olvColumn5.IsTileViewColumn = true;
            this.olvColumn5.Text = "Посл. Изм.";
            // 
            // GeneralReferenceInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GeneralReferenceInformation";
            this.Size = new System.Drawing.Size(1083, 684);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalListView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.fileInfoPanel.ResumeLayout(false);
            this.fileInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileListView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchFilesListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView generalListView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button objectsButton;
        private System.Windows.Forms.Button sectorButton;
        private System.Windows.Forms.Button wellsButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private BrightIdeasSoftware.ObjectListView fileListView;
        private BrightIdeasSoftware.OLVColumn NameColumn;
        private BrightIdeasSoftware.OLVColumn AuthorColumn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private BrightIdeasSoftware.OLVColumn VersionColumn;
        private BrightIdeasSoftware.OLVColumn DateColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button cloneButton;
        private System.Windows.Forms.RadioButton privateRadioButton;
        private System.Windows.Forms.RadioButton readonlyRadioButton;
        private System.Windows.Forms.RadioButton chengedRadioButton;
        private System.Windows.Forms.Panel fileInfoPanel;
        private System.Windows.Forms.Button saveEditButton;
        private System.Windows.Forms.TextBox fileVersionTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button cancelButton;
        private BrightIdeasSoftware.OLVColumn LastChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ExtendedSearch;
        private System.Windows.Forms.TextBox ExtendedSearchField;
        private System.Windows.Forms.ListBox listBox1;
        private BrightIdeasSoftware.ObjectListView searchFilesListView;
        private BrightIdeasSoftware.OLVColumn NameColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
    }
}
