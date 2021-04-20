using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuickNote
{
  class Drawing
  {
    //start point of the drawing
    private Point startPoint;
    //end point of the drawing
    private Point endPoint;
    //color of the drawing
    private Color color;
    //line thickness of the drawing
    private float thickness;

    /// <summary>
    /// Constructor for the drawing
    /// </summary>
    /// <param name="startPoint"></param>
    /// <param name="endPoint"></param>
    /// <param name="color"></param>
    /// <param name="thickness"></param>
    public Drawing(Point startPoint, Point endPoint, Color color, float thickness)
    {
      this.startPoint = startPoint;
      this.endPoint = endPoint;
      this.color = color;
      this.thickness = thickness;
    }

    /// <summary>
    /// startPoint getter
    /// </summary>
    /// <returns></returns>
    public Point getStartPoint()
    {
      return this.startPoint;
    }

    /// <summary>
    /// endPoint getter
    /// </summary>
    /// <returns></returns>
    public Point getEndPoint()
    {
      return this.endPoint;
    }

    /// <summary>
    /// color getter
    /// </summary>
    /// <returns></returns>
    public Color getColor()
    {
      return this.color;
    }

    /// <summary>
    /// thickness getter
    /// </summary>
    /// <returns></returns>
    public float getThickness()
    {
      return this.thickness;
    }
  }
}
