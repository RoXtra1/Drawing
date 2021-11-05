using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Draw_Figures
{
    public enum FigureTypes {Ellipse=1, Rectangle=3, Polygon=2, Curve=4, ClosedCurve=6, Unknown=0};

    public abstract class BaseShape
    {
        protected Point basePoint;
        protected Size size;
        protected Pen pen;
        protected SolidBrush brush;
        protected Rectangle rect;
        protected Point[] points;
        protected string figurename;
        protected FigureTypes figureType;

        public BaseShape()
        {
            SetDimensions();
            SetCol(Color.Empty, 1, Color.Empty);
            rect = new Rectangle(basePoint.X, basePoint.Y, size.Width, size.Height);
        }

        public BaseShape(int pX, int pY, int pW, int pH, Color penColor, int penThikness, Color brushColor)
        {
            SetDimensions(pX, pY, pW, pH);
            SetCol(penColor, penThikness, brushColor);
            rect = new Rectangle(basePoint, size);
        }

        public BaseShape(Point[] p_points, Color penColor, int penThikness, Color brushColor)
        {
            SetCol(penColor, penThikness, brushColor);
            points = p_points;
        }

        public BaseShape(Point[] p_points, Color penColor, int penThikness)
        {
            pen = new Pen(penColor, penThikness);
            points = p_points;
        }

        public BaseShape(Point[] p_points)
        {
            points = p_points;
        }

        public BaseShape(int pX, int pY, int pW, int pH)
        {
            SetDimensions(pX, pY, pW, pH);
            rect = new Rectangle(basePoint, size);
        }

        public void Draw(Control control)
        {
            Graphics canvas = control.CreateGraphics();
            DrawFigure(canvas);
        }

        public virtual void DrawFigure(Graphics graph)
        { }

        public void SetPoints(Point[] p_points)
        {
            points = p_points;
        }

        public void SetDimensions(int pX = 10, int pY = 10, int pW = 300, int pH = 300)
        {
            basePoint.X = pX;
            basePoint.Y = pY;
            size.Width = pW;
            size.Height = pH;
        }

        public void SetCol(Color penColor, int penThikness, Color brushColor)
        {
            setPen(penColor, penThikness);
            setBrush(brushColor);
        }

        public void SetPointsList(string[] strList)
        {
            List<Point> vertex;
            vertex = new List<Point> { };
            char[] separator = { ';' };
            for (int i = 0; i < strList.Length; i++)
            {
                string[] XY = strList[i].Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
                if (XY.Length == 2)
                {
                    try
                    {
                        int x = Convert.ToInt32(XY[0]);
                        int y = Convert.ToInt32(XY[1]);
                        vertex.Add(new Point(x, y));
                    }
                    catch
                    { }
                }
            }
            points = vertex.ToArray();
        }

        public void setPen(Color penColor, int penW)
        {
            pen = new Pen(penColor, penW);
        }

        public void setBrush(Color brushColor)
        {
            brush = new SolidBrush(brushColor);
        }

        public void setName(string figname)
        {
            figurename = figname;
        }

        public Point[] getPoints()
        {
            return points;
        }

        public Point getPoint()
        {
            return basePoint;
        }

        public Size getSize()
        {
            return size;
        }

        public Pen getPen()
        {
            return pen;
        }

        public SolidBrush getBrush()
        {
            return brush;
        }

        public string getName()
        {
            return figurename;
        }

        public string getTypeStr()
        {
            return figureType.ToString();
        }

        public FigureTypes getType()
        {
            return figureType;
        }

        public bool IsPoly()
        {
            return (int)figureType % 2 == 0;
        }
    }

    public class EllipseFigure : BaseShape
    {
        public EllipseFigure() : base()
        {
            figureType = FigureTypes.Ellipse;
        }

        public EllipseFigure(int pX, int pY, int pW, int pH, Color penColor, int penThikness, Color brushColor) :base(pX, pY, pW, pH, penColor, penThikness, brushColor)
        {
            figureType = FigureTypes.Ellipse;
        }

        public EllipseFigure(int pX, int pY, int pW, int pH) : base(pX, pY, pW, pH)
        {
            figureType = FigureTypes.Ellipse;
        }

        public override void DrawFigure(Graphics graph)
        {
            graph.FillEllipse(brush, rect);
            graph.DrawEllipse(pen, rect);
        }
    }

    public class RectangleFigure : BaseShape
    {
        public RectangleFigure() : base()
        {
            figureType = FigureTypes.Rectangle;
        }

        public RectangleFigure(int pX, int pY, int pW, int pH, Color penColor, int penThikness, Color brushColor) : base(pX, pY, pW, pH, penColor, penThikness, brushColor)
        {
            figureType = FigureTypes.Rectangle;
        }

        public RectangleFigure(int pX, int pY, int pW, int pH) : base(pX, pY, pW, pH)
        {
            figureType = FigureTypes.Rectangle;
        }

        public override void DrawFigure(Graphics graph)
        {
            graph.FillRectangle (brush, rect);
            graph.DrawRectangle(pen, rect);
        }
    }

    public class PolygonFigure : BaseShape
    {
        public PolygonFigure() : base()
        {
            figureType = FigureTypes.Polygon;
        }

        public PolygonFigure(Point[] p_points, Color penColor, int penThikness, Color brushColor) : base(p_points, penColor, penThikness, brushColor)
        {
            points = p_points;
            pen = new Pen(penColor, penThikness);
            brush = new SolidBrush(brushColor);
            figureType = FigureTypes.Polygon;
        }

        public PolygonFigure(int pX, int pY, int pW, int pH) : base(pX, pY, pW, pH)
        {
            figureType = FigureTypes.Polygon;
        }

        public PolygonFigure(Point[] p_points) : base(p_points)
        {
            figureType = FigureTypes.Polygon;
        }

        public override void DrawFigure(Graphics graph)
        {
            graph.FillPolygon(brush, points);
            graph.DrawPolygon(pen, points);
        }
    }

    public class CurveFigure : BaseShape
    {
        public CurveFigure() : base()
        {
            figureType = FigureTypes.Curve;
        }

        public CurveFigure(Point[] p_points, Color penColor, int penThikness) : base(p_points, penColor, penThikness)
        {
            points = p_points;
            pen = new Pen(penColor, penThikness);
            figureType = FigureTypes.Curve;
        }

        public CurveFigure(int pX, int pY, int pW, int pH) : base(pX, pY, pW, pH)
        {
            figureType = FigureTypes.Curve;
        }

        public CurveFigure(Point[] p_points) : base(p_points)
        {
            figureType = FigureTypes.Curve;
        }

        public override void DrawFigure(Graphics graph)
        {
            graph.DrawCurve(pen, points);
        }
    }

    public class ClosedCurveFigure : BaseShape
    {
        public ClosedCurveFigure() : base()
        {
            figureType = FigureTypes.ClosedCurve;
        }

        public ClosedCurveFigure(Point[] p_points, Color penColor, int penThikness, Color brushColor) : base(p_points, penColor, penThikness)
        {
            points = p_points;
            pen = new Pen(penColor, penThikness);
            brush = new SolidBrush(brushColor);
            figureType = FigureTypes.ClosedCurve;
        }

        public ClosedCurveFigure(int pX, int pY, int pW, int pH) : base(pX, pY, pW, pH)
        {
            figureType = FigureTypes.ClosedCurve;
        }

        public ClosedCurveFigure(Point[] p_points) : base(p_points)
        {
            figureType = FigureTypes.ClosedCurve;
        }

        public override void DrawFigure(Graphics graph)
        {
            graph.FillClosedCurve(brush, points);
            graph.DrawClosedCurve(pen, points);
        }
    }
}
