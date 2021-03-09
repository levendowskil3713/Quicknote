using System;
using System.Windows.Forms;

namespace QuickNote
{
  public static class ControlExtensions
  {
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern bool LockWindowUpdate(IntPtr hWndLock);

    /// <summary>
    /// Prevents the selected control from being repainted
    /// </summary>
    /// <param name="sender">The control that shall be suspended.</param>
    public static void Suspend(this System.Windows.Forms.Control control)
    {
      LockWindowUpdate(control.Handle);
    }

    /// <summary>
    /// Allows the selected control to be repainted
    /// </summary>
    /// <param name="sender">The control that shall be resumed.</param>
    public static void Resume(this System.Windows.Forms.Control control)
    {
      LockWindowUpdate(IntPtr.Zero);
    }
  }
}