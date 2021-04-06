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
  /// <summary>This class contains generic extension functions that can be called by various UI elements</summary>
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
  }
}