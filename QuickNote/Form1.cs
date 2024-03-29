﻿using System;
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
using System.Collections;
using System.IO;

namespace QuickNote
{
    public partial class MainForm : Form
    {
        //font size of the main text box
        float fontSize = 11;
        //the style of the currently selected font (unused)
        //the thickness of lines created via the drawing tool
        float penSize = 4;
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

        //the file path for the image to be added
        string fileName = null;
        //a timer
        Timer saveTime;
        //a color intended to be used for UI element background (unused)
        private Color backcolor;
        //set to true of a selected image is rotating
        private bool isRotating;
        //set to true if the selected image is being translated
        private bool isDragging;
        //the current horizontal coordinate of the mouse cursor
        private int currentX;
        //the current vertical coordinate of the mouse cursor
        private int currentY;

        //list of pictures
        List<PictureBox> pictureBoxes = new List<PictureBox>();

        //list of drawings
        List<Drawing> Drawings = new List<Drawing>();

        //index of the selected image
        int selectedImageIndex = -1;
        //Hyperlink object
        LinkLabel dynamicLinkLabel = new LinkLabel();

        //keeps track of the number of images
        int numImages = 0;

        /// <summary>
        /// Initializes graphics panel and pen for drawing. 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            linkLabel1.Visible = false;
            Controls.Add(dynamicLinkLabel);
            dynamicLinkLabel.LinkArea = new LinkArea(0, 22);
            dynamicLinkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
            textBox1.Visible = false;
            graphics = MainTextBox.CreateGraphics();
            
            pen = new Pen(Color.Black, 5);
            EraserButton.Enabled = false;

            //disables unfinished or unused tools
            ImportImageButton.Enabled = false;
            EditImageButton.Enabled = false;
            HyperlinkButton.Enabled = false;
            NumberButton.Enabled = false;
            ImportImageButton.Visible = false;
            EditImageButton.Visible = false;
            HyperlinkButton.Visible = false;
            toolStripSeparator4.Visible = false;
            toolStripSeparator5.Visible = false;
            NumberButton.Visible = false;
            
            
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

            //TEMP
            pictureBox1.Visible = false;
            monthCalendar1.Visible = false;
            monthCalendar1.MaxSelectionCount = 1;

            InitiatlizeTimer();
        }

        /// <summary>
        /// Bolds all selected text and updates button color.
        /// </summary>
        /// <param name="sender">A reference to the object that raised the event.</param>
        /// <param name="e">Contains the function's event data.</param>
        private void BoldButton_Click(object sender, EventArgs e)
        {
            int selectionLength = MainTextBox.SelectionLength;
            MainTextBox.SelectionLength = 1;
            
            //un-bolds selected text if the selected text is currently bolded
            if (MainTextBox.SelectionFont.Bold == true)
            {
                //the length of the selected text
                MainTextBox.SelectionLength = selectionLength;

                if (MainTextBox.SelectionLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Bold);
                }

                else
                {
                    MainTextBox.ChangeFontStyle(~FontStyle.Bold, false);
                }

                BoldButton.BackColor = Color.White;
            }

            //bolds selected text if the selected text is not currently bolded
            else
            {
                //the length of the selected text
                MainTextBox.SelectionLength = selectionLength;

                if (MainTextBox.SelectionLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Bold);
                }

                else
                {
                    MainTextBox.ChangeFontStyle(FontStyle.Bold, true);
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
            int selectionLength = MainTextBox.SelectionLength;
            MainTextBox.SelectionLength = 1;

            //un-underlines selected text if the selected text is currently underlined
            if (MainTextBox.SelectionFont.Underline == true)
            {
                //the length of the selected text
                MainTextBox.SelectionLength = selectionLength;

                if (MainTextBox.SelectionLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Underline);
                }

                else
                {
                    MainTextBox.ChangeFontStyle(~FontStyle.Underline, false);
                }

                UnderlineButton.BackColor = Color.White;
            }

