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
    //font size of the main text box
    float fontSize = 11;

    public MainForm()
    {
      InitializeComponent();
    }

    /**
     * Initializes utilized UI component values
     */
    private void QuickNote_Load(object sender, EventArgs e)
    {
      //Sets the font size of the main text box
      MainTextBox.Font = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style);

      //sets the text of the text size combo box equal to the starting font size of the main text box upon startup
      FontSizeComboBox.Text = string.Format("{0:N0}", MainTextBox.Font.Size);
    }

    /**
     * Bolds all selected text and updates button color
     */
    private void BoldButton_Click(object sender, EventArgs e)
    {
      if (MainTextBox.SelectionFont.Bold == true)
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Bold);
        BoldButton.BackColor = Color.White;
      }

      else
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Bold);
        BoldButton.BackColor = Color.Silver;
      }
    }

    /**
     * Underlines all selected text and updates button color
     */
    private void UnderlineButton_Click(object sender, EventArgs e)
    {
      if (MainTextBox.SelectionFont.Underline == true)
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Underline);
        UnderlineButton.BackColor = Color.White;
      }

      else
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Underline);
        UnderlineButton.BackColor = Color.Silver;
      }
    }

    /**
     * Italicizes all selected text and updates button color
     */
    private void ItalicsButton_Click(object sender, EventArgs e)
    {
      if (MainTextBox.SelectionFont.Italic == true)
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Italic);
        ItalicsButton.BackColor = Color.White;
      }

      else
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Italic);
        ItalicsButton.BackColor = Color.Silver;
      }
    }

    /**
     * Sets selected text to the specified size
     */
    private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      try
      {
        fontSize = float.Parse(FontSizeComboBox.Text);
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style);
      }

      catch (FormatException)
      {
        //do nothing
      }
    }


    /**
     * Updates the color and/or text of pertinent UI elements when new text is selected on the main text box
     */
    private void MainTextBox_SelectionChanged(object sender, EventArgs e)
    {
      //updates text of font size combo box
      FontSizeComboBox.Text = string.Format("{0:N0}", fontSize);

      //updates color of italics button
      if (MainTextBox.SelectionFont.Italic == true)
      {
        ItalicsButton.BackColor = Color.Silver;
      }
      else if(MainTextBox.SelectionFont.Italic == false)
      {
        ItalicsButton.BackColor = Color.White;
      }

      //updates color of bold button
      if (MainTextBox.SelectionFont.Bold == true)
      {
        BoldButton.BackColor = Color.Silver;
      }
      else if(MainTextBox.SelectionFont.Bold == false)
      {
        BoldButton.BackColor = Color.White;
      }

      //updates color of underline button
      if (MainTextBox.SelectionFont.Underline == true)
      {
        UnderlineButton.BackColor = Color.Silver;
      }
      else if(MainTextBox.SelectionFont.Underline == false)
      {
        UnderlineButton.BackColor = Color.White;
      }
    }
  }
}
