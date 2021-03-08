using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Documents;
using System.Windows.Controls;

namespace QuickNote
{
  public partial class MainForm : Form
  {
    //font size of the main text box
    float fontSize = 11;
       float fontStyle;
    float penSize;
    Graphics g;
    int x = -1;
    int y = -1;
    bool moving = false;
    Pen pen;

    /// <summary>
    /// Initializes graphics panel and pen for drawing. 
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
      g = panel1.CreateGraphics();
      
      pen = new Pen(Color.Black, 5);
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
           
        //Puts all fonts into the font style combobox.    
            foreach (FontFamily font in FontFamily.Families)
            {
                FontStyleComboBox.Items.Add(font.Name.ToString());
            }
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
        //the length of the selected text
        int selectedTextLength = MainTextBox.SelectionLength;

        if (selectedTextLength < 1)
        {
          MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Bold);
        }

        else
        {
          //the starting index of the selected text
          int selectedTextStart = MainTextBox.SelectionStart;

          //changes each character individually to preserve formatting
          for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
          {
            MainTextBox.Select(i, 1);
            MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, MainTextBox.SelectionFont.Size, MainTextBox.SelectionFont.Style & ~FontStyle.Bold);
          }

          //re-selects the text segment
          MainTextBox.Select(selectedTextStart, selectedTextLength);
        }

        BoldButton.BackColor = Color.White;
      }

      //bolds selected text if the selected text is not currently bolded
      else
      {
        //the length of the selected text
        int selectedTextLength = MainTextBox.SelectionLength;

        if (selectedTextLength < 1)
        {
          MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Bold);
        }

        else
        {
          //the starting index of the selected text
          int selectedTextStart = MainTextBox.SelectionStart;

          //changes each character individually to preserve formatting
          for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
          {
            MainTextBox.Select(i, 1);
            MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, MainTextBox.SelectionFont.Size, MainTextBox.SelectionFont.Style | FontStyle.Bold);
          }

          //re-selects the text segment
          MainTextBox.Select(selectedTextStart, selectedTextLength);
        }

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
        //the length of the selected text
        int selectedTextLength = MainTextBox.SelectionLength;

        if(selectedTextLength < 1)
        {
          MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Underline);
        }

        else
        {
          //the starting index of the selected text
          int selectedTextStart = MainTextBox.SelectionStart;

          //changes each character individually to preserve formatting
          for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
          {
            MainTextBox.Select(i, 1);
            MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, MainTextBox.SelectionFont.Size, MainTextBox.SelectionFont.Style & ~FontStyle.Underline);
          }

          //re-selects the text segment
          MainTextBox.Select(selectedTextStart, selectedTextLength);
        }

        UnderlineButton.BackColor = Color.White;
      }

      //underlines selected text if the selected text is not currently underlined
      else
      {
        //the length of the selected text
        int selectedTextLength = MainTextBox.SelectionLength;

        if(selectedTextLength < 1)
        {
          MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Underline);
        }

        else
        {
          //the starting index of the selected text
          int selectedTextStart = MainTextBox.SelectionStart;

          //changes each character individually to preserve formatting
          for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
          {
            MainTextBox.Select(i, 1);
            MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, MainTextBox.SelectionFont.Size, MainTextBox.SelectionFont.Style | FontStyle.Underline);
          }

          //re-selects the text segment
          MainTextBox.Select(selectedTextStart, selectedTextLength);
        }

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
        //the length of the selected text
        int selectedTextLength = MainTextBox.SelectionLength;

        if(selectedTextLength < 1)
        {
          MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Italic);
        }

        else
        {
          //the starting index of the selected text
          int selectedTextStart = MainTextBox.SelectionStart;

          //changes each character individually to preserve formatting
          for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
          {
            MainTextBox.Select(i, 1);
            MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, MainTextBox.SelectionFont.Size, MainTextBox.SelectionFont.Style & ~FontStyle.Italic);
          }

          //re-selects the text segment
          MainTextBox.Select(selectedTextStart, selectedTextLength);
        }

        ItalicsButton.BackColor = Color.White;
      }

      //italicizes selected text if the selected text is not currently italicizes
      else
      {
        //the length of the selected text
        int selectedTextLength = MainTextBox.SelectionLength;

        if(selectedTextLength < 1)
        {
          MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Italic);
        }

        else
        {
          //the starting index of the selected text
          int selectedTextStart = MainTextBox.SelectionStart;

          //changes each character individually to preserve formatting
          for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
          {
            MainTextBox.Select(i, 1);
            MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, MainTextBox.SelectionFont.Size, MainTextBox.SelectionFont.Style | FontStyle.Italic);
          }

          //re-selects the text segment
          MainTextBox.Select(selectedTextStart, selectedTextLength);
        }

        ItalicsButton.BackColor = Color.Silver;
      }
    }
        /// <summary>
        /// Sets selected text to the specified style in the text style combo box.
        /// </summary>
        /// <param name="sender">A reference to the object that raised the event.</param>
        /// <param name="e">Contains the function's event data.</param>
        private void FontStyleComboBox_Click(object sender, EventArgs e)
        {
            try
            {
                MainTextBox.SelectionFont = new Font(FontStyleComboBox.Text, MainTextBox.SelectionFont.Size);
            }
            catch
            {
                //do nothing
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
        /// <summary>
        /// Stops drawing when the mouse button is up.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;

        }
        /// <summary>
        /// Starts drawing when the mouse button is pressed down.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
        }
        /// <summary>
        /// Draws lines along the coordinates of mouse movement.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1) 
            {
                g.DrawLine(pen, new Point(x, y),e.Location);
                x = e.X;
                y = e.Y;
            }
        }
        /// <summary>
        /// Swaps the drawing panel with the textbox panel when drawing button is clicked.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        
        // Developer note- This isn't fully functional yet and may not work long term, just testing it as a method. 
        private void CursorButton_Click(object sender, EventArgs e)
        {
            if (CursorButton.Checked == false)
            {
                panel1.BringToFront();
                CursorButton.BackColor = Color.Silver;
            }
            else
            {
                MainTextBox.BringToFront();
                CursorButton.BackColor = Color.White;
            }
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem b = (System.Windows.Forms.ToolStripMenuItem)sender;
            pen.Color = b.BackColor;
        }
        private void GreenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem b = (System.Windows.Forms.ToolStripMenuItem)sender;
            pen.Color = b.BackColor;
        }

        private void BlueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem b = (System.Windows.Forms.ToolStripMenuItem)sender;
            pen.Color = b.BackColor;
        }

        /// <summary>
        /// Sets the thickness of pen to the user selected value.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void LineThicknessSplitButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            penSize = float.Parse(e.ClickedItem.Text);
            pen.Width = penSize;

        }
         /// <summary>
        /// Allows text to be displayed into bullet points.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void BulletButton_Click(object sender, EventArgs e)
        {
            try
            {
                MainTextBox.SelectionBullet = true;
                MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style);
            }
            catch (FormatException)
            {
                //do nothing
            }
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripMenuItem b = (System.Windows.Forms.ToolStripMenuItem)sender;
            pen.Color = b.BackColor;
        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolStripButton b = (System.Windows.Forms.ToolStripButton)sender;
            pen.Color = b.BackColor;
        }

    }
}
