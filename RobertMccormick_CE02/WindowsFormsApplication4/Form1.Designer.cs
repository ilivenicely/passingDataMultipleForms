namespace WindowsFormsApplication4
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
            this.LeftItems = new System.Windows.Forms.ListBox();
            this.RightItems = new System.Windows.Forms.ListBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnDeselect = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddToList2 = new System.Windows.Forms.Button();
            this.AddToLeftList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.clear2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftItems
            // 
            this.LeftItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftItems.FormattingEnabled = true;
            this.LeftItems.IntegralHeight = false;
            this.LeftItems.ItemHeight = 25;
            this.LeftItems.Items.AddRange(new object[] {
            "Left Items:"});
            this.LeftItems.Location = new System.Drawing.Point(6, 6);
            this.LeftItems.Margin = new System.Windows.Forms.Padding(6);
            this.LeftItems.Name = "LeftItems";
            this.tableLayoutPanel1.SetRowSpan(this.LeftItems, 4);
            this.LeftItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LeftItems.Size = new System.Drawing.Size(274, 257);
            this.LeftItems.TabIndex = 0;
            this.LeftItems.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // RightItems
            // 
            this.RightItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightItems.FormattingEnabled = true;
            this.RightItems.IntegralHeight = false;
            this.RightItems.ItemHeight = 25;
            this.RightItems.Items.AddRange(new object[] {
            "Right Items:"});
            this.RightItems.Location = new System.Drawing.Point(444, 6);
            this.RightItems.Margin = new System.Windows.Forms.Padding(6);
            this.RightItems.Name = "RightItems";
            this.tableLayoutPanel1.SetRowSpan(this.RightItems, 4);
            this.RightItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.RightItems.Size = new System.Drawing.Size(275, 257);
            this.RightItems.TabIndex = 1;
            this.RightItems.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelect.Location = new System.Drawing.Point(334, 18);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(6);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(56, 44);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = ">";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnLeft_Click_1);
            // 
            // btnDeselect
            // 
            this.btnDeselect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeselect.Location = new System.Drawing.Point(334, 212);
            this.btnDeselect.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeselect.Name = "btnDeselect";
            this.btnDeselect.Size = new System.Drawing.Size(56, 44);
            this.btnDeselect.TabIndex = 4;
            this.btnDeselect.Text = "<";
            this.btnDeselect.UseVisualStyleBackColor = true;
            this.btnDeselect.Click += new System.EventHandler(this.btnRight_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LeftItems, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RightItems, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeselect, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSelect, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 66);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.03802F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.39164F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 269);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // AddToList2
            // 
            this.AddToList2.Location = new System.Drawing.Point(466, 410);
            this.AddToList2.Name = "AddToList2";
            this.AddToList2.Size = new System.Drawing.Size(267, 41);
            this.AddToList2.TabIndex = 7;
            this.AddToList2.Text = "Add2";
            this.AddToList2.UseVisualStyleBackColor = true;
            this.AddToList2.Click += new System.EventHandler(this.AddToList2_Click);
            // 
            // AddToLeftList
            // 
            this.AddToLeftList.Location = new System.Drawing.Point(36, 408);
            this.AddToLeftList.Name = "AddToLeftList";
            this.AddToLeftList.Size = new System.Drawing.Size(266, 43);
            this.AddToLeftList.TabIndex = 8;
            this.AddToLeftList.Text = "Add1";
            this.AddToLeftList.UseVisualStyleBackColor = true;
            this.AddToLeftList.Click += new System.EventHandler(this.AddToLeftList_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 31);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(466, 358);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 31);
            this.textBox2.TabIndex = 10;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(36, 476);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(266, 38);
            this.clear.TabIndex = 11;
            this.clear.Text = "clear1";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // clear2
            // 
            this.clear2.Location = new System.Drawing.Point(466, 476);
            this.clear2.Name = "clear2";
            this.clear2.Size = new System.Drawing.Size(267, 38);
            this.clear2.TabIndex = 12;
            this.clear2.Text = "clear2";
            this.clear2.UseVisualStyleBackColor = true;
            this.clear2.Click += new System.EventHandler(this.clear2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 40);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.extToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(166, 38);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(166, 38);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // extToolStripMenuItem
            // 
            this.extToolStripMenuItem.Name = "extToolStripMenuItem";
            this.extToolStripMenuItem.Size = new System.Drawing.Size(166, 38);
            this.extToolStripMenuItem.Text = "Exit";
            this.extToolStripMenuItem.Click += new System.EventHandler(this.extToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statsToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // statsToolStripMenuItem
            // 
            this.statsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statsToolStripMenuItem.CheckOnClick = true;
            this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
            this.statsToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.statsToolStripMenuItem.Text = "stats";
            this.statsToolStripMenuItem.Click += new System.EventHandler(this.statsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 546);
            this.Controls.Add(this.clear2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddToLeftList);
            this.Controls.Add(this.AddToList2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "CE02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LeftItems;
        private System.Windows.Forms.ListBox RightItems;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDeselect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddToList2;
        private System.Windows.Forms.Button AddToLeftList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button clear2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
    }
}