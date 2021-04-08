
using System;

namespace QuickNote
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.MainTextBox = new System.Windows.Forms.RichTextBox();
      this.MainToolStrip = new System.Windows.Forms.ToolStrip();
      this.SaveButton = new System.Windows.Forms.ToolStripButton();
      this.LoadButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.FontStyleComboBox = new System.Windows.Forms.ToolStripComboBox();
      this.FontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.BoldButton = new System.Windows.Forms.ToolStripButton();
      this.UnderlineButton = new System.Windows.Forms.ToolStripButton();
      this.ItalicsButton = new System.Windows.Forms.ToolStripButton();
      this.BulletButton = new System.Windows.Forms.ToolStripButton();
      this.NumberButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.CursorButton = new System.Windows.Forms.ToolStripButton();
      this.EraserButton = new System.Windows.Forms.ToolStripButton();
      this.LineColorSplitButton = new System.Windows.Forms.ToolStripSplitButton();
      this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.GreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.BlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.LineThicknessSplitButton = new System.Windows.Forms.ToolStripSplitButton();
      this.pxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.pxToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.pxToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.pxToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.pxToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.pxToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      this.pxToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
      this.pxToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ImportImageButton = new System.Windows.Forms.ToolStripButton();
      this.EditImageButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.HyperlinkButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.CalendarButton = new System.Windows.Forms.ToolStripButton();
      this.clearNoteButton = new System.Windows.Forms.ToolStripButton();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.MainToolStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // MainTextBox
      // 
      this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.MainTextBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainTextBox.Location = new System.Drawing.Point(0, 39);
      this.MainTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MainTextBox.Name = "MainTextBox";
      this.MainTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
      this.MainTextBox.Size = new System.Drawing.Size(1299, 937);
      this.MainTextBox.TabIndex = 0;
      this.MainTextBox.Text = "";
      this.MainTextBox.SelectionChanged += new System.EventHandler(this.MainTextBox_SelectionChanged);
      this.MainTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainTextBox_MouseDown);
      this.MainTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainTextBox_MouseMove);
      this.MainTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainTextBox_MouseUp);
      // 
      // MainToolStrip
      // 
      this.MainToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.MainToolStrip.AutoSize = false;
      this.MainToolStrip.BackColor = System.Drawing.Color.White;
      this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.LoadButton,
            this.toolStripSeparator1,
            this.FontStyleComboBox,
            this.FontSizeComboBox,
            this.toolStripButton1,
            this.BoldButton,
            this.UnderlineButton,
            this.ItalicsButton,
            this.BulletButton,
            this.NumberButton,
            this.toolStripSeparator2,
            this.CursorButton,
            this.EraserButton,
            this.LineColorSplitButton,
            this.LineThicknessSplitButton,
            this.toolStripSeparator3,
            this.ImportImageButton,
            this.EditImageButton,
            this.toolStripSeparator4,
            this.HyperlinkButton,
            this.toolStripSeparator5,
            this.CalendarButton,
            this.clearNoteButton});
      this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
      this.MainToolStrip.Name = "MainToolStrip";
      this.MainToolStrip.Size = new System.Drawing.Size(1307, 38);
      this.MainToolStrip.Stretch = true;
      this.MainToolStrip.TabIndex = 1;
      this.MainToolStrip.Text = "MainToolStrip";
      // 
      // SaveButton
      // 
      this.SaveButton.AutoSize = false;
      this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
      this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(35, 35);
      this.SaveButton.Text = "Save";
      this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // LoadButton
      // 
      this.LoadButton.AutoSize = false;
      this.LoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.LoadButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadButton.Image")));
      this.LoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.LoadButton.Name = "LoadButton";
      this.LoadButton.Size = new System.Drawing.Size(35, 35);
      this.LoadButton.Text = "Load";
      this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
      // 
      // FontStyleComboBox
      // 
      this.FontStyleComboBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FontStyleComboBox.Name = "FontStyleComboBox";
      this.FontStyleComboBox.Size = new System.Drawing.Size(124, 38);
      this.FontStyleComboBox.Text = "Font Style";
      this.FontStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.FontStyleComboBox_SelectedIndexChange);
      // 
      // FontSizeComboBox
      // 
      this.FontSizeComboBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
      this.FontSizeComboBox.Name = "FontSizeComboBox";
      this.FontSizeComboBox.Size = new System.Drawing.Size(121, 38);
      this.FontSizeComboBox.Text = "Font Size";
      this.FontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.FontSizeComboBox_SelectedIndexChanged);
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(29, 35);
      this.toolStripButton1.Text = "Text Color";
      this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
      // 
      // BoldButton
      // 
      this.BoldButton.AutoSize = false;
      this.BoldButton.BackColor = System.Drawing.Color.White;
      this.BoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BoldButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldButton.Image")));
      this.BoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BoldButton.Name = "BoldButton";
      this.BoldButton.Size = new System.Drawing.Size(35, 35);
      this.BoldButton.Text = "Bold";
      this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
      // 
      // UnderlineButton
      // 
      this.UnderlineButton.AutoSize = false;
      this.UnderlineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.UnderlineButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineButton.Image")));
      this.UnderlineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.UnderlineButton.Name = "UnderlineButton";
      this.UnderlineButton.Size = new System.Drawing.Size(35, 35);
      this.UnderlineButton.Text = "Underline";
      this.UnderlineButton.Click += new System.EventHandler(this.UnderlineButton_Click);
      // 
      // ItalicsButton
      // 
      this.ItalicsButton.AutoSize = false;
      this.ItalicsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ItalicsButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicsButton.Image")));
      this.ItalicsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ItalicsButton.Name = "ItalicsButton";
      this.ItalicsButton.Size = new System.Drawing.Size(35, 35);
      this.ItalicsButton.Text = "Italics";
      this.ItalicsButton.Click += new System.EventHandler(this.ItalicsButton_Click);
      // 
      // BulletButton
      // 
      this.BulletButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BulletButton.Image = ((System.Drawing.Image)(resources.GetObject("BulletButton.Image")));
      this.BulletButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BulletButton.Name = "BulletButton";
      this.BulletButton.Size = new System.Drawing.Size(29, 35);
      this.BulletButton.Text = "Bulleted List";
      this.BulletButton.Click += new System.EventHandler(this.BulletButton_Click);
      // 
      // NumberButton
      // 
      this.NumberButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.NumberButton.Image = ((System.Drawing.Image)(resources.GetObject("NumberButton.Image")));
      this.NumberButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.NumberButton.Name = "NumberButton";
      this.NumberButton.Size = new System.Drawing.Size(29, 35);
      this.NumberButton.Text = "Numbered List";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
      // 
      // CursorButton
      // 
      this.CursorButton.AutoSize = false;
      this.CursorButton.BackColor = System.Drawing.Color.White;
      this.CursorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.CursorButton.Image = ((System.Drawing.Image)(resources.GetObject("CursorButton.Image")));
      this.CursorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.CursorButton.Name = "CursorButton";
      this.CursorButton.Size = new System.Drawing.Size(35, 35);
      this.CursorButton.Text = "Cursor Select";
      this.CursorButton.Click += new System.EventHandler(this.CursorButton_Click);
      // 
      // EraserButton
      // 
      this.EraserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.EraserButton.Image = ((System.Drawing.Image)(resources.GetObject("EraserButton.Image")));
      this.EraserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.EraserButton.Name = "EraserButton";
      this.EraserButton.Size = new System.Drawing.Size(29, 35);
      this.EraserButton.Text = "Eraser Tool Select";
      this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
      // 
      // LineColorSplitButton
      // 
      this.LineColorSplitButton.AutoSize = false;
      this.LineColorSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.LineColorSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.redToolStripMenuItem,
            this.GreenToolStripMenuItem,
            this.BlueToolStripMenuItem});
      this.LineColorSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("LineColorSplitButton.Image")));
      this.LineColorSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.LineColorSplitButton.Name = "LineColorSplitButton";
      this.LineColorSplitButton.Size = new System.Drawing.Size(70, 35);
      this.LineColorSplitButton.Text = "Line Color";
      this.LineColorSplitButton.ButtonClick += new System.EventHandler(this.LineColorSplitButton_ButtonClick);
      this.LineColorSplitButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.LineColorSplitButton_DropDownItemClicked);
      // 
      // blackToolStripMenuItem
      // 
      this.blackToolStripMenuItem.BackColor = System.Drawing.Color.Black;
      this.blackToolStripMenuItem.ForeColor = System.Drawing.Color.White;
      this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
      this.blackToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
      this.blackToolStripMenuItem.Text = "Black";
      // 
      // redToolStripMenuItem
      // 
      this.redToolStripMenuItem.BackColor = System.Drawing.Color.Red;
      this.redToolStripMenuItem.Name = "redToolStripMenuItem";
      this.redToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
      this.redToolStripMenuItem.Text = "Red";
      // 
      // GreenToolStripMenuItem
      // 
      this.GreenToolStripMenuItem.BackColor = System.Drawing.Color.Lime;
      this.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem";
      this.GreenToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
      this.GreenToolStripMenuItem.Text = "Green";
      // 
      // BlueToolStripMenuItem
      // 
      this.BlueToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
      this.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem";
      this.BlueToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
      this.BlueToolStripMenuItem.Text = "Blue";
      // 
      // LineThicknessSplitButton
      // 
      this.LineThicknessSplitButton.AutoSize = false;
      this.LineThicknessSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.LineThicknessSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pxToolStripMenuItem1,
            this.pxToolStripMenuItem2,
            this.pxToolStripMenuItem3,
            this.pxToolStripMenuItem4,
            this.pxToolStripMenuItem5,
            this.pxToolStripMenuItem6,
            this.pxToolStripMenuItem7,
            this.pxToolStripMenuItem8});
      this.LineThicknessSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("LineThicknessSplitButton.Image")));
      this.LineThicknessSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.LineThicknessSplitButton.Name = "LineThicknessSplitButton";
      this.LineThicknessSplitButton.Size = new System.Drawing.Size(70, 35);
      this.LineThicknessSplitButton.Text = "Line Thickness";
      this.LineThicknessSplitButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.LineThicknessSplitButton_DropDownItemClicked);
      // 
      // pxToolStripMenuItem1
      // 
      this.pxToolStripMenuItem1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pxToolStripMenuItem1.Name = "pxToolStripMenuItem1";
      this.pxToolStripMenuItem1.Size = new System.Drawing.Size(113, 28);
      this.pxToolStripMenuItem1.Text = "1";
      // 
      // pxToolStripMenuItem2
      // 
      this.pxToolStripMenuItem2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pxToolStripMenuItem2.Name = "pxToolStripMenuItem2";
      this.pxToolStripMenuItem2.Size = new System.Drawing.Size(113, 28);
      this.pxToolStripMenuItem2.Text = "2";
      // 
      // pxToolStripMenuItem3
      // 
      this.pxToolStripMenuItem3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pxToolStripMenuItem3.Name = "pxToolStripMenuItem3";
      this.pxToolStripMenuItem3.Size = new System.Drawing.Size(113, 28);
      this.pxToolStripMenuItem3.Text = "3";
      // 
      // pxToolStripMenuItem4
      // 
      this.pxToolStripMenuItem4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pxToolStripMenuItem4.Name = "pxToolStripMenuItem4";
      this.pxToolStripMenuItem4.Size = new System.Drawing.Size(113, 28);
      this.pxToolStripMenuItem4.Text = "4";
      // 
      // pxToolStripMenuItem5
      // 
      this.pxToolStripMenuItem5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pxToolStripMenuItem5.Name = "pxToolStripMenuItem5";
      this.pxToolStripMenuItem5.Size = new System.Drawing.Size(113, 28);
      this.pxToolStripMenuItem5.Text = "8";
      // 
      // pxToolStripMenuItem6
      // 
      this.pxToolStripMenuItem6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pxToolStripMenuItem6.Name = "pxToolStripMenuItem6";
      this.pxToolStripMenuItem6.Size = new System.Drawing.Size(113, 28);
      this.pxToolStripMenuItem6.Text = "12";
      // 
      // pxToolStripMenuItem7
      // 
      this.pxToolStripMenuItem7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pxToolStripMenuItem7.Name = "pxToolStripMenuItem7";
      this.pxToolStripMenuItem7.Size = new System.Drawing.Size(113, 28);
      this.pxToolStripMenuItem7.Text = "16";
      // 
      // pxToolStripMenuItem8
      // 
      this.pxToolStripMenuItem8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pxToolStripMenuItem8.Name = "pxToolStripMenuItem8";
      this.pxToolStripMenuItem8.Size = new System.Drawing.Size(113, 28);
      this.pxToolStripMenuItem8.Text = "24";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
      // 
      // ImportImageButton
      // 
      this.ImportImageButton.AutoSize = false;
      this.ImportImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.ImportImageButton.Image = ((System.Drawing.Image)(resources.GetObject("ImportImageButton.Image")));
      this.ImportImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ImportImageButton.Name = "ImportImageButton";
      this.ImportImageButton.Size = new System.Drawing.Size(35, 35);
      this.ImportImageButton.Text = "Import Image";
      this.ImportImageButton.Click += new System.EventHandler(this.ImportImageButton_Click);
      // 
      // EditImageButton
      // 
      this.EditImageButton.AutoSize = false;
      this.EditImageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.EditImageButton.Image = ((System.Drawing.Image)(resources.GetObject("EditImageButton.Image")));
      this.EditImageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.EditImageButton.Name = "EditImageButton";
      this.EditImageButton.Size = new System.Drawing.Size(35, 35);
      this.EditImageButton.Text = "Edit Image";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
      // 
      // HyperlinkButton
      // 
      this.HyperlinkButton.AutoSize = false;
      this.HyperlinkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.HyperlinkButton.Image = ((System.Drawing.Image)(resources.GetObject("HyperlinkButton.Image")));
      this.HyperlinkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.HyperlinkButton.Name = "HyperlinkButton";
      this.HyperlinkButton.Size = new System.Drawing.Size(35, 35);
      this.HyperlinkButton.Text = "Embed Hyperlink";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
      // 
      // CalendarButton
      // 
      this.CalendarButton.AutoSize = false;
      this.CalendarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.CalendarButton.Image = ((System.Drawing.Image)(resources.GetObject("CalendarButton.Image")));
      this.CalendarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.CalendarButton.Name = "CalendarButton";
      this.CalendarButton.Size = new System.Drawing.Size(35, 35);
      this.CalendarButton.Text = "Calendar";
      // 
      // clearNoteButton
      // 
      this.clearNoteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.clearNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("clearNoteButton.Image")));
      this.clearNoteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.clearNoteButton.Name = "clearNoteButton";
      this.clearNoteButton.Size = new System.Drawing.Size(29, 35);
      this.clearNoteButton.Text = "ClearNote";
      this.clearNoteButton.Click += new System.EventHandler(this.clearNoteButton_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(653, 338);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(133, 62);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
      this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
      this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(1299, 977);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.MainToolStrip);
      this.Controls.Add(this.MainTextBox);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "MainForm";
      this.Text = "QuickNote";
      this.Load += new System.EventHandler(this.QuickNote_Load);
      this.MainToolStrip.ResumeLayout(false);
      this.MainToolStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton SaveButton;
        private System.Windows.Forms.ToolStripButton LoadButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BoldButton;
        private System.Windows.Forms.ToolStripButton UnderlineButton;
        private System.Windows.Forms.ToolStripButton ItalicsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton CursorButton;
        private System.Windows.Forms.ToolStripButton EraserButton;
        private System.Windows.Forms.ToolStripSplitButton LineColorSplitButton;
        private System.Windows.Forms.ToolStripSplitButton LineThicknessSplitButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ImportImageButton;
        private System.Windows.Forms.ToolStripButton EditImageButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton HyperlinkButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton CalendarButton;
    private System.Windows.Forms.ToolStripButton BulletButton;
    private System.Windows.Forms.ToolStripButton NumberButton;
    private System.Windows.Forms.ToolStripComboBox FontStyleComboBox;
    private System.Windows.Forms.ToolStripComboBox FontSizeComboBox;
    private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem6;
    private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem7;
    private System.Windows.Forms.ToolStripMenuItem pxToolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlueToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton clearNoteButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