            //underlines selected text if the selected text is not currently underlined
            else
            {
                //the length of the selected text
                MainTextBox.SelectionLength = selectionLength;

                if (MainTextBox.SelectionLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.Font.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Underline);
                }

                else
                {
                    MainTextBox.ChangeFontStyle(FontStyle.Underline, true);
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
            int selectionLength = MainTextBox.SelectionLength;
            MainTextBox.SelectionLength = 1;

            //un-italicizes selected text if the selected text is currently italicizes
            if (MainTextBox.SelectionFont.Italic == true)
            {
                //the length of the selected text
                MainTextBox.SelectionLength = selectionLength;

                if (MainTextBox.SelectionLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, fontSize, MainTextBox.SelectionFont.Style & ~FontStyle.Italic);
                }

                else
                {
                    MainTextBox.ChangeFontStyle(~FontStyle.Italic, false);
                }

                ItalicsButton.BackColor = Color.White;
            }

            //italicizes selected text if the selected text is not currently italicizes
            else
            {
                //the length of the selected text
                MainTextBox.SelectionLength = selectionLength;

                if (MainTextBox.SelectionLength < 1)
                {
                    MainTextBox.SelectionFont = new Font(MainTextBox.SelectionFont.FontFamily, fontSize, MainTextBox.SelectionFont.Style | FontStyle.Italic);
                }

                else
                {
                    MainTextBox.ChangeFontStyle(FontStyle.Italic, true);
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
            if (MainTextBox.SelectionLength < 1)
            {
                MainTextBox.SelectionFont = new Font(FontStyleComboBox.Text, fontSize, MainTextBox.SelectionFont.Style);
            }

            else
            {
                MainTextBox.ChangeFontStyle(FontStyleComboBox.Text);
            }
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

            if(HyperlinkButton.BackColor == Color.Silver)
            {
                textBox1.Text = MainTextBox.SelectedText;
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
                Point startPoint = new Point(x, y);
                graphics.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
                //saving the information for the newly created line
                Drawings.Add(new Drawing(startPoint, e.Location, lineColor, penSize));
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
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                //saving text
                fileName = fileDialog.FileName;
                System.IO.TextWriter textWriter = new System.IO.StreamWriter(fileName);
                textWriter.WriteLine();
                textWriter.WriteLine(MainTextBox.Text);
                //textWriter.WriteLine(MainTextBox.Rtf);

                //saving drawings
                textWriter.WriteLine();
                textWriter.WriteLine("€--------------------------------€");
                textWriter.WriteLine();

                for(int i = 0; i < Drawings.Count; i++)
                {
                    string drawingInfo = Drawings[i].getStartPoint().X.ToString()
                    + "," + Drawings[i].getStartPoint().Y.ToString()
                    + "," + Drawings[i].getEndPoint().X.ToString()
                    + "," + Drawings[i].getEndPoint().Y.ToString()
                    + "," + Drawings[i].getColor().ToString()
                    + "," + Drawings[i].getThickness().ToString();

                    textWriter.Write(drawingInfo + Environment.NewLine);
                    textWriter.WriteLine();
                } 

                textWriter.Close();
                /*
                int count = 0;
                if (numImages == 0)
                {
                    using (FileStream fs = File.Create(@"A:\AA--UW-STOUT\image4.bmp"))
                    { // something is broken here
                        pictureBoxes[count].Image.Save(@"A:\AA--UW-STOUT\image1.bmp", System.Drawing.Imaging.ImageFormat.Bmp); // this should work once the previous line is fixed
                        count++;

                    }
                }

                if (numImages == 1)
                {
                    using (FileStream fs = File.Create(@"A:\AA--UW-STOUT\image4.bmp"))
                    {
                        pictureBoxes[count].Image.Save(@"A:\AA--UW-STOUT\image2.bmp", System.Drawing.Imaging.ImageFormat.Bmp); // this should work once the previous line is fixed
                        count++;
                    }
                }

                if (numImages == 2)
                {
                    using (FileStream fs = File.Create(@"A:\AA--UW-STOUT\image4.bmp"))
                    {
                        pictureBoxes[count].Image.Save(@"A:\AA--UW-STOUT\image3.bmp", System.Drawing.Imaging.ImageFormat.Bmp); // this should work once the previous line is fixed
                        count++;
                    }
                }
                using (FileStream fs = File.Create(@"A:\AA--UW-STOUT\numImages.txt"))
                {
                    Byte[] result = BitConverter.GetBytes(count);
                    fs.Write(result, 0, result.Length);
                }*/
            }

            
        }

        /// <summary>
        /// Creates a timer to autosave every 30 seconds. 
        /// </summary>
        public void InitiatlizeTimer() 
        {
            saveTime = new Timer();
            saveTime.Tick += new EventHandler(saveTime_Tick);
            //saveTime.Interval = 30000;
            saveTime.Interval = 99999999;
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
                try
                {
                    System.IO.TextWriter textWriter = new System.IO.StreamWriter(fileName);
                    textWriter.Write(MainTextBox.Text);
                    textWriter.Close();
                }

                catch (Exception)
                {
                    //NYI
                }
            }
        }

