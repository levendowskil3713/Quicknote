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

    /// <summary>
    /// Initializes utilized UI component values.
    /// </summary>
    /// <param name="sender">A reference to the object that raised the event.</param>
    /// <param name="e">Contains the function's event data.</param>
    private void QuickNote_Load(object sender, EventArgs e)
    {
      //Sets the font size of the main text box
      MainTextBox.Font = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style);

      //sets the text of the text size combo box equal to the starting font size of the main text box upon startup
      FontSizeComboBox.Text = string.Format("{0:N0}", MainTextBox.Font.Size);
    }

    /// <summary>
    /// Bolds all selected text and updates button color.
    /// </summary>
    /// <param name="sender">A reference to the object that raised the event.</param>
    /// <param name="e">Contains the function's event data.</param>
    private void BoldButton_Click(object sender, EventArgs e)
    {
      //un-bolds selected text if the selected text is currently bolded
      if (MainTextBox.SelectionFont.Bold == true)
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Bold);
        BoldButton.BackColor = Color.White;
      }

      //bolds selected text if the selected text is not currently bolded
      else
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Bold);
        BoldButton.BackColor = Color.Silver;
      }
    }

    /// <summary>
    /// Underlines all selected text and updates button color.
    /// </summary>
    /// <param name="sender">A reference to the object that raised the event.</param>
    /// <param name="e">Contains the function's event data.</param>
    private void UnderlineButton_Click(object sender, EventArgs e)
    {
      //un-underlines selected text if the selected text is currently underlined
      if (MainTextBox.SelectionFont.Underline == true)
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Underline);
        UnderlineButton.BackColor = Color.White;
      }

      //underlines selected text if the selected text is not currently underlined
      else
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Underline);
        UnderlineButton.BackColor = Color.Silver;
      }
    }

    /// <summary>
    /// Italicizes all selected text and updates button color.
    /// </summary>
    /// <param name="sender">A reference to the object that raised the event.</param>
    /// <param name="e">Contains the function's event data.</param>
    private void ItalicsButton_Click(object sender, EventArgs e)
    {
      //un-italicizes selected text if the selected text is currently italicizes
      if (MainTextBox.SelectionFont.Italic == true)
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Italic);
        ItalicsButton.BackColor = Color.White;
      }

      //italicizes selected text if the selected text is not currently italicizes
      else
      {
        MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Italic);
        ItalicsButton.BackColor = Color.Silver;
      }
    }

    /// <summary>
    /// Sets selected text to the specified size in the text size combo box.
    /// </summary>
    /// <param name="sender">A reference to the object that raised the event.</param>
    /// <param name="e">Contains the function's event data.</param>
    private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      //only changes text size when the input can be parsed as a float
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

    /// <summary>
    /// Updates the color and/or text of pertinent UI elements when new text is selected on the main text box.
    /// </summary>
    /// <param name="sender">A reference to the object that raised the event.</param>
    /// <param name="e">Contains the function's event data.</param>
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
