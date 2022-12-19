using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineGraph
{
    public partial class LineGraphUserControl : UserControl
    {
        public Graph graph = new Graph();
        
        

        LineEditor lineEditor = new LineEditor();
        public LineGraphUserControl()
        {

            InitializeComponent();
            //graph.label_scale_Y_max = lbl_scale_Y_high;
            //graph.label_scale_Y_min = lbl_scale_y_low;

            cmb_Select_Color.Items.Add("Black");
            cmb_Select_Color.Items.Add("Red");
            cmb_Select_Color.Items.Add("Blue");
            cmb_Select_Color.Items.Add("Green");
            cmb_Select_Color.Items.Add("Purple");

           
        }

        


        public class Graph
        {
            public List<Line> lines = new List<Line>();

         
            public float originalOffsetY = 100;
            public float originalOffsetX = 175;
            
            public float graphScaleX = 1.0f;
            public float graphScaleY = 1.0f;
            public void PlotGraph(PaintEventArgs e)
            {

                Console.WriteLine("Plotting Graph");
                
                foreach (Line line in lines)
                {
                    line.PlotLine(e);
                    
                }

            }


        }

        public class Line
        {
            public string Name;
            public List<Point> points = new List<Point>();
            public Color color = Color.Black;
            public Graph graph;
            

            public void PlotLine(PaintEventArgs e)
            {

                Console.WriteLine("Plotting Line"+ Name);
                //order the points in ascending x value or

                Point lastPoint = new Point(0,0);
                Brush brush = new SolidBrush(color);

                //set our original last point as the starting point.
                if (points.Count > 0)
                {
                    lastPoint = points[0];
                    using (Font font = new Font("Arial", 10)) 
                    {
                       
                        e.Graphics.DrawString(Name, font, brush, new System.Drawing.Point((int)graph.originalOffsetX+(int)points[points.Count - 1].X, (int)graph.originalOffsetY-(int)points[points.Count - 1].Y));
                    }

                }


                Pen pen = new Pen(color, 1 ); 

                //loop through all points
                foreach (Point point in points)
                {
                    Console.WriteLine("Plotting point: " + point);

                   
                   
                    e.Graphics.DrawLine(pen, graph.originalOffsetX+lastPoint.X, graph.originalOffsetY-lastPoint.Y, graph.originalOffsetX+point.X, graph.originalOffsetY-point.Y);

                    
                    //set current point as last point
                    lastPoint = point;
                }

            }
        }

        public class Point
        {
            public Point(float x, float y)
            {
                this.X = x;
                this.Y = y;
            }
            public float X;
            public float Y;
        }

        public class LineEditor
        {
            public Line activeLine;
            public Point activePoint;
        }

        private void btn_Add_New_Line(object sender, EventArgs e)
        {
                    Line newLine = new Line();
                    newLine.Name = "Line " + graph.lines.Count;

                    graph.lines.Add(newLine);
                    newLine.graph = graph;
                    cmb_SelectLine.Items.Add(newLine.Name);
                    cmb_SelectLine.SelectedIndex = graph.lines.Count-1;
                    cmb_Select_Color.SelectedIndex = 0;
        }

        private void cmb_SelectLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                lineEditor.activeLine = graph.lines[cmb_SelectLine.SelectedIndex];
                //clear combobox
                cmb_Select_Point.Items.Clear();
                //update points available for selection in combobox
                for (int i = 0; i < lineEditor.activeLine.points.Count; i++)
                {
                    cmb_Select_Point.Items.Add("Point " + i);
                }

                Console.WriteLine("Selected line: " + lineEditor.activeLine.Name);
            
        }

        private void btn_update_graph_Click(object sender, EventArgs e)
        {
           
            //redraw graph and lines
          
          

            this.Refresh();

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            graph.PlotGraph(e);
        }



        private void cmb_Line_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Console.WriteLine(cmb_Select_Color.SelectedItem);
                switch (cmb_Select_Color.SelectedItem)
                {
                    case "Black":
                        lineEditor.activeLine.color = Color.Black;
                        break;
                    case "Red":
                        lineEditor.activeLine.color = Color.Red;
                        break;
                    case "Blue":
                        lineEditor.activeLine.color = Color.Blue;
                        break;
                    case "Green":
                        lineEditor.activeLine.color = Color.Green;
                        break;
                    case "Purple":
                        lineEditor.activeLine.color = Color.Purple;
                        break;
                }


                img_line_editor_color.BackColor = lineEditor.activeLine.color;
                //Console.WriteLine("Selected Color " + lineEditor.activeLine.color.Name + " for line: " + lineEditor.activeLine.Name);
            }
            catch
            {
                Console.WriteLine("No active Line in line editor!");
            }

            //refresh graph
            btn_update_graph_Click(sender, e);
        }

        
        private void btn_Point_Editor_Newpoint_Click(object sender, EventArgs e)
        {
            try
            {
                Point newPoint = new Point(int.Parse(textbox_pointEditor_inputX.Text), int.Parse(textbox_pointEditor_inputY.Text));
                lineEditor.activeLine.points.Add(newPoint);
                cmb_Select_Point.Items.Add("Point " + (lineEditor.activeLine.points.Count - 1));
                Console.WriteLine("Added new point (" + textbox_pointEditor_inputX.Text + ", " + textbox_pointEditor_inputY.Text + ") to line" + lineEditor.activeLine.Name);
                cmb_Select_Point.SelectedIndex = lineEditor.activeLine.points.Count - 1;
            }
            catch
            {
                Console.WriteLine("No active point in line editor!");
            }

            
            btn_update_graph_Click(sender, e);
        }

        
        private void cmb_Select_Point_SelectedIndexChanged(object sender, EventArgs e)
        {
            lineEditor.activePoint = lineEditor.activeLine.points[cmb_Select_Point.SelectedIndex];

            Console.WriteLine("active point set: (" + lineEditor.activePoint.X + ", " + lineEditor.activePoint.Y + ").");
            textbox_pointEditor_inputX.Text = lineEditor.activePoint.X.ToString();
            textbox_pointEditor_inputY.Text = lineEditor.activePoint.Y.ToString();
        }

       

        private void btn_update_point_Click_1(object sender, EventArgs e)
        {
            //make sure we have a line with points before update becomes available
            if (lineEditor.activeLine != null) {
                if (lineEditor.activeLine.points.Count > 0)
                {
                    int pointToChangeIndex = 0;
                    //Find the Point we need to change
                    for (int i = 0; i < lineEditor.activeLine.points.Count; i++)
                    {
                        if (lineEditor.activeLine.points[i] == lineEditor.activePoint)
                        {
                            pointToChangeIndex = i;
                        }
                    }
                    //update the points coordinates
                    lineEditor.activeLine.points[pointToChangeIndex] = new Point(int.Parse(textbox_pointEditor_inputX.Text), int.Parse(textbox_pointEditor_inputY.Text));


                    //Refresh the graph
                    btn_update_graph_Click(sender, e);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
