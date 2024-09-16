namespace FunctionUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Pen lijnkleur = Pens.Black;
            Brush vulKleur = Brushes.Red;

            // Draw a rectangle at position (0, 0)
            g.DrawRectangle(lijnkleur, 0, 0, 50, 50);

            // Draw a filled rectangle at position (60, 0)
            g.FillRectangle(vulKleur, 60, 0, 30, 30);

            // Draw a rectangle at position (100, 0)
            g.DrawRectangle(lijnkleur, 100, 0, 100, 50);

            // Draw a triangle at position (0, 60)
            g.DrawLine(lijnkleur, 0, 60, 50, 110);
            g.DrawLine(lijnkleur, 50, 110, 100, 60);
            g.DrawLine(lijnkleur, 100, 60, 0, 60);

            // Draw a circle at position (120, 60)
            g.DrawEllipse(lijnkleur, 120, 60, 100, 100);
        }
    }
}
