namespace FastReportsTestApp.Models
{
    /// <summary>
    /// Класс равностороннего треугольника
    /// </summary>
    public class EqualTriangle : Primitive
    {
        /// <summary>
        /// Угол треугольника
        /// </summary>
        public double Angle { get; } = 60;

        /// <summary>
        /// Координаты вершины, расположенной равномерно от двух других
        /// </summary>
        public Point StartPoint { get; set; }

        public override bool CheckPoint(Point point)
        {
            var yInRange = point.Y >= StartPoint.Y && point.Y <= (StartPoint.Y + Height);
            var k = (double)(point.Y - StartPoint.Y) / Height;
            var xMin = StartPoint.X - k * Width / 2;
            var xMax = StartPoint.X + k * Width / 2;
            var xInRange = point.X >= xMin && point.X <= xMax;
            return xInRange && yInRange;
        }

        public override void Show(Graphics graphics)
        {
            var points = new Point[] {
                StartPoint,
                new Point(StartPoint.X + Width / 2, StartPoint.Y + Height),
                new Point(StartPoint.X - Width / 2, StartPoint.Y + Height),
                StartPoint
            };

            Pen pen = new Pen(BorderColor);
            graphics.DrawPolygon(pen, points);

            Brush brush = new SolidBrush(FillColor);
            graphics.FillPolygon(brush, points);
        }
    }
}
