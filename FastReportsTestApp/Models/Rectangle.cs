namespace FastReportsTestApp.Models
{
    /// <summary>
    /// Класс прямоугольника
    /// </summary>
    public class Rectangle : Primitive
    {
        /// <summary>
        /// Координаты левой верхней точки прямоугольника
        /// </summary>
        public Point StartPoint { get; set; }

        public override bool CheckPoint(Point point)
        {
            var xInRange = point.X >= StartPoint.X && point.X <= (StartPoint.X + Width);
            var yInRange = point.Y >= StartPoint.Y && point.Y <= (StartPoint.Y + Height);
            return xInRange && yInRange;
        }

        public override void Show(Graphics graphics)
        {
            var rect = new System.Drawing.Rectangle(StartPoint, new Size(Width, Height));

            Pen pen = new Pen(BorderColor);
            graphics.DrawRectangle(pen, rect);

            Brush brush = new SolidBrush(FillColor);
            graphics.FillRectangle(brush, rect);
        }
    }
}
