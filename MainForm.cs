using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Draw_Figures
{
    public partial class MainForm : Form
    {
        private List<BaseShape> figureList;
        private Dictionary<FigureTypes, string> figure_names;

        public MainForm()
        {
            InitializeComponent();
            cbFigure.SelectedValue = 0;

            figureList = new List<BaseShape>();

            figure_names = new Dictionary<FigureTypes, string>
            {
                { FigureTypes.Ellipse, "Овал"},
                { FigureTypes.Rectangle, "Прямоугольник"},
                { FigureTypes.Polygon, "Полигон"},
                { FigureTypes.Curve, "Кривая"},
                { FigureTypes.ClosedCurve, "Замкнутая кривая"}
            };
            List<KeyValuePair<FigureTypes, string>> tmp = figure_names.ToList();
            cbFigure.DataSource = tmp;
            cbFigure.ValueMember = "Key";
            cbFigure.DisplayMember = "Value";
            cbFigure.SelectedIndex = 0;
        }

        private void btPenColor_Click(object sender, EventArgs e)
        {
            if (CDpen.ShowDialog() == DialogResult.OK) p1.BackColor = CDpen.Color;
        }

        private void btDraw_Click(object sender, EventArgs e)
        {
            Point[] p_fig = new Point[tb.Lines.Length];
            Color penCol, brushCol;

            if (chPen.Checked) penCol = Color.Empty;
            else penCol = p1.BackColor;

            if (chBrush.Checked) brushCol = Color.Empty;
            else brushCol = p2.BackColor;

            char[] separator = { ';' };
            int validCount = 0;
            for (int i = 0; i < tb.Lines.Length; i++)
            {
                string[] XY = tb.Lines[i].Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
                if (XY.Length == 2)
                {
                    try
                    {
                        int x = Convert.ToInt32(XY[0]);
                        int y = Convert.ToInt32(XY[1]);
                        p_fig[validCount] = new Point(x, y);
                        validCount++;
                    }
                    catch
                    { }
                }
            }
            Array.Resize(ref p_fig, validCount);

            BaseShape figure = get_fig(
                (FigureTypes)cbFigure.SelectedValue,
                new Point((int)udx.Value, (int)udy.Value),
                new Size((int)udW.Value, (int)udH.Value),
                p_fig,
                new Pen(penCol, (int)udT.Value),
                new SolidBrush(brushCol));

            if (figure != null)
            {
                figure.Draw(PB);
                figureList.Add(figure);
            }
        }

        private BaseShape get_fig(FigureTypes fig_type, Point point, Size size, Point[] points, Pen pen, SolidBrush brush)
        {
            BaseShape figure;
            switch (fig_type)
            {
                case FigureTypes.Ellipse:
                    {
                        figure = new EllipseFigure(point.X, point.Y, size.Width, size.Height);
                        break;
                    }
                case FigureTypes.Rectangle:
                    {
                        figure = new RectangleFigure(point.X, point.Y, size.Width, size.Height);
                        break;
                    }
                case FigureTypes.Polygon:
                    {
                        figure = new PolygonFigure(points);
                        break;
                    }
                case FigureTypes.Curve:
                    {
                        figure = new CurveFigure(points);
                        break;
                    }
                case FigureTypes.ClosedCurve:
                    {
                        figure = new ClosedCurveFigure(points);
                        break;
                    }
                default:
                    {
                        figure = null;
                        break;
                    }
            }

            if (figure != null)
            {
                figure.SetCol(pen.Color, (int)pen.Width, brush.Color);
            }
            return figure;
        }

        private void drawFigureList()
        {
            PB.Refresh();

            foreach (BaseShape fig in figureList)
                fig.Draw(PB);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbFigure.SelectedValue % 2 == 0)
            {
                tb.Visible = true;
                btClearTb.Visible = true;
                p_coord.Visible = false;
            }
            else
            {
                tb.Visible = false;
                btClearTb.Visible = false;
                p_coord.Visible = true;
            };
            tb.Text = "";
        }

        private void btBrushColor_Click(object sender, EventArgs e)
        {
            if (CDbrush.ShowDialog() == DialogResult.OK) p2.BackColor = CDbrush.Color;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            PB.Refresh();
            tb.Text = "";
            figureList.Clear();
        }

        private void PB_MouseClick(object sender, MouseEventArgs e)
        {
            switch ((FigureTypes)cbFigure.SelectedValue)
            {
                case FigureTypes.Ellipse:
                    {
                        udx.Value = e.X;
                        udy.Value = e.Y;
                        break;
                    }
                case FigureTypes.Rectangle:
                    {
                        udx.Value = e.X;
                        udy.Value = e.Y;
                        break;
                    }
                case FigureTypes.Polygon:
                    {
                        tb.AppendText(e.X + ";" + e.Y + Environment.NewLine);
                        break;
                    }
                case FigureTypes.Curve:
                    {
                        tb.AppendText(e.X + ";" + e.Y + Environment.NewLine);
                        break;
                    }
                case FigureTypes.ClosedCurve:
                    {
                        tb.AppendText(e.X + ";" + e.Y + Environment.NewLine);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            if (ModifierKeys == Keys.Control)
                PB.CreateGraphics().FillRectangle(Brushes.Black, Rectangle.FromLTRB(e.X - 1, e.Y - 1, e.X + 1, e.Y + 1));
            if (ModifierKeys == Keys.Alt)
            {
                BaseShape figure;
                Color penCol, brushCol;

                if (chPen.Checked) penCol = Color.Empty;
                else penCol = p1.BackColor;

                if (chBrush.Checked) brushCol = Color.Empty;
                else brushCol = p2.BackColor;

                Point[] p_fig = new Point[tb.Lines.Length];
                char[] separator = { ';' };
                int validCount = 0;
                for (int i = 0; i < tb.Lines.Length; i++)
                {
                    string[] XY = tb.Lines[i].Split(separator, 2, StringSplitOptions.RemoveEmptyEntries);
                    if (XY.Length == 2)
                    {
                        try
                        {
                            int x = Convert.ToInt32(XY[0]);
                            int y = Convert.ToInt32(XY[1]);
                            p_fig[validCount] = new Point(x, y);
                            validCount++;
                        }
                        catch
                        { }
                    }
                }
                Array.Resize(ref p_fig, validCount);

                switch ((FigureTypes)cbFigure.SelectedValue)
                {
                    case FigureTypes.Ellipse:
                        {
                            figure = new EllipseFigure((int)udx.Value, (int)udy.Value, (int)udW.Value, (int)udH.Value, penCol, (int)udT.Value, brushCol);
                            figure.Draw(PB);
                            figureList.Add(figure);
                            break;
                        }
                    case FigureTypes.Rectangle:
                        {
                            figure = new RectangleFigure((int)udx.Value, (int)udy.Value, (int)udW.Value, (int)udH.Value, penCol, (int)udT.Value, brushCol);
                            figure.Draw(PB);
                            figureList.Add(figure);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                };
            }
        }

        private void rbEllip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PB_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PB_MouseMove(object sender, MouseEventArgs e)
        {
            tSSL.Text = e.X + ";" + e.Y;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btUndo_Click(object sender, EventArgs e)
        {
            if (figureList.Count > 0)
            {
                figureList.RemoveAt(figureList.Count - 1);
                drawFigureList();
            } 
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            drawFigureList();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            drawFigureList();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (sfdPoints.ShowDialog() == DialogResult.OK)
                File.WriteAllLines(sfdPoints.FileName, tb.Lines);           
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (ofdPoints.ShowDialog() == DialogResult.OK)
                tb.Lines = File.ReadAllLines(ofdPoints.FileName);
        }

        private void btSaveXml_Click_1(object sender, EventArgs e)
        {
            if (sfdXML.ShowDialog() == DialogResult.OK)
            {
                XmlDocument xml = new XmlDocument();
                XmlDeclaration declaration = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
                xml.AppendChild(declaration);

                XmlElement root = xml.CreateElement("Figures");
                xml.AppendChild(root);

                foreach (BaseShape fig in figureList)
                {
                    XmlNode node = xml.CreateElement("Figure");
                    XmlAttribute attribute = xml.CreateAttribute("Name");
                    attribute.Value = fig.getTypeStr();
                    node.Attributes.Append(attribute);

                    XmlNode child = xml.CreateElement("Pen");
                    attribute = xml.CreateAttribute("Width");
                    attribute.Value = fig.getPen().Width.ToString();
                    child.Attributes.Append(attribute);
                    child.InnerText = fig.getPen().Color.ToArgb().ToString();
                    node.AppendChild(child);

                    child = xml.CreateElement("Brush");
                    child.InnerText = fig.getBrush().Color.ToArgb().ToString();
                    node.AppendChild(child);

                    if(!fig.IsPoly())
                    {
                        child = xml.CreateElement("TopLeft");
                        attribute = xml.CreateAttribute("X");
                        attribute.Value = fig.getPoint().X.ToString();
                        child.Attributes.Append(attribute);
                        attribute = xml.CreateAttribute("Y");
                        attribute.Value = fig.getPoint().Y.ToString();
                        child.Attributes.Append(attribute);
                        node.AppendChild(child);

                        child = xml.CreateElement("Size");
                        attribute = xml.CreateAttribute("Width");
                        attribute.Value = fig.getSize().Width.ToString();
                        child.Attributes.Append(attribute);
                        attribute = xml.CreateAttribute("Height");
                        attribute.Value = fig.getSize().Height.ToString();
                        child.Attributes.Append(attribute);
                        node.AppendChild(child);
                    }
                    else
                    {
                        child = xml.CreateElement("Points");
                        foreach (Point p in fig.getPoints())
                        {
                            XmlNode pointNode = xml.CreateElement("Point");
                            attribute = xml.CreateAttribute("X");
                            attribute.Value = p.X.ToString();
                            pointNode.Attributes.Append(attribute);
                            attribute = xml.CreateAttribute("Y");
                            attribute.Value = p.Y.ToString();
                            pointNode.Attributes.Append(attribute);
                            child.AppendChild(pointNode);
                        }
                        node.AppendChild(child);
                    }
                    root.AppendChild(node);
                }
                xml.Save(sfdXML.FileName);
            }
        }

        private void btClearTb_Click(object sender, EventArgs e)
        {
            tb.Text="";
        }

        private void btLoadXml_Click(object sender, EventArgs e)
        {
            if (ofdXML.ShowDialog() == DialogResult.OK)
            {
                figureList.Clear();
                XmlDocument xml = new XmlDocument();
                xml.Load(ofdXML.FileName);
                XmlElement root = xml.DocumentElement;

                foreach(XmlNode node in root)
                {
                    int x = 0, y = 0, w = 0, h = 0 , pen_w = 1;
                    Color pen_color = Color.Empty, brush_color = Color.Empty;
                    List<Point> points = new List<Point>();
                    FigureTypes f_type;

                    string f_name = node.Attributes.GetNamedItem("Name").Value;
                    if (Enum.IsDefined(typeof(FigureTypes), f_name))
                    {
                        f_type = (FigureTypes)Enum.Parse(typeof(FigureTypes), f_name);
                    }
                    else
                        f_type = FigureTypes.Unknown;

                    foreach(XmlNode child_node in node.ChildNodes)
                    {
                        if(child_node.Name == "Pen")
                        {
                            pen_w = Convert.ToInt32(child_node.Attributes.GetNamedItem("Width").Value);
                            pen_color = Color.FromArgb(Convert.ToInt32(child_node.InnerText));
                        }
                        else if(child_node.Name == "Brush")
                        {
                            brush_color = Color.FromArgb(Convert.ToInt32(child_node.InnerText));
                        }
                        else if (child_node.Name == "Size")
                        {
                            w = Convert.ToInt32(child_node.Attributes.GetNamedItem("Width").Value);
                            h = Convert.ToInt32(child_node.Attributes.GetNamedItem("Height").Value);
                        }
                        else if (child_node.Name == "TopLeft")
                        {
                            x = Convert.ToInt32(child_node.Attributes.GetNamedItem("X").Value);
                            y = Convert.ToInt32(child_node.Attributes.GetNamedItem("Y").Value);
                        }
                        else if (child_node.Name == "Points")
                        {
                            foreach(XmlNode point_node in child_node.ChildNodes)
                            {
                                if (point_node.Name == "Point")
                                {
                                    int p_x = Convert.ToInt32(point_node.Attributes.GetNamedItem("X").Value);
                                    int p_y = Convert.ToInt32(point_node.Attributes.GetNamedItem("Y").Value);
                                    points.Add(new Point(p_x, p_y));

                                }
                            }
                        }
                    }
                    figureList.Add(get_fig(
                            f_type,
                            new Point(x, y),
                            new Size(w, h),
                            points.ToArray(),
                            new Pen(pen_color, pen_w),
                            new SolidBrush(brush_color)));
                }
                this.Invalidate();
            }
        }

        private void btSaveP_Click(object sender, EventArgs e)
        {
            if (sfdPic.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(PB.Width, PB.Height);
                var graphics = Graphics.FromImage(bmp);
                var area = PB.RectangleToScreen(PB.ClientRectangle);
                graphics.CopyFromScreen(area.Location, Point.Empty, PB.Size);
                bmp.Save(sfdPic.FileName, ImageFormat.Png);
            }
        }
    }
}
