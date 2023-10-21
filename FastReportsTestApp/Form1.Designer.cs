namespace FastReportsTestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            acceptBtn = new Button();
            chooseFigCb = new ComboBox();
            chooseFillColorCb = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            xCoord = new TextBox();
            yCoord = new TextBox();
            label6 = new Label();
            label7 = new Label();
            width = new TextBox();
            height = new TextBox();
            chooseBorderColorCb = new Button();
            label8 = new Label();
            clearBtn = new Button();
            drawPanel = new Panel();
            checkPointPanel = new Panel();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            xCoordCheck = new TextBox();
            yCoordCheck = new TextBox();
            checkBtn = new Button();
            resultLbl = new Label();
            checkPointPanel.SuspendLayout();
            SuspendLayout();
            // 
            // acceptBtn
            // 
            acceptBtn.Location = new Point(686, 403);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.Size = new Size(92, 30);
            acceptBtn.TabIndex = 0;
            acceptBtn.Text = "OK";
            acceptBtn.UseVisualStyleBackColor = true;
            acceptBtn.Click += acceptBtn_Click;
            // 
            // chooseFigCb
            // 
            chooseFigCb.DropDownStyle = ComboBoxStyle.DropDownList;
            chooseFigCb.FormattingEnabled = true;
            chooseFigCb.Items.AddRange(new object[] { "Круг", "Прямоугольник", "Равносторонний треугольник" });
            chooseFigCb.Location = new Point(12, 408);
            chooseFigCb.Name = "chooseFigCb";
            chooseFigCb.Size = new Size(202, 23);
            chooseFigCb.TabIndex = 1;
            chooseFigCb.SelectedIndexChanged += chooseFigCb_SelectedIndexChanged;
            // 
            // chooseFillColorCb
            // 
            chooseFillColorCb.Location = new Point(247, 408);
            chooseFillColorCb.Name = "chooseFillColorCb";
            chooseFillColorCb.Size = new Size(177, 23);
            chooseFillColorCb.TabIndex = 2;
            chooseFillColorCb.UseVisualStyleBackColor = true;
            chooseFillColorCb.Click += chooseFillColorCb_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 373);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 3;
            label1.Text = "Выберите нужную фигуру";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 373);
            label2.Name = "label2";
            label2.Size = new Size(183, 15);
            label2.TabIndex = 4;
            label2.Text = "Выберите нужный цвет заливки";
            // 
            // label3
            // 
            label3.Location = new Point(390, 459);
            label3.Name = "label3";
            label3.Size = new Size(232, 15);
            label3.TabIndex = 5;
            label3.Text = "Координаты точки";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 493);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 6;
            label4.Text = "x";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 493);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 7;
            label5.Text = "y";
            // 
            // xCoord
            // 
            xCoord.Location = new Point(409, 490);
            xCoord.Name = "xCoord";
            xCoord.Size = new Size(78, 23);
            xCoord.TabIndex = 8;
            xCoord.TextChanged += xCoord_TextChanged;
            // 
            // yCoord
            // 
            yCoord.Location = new Point(544, 490);
            yCoord.Name = "yCoord";
            yCoord.Size = new Size(78, 23);
            yCoord.TabIndex = 9;
            yCoord.TextChanged += yCoord_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 459);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 10;
            label6.Text = "Ширина";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(189, 459);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 11;
            label7.Text = "Высота";
            // 
            // width
            // 
            width.Location = new Point(12, 490);
            width.Name = "width";
            width.Size = new Size(115, 23);
            width.TabIndex = 12;
            width.TextChanged += width_TextChanged;
            // 
            // height
            // 
            height.Location = new Point(189, 490);
            height.Name = "height";
            height.Size = new Size(115, 23);
            height.TabIndex = 13;
            height.TextChanged += height_TextChanged;
            // 
            // chooseBorderColorCb
            // 
            chooseBorderColorCb.Location = new Point(463, 408);
            chooseBorderColorCb.Name = "chooseBorderColorCb";
            chooseBorderColorCb.Size = new Size(177, 23);
            chooseBorderColorCb.TabIndex = 14;
            chooseBorderColorCb.UseVisualStyleBackColor = true;
            chooseBorderColorCb.Click += chooseBorderColorCb_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(463, 373);
            label8.Name = "label8";
            label8.Size = new Size(174, 15);
            label8.TabIndex = 15;
            label8.Text = "Выберите нужный цвет рамки";
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(686, 485);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(92, 30);
            clearBtn.TabIndex = 25;
            clearBtn.Text = "Очистить";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // drawPanel
            // 
            drawPanel.Location = new Point(12, 5);
            drawPanel.Name = "drawPanel";
            drawPanel.Size = new Size(776, 356);
            drawPanel.TabIndex = 17;
            // 
            // checkPointPanel
            // 
            checkPointPanel.BorderStyle = BorderStyle.FixedSingle;
            checkPointPanel.Controls.Add(label9);
            checkPointPanel.Controls.Add(label10);
            checkPointPanel.Controls.Add(label11);
            checkPointPanel.Controls.Add(label12);
            checkPointPanel.Controls.Add(xCoordCheck);
            checkPointPanel.Controls.Add(yCoordCheck);
            checkPointPanel.Controls.Add(checkBtn);
            checkPointPanel.Controls.Add(resultLbl);
            checkPointPanel.Location = new Point(12, 535);
            checkPointPanel.Name = "checkPointPanel";
            checkPointPanel.Size = new Size(776, 123);
            checkPointPanel.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 0);
            label9.Name = "label9";
            label9.Size = new Size(265, 15);
            label9.TabIndex = 19;
            label9.Text = "Проверка вхождения заданной точки в фигуру";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 25);
            label10.Name = "label10";
            label10.Size = new Size(110, 15);
            label10.TabIndex = 20;
            label10.Text = "Координаты точки";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 55);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 21;
            label11.Text = "x";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(117, 55);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 22;
            label12.Text = "y";
            // 
            // xCoordCheck
            // 
            xCoordCheck.Location = new Point(22, 52);
            xCoordCheck.Name = "xCoordCheck";
            xCoordCheck.Size = new Size(78, 23);
            xCoordCheck.TabIndex = 23;
            xCoordCheck.TextChanged += xCoordCheck_TextChanged;
            // 
            // yCoordCheck
            // 
            yCoordCheck.Location = new Point(136, 52);
            yCoordCheck.Name = "yCoordCheck";
            yCoordCheck.Size = new Size(78, 23);
            yCoordCheck.TabIndex = 24;
            yCoordCheck.TextChanged += yCoordCheck_TextChanged;
            // 
            // checkBtn
            // 
            checkBtn.Enabled = false;
            checkBtn.Location = new Point(297, 48);
            checkBtn.Name = "checkBtn";
            checkBtn.Size = new Size(114, 29);
            checkBtn.TabIndex = 25;
            checkBtn.Text = "Старт";
            checkBtn.Click += checkBtn_Click;
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Location = new Point(3, 94);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(66, 15);
            resultLbl.TabIndex = 26;
            resultLbl.Text = "Результат: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 669);
            Controls.Add(acceptBtn);
            Controls.Add(chooseFigCb);
            Controls.Add(chooseFillColorCb);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(xCoord);
            Controls.Add(yCoord);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(width);
            Controls.Add(height);
            Controls.Add(chooseBorderColorCb);
            Controls.Add(label8);
            Controls.Add(clearBtn);
            Controls.Add(drawPanel);
            Controls.Add(checkPointPanel);
            Name = "Form1";
            Text = "Form1";
            checkPointPanel.ResumeLayout(false);
            checkPointPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button acceptBtn;
        private ComboBox chooseFigCb;
        private Button chooseFillColorCb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox xCoord;
        private TextBox yCoord;
        private Label label6;
        private Label label7;
        private TextBox width;
        private TextBox height;
        private Button chooseBorderColorCb;
        private Label label8;
        private Button clearBtn;
        private Panel drawPanel;
        private Panel checkPointPanel;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox xCoordCheck;
        private TextBox yCoordCheck;
        private Button checkBtn;
        private Label resultLbl;
    }
}