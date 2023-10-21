namespace FastReportsTestApp.Models
{
    /// <summary>
    /// Базовый класс графического примитива
    /// </summary>
    public abstract class Primitive
    {
        /// <summary>
        /// Цвет заливки
        /// </summary>
        public Color FillColor { get; set; }

        /// <summary>
        /// Цвет окантовки (рамки)
        /// </summary>
        public Color BorderColor { get; set; }

        /// <summary>
        /// Ширина
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Высота
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Метод вывода на Graphics
        /// </summary>
        public abstract void Show(Graphics graphics);

        /// <summary>
        /// Метод проверки лежит ли заданная точка внутри примитива
        /// </summary>
        /// <param name="point">Точка для проверки принадлежности</param>
        /// <returns>Лежит ли точка внутри примитива</returns>
        public abstract bool CheckPoint(Point point);
    }
}
