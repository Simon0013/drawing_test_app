using FastReportsTestApp.Models;
using Rectangle = FastReportsTestApp.Models.Rectangle;

namespace FastReportsTestApp
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Primitive? primitive;

        private string oldWidthTxt, oldHeightTxt, oldXTxt, oldYTxt, oldXCheck, oldYCheck;
        private Color border, fill;

        public Form1()
        {
            InitializeComponent();
            graphics = drawPanel.CreateGraphics();
        }

        private void InitializePrimitive()
        {
            primitive.Width = (int)Convert.ToDouble(width.Text.Replace(".", ","));
            primitive.Height = (int)Convert.ToDouble(height.Text.Replace(".", ","));

            var point = new Point();
            point.X = (int)Convert.ToDouble(xCoord.Text.Replace(".", ","));
            point.Y = (int)Convert.ToDouble(yCoord.Text.Replace(".", ","));
            if (primitive is Circle)
                (primitive as Circle).Center = point;
            else if (primitive is Rectangle)
                (primitive as Rectangle).StartPoint = point;
            else
                (primitive as EqualTriangle).StartPoint = point;
        }

        private void GetTriangleHeight()
        {
            if (primitive is EqualTriangle && width.Text.Length > 0)
            {
                double w = Convert.ToDouble(width.Text);
                double h = Math.Sqrt(w * w - 0.25 * w * w);
                height.Text = h.ToString();
            }
        }

        private void chooseFigCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (chooseFigCb.SelectedIndex)
            {
                case 0:
                    primitive = new Circle();
                    label3.Text = "Координаты центра";
                    label6.Text = "Радиус";
                    height.Text = "0";
                    height.Enabled = false;
                    break;
                case 1:
                    primitive = new Rectangle();
                    label3.Text = "Координаты левой верхней точки";
                    label6.Text = "Ширина";
                    height.Enabled = true;
                    break;
                case 2:
                    primitive = new EqualTriangle();
                    label3.Text = "Координаты верхней точки";
                    label6.Text = "Ширина";
                    height.Enabled = false;
                    GetTriangleHeight();
                    break;
            }
        }

        private void width_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateNumberField(width.Text))
                width.Text = oldWidthTxt;
            else
                oldWidthTxt = width.Text;

            GetTriangleHeight();
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateNumberField(height.Text))
                height.Text = oldHeightTxt;
            else
                oldHeightTxt = height.Text;
        }

        private void xCoord_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateNumberField(xCoord.Text))
                xCoord.Text = oldXTxt;
            else
                oldXTxt = xCoord.Text;
        }

        private void yCoord_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateNumberField(yCoord.Text))
                yCoord.Text = oldYTxt;
            else
                oldYTxt = yCoord.Text;
        }

        private bool ValidateNumberField(string value)
        {
            if (value.Length == 0) return true;

            bool hasComma = false;

            if (!char.IsAsciiDigit(value[0])) return false;

            if (value.Length == 1) return true;

            for (int i = 1; i < value.Length; i++)
            {
                if (!char.IsAsciiDigit(value[i]))
                {
                    if (hasComma) return false;

                    if (value[i] == ',' || value[i] == '.')
                    {
                        hasComma = true;
                    }
                    else return false;
                }
            }

            return true;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            if (primitive is null)
            {
                MessageBox.Show("Вы не выбрали фигуру!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (width.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели ширину фигуры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (height.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели высоту фигуры!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (xCoord.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели координату Х!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yCoord.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели координату Y!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            primitive.BorderColor = border;
            primitive.FillColor = fill;

            InitializePrimitive();

            graphics.Clear(SystemColors.Control);
            primitive.Show(graphics);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            graphics.Clear(SystemColors.Control);
        }

        private void chooseFillColorCb_Click(object sender, EventArgs e)
        {
            if (primitive is null)
            {
                MessageBox.Show("Вы не выбрали фигуру!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ColorDialog dlg = new ColorDialog();
            dlg.ShowHelp = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fill = dlg.Color;
                chooseFillColorCb.Text = dlg.Color.Name;
            }
        }

        private void chooseBorderColorCb_Click(object sender, EventArgs e)
        {
            if (primitive is null)
            {
                MessageBox.Show("Вы не выбрали фигуру!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ColorDialog dlg = new ColorDialog();
            dlg.ShowHelp = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                border = dlg.Color;
                chooseBorderColorCb.Text = dlg.Color.Name;
            }
        }

        private void xCoordCheck_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateNumberField(xCoordCheck.Text))
                xCoordCheck.Text = oldXCheck;
            else
                oldXCheck = xCoordCheck.Text;

            if (primitive is not null && xCoordCheck.Text.Length > 0 && yCoordCheck.Text.Length > 0
                && xCoord.Text.Length > 0 && yCoord.Text.Length > 0 && width.Text.Length > 0 && height.Text.Length > 0)
                checkBtn.Enabled = true;
            else checkBtn.Enabled = false;
        }

        private void yCoordCheck_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateNumberField(yCoordCheck.Text))
                yCoordCheck.Text = oldYCheck;
            else
                oldYCheck = yCoordCheck.Text;

            if (primitive is not null && xCoordCheck.Text.Length > 0 && yCoordCheck.Text.Length > 0
                && xCoord.Text.Length > 0 && yCoord.Text.Length > 0 && width.Text.Length > 0 && height.Text.Length > 0)
                checkBtn.Enabled = true;
            else checkBtn.Enabled = false;
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            InitializePrimitive();
            var point = new Point((int)Convert.ToDouble(xCoordCheck.Text.Replace(".", ",")), (int)Convert.ToDouble(yCoordCheck.Text.Replace(".", ",")));
            resultLbl.Text = primitive.CheckPoint(point) ? "Результат: входит" : "Результат: не входит";
        }
    }
}