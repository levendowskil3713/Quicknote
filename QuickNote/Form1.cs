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
        //the style of the currently selected font
        float fontStyle; //can we get rid of this?
        //the thickness of lines created via the drawing tool
        float penSize;
        //Object that stores lines created via the drawing tool
        Graphics graphics;
        int x = -1;
        int y = -1;
        //true when the cursor is moving
        bool moving = false;
        //the pen object used in the drawing tool
        Pen pen;
        //true when the drawing tool is selected
        bool isDrawing = false;
        //true when the eraser tool is selected
        bool isErasing = false;
        //the currently selected drawing tool line color
        Color lineColor = Color.Black;

        string fileName = null;
        Timer saveTime;
        private Color backcolor;
        private bool isRotating;
        private bool isDragging;
        private int currentX;
        private int currentY;

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

            InitiatlizeTimer();
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
                    MainTextBox.ChangeFontStyle(MainTextBox.SelectionFont.Style & ~FontStyle.Bold);
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
                    MainTextBox.ChangeFontStyle(MainTextBox.SelectionFont.Style | FontStyle.Bold);
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
                    MainTextBox.ChangeFontStyle(MainTextBox.SelectionFont.Style & ~FontStyle.Underline);
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
                    MainTextBox.ChangeFontStyle(MainTextBox.SelectionFont.Style | FontStyle.Underline);
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
                    MainTextBox.ChangeFontStyle(MainTextBox.SelectionFont.Style & ~FontStyle.Italic);
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
                    MainTextBox.ChangeFontStyle(MainTextBox.SelectionFont.Style | FontStyle.Italic);
                }

                ItalicsButton.BackColor = Color.Silver;
            }
        }

        /// <summary>
        /// Sets selected text to the specified style in the text style combo box.
        /// </summary>
        /// <param name="sender">A reference to the object that raised the event.</param>
        /// <param name="e">Contains the function's event data.</param>
        private void FontStyleComboBox_SelectedIndexChange(object sender, EventArgs e)
        {
            MainTextBox.ChangeFontStyle(FontStyleComboBox.Text);
        }

        /// <summary>
        /// Sets selected text to the specified size in the text size combo box.
        /// </summary>
        /// <param name="sender">A reference to the object that raised the event.</param>
        /// <param name="e">Contains the function's event data.</param>
        private void FontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fontSize = float.Parse(FontSizeComboBox.Text);
            MainTextBox.ChangeFontSize(fontSize);
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

            //updates color of underline button
            try
            {
                if (MainTextBox.SelectionBullet == true)
                {
                    BulletButton.BackColor = Color.Silver;
                }
                else if (MainTextBox.SelectionBullet == false)
                {
                    BulletButton.BackColor = Color.White;
                }
            }
            
            catch (NullReferenceException)
            {
                BulletButton.BackColor = Color.White;
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
                MainTextBox.ReadOnly = true;
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
                MainTextBox.ReadOnly = false;
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
                if(MainTextBox.SelectionBullet == true)
                {
                    MainTextBox.SelectionBullet = false;
                    BulletButton.BackColor = Color.White;
                }

                else
                {
                    MainTextBox.SelectionBullet = true;
                    BulletButton.BackColor = Color.Silver;
                }
            }
            catch (FormatException)
            {
                //do nothing
            }
        }

        /// <summary>
        /// Sets the pen color to white to allow user to erase other pen marks. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Sets the font color to the selected drop down item. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontColorButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            MainTextBox.SelectionColor = e.ClickedItem.BackColor;
        }

        /// <summary>
        /// Sets the color of the pen. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LineColorSplitButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lineColor = e.ClickedItem.BackColor;
            pen.Color = lineColor;
        }

        /// <summary>
        /// This prevents the program from crashing when the LineColor button is clicked, but does not implement any features itself.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LineColorSplitButton_ButtonClick(object sender, EventArgs e)
        {
          //Do nothing
        }
        
        /// <summary>
        /// Prompts the user to select a save location for the file. 
        /// </summary>
        /// <param name="sender">A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                fileName = fileDialog.FileName;
                System.IO.TextWriter textWriter = new System.IO.StreamWriter(fileName);
                textWriter.Write(MainTextBox.Text);
                textWriter.Close();
            }

            
        }

        /// <summary>
        /// Creates a timer to autosave every 30 seconds. 
        /// </summary>
        public void InitiatlizeTimer() 
        {
            saveTime = new Timer();
            saveTime.Tick += new EventHandler(saveTime_Tick);
            saveTime.Interval = 30000;
            saveTime.Start();
        }

        /// <summary>
        /// Saves the file during each tick event. 
        /// </summary>
        /// <param name="sender">A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void saveTime_Tick(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                System.IO.TextWriter textWriter = new System.IO.StreamWriter(fileName);
                textWriter.Write(MainTextBox.Text);
                textWriter.Close();
            }
        }

        /// <summary>
        /// Allows user to clear the notepad.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void clearNoteButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(MainTextBox.BackColor);
            MainTextBox.Clear();
            MainTextBox.Focus();
        }
        
        /// <summary>
        /// Loads file from file explorer and writes text to MainTextBox.
        /// </summary>
        /// <param name="sender">A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            String line;
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = fileDialog.FileName;
                System.IO.TextReader textReader = new System.IO.StreamReader(fileName);
                while((line = textReader.ReadLine()) != null)
                {
                    MainTextBox.AppendText(line);
                }
                textReader.Close();
            }
        }

        /// <summary>
        /// Prompts user to search file explorer for their image, uploads image to MainTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = fileDialog.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Load(fileName);
             
            }
        }

        /// <summary>
        /// Prompts user to change color of selected text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                MainTextBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
              isDragging = true;
              currentX = e.X;
              currentY = e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
              isRotating = true;
              currentX = e.X;
              currentY = e.Y;
            }
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                pictureBox1.Top = pictureBox1.Top + (e.Y - currentY);
                pictureBox1.Left = pictureBox1.Left + (e.X - currentX);
            }

            if(isRotating)
            {
              /*System.Drawing.Image img = pictureBox1.Image;
              Graphics g = Graphics.FromImage(img);
              g.RotateTransform(e.Y - currentY);
              Bitmap bitMap = new Bitmap(img.Width, img.Height, g);
              for(int i = 0; i < img.Width; i++)
              {
                  for(int j = 0; j < img.Height; j++)
                  {
                      bitMap.SetPixel(i, j, Color.Black);
                  }
              }
              img = bitMap;
              pictureBox1.Image = img;*/
            }
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
              isDragging = false;
            }
            else if (e.Button == MouseButtons.Right)
            {
              isRotating = false;
            }
        }
    }
}
