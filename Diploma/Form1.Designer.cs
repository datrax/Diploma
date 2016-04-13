using System.Windows.Forms;

namespace Diploma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.objectsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new Extended_textbox.ExtendedTextBox();
            this.textBox1 = new Extended_textbox.ExtendedTextBox();
            this.sectorsGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.extendedTextBox12 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox11 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox10 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox9 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox8 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox7 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox6 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox5 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox4 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox3 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox2 = new Extended_textbox.ExtendedTextBox();
            this.extendedTextBox1 = new Extended_textbox.ExtendedTextBox();
            this.wellsGrid = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.informationTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectsGrid)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wellsGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(598, 34);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(575, 484);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(598, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(598, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // objectsGrid
            // 
            this.objectsGrid.AllowUserToAddRows = false;
            this.objectsGrid.AllowUserToDeleteRows = false;
            this.objectsGrid.AllowUserToOrderColumns = true;
            this.objectsGrid.AllowUserToResizeRows = false;
            this.objectsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.objectsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.objectsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.objectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.objectsGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.objectsGrid.GridColor = System.Drawing.SystemColors.Control;
            this.objectsGrid.Location = new System.Drawing.Point(0, -4);
            this.objectsGrid.MultiSelect = false;
            this.objectsGrid.Name = "objectsGrid";
            this.objectsGrid.ReadOnly = true;
            this.objectsGrid.RowHeadersVisible = false;
            this.objectsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.objectsGrid.Size = new System.Drawing.Size(706, 500);
            this.objectsGrid.TabIndex = 6;
            this.objectsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseDoubleClick);
            this.objectsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(35, 150);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(864, 500);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.objectsGrid);
            this.tabPage1.Location = new System.Drawing.Point(154, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(706, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.sectorsGrid);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Cue = "Объект";
            this.textBox2.Location = new System.Drawing.Point(349, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Cue = "Имя";
            this.textBox1.Location = new System.Drawing.Point(35, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sectorsGrid
            // 
            this.sectorsGrid.AllowUserToAddRows = false;
            this.sectorsGrid.AllowUserToDeleteRows = false;
            this.sectorsGrid.AllowUserToResizeRows = false;
            this.sectorsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sectorsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sectorsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sectorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sectorsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.sectorsGrid.GridColor = System.Drawing.SystemColors.Control;
            this.sectorsGrid.Location = new System.Drawing.Point(0, 41);
            this.sectorsGrid.MultiSelect = false;
            this.sectorsGrid.Name = "sectorsGrid";
            this.sectorsGrid.ReadOnly = true;
            this.sectorsGrid.RowHeadersVisible = false;
            this.sectorsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sectorsGrid.Size = new System.Drawing.Size(706, 455);
            this.sectorsGrid.TabIndex = 7;
            this.sectorsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sectorsGrid_CellClick);
            this.sectorsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseDoubleClick);
            this.sectorsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.extendedTextBox12);
            this.tabPage3.Controls.Add(this.extendedTextBox11);
            this.tabPage3.Controls.Add(this.extendedTextBox10);
            this.tabPage3.Controls.Add(this.extendedTextBox9);
            this.tabPage3.Controls.Add(this.extendedTextBox8);
            this.tabPage3.Controls.Add(this.extendedTextBox7);
            this.tabPage3.Controls.Add(this.extendedTextBox6);
            this.tabPage3.Controls.Add(this.extendedTextBox5);
            this.tabPage3.Controls.Add(this.extendedTextBox4);
            this.tabPage3.Controls.Add(this.extendedTextBox3);
            this.tabPage3.Controls.Add(this.extendedTextBox2);
            this.tabPage3.Controls.Add(this.extendedTextBox1);
            this.tabPage3.Controls.Add(this.wellsGrid);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(706, 492);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // extendedTextBox12
            // 
            this.extendedTextBox12.Cue = "Фильтр. низ";
            this.extendedTextBox12.Location = new System.Drawing.Point(570, 30);
            this.extendedTextBox12.Name = "extendedTextBox12";
            this.extendedTextBox12.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox12.TabIndex = 31;
            // 
            // extendedTextBox11
            // 
            this.extendedTextBox11.Cue = "Фильтр. верх";
            this.extendedTextBox11.Location = new System.Drawing.Point(463, 30);
            this.extendedTextBox11.Name = "extendedTextBox11";
            this.extendedTextBox11.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox11.TabIndex = 30;
            // 
            // extendedTextBox10
            // 
            this.extendedTextBox10.Cue = "Горизонт";
            this.extendedTextBox10.Location = new System.Drawing.Point(356, 30);
            this.extendedTextBox10.Name = "extendedTextBox10";
            this.extendedTextBox10.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox10.TabIndex = 29;
            // 
            // extendedTextBox9
            // 
            this.extendedTextBox9.Cue = "Ур. Выс.";
            this.extendedTextBox9.Location = new System.Drawing.Point(249, 30);
            this.extendedTextBox9.Name = "extendedTextBox9";
            this.extendedTextBox9.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox9.TabIndex = 28;
            // 
            // extendedTextBox8
            // 
            this.extendedTextBox8.Cue = "Инд. Выс.";
            this.extendedTextBox8.Location = new System.Drawing.Point(142, 30);
            this.extendedTextBox8.Name = "extendedTextBox8";
            this.extendedTextBox8.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox8.TabIndex = 27;
            // 
            // extendedTextBox7
            // 
            this.extendedTextBox7.Cue = "Дата";
            this.extendedTextBox7.Location = new System.Drawing.Point(35, 31);
            this.extendedTextBox7.Name = "extendedTextBox7";
            this.extendedTextBox7.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox7.TabIndex = 26;
            // 
            // extendedTextBox6
            // 
            this.extendedTextBox6.Cue = "Заметка";
            this.extendedTextBox6.Location = new System.Drawing.Point(570, 3);
            this.extendedTextBox6.Name = "extendedTextBox6";
            this.extendedTextBox6.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox6.TabIndex = 25;
            // 
            // extendedTextBox5
            // 
            this.extendedTextBox5.Cue = "Глубина";
            this.extendedTextBox5.Location = new System.Drawing.Point(463, 3);
            this.extendedTextBox5.Name = "extendedTextBox5";
            this.extendedTextBox5.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox5.TabIndex = 24;
            // 
            // extendedTextBox4
            // 
            this.extendedTextBox4.Cue = "Y";
            this.extendedTextBox4.Location = new System.Drawing.Point(356, 3);
            this.extendedTextBox4.Name = "extendedTextBox4";
            this.extendedTextBox4.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox4.TabIndex = 23;
            // 
            // extendedTextBox3
            // 
            this.extendedTextBox3.Cue = "X";
            this.extendedTextBox3.Location = new System.Drawing.Point(249, 3);
            this.extendedTextBox3.Name = "extendedTextBox3";
            this.extendedTextBox3.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox3.TabIndex = 22;
            // 
            // extendedTextBox2
            // 
            this.extendedTextBox2.Cue = "Участок";
            this.extendedTextBox2.Location = new System.Drawing.Point(142, 3);
            this.extendedTextBox2.Name = "extendedTextBox2";
            this.extendedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox2.TabIndex = 21;
            // 
            // extendedTextBox1
            // 
            this.extendedTextBox1.Cue = "Имя";
            this.extendedTextBox1.Location = new System.Drawing.Point(35, 4);
            this.extendedTextBox1.Name = "extendedTextBox1";
            this.extendedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.extendedTextBox1.TabIndex = 20;
            this.extendedTextBox1.TextChanged += new System.EventHandler(this.extendedTextBox1_TextChanged);
            // 
            // wellsGrid
            // 
            this.wellsGrid.AllowUserToAddRows = false;
            this.wellsGrid.AllowUserToDeleteRows = false;
            this.wellsGrid.AllowUserToOrderColumns = true;
            this.wellsGrid.AllowUserToResizeRows = false;
            this.wellsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wellsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.wellsGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.wellsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.wellsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.wellsGrid.GridColor = System.Drawing.SystemColors.Control;
            this.wellsGrid.Location = new System.Drawing.Point(0, 55);
            this.wellsGrid.MultiSelect = false;
            this.wellsGrid.Name = "wellsGrid";
            this.wellsGrid.ReadOnly = true;
            this.wellsGrid.RowHeadersVisible = false;
            this.wellsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wellsGrid.Size = new System.Drawing.Size(703, 441);
            this.wellsGrid.TabIndex = 7;
            this.wellsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wellsGrid_CellClick);
            this.wellsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseDoubleClick);
            this.wellsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(154, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(706, 492);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(155, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 497);
            this.panel1.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(600, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "Редактировать";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(598, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 34);
            this.button6.TabIndex = 8;
            this.button6.Text = "Настроить доступ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(598, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(598, 180);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "Отменить редактирование";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(598, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Location = new System.Drawing.Point(155, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 514);
            this.panel4.TabIndex = 10;
            // 
            // informationTextBox
            // 
            this.informationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.informationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationTextBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.informationTextBox.Location = new System.Drawing.Point(3, 142);
            this.informationTextBox.Margin = new System.Windows.Forms.Padding(13, 3, 3, 3);
            this.informationTextBox.Name = "informationTextBox";
            this.informationTextBox.ReadOnly = true;
            this.informationTextBox.Size = new System.Drawing.Size(155, 355);
            this.informationTextBox.TabIndex = 11;
            this.informationTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(862, 499);
            this.Controls.Add(this.informationTextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.objectsGrid)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectorsGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wellsGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView objectsGrid;
        private DataGridViewTextBoxColumn Column1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView sectorsGrid;
        private DataGridView wellsGrid;
        private Panel panel1;
        private Panel panel4;
        private Extended_textbox.ExtendedTextBox textBox2;
        private Extended_textbox.ExtendedTextBox textBox1;
        private Extended_textbox.ExtendedTextBox extendedTextBox1;
        private Extended_textbox.ExtendedTextBox extendedTextBox12;
        private Extended_textbox.ExtendedTextBox extendedTextBox11;
        private Extended_textbox.ExtendedTextBox extendedTextBox10;
        private Extended_textbox.ExtendedTextBox extendedTextBox9;
        private Extended_textbox.ExtendedTextBox extendedTextBox8;
        private Extended_textbox.ExtendedTextBox extendedTextBox7;
        private Extended_textbox.ExtendedTextBox extendedTextBox6;
        private Extended_textbox.ExtendedTextBox extendedTextBox5;
        private Extended_textbox.ExtendedTextBox extendedTextBox4;
        private Extended_textbox.ExtendedTextBox extendedTextBox3;
        private Extended_textbox.ExtendedTextBox extendedTextBox2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button7;
        private RichTextBox informationTextBox;
    }
}

