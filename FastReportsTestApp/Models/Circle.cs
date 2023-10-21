namespace FastReportsTestApp.Models
{
    /// <summary>
    /// Класс круга
    /// </summary>
    public class Circle : Primitive
    {
        /// <summary>
        /// Координаты центра окружности
        /// </summary>
        public Point Center { get; set; }

        /// <summary>
        /// Радиус окружности
        /// </summary>
        public int Radius { get { return Width; } set { Width = value; } }

        public override bool CheckPoint(Point point)
        {
            var tmp = Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2);
            return tmp <= Radius * Radius;
        }

        public override void Show(Graphics graphics)
        {
            var rect = new System.Drawing.Rectangle(Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);

            Pen pen = new Pen(BorderColor);
            graphics.DrawEllipse(pen, rect);

            Brush brush = new SolidBrush(FillColor);
            graphics.FillEllipse(brush, rect);
        }
    }
}
