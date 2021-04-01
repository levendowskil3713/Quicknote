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
  public static class ControlExtensions
  {
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern bool LockWindowUpdate(IntPtr hWndLock);

    /// <summary>
    /// Prevents the selected control from being repainted
    /// </summary>
    /// <param name="control">The control that shall be suspended.</param>
    public static void Suspend(this System.Windows.Forms.Control control)
    {
      LockWindowUpdate(control.Handle);
    }

    /// <summary>
    /// Allows the selected control to be repainted
    /// </summary>
    /// <param name="control">The control that shall be resumed.</param>
    public static void Resume(this System.Windows.Forms.Control control)
    {
      LockWindowUpdate(IntPtr.Zero);
    }

    /// <summary>
    /// Changes the font style of the selected text to the desired value
    /// </summary>
    /// <param name="RTB">The rich text box bring manipulated</param>
    /// <param name="fontStyle">The font style to be added.</param>
    public static void ChangeFontStyle(this System.Windows.Forms.RichTextBox RTB, FontStyle fontStyle)
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
        RTB.SelectionFont = new Font(RTB.SelectionFont.FontFamily, RTB.SelectionFont.Size, fontStyle);
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