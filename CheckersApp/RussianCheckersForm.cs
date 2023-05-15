using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RusCheckersLib;

namespace CheckersApp
{
    public partial class RussianCheckersForm : Form
    {
        bool capturedOnLastMove = false;

        string[] moveStrings = new string[2];
        //string[] colorNames = { "Белые", "Чёрные" };

        string[] players = new string[2];

        Point diskPoint;
        Point selectedPoint;
        
        List<Point> movePoints = new List<Point>();
        
        DiskColor moveColor = DiskColor.White;
        
        PictureBox[,] pictureBoxes = new PictureBox[8, 8];
        
        Board board = new Board();

        string styleColor;

        string player1;
        string player2;

        public RussianCheckersForm(string styleColor, string player1, string player2)
        {
            InitializeComponent();

            this.player1 = player1;
            this.player2 = player2;

            players[0] = player1; 
            players[1] = player2;

            moveStrings[0] = player1;
            moveStrings[1] = player2;

            moveLabel.Text = "Ходит " + player1;

            this.styleColor = styleColor;
            
            Icon = new Icon(Environment.CurrentDirectory + "\\pictures\\icon.ico");
            
            board.FillStart();
            
            createCells();
            fillLikeBoard();
            createEvents();
        }

        private void startGame()
        {
            board.FillStart();
            fillLikeBoard();
            diskPoint = new Point();
            selectedPoint = new Point();
            movePoints.Clear();
            moveColor = DiskColor.White;
            moveLabel.Text = "Ходит: " + moveStrings[1 - (int)moveColor];
        }
        
        private void createCells()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    PictureBox cell = null;
                    if ((j + i) % 2 == 0)
                    {
                        cell = createPictureBox(new Point(5 + i * 50, 5 + j * 50), Color.FromArgb(255, 253, 208));
                    }
                    else
                    {
                        cell = createPictureBox(new Point(5 + i * 50, 5 + j * 50), Color.FromArgb(128, 64, 48));
                    }
                    pictureBoxes[i, j] = cell;
                }
            }
        }
        
        // Заполнение уже сделанного поля цветом
        private void fillCells()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((j + i) % 2 == 0)
                    {
                        pictureBoxes[i, j].BackColor = Color.FromArgb(255, 253, 208);
                    }
                    else
                    {
                        pictureBoxes[i, j].BackColor = Color.FromArgb(128, 64, 48);
                    }
                }
            }
        }

        // Заполнение сделанного поля картинками
        private void fillLikeBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (pictureBoxes[i, j].Image != null)
                    {
                        pictureBoxes[i, j].Image.Dispose();
                        pictureBoxes[i, j].Image = null;
                    }
                    if (board[i, j].Disk != null && board[i, j].Disk.Color == DiskColor.Black)
                    {
                        SimpleDisk simpleDisk = board[i, j].Disk as SimpleDisk;
                        if (simpleDisk != null)
                        {
                            pictureBoxes[i, j].Image = Image.FromFile(Environment.CurrentDirectory + "\\pictures\\" + styleColor + ".png");
                        }
                        else
                        {
                            pictureBoxes[i, j].Image = Image.FromFile(Environment.CurrentDirectory + "\\pictures\\" + styleColor + "_king.png");
                        }
                    }
                    else
                    {
                        if (board[i, j].Disk != null && board[i, j].Disk.Color == DiskColor.White)
                        {
                            SimpleDisk simpleDisk = board[i, j].Disk as SimpleDisk;
                            if (simpleDisk != null)
                            {
                                pictureBoxes[i, j].Image = Image.FromFile(Environment.CurrentDirectory + "\\pictures\\white.png");
                            }
                            else
                            {
                                pictureBoxes[i, j].Image = Image.FromFile(Environment.CurrentDirectory + "\\pictures\\white_king.png");
                            }
                        }
                        else
                        {
                            if (pictureBoxes[i, j].Image != null)
                            {
                                pictureBoxes[i, j].Image.Dispose();
                                pictureBoxes[i, j].Image = null;
                            }

                        }
                    }
                }
            }
        }

        // Присваивание каждой клетки метод SimpleClick
        private void createEvents()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int x = i;
                    int y = j;
                    pictureBoxes[i, j].Click += (sender, e) =>
                    {
                        SimpleClick(new Point(x, y));
                    };
                }
            }
        }

        // Простой клик шашки
        private void SimpleClick(Point position)
        {
            fillCells();
            selectedPoint = position;
            pictureBoxes[position.X, position.Y].BackColor = Color.Green;
            if (board[position.X, position.Y].Disk != null && board[position.X, position.Y].Disk.Color == moveColor)
            {
                if (!board[position.X, position.Y].Disk.MayCapture(board))
                {
                    movePoints = board[position.X, position.Y].Disk.GetAvailableMoves(board);
                    foreach (Point point in movePoints)
                    {
                        diskPoint = position;
                        //костыль которого быть не должно
                        if (board[point.X, point.Y].Disk == null)
                        {
                            pictureBoxes[point.X, point.Y].BackColor = Color.Gray;
                        }
                    }
                }
                else
                {
                    if (board[position.X, position.Y].Disk.MayCapture(board) && board[position.X, position.Y].Disk.CanCapture)
                    {
                        movePoints = board[position.X, position.Y].Disk.GetAvailableMoves(board);
                        foreach (Point point in movePoints)
                        {
                            diskPoint = position;
                            //костыль которого быть не должно
                            if (board[point.X, point.Y].Disk == null)
                            {
                                pictureBoxes[point.X, point.Y].BackColor = Color.Gray;
                            }
                        }
                    }
                }
            }
            else
            {
                if (movePoints.Contains(selectedPoint))
                {
                    board.DoMove(diskPoint, selectedPoint);
                    board[selectedPoint.X, selectedPoint.Y].Disk.GetAvailableMoves(board);
                    if(Math.Abs(diskPoint.X - selectedPoint.X) > 1)
                    {
                        capturedOnLastMove = true;
                    }
                    else
                    {
                        capturedOnLastMove = false;
                    }
                    if(!capturedOnLastMove)
                    {
                        powerTransmission();
                    }
                    else
                    {
                        if (!board[selectedPoint.X, selectedPoint.Y].Disk.CanCapture)
                        {
                            powerTransmission();
                        }
                    }
                    fillLikeBoard();
                    fillCells();
                    if (!board.CanMove(moveColor))
                    {
                        MessageBox.Show(moveStrings[(int)moveColor] + " победил!");
                        startGame();
                    }
                }
                movePoints.Clear();
            }
        }

        // Метод, который передаёт всё необхадимое в класс Disk и вызывает Expand
        private void powerTransmission()
        {
            moveColor = (DiskColor)(1 - (int)moveColor);
            board.Expand();
            moveLabel.Text = "Ходит: " + moveStrings[1 - (int)moveColor];
        }
        
        private PictureBox createPictureBox(Point point, Color color)
        {
            return new PictureBox
            {
                Height = 50,
                Width = 50,
                Location = point,
                Parent = this,
                Visible = true,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = color,
                SizeMode = PictureBoxSizeMode.Zoom
            };
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            Point[,] locations = new Point[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    locations[i, j] = new Point(5 + i * 50, 5 + j * 50);
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    pictureBoxes[i, j].Location =
                        new Point(
                            (locations[i, j].X) * Size.Width / 600,
                            (locations[i, j].Y) * Size.Height / 450
                            );
                    pictureBoxes[i, j].Width = 50 * Size.Width / 600;
                    pictureBoxes[i, j].Height = 50 * Size.Height / 450;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
