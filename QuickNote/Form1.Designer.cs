
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
      this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSplitButton6 = new System.Windows.Forms.ToolStripSplitButton();
      this.BoldButton = new System.Windows.Forms.ToolStripButton();
      this.UnderlineButton = new System.Windows.Forms.ToolStripButton();
      this.ItalicsButton = new System.Windows.Forms.ToolStripButton();
      this.BulletButton = new System.Windows.Forms.ToolStripButton();
      this.NumberButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.CursorButton = new System.Windows.Forms.ToolStripButton();
      this.DrawButton = new System.Windows.Forms.ToolStripButton();
      this.EraserButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
      this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.ImportImageButton = new System.Windows.Forms.ToolStripButton();
      this.EditImageButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.HyperlinkButton = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.CalendarButton = new System.Windows.Forms.ToolStripButton();
      this.MainToolStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // MainTextBox
      // 
      this.MainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.MainTextBox.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainTextBox.Location = new System.Drawing.Point(0, 40);
      this.MainTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.MainTextBox.Name = "MainTextBox";
      this.MainTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
      this.MainTextBox.Size = new System.Drawing.Size(1182, 939);
      this.MainTextBox.TabIndex = 0;
      this.MainTextBox.Text = "";
      // 
      // MainToolStrip
      // 
      this.MainToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.MainToolStrip.AutoSize = false;
      this.MainToolStrip.BackColor = System.Drawing.Color.White;
      this.MainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
      this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveButton,
            this.LoadButton,
            this.toolStripSeparator1,
            this.toolStripSplitButton5,
            this.toolStripSplitButton6,
            this.BoldButton,
            this.UnderlineButton,
            this.ItalicsButton,
            this.BulletButton,
            this.NumberButton,
            this.toolStripSeparator2,
            this.CursorButton,
            this.DrawButton,
            this.EraserButton,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4,
            this.toolStripSeparator3,
            this.ImportImageButton,
            this.EditImageButton,
            this.toolStripSeparator4,
            this.HyperlinkButton,
            this.toolStripSeparator5,
            this.CalendarButton});
      this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
      this.MainToolStrip.Name = "MainToolStrip";
      this.MainToolStrip.Size = new System.Drawing.Size(1182, 38);
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
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
      // 
      // toolStripSplitButton5
      // 
      this.toolStripSplitButton5.AutoSize = false;
      this.toolStripSplitButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripSplitButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
      this.toolStripSplitButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton5.Image")));
      this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripSplitButton5.Name = "toolStripSplitButton5";
      this.toolStripSplitButton5.Size = new System.Drawing.Size(70, 35);
      this.toolStripSplitButton5.Text = "toolStripSplitButton2";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 26);
      this.toolStripMenuItem2.Text = "1";
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 26);
      this.toolStripMenuItem3.Text = "2";
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 26);
      this.toolStripMenuItem4.Text = "3";
      // 
      // toolStripSplitButton6
      // 
      this.toolStripSplitButton6.AutoSize = false;
      this.toolStripSplitButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripSplitButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton6.Image")));
      this.toolStripSplitButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripSplitButton6.Name = "toolStripSplitButton6";
      this.toolStripSplitButton6.Size = new System.Drawing.Size(70, 35);
      this.toolStripSplitButton6.Text = "toolStripSplitButton2";
      // 
      // BoldButton
      // 
      this.BoldButton.AutoSize = false;
      this.BoldButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BoldButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldButton.Image")));
      this.BoldButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BoldButton.Name = "BoldButton";
      this.BoldButton.Size = new System.Drawing.Size(35, 35);
      this.BoldButton.Text = "Bold";
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
      // 
      // BulletButton
      // 
      this.BulletButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.BulletButton.Image = ((System.Drawing.Image)(resources.GetObject("BulletButton.Image")));
      this.BulletButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.BulletButton.Name = "BulletButton";
      this.BulletButton.Size = new System.Drawing.Size(29, 35);
      this.BulletButton.Text = "Bulleted List";
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
      this.CursorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.CursorButton.Image = ((System.Drawing.Image)(resources.GetObject("CursorButton.Image")));
      this.CursorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.CursorButton.Name = "CursorButton";
      this.CursorButton.Size = new System.Drawing.Size(35, 35);
      this.CursorButton.Text = "Cursor Select";
      // 
      // DrawButton
      // 
      this.DrawButton.AutoSize = false;
      this.DrawButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.DrawButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawButton.Image")));
      this.DrawButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.DrawButton.Name = "DrawButton";
      this.DrawButton.Size = new System.Drawing.Size(35, 35);
      this.DrawButton.Text = "Draw Tool Select";
      // 
      // EraserButton
      // 
      this.EraserButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.EraserButton.Image = ((System.Drawing.Image)(resources.GetObject("EraserButton.Image")));
      this.EraserButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.EraserButton.Name = "EraserButton";
      this.EraserButton.Size = new System.Drawing.Size(29, 35);
      this.EraserButton.Text = "Eraser Tool Select";
      // 
      // toolStripSplitButton3
      // 
      this.toolStripSplitButton3.AutoSize = false;
      this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
      this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripSplitButton3.Name = "toolStripSplitButton3";
      this.toolStripSplitButton3.Size = new System.Drawing.Size(70, 35);
      this.toolStripSplitButton3.Text = "toolStripSplitButton3";
      // 
      // toolStripSplitButton4
      // 
      this.toolStripSplitButton4.AutoSize = false;
      this.toolStripSplitButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripSplitButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton4.Image")));
      this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripSplitButton4.Name = "toolStripSplitButton4";
      this.toolStripSplitButton4.Size = new System.Drawing.Size(70, 35);
      this.toolStripSplitButton4.Text = "toolStripSplitButton4";
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(1182, 977);
      this.Controls.Add(this.MainTextBox);
      this.Controls.Add(this.MainToolStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.Name = "MainForm";
      this.Text = "QuickNote";
      this.Load += new System.EventHandler(this.QuickNote_Load);
      this.MainToolStrip.ResumeLayout(false);
      this.MainToolStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton DrawButton;
        private System.Windows.Forms.ToolStripButton EraserButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ImportImageButton;
        private System.Windows.Forms.ToolStripButton EditImageButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton HyperlinkButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton CalendarButton;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton6;
    private System.Windows.Forms.ToolStripButton BulletButton;
    private System.Windows.Forms.ToolStripButton NumberButton;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
  }
}