        /// <summary>
        /// Allows user to clear the notepad.
        /// </summary>
        /// <param name="sender"> A reference to the object that raised the event. </param>
        /// <param name="e"> Contains the function's event data. </param>
        private void clearNoteButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            MainTextBox.Clear();
            MainTextBox.Focus();
            Drawings = new List<Drawing>();
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
                //clearing notesheet
                MainTextBox.Text = "";
                graphics.Clear(Color.White);

                fileName = fileDialog.FileName;
                System.IO.TextReader textReader = new System.IO.StreamReader(fileName);
                //set to true when drawing information has been reached
                bool isDrawing = false;
                while((line = textReader.ReadLine()) != null)
                {
                    if((line = textReader.ReadLine()) == "€--------------------------------€")
                    {
                          isDrawing = true;
                    }

                    if(isDrawing == false)
                    {
                          try
                          {        
                              MainTextBox.AppendText(line);
                          }
                          catch(Exception)
                          {
                              //do nothing
                          }
                    }

                    else
                    {
                        //draw
                        string drawingInfo = line;
                        List<int> commaIndices = new List<int>();
                        int openBracketIndex = 0;
                        int closedBracketIndex = 0;
                        if(drawingInfo != null)
                        {
                            for(int i = 0; i < drawingInfo.Length; i++)
                            {
                                if(drawingInfo[i] == ',')
                                {
                                    commaIndices.Add(i);
                                }

                                if(drawingInfo[i] == '[')
                                {
                                    openBracketIndex = i;
                                }

                                if(drawingInfo[i] == ']')
                                {
                                    closedBracketIndex = i;
                                }
                            }

                            try
                            {
                                //getting the indices of commas
                                int xStartIndex = commaIndices[0];
                                int yStartIndex = commaIndices[1];
                                int xEndIndex = commaIndices[2];
                                int yEndIndex = commaIndices[3];
                                int colorIndex = commaIndices[4];
                                
                                //setting drawing values
                                int xStart = Int32.Parse(drawingInfo.Substring(0, xStartIndex));
                                int yStart = Int32.Parse(drawingInfo.Substring(xStartIndex + 1, yStartIndex - xStartIndex - 1));
                                int xEnd = Int32.Parse(drawingInfo.Substring(yStartIndex + 1, xEndIndex - yStartIndex - 1));
                                int yEnd = Int32.Parse(drawingInfo.Substring(xEndIndex + 1, yEndIndex - xEndIndex - 1));
                                Color color = Color.FromName(drawingInfo.Substring(openBracketIndex + 1, closedBracketIndex - openBracketIndex - 1));
                                int thickness = Int32.Parse(drawingInfo.Substring(colorIndex + 1, drawingInfo.Length - colorIndex - 1));

                                //draws the line
                                pen.Color = color;
                                if(thickness > 0)
                                {
                                      pen.Width = thickness;
                                }
                                Point startPoint = new Point(xStart, yStart);
                                Point endPoint = new Point(xEnd, yEnd);
                                graphics.DrawLine(pen, startPoint, endPoint);
                                Drawings.Add(new Drawing(startPoint, endPoint, pen.Color, pen.Width));
                            }

                            catch(Exception)
                            {
                                 //do nothing
                                 //MainTextBox.AppendText("Failed");
                            }
                        }
                    }
                }
                textReader.Close();
                int numImages = 0;
                /*UTF8Encoding temp = new UTF8Encoding(true);
                using (FileStream fs = File.OpenRead(@"A:\AA--UW-STOUT\numImages.txt")) {
                    Byte[] b = new Byte[1024];
                    while (fs.Read(b, 0, b.Length) > 0) {
                        Console.WriteLine(temp.GetString(b));
                    }
                    numImages = Convert.ToInt32(b);
                }

                fileName = @"A:\AA--UW-STOUT\image1.bmp";
                PictureBox pictureBox = new PictureBox
                {
                    Name = "pictureBox",
                    Location = new Point(100, 100),
                    Visible = true,
                    Image = Bitmap.FromFile(fileName),
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Anchor = (AnchorStyles.Top | AnchorStyles.Left)
                };

                pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
                pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
                pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
                this.Controls.Add(pictureBox);
                pictureBox.Show();
                pictureBox.BringToFront();
                MainToolStrip.BringToFront();
                pictureBoxes.Add(pictureBox);
                
                if (numImages == 0)
                    pictureBoxes[numImages].Image.Save(@"A:\AA--UW-STOUT\image1.bmp", System.Drawing.Imaging.ImageFormat.Bmp); // testing purposes only
                if (numImages == 1)
                    pictureBoxes[numImages].Image.Save(@"A:\AA--UW-STOUT\image2.bmp", System.Drawing.Imaging.ImageFormat.Bmp); // testing purposes only
                if (numImages == 2)
                    pictureBoxes[numImages].Image.Save(@"A:\AA--UW-STOUT\image3.bmp", System.Drawing.Imaging.ImageFormat.Bmp); // testing purposes only
                
                numImages++;
                //de-selecting selected image
                selectedImageIndex = -1;
                for (int i = 0; i < pictureBoxes.Count; i++)
                {
                    pictureBoxes[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                }*/

