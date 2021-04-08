using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Controls;

namespace QuickNote
{
  /// <summary>This class contains extension functions that can be called by rich text boxes</summary>
  public static class RTBControlExtensions
  {
    /// <summary>
    /// Changes the font style of the selected text to the desired value
    /// </summary>
    /// <param name="RTB">The rich text box bring manipulated</param>
    /// <param name="fontStyle">The font style to be added.</param>
    /// <param name="add">Set to true when adding a style to the font. Set to false when removing a style from a font.</param>
    public static void ChangeFontStyle(this System.Windows.Forms.RichTextBox RTB, FontStyle fontStyle, bool add)
    {
      RTB.Suspend();

      //the length of the selected text
      int selectedTextLength = RTB.SelectionLength;
      //the starting index of the selected text
      int selectedTextStart = RTB.SelectionStart;

      //changes each character individually to preserve formatting
      for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
      {
        RTB.Select(i, 1);
        if(add == true)
        {
          RTB.SelectionFont = new Font(RTB.SelectionFont.FontFamily, RTB.SelectionFont.Size, RTB.SelectionFont.Style | fontStyle);
        }
        else
        {
          RTB.SelectionFont = new Font(RTB.SelectionFont.FontFamily, RTB.SelectionFont.Size, RTB.SelectionFont.Style & fontStyle);
        }
      }

      //re-selects the text segment
      RTB.Select(selectedTextStart, selectedTextLength);

      RTB.Resume();
    }

    /// <summary>
    /// Changes the font style of the selected text to the desired value
    /// </summary>
    /// <param name="RTB">The rich text box bring manipulated</param>
    /// <param name="fontFamily">The font style to be added.</param>
    public static void ChangeFontStyle(this System.Windows.Forms.RichTextBox RTB, String fontFamily)
    {
      RTB.Suspend();

      //the length of the selected text
      int selectedTextLength = RTB.SelectionLength;
      //the starting index of the selected text
      int selectedTextStart = RTB.SelectionStart;

      //changes each character individually to preserve formatting
      for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
      {
        RTB.Select(i, 1);
        RTB.SelectionFont = new Font(fontFamily, RTB.SelectionFont.Size, RTB.SelectionFont.Style);
      }

      //re-selects the text segment
      RTB.Select(selectedTextStart, selectedTextLength);

      RTB.Resume();
    }

    /// <summary>
    /// Changes the font size of the selected text to the desired value
    /// </summary>
    /// <param name="RTB">The rich text box bring manipulated</param>
    /// <param name="fontSize">The font size to be added.</param>
    public static void ChangeFontSize(this System.Windows.Forms.RichTextBox RTB, float fontSize)
    {
      RTB.Suspend();

      //the length of the selected text
      int selectedTextLength = RTB.SelectionLength;
      //the starting index of the selected text
      int selectedTextStart = RTB.SelectionStart;

      //changes each character individually to preserve formatting
      for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
      {
        RTB.Select(i, 1);
        RTB.SelectionFont = new Font(RTB.SelectionFont.FontFamily, fontSize, RTB.SelectionFont.Style);
      }

      //re-selects the text segment
      RTB.Select(selectedTextStart, selectedTextLength);

      RTB.Resume();
    }
  }
}