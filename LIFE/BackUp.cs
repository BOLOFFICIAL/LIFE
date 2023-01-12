/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFE
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private Graphics graphics;
        private int resolution;
        private int density;
        private int alllife = 0;

        private bool[,] field;

        private int rows;
        private int columns;

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private int CountNeighbours(int I,int J) 
        {
            int count = 0;
            int col;
            int row;
            bool isself;
            bool haslife;
            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    col = (I + i + columns) % columns;
                    row = (J + j + rows) % rows;
                    isself = col == I && row == J;
                    haslife = field[col, row];
                    if (haslife && !isself) 
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void Initialization() 
        {
            if (timer1.Enabled&& buttonAction.Text=="Stop")
            {
                timer1.Stop();
                numericUpDown1Resolution.Enabled = true;
                numericUpDown2Density.Enabled = true;
                buttonAction.Text = "Start";
                buttonAction.BackColor = Color.FromArgb(1, 0, 192, 0);
                alllife = 0;
                return;
            }
            else 
            {
                alllife= 0;
                numericUpDown1Resolution.Enabled = false;
                numericUpDown2Density.Enabled = false;
                resolution = (int)numericUpDown1Resolution.Value;
                density = (int)numericUpDown2Density.Value;
                rows = pictureBox1.Height / resolution;
                columns = pictureBox1.Width / resolution;
                field = new bool[columns, rows];
                for (int i = 0; i < columns; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        field[i, j] = random.Next(density) == 0;
                        if (field[i, j]) 
                        {
                            alllife++;
                        }
                    }
                }
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                graphics = Graphics.FromImage(pictureBox1.Image);
                timer1.Start();
                buttonAction.Text = "Stop";
                buttonAction.BackColor = Color.FromArgb(1, 192, 0, 0);
                return;
            } 
        }

        private void Generation() 
        {
            alllife = 0;
            var newfield = new bool[columns, rows];
            graphics.Clear(Color.Black);
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    var countneighbours = CountNeighbours(i, j);
                    var haslife = field[i, j];

                    if (!haslife && countneighbours == 3)
                    {
                        newfield[i, j] = true;
                    }
                    else if (haslife && (countneighbours < 2 || countneighbours > 3))
                    {
                        newfield[i, j] = false;
                    }
                    else 
                    {
                        newfield[i, j] = field[i, j];
                    }

                    if (haslife) 
                    {
                        graphics.FillEllipse(Brushes.White, i * resolution, j * resolution, resolution - 1, resolution - 1);
                        alllife++;
                    }
                }
            }
            field = newfield;
            label3Lifes.Text = $"Живых: {alllife}";
            pictureBox1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Generation();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            Initialization();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            AddDeleteLife(sender, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            AddDeleteLife(sender,e);
        }

        private void AddDeleteLife(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled)
            {
                var x = e.X / resolution;
                var y = e.Y / resolution;
                if (CheckMousePosition(x, y)) 
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        field[x, y] = true;
                    }
                    if (e.Button == MouseButtons.Right)
                    {
                        field[x, y] = false;
                    }
                } 
            }
        }
        
        private bool CheckMousePosition(int x,int y) 
        {
            return x >= 0 && y >= 0 && x < columns && y < rows;
        }
    }
}

*/