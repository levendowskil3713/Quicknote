using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNote
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void QuickNote_Load(object sender, EventArgs e)
    {

    }

    /**
     * Bolds all selected text
     */
    private void BoldButton_Click(object sender, EventArgs e)
    {
      if (MainTextBox.SelectionFont.Bold == true)
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, MainTextBox.Font.Size, MainTextBox.SelectionFont.Style & ~FontStyle.Bold);
      }

      else
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, MainTextBox.Font.Size, MainTextBox.SelectionFont.Style | FontStyle.Bold);
      }
    }

    /**
     * Underlines all selected text
     */
    private void UnderlineButton_Click(object sender, EventArgs e)
    {
      if (MainTextBox.SelectionFont.Underline == true)
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, MainTextBox.Font.Size, MainTextBox.SelectionFont.Style & ~FontStyle.Underline);
      }

      else
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, MainTextBox.Font.Size, MainTextBox.SelectionFont.Style | FontStyle.Underline);
      }
    }

    /**
     * Italicizes all selected text
     */
    private void ItalicsButton_Click(object sender, EventArgs e)
    {
      if (MainTextBox.SelectionFont.Italic == true)
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, MainTextBox.Font.Size, MainTextBox.SelectionFont.Style & ~FontStyle.Italic);
      }

      else
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, MainTextBox.Font.Size, MainTextBox.SelectionFont.Style | FontStyle.Italic);
      }
    }
  }
}