                //locking the main text box
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

                //OLD
                //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                //pictureBox1.Load(fileName);

                PictureBox pictureBox = new PictureBox
                {
                    Name = "pictureBox",
                    Location = new Point(100, 100),
                    Visible = true,
                    Image = Bitmap.FromFile(fileName),
                    SizeMode = PictureBoxSizeMode.AutoSize,
                    Anchor = (AnchorStyles.Top | AnchorStyles.Left)
                };
                pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
                pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
                pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
                this.Controls.Add(pictureBox);
                pictureBox.Show();
                pictureBox.BringToFront();
                MainToolStrip.BringToFront();
                pictureBoxes.Add(pictureBox);
                /*if (numImages == 0)
                    pictureBoxes[numImages].Image.Save(@"A:\AA--UW-STOUT\image1.bmp", System.Drawing.Imaging.ImageFormat.Bmp); // testing purposes only
                if (numImages == 1)
                    pictureBoxes[numImages].Image.Save(@"A:\AA--UW-STOUT\image2.bmp", System.Drawing.Imaging.ImageFormat.Bmp); // testing purposes only
                if (numImages == 2)
                    pictureBoxes[numImages].Image.Save(@"A:\AA--UW-STOUT\image3.bmp", System.Drawing.Imaging.ImageFormat.Bmp); // testing purposes only

                numImages++;*/
            }

            //de-selecting selected image
            selectedImageIndex = -1;
            for(int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
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

        /// <summary>
        /// Detects when the user has pressed down the left or right mouse button while hovering over an image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
              isDragging = true;
              for(int i = 0; i < pictureBoxes.Count; i++)
              {
                  if(Cursor.Position.X >= pictureBoxes[i].Location.X + pictureBoxes[i].Width
                  && Cursor.Position.X <= pictureBoxes[i].Location.X + pictureBoxes[i].Width * 2
                  && Cursor.Position.Y >= pictureBoxes[i].Location.Y + pictureBoxes[i].Height
                  && Cursor.Position.Y <= pictureBoxes[i].Location.Y + pictureBoxes[i].Height * 2)
                  {
                        selectedImageIndex = i;
                        break;
                  }
              }

              for(int i = 0; i < pictureBoxes.Count; i++)
              {
                  if(i == selectedImageIndex)
                  {
                      pictureBoxes[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                      pictureBoxes[i].BringToFront();
                      MainToolStrip.BringToFront();
                  }

                  else
                  {
                      pictureBoxes[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                  }
              }
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

        /// <summary>
        /// Moves a selected image while the left mouse button is held. Rotates the selected image while the right mouse button is held.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                //Old
                //pictureBox1.Top = pictureBox1.Top + (e.Y - currentY);
                //pictureBox1.Left = pictureBox1.Left + (e.X - currentX);

                if (selectedImageIndex != -1)
                {
                    pictureBoxes[selectedImageIndex].Top = pictureBoxes[selectedImageIndex].Top + (e.Y - currentY);
                    pictureBoxes[selectedImageIndex].Left = pictureBoxes[selectedImageIndex].Left + (e.X - currentX);
                }
            }

            if(isRotating)
            {
                //rotate logic
            }
        }

        /// <summary>
        /// Sets isDragging to false when the left mouse button is released. Sets isRotating to false when the right mouse button is released.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Opens a website with the adress of the indicated hyperlink when a hyperlink is 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

    private void EditImageButton_Click(object sender, EventArgs e)
    {
        if (selectedImageIndex != -1)
        {
           this.Controls.Remove(pictureBoxes[selectedImageIndex]);
           pictureBoxes.RemoveAt(selectedImageIndex);
        }
    }

        /// <summary>
        /// Method to enable all calendar features when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalendarButton_Click(object sender, EventArgs e)
        {
            if(CalendarButton.BackColor == Color.White)
            {
                monthCalendar1.Visible = true;

                CalendarButton.DoubleClick += clicked;
                CalendarButton.BackColor = Color.Silver;
            }

            else
            {
                monthCalendar1.Visible = false;
                CalendarButton.BackColor = Color.White;   
            }
        }

        /// <summary>
        /// Old method to disable and reset calendar button when double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clicked(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            CalendarButton.BackColor = Color.White;
        }

        //OLD
        /// <summary>
        /// Method to disable hyperlink when it is double clicked by user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickedHyper(object sender, EventArgs e)
        {
            HyperlinkButton.BackColor = Color.White;
            linkLabel1.Visible = false;
            textBox1.Visible = false;
        }

        /// <summary>
        /// Method to show hyperlink when clicked and allows user to enter in a website name and apply it during runtime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HyperlinkButton_Click_1(object sender, EventArgs e)
        {
            if(HyperlinkButton.BackColor == Color.White)
            {
                linkLabel1.Visible = true;
                textBox1.Visible = true;
                HyperlinkButton.DoubleClick += clickedHyper;
                HyperlinkButton.BackColor = Color.Silver;
            }

            else
            {
                HyperlinkButton.BackColor = Color.White;
                linkLabel1.Visible = false;
                textBox1.Visible = false;
            }
        }

        /// <summary>
        /// Clickable link that takes the user to a valid website or does nothing if site is invalid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dynamicLinkLabel.LinkVisited = true;
            try
            {
                //Automatically places www. and .com at the start and end of the link respectively
                //System.Diagnostics.Process.Start("http://www." + textBox1.Text + ".com");

                //Uses the exact text in the text box
                System.Diagnostics.Process.Start(textBox1.Text);
            }
            catch (Exception)
            {
                //Do Nothing

            }
        }
        

    }
}
