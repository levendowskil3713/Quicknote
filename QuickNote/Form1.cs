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
        float fontStyle; //can we get rid of this?
        float penSize;
        Graphics graphics;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        bool isDrawing = false;
        bool isErasing = false;
        Color lineColor = Color.Black;

        /// <summary>
        /// Initializes graphics panel and pen for drawing. 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            graphics = MainTextBox.CreateGraphics();

            pen = new Pen(Color.Black, 5);
            EraserButton.Enabled = false;
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
                    MainTextBox.Suspend();

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

                    MainTextBox.Resume();
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
                    MainTextBox.Suspend();

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

                    MainTextBox.Resume();
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

                if (selectedTextLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Underline);
                }

                else
                {
                    MainTextBox.Suspend();

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

                    MainTextBox.Resume();
                 }

                UnderlineButton.BackColor = Color.White;
            }

            //underlines selected text if the selected text is not currently underlined
            else
            {
                //the length of the selected text
                int selectedTextLength = MainTextBox.SelectionLength;

                if (selectedTextLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Underline);
                }

                else
                {
                    MainTextBox.Suspend();

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

                    MainTextBox.Resume();
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

                if (selectedTextLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Italic);
                }

                else
                {
                    MainTextBox.Suspend();

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

                    MainTextBox.Resume();
                }

                ItalicsButton.BackColor = Color.White;
            }

            //italicizes selected text if the selected text is not currently italicizes
            else
            {
                //the length of the selected text
                int selectedTextLength = MainTextBox.SelectionLength;

                if (selectedTextLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Italic);
                }

                else
                {
                    MainTextBox.Suspend();

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

                    MainTextBox.Resume();
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
            try
            {
                if (MainTextBox.SelectionFont.Italic == true)
                {
                    ItalicsButton.BackColor = Color.Silver;
                }
                else if (MainTextBox.SelectionFont.Italic == false)
                {
                    ItalicsButton.BackColor = Color.White;
                }
            }

            catch (NullReferenceException)
            {
                ItalicsButton.BackColor = Color.White;
            }

            //updates color of bold button
            try
            {
                if (MainTextBox.SelectionFont.Bold == true)
                {
                    BoldButton.BackColor = Color.Silver;
                }
                else if (MainTextBox.SelectionFont.Bold == false)
                {
                    BoldButton.BackColor = Color.White;
                }
            }

            catch (NullReferenceException)
            {
                BoldButton.BackColor = Color.White;
            }

            //updates color of underline button
            try
            {
                if (MainTextBox.SelectionFont.Underline == true)
                {
                    UnderlineButton.BackColor = Color.Silver;
                }
                else if (MainTextBox.SelectionFont.Underline == false)
                {
                    UnderlineButton.BackColor = Color.White;
                }
            }
            
            catch (NullReferenceException)
            {
                UnderlineButton.BackColor = Color.White;
            }
        }
        /// <summary>
        /// Stops drawing when the mouse button is up.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void MainTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if(isDrawing == true)
            {
                moving = false;
                x = -1;
                y = -1;
            }
        }

        /// <summary>
        /// Starts drawing when the mouse button is pressed down.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void MainTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                moving = true;
                x = e.X;
                y = e.Y;
            }
        }

        /// Draws lines along the coordinates of mouse movement.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void MainTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1 && isDrawing == true)
            {
                graphics.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }


        /// <summary>
        /// Swaps the drawing panel with the textbox panel when drawing button is clicked.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void CursorButton_Click(object sender, EventArgs e)
        {
            if (isDrawing == false)
            {
                MainTextBox.ReadOnly = true;
                CursorButton.BackColor = Color.Silver;
                isDrawing = true;

                EraserButton.Enabled = true;

                MainTextBox.Cursor = Cursors.Cross;
            }
            else
            {
                MainTextBox.ReadOnly = false;
                CursorButton.BackColor = Color.White;
                isDrawing = false;

                EraserButton.BackColor = Color.White;
                isErasing = false;
                EraserButton.Enabled = false;

                pen.Color = lineColor;

                MainTextBox.Cursor = Cursors.IBeam;
            }
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

        private void EraserButton_Click(object sender, EventArgs e)
        {
            if(isErasing == false)
            {
                //System.Windows.Forms.ToolStripButton b = (System.Windows.Forms.ToolStripButton)sender;
                pen.Color = Color.White;
                EraserButton.BackColor = Color.Silver;
                isErasing = true;
            }

            else
            {
                EraserButton.BackColor = Color.White;
                pen.Color = lineColor;
                isErasing = false;
            }
        }

        private void FontColorButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MainTextBox.SelectionColor = e.ClickedItem.BackColor;
            //Changes the color of the selected text
            //the length of the selected text
            int selectedTextLength = MainTextBox.SelectionLength;

                if (selectedTextLength < 1)
                {
                    MainTextBox.SelectionColor = MainTextBox.SelectionColor = e.ClickedItem.BackColor;
                }

                else
                {
                    //the starting index of the selected text
                    int selectedTextStart = MainTextBox.SelectionStart;

                    //changes each character individually to preserve formatting
                    for (int i = selectedTextStart; i < (selectedTextStart + selectedTextLength); i++)
                    {
                        MainTextBox.Select(i, 1);
                        MainTextBox.SelectionColor = e.ClickedItem.BackColor;
                }

                    //re-selects the text segment
                    MainTextBox.Select(selectedTextStart, selectedTextLength);
                }

                FontColorButton.BackColor = e.ClickedItem.BackColor;

        }

        private void LineColorSplitButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lineColor = e.ClickedItem.BackColor;
            pen.Color = lineColor;
        }

    private void LineColorSplitButton_ButtonClick(object sender, EventArgs e)
    {
      //Do nothing
    }
  }
}
