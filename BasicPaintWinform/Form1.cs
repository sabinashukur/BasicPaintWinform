namespace BasicPaintWinform;

public partial class Form1 : Form
{

    Pen p = new Pen(Color.Black, 3);
    int x, y, h, w;
    string NameofClicked;
    Point Point;
    public Brush Brush { get; set; }

    public Form1()
    {
        InitializeComponent();
        Brush = new SolidBrush(Color.Black);

    }

    private void Form1_MouseUp(object sender, MouseEventArgs e)
    {
        h = e.X - x;
        w = e.Y - y;
        Graphics g = this.CreateGraphics();
        Rectangle shape = new Rectangle(x, y, w, h);
        if (rbtn_Pen.Checked)
        {
            if (NameofClicked == "circle")
            {
                g.DrawEllipse(p, shape);
            }

            else if (NameofClicked == "rectangle")
            {
                g.DrawRectangle(p, shape);

            }
            else if (NameofClicked == "line")
            {
                g.DrawLine(p, x, y, Point.X, Point.Y);
            }
        }
        else if (rbtn_Filled.Checked)
        {
            if (NameofClicked == "circle")
            {
                g.FillEllipse(Brush, shape);

            }

            else if (NameofClicked == "rectangle")
            {
                g.FillRectangle(Brush, shape);

            }

        }

    }

   
    private void Form1_MouseDown(object sender, MouseEventArgs e)
    {
        x = e.X;
        y = e.Y;
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {

        Point = e.Location;

    }

  

    private void btn_Clear_Click(object sender, EventArgs e)
    {
        Graphics g = this.CreateGraphics();
        g.Clear(Color.White);
    }

    private void btn_Color_Click(object sender, EventArgs e)
    {
        colorDialog1.ShowDialog();
        Brush = new SolidBrush(colorDialog1.Color);
        p.Color = colorDialog1.Color;
    }

    private void btn_Rectangle_Click(object sender, EventArgs e)
    {
        NameofClicked = "rectangle";

    }

    private void btn_Circle_Click(object sender, EventArgs e)
    {
        NameofClicked = "circle";

    }

    private void btn_Line_Click(object sender, EventArgs e)
    {
        NameofClicked = "line";

    }

}