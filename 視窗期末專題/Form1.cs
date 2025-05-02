using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 視窗期末專題
{
    public partial class Form1 : Form
    {
        /*
         * 1.
         * 2.
         * 3.
         * 4.加過關的label提示
         * 5.
         * 6.
         * 7.
         */
        
        
        //未倒轉前  0=邊界 1=空間 -5=箱子 5=轉了之後變箱子的方塊 8=終點 4=人物的初始位置
        //改地圖修Map,col,row和下一行的PictureBox[] mpblk = new PictureBox[改這裡!!];
        //改地圖記得不要改到邊界的那圈'0';
        static int[,,] LoadMap = {
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 1, 1, 1, 4,-5, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                { 0, 1, 1, 1,-1,-1,-1,-1,-1,-1, 1, 1,-1, 1, 1, 1, 1,-1,-1, 0},
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,-1,-1,-1,-1, 1, 1, 1, 0},
                { 0, 1, 1, 1, 1,-1,-1,-1, 1, 1, 1, 1,-1,-1,-1, 1, 1, 1,-1, 0},
                { 0, 1,-1,-1, 1, 1, 1, 1, 1, 1, 1, 1, 1,-1,-1, 1,-1, 1,-1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,-1, 1, 1, 1, 1, 0},
                { 0, 1,-1, 1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 1, 1, 1,-1,-1, 0},
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,-1, 1,-1,-1,-1, 0},
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                { 0, 1, 1, 1,-1,-1,-1, 1, 1, 8, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
                { 0, 1, 1, 1, 1,-1, 1, 1, 1,-1,-1,-1,-1, 1, 1, 1,-5, 1, 1, 0},
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,-1,-1,-1,-1,-1,-1, 0},
                { 0, 1, 1, 1, 1, 1,-1,-1,-1,-1,-1,-1, 1,-1,-1,-1,-1,-1,-1, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            },
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 1, 1, 1, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,-1,-1, 1, 0},
                { 0, 1,-1, 1,-1,-1,-1,-1,-1, 1, 1,-1,-1, 1, 1,-1,-1,-1, 8, 0},
                { 0, 1,-1, 1, 1, 1,-1, 1,-1,-1, 1, 1,-1,-1, 1,-1,-1, 1,-1, 0},
                { 0,-1, 1,-1,-1, 1,-1, 1, 1,-1,-1, 1, 1, 1, 1, 1,-1, 1, 1, 0},
                { 0, 1, 1, 1, 1, 1, 1, 1,-5, 1, 1, 1,-1,-1,-1, 5,-1, 5,-1, 0},
                { 0, 1, 1, 1, 1, 1, 1, 1,-1,-1, 1, 1,-1,-1,-1,-1,-1,-1,-1, 0},
                { 0, 1,-1,-1, 1, 1, 1, 1,-1, 1, 1, 1, 1, 1, 1, 1, 1,-1, 1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1, 1, 1, 1, 1, 1,-1, 1,-1,-1,-1, 0},
                { 0, 1,-1, 1, 1, 1, 1,-1,-1, 1,-1,-1,-1, 1,-1, 1,-1,-1, 1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1, 1, 1, 1, 1, 1,-1, 1, 1,-1, 1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1, 1, 1,-1, 1, 1,-1,-1,-1,-1, 1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1, 1, 1,-1, 1, 1,-1,-1, 1, 1,-1, 0},
                { 0, 1,-1,-1, 1, 1, 1,-1,-1, 1, 1,-1,-1,-1, 1,-1,-1, 1,-1, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            },
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 1,-1,-1, 1, 1, 1, 1, 1, 1,-1, 1, 1, 1, 1,-1, 1, 4,-1, 0},
                { 0, 1,-1, 1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1, 1,-1,-1, 0},
                { 0, 1, 1, 1, 1, 1, 1, 1,-1,-1,-1, 1, 1, 1, 1,-1, 1,-1,-1, 0},
                { 0,-8,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1, 5,-1, 1,-1,-1, 0},
                { 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,-1,-1,-1, 1,-1,-1, 0},
                { 0,-1,-1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,-1,-1, 1, 1,-1,-1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1, 1, 1,-1,-1,-1,-1,-1,-1,-1,-1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1,-1, 1,-1,-1, 1, 1, 1,-1,-1,-1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1,-1, 1, 1,-1, 5,-1,-1,-1,-1,-1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1,-1,-1, 1,-1,-1,-1,-1,-1, 1,-1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1,-1,-1, 1, 1, 1, 1, 1,-1,-1,-1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1,-1,-1,-1, 1,-5, 1, 1, 1, 1, 1, 0},
                { 0, 1,-1, 1, 1, 1, 1, 1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1, 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            },
            {
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                { 0, 1, 1, 1, 4,-5, 1, 1, 1, 1, 1, 1,-5, 1, 1, 1, 1, 1, 1, 0},
                { 0, 1, 1, 1,-1,-1, 5,-1,-1,-1, 5,-1,-1,-1, 1, 1, 1,-1,-1, 0},
                { 0, 1, 1, 1, 1, 1, 1, 1,-1, 1, 1, 1,-1,-1,-1,-1, 1, 1,-1, 0},
                { 0, 1, 1, 1, 1,-1,-1,-1,-1, 1, 1, 1,-1,-1,-1, 1, 1, 1,-1, 0},
                { 0, 1,-1,-1, 1, 1, 1, 1, 1, 1, 1, 1, 1,-1,-1, 1,-1,-1,-1, 0},
                { 0, 1,-1, 1,-1,-1,-1,-1, 1, 1, 1, 1, 1, 1,-1, 1, 1, 1, 1, 0},
                { 0, 1,-1, 1, 1, 1, 1,-1,-1, 5,-1,-1,-1,-1, 1, 1, 1,-1,-1, 0},
                { 0, 1, 1, 1, 1, 1, 1,-1,-1, 1, 1, 1,-1, 1,-1, 1,-1,-1,-1, 0},
                { 0, 1, 1,-5, 1, 1, 1, 1, 1, 1,-5, 1,-1, 1, 1, 1, 1, 1, 1, 0},
                { 0,-1,-1,-1,-1,-1,-1,-1, 1, 1,-1, 1,-1, 1, 1, 1, 1, 1, 1, 0},
                { 0, 1, 1, 1,-1,-1, 1, 1, 1,-1,-1, 1,-1, 1, 1, 1,-5, 1, 1, 0},
                { 0, 1, 1, 8, 1,-1, 1, 1, 1, 1, 1, 1, 1,-1,-1, 1,-1,-1,-1, 0},
                { 0,-1,-1,-1,-1,-1,-1, 5,-1,-1,-1,-1, 1,-1,-1, 1,-1,-1,-1 , 0},
                { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            }
        };
        int col = 20, row = 15;
        PictureBox[] mpblk = new PictureBox[300];
        int[,] Map;
        int x, y, cx, cy;
        bool isreverse=false,dir=true;
        int stage=1;
        bool[] isClear = new bool[5];
        bool unlock = false;
        WMPLib.WindowsMediaPlayer wp = new WMPLib.WindowsMediaPlayer();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Map[cy, cx] == 8)
            {
                timer1.Stop();
                if (stage == 1)
                {
                    isClear[stage] = true;
                    label1.Visible = true;
                    一ToolStripMenuItem.Text = "一(已通關)";
                    for (int i = 1; i <= 3; i++)
                    {
                        if (isClear[i] == false)
                        {
                            break;
                        }
                        else if (i == 3)
                        {
                            unlock = true;
                        }
                    }
                    if (unlock == true)
                    { toolStripMenuItem2.Text = "隱藏關OuO"; }
                }
                else if (stage == 2)
                {
                    isClear[stage] = true;
                    label1.Visible = true;
                    二ToolStripMenuItem.Text = "二(已通關)";
                    for (int i = 1; i <= 3; i++)
                    {
                        if (isClear[i] == false)
                        {
                            break;
                        }
                        else if (i == 3)
                        {
                            unlock = true;
                        }
                    }
                    if (unlock == true)
                    { toolStripMenuItem2.Text = "隱藏關OuO"; }
                }
                else if (stage == 3)
                {
                    isClear[stage] = true;
                    label1.Visible = true;
                    三ToolStripMenuItem.Text = "三(已通關)";
                    for (int i = 1; i <= 3; i++)
                    {
                        if (isClear[i] == false)
                        {
                            break;
                        }
                        else if(i==3)
                        {
                            unlock = true;
                        }
                    }
                    if (unlock == true)
                    { toolStripMenuItem2.Text = "隱藏關OuO"; }
                }
                else if (stage == 4)
                {
                    isClear[stage] = true;
                    label1.Visible = true;
                     toolStripMenuItem2.Text = "隱藏關(已通關)";
                }
            }
            else if(Map[cy+1,cx]>0 && isreverse==false)
            {
                cy = cy + 1;
                pictureBox4.Location = new Point((cx - 1) * 40, (cy - 1) * 40 + 25);
            }
            else if (Map[cy - 1, cx] > 0 && isreverse == true)
            {
                cy = cy - 1;
                pictureBox4.Location = new Point((cx - 1) * 40, (cy - 1) * 40 + 25);
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.NumPad5)
            { unlock = true;
                this.toolStripMenuItem2_Click(null, null);
            }
            if (e.KeyCode == Keys.R)
            {
                this.重新開始ToolStripMenuItem_Click(null,null);
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                this.二ToolStripMenuItem_Click(null, null);
            }
            if (e.KeyCode == Keys.NumPad3)
            {
                this.三ToolStripMenuItem_Click(null, null);
            }
            if (e.KeyCode==Keys.Space)
            {
                pictureBox5.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                reverse();
            }
            if (e.KeyCode==Keys.Left)
            {
                if(dir==false)
                {
                    pictureBox4.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    dir = true;
                }
                if ((Map[cy,cx-1]==1 || Map[cy,cx-1]==5) && cx>=1)
                {
                    cx = cx - 1;
                    pictureBox4.Location = new Point((cx - 1) * 40, (cy - 1) * 40 + 25);
                }
                else if(Map[cy,cx-1]==-5 && Map[cy,cx-2]==1 && cx>=2)
                {
                    Map[cy, cx - 1] = 1;
                    Map[cy, cx - 2] =-5;
                    drawMap(cy, cx - 2, cy * col + cx - 2);
                    drawMap(cy, cx - 1, cy * col + cx - 1);
                    cx = cx - 1;
                    pictureBox4.Location = new Point((cx - 1) * 40, (cy - 1) * 40 + 25);
                    int dy = cy, dx = cx - 1;
                    while (Map[dy + 1, dx] == 1 && isreverse == false)
                    {
                        if (Map[dy + 1, dx] == 1)
                        {
                            Map[dy + 1, dx] = -5;
                            Map[dy, dx] = 1;
                            drawMap(dy + 1, dx, (dy + 1) * col + dx);
                            drawMap(dy, dx, dy * col + dx);
                            dy = dy + 1;
                        }
                        /*else if(Map[cy+1,cx+1]==5)
                        {

                        }*/
                    }
                    while (Map[dy - 1, dx] == 1 && isreverse == true)
                    {
                        if (Map[dy - 1, dx] == 1)
                        {
                            Map[dy - 1, dx] = -5;
                            Map[dy, dx] = 1;
                            drawMap(dy - 1, dx, (dy - 1) * col + dx);
                            drawMap(dy, dx, dy * col + dx);
                            dy = dy - 1;
                        }
                        /*else if(Map[cy+1,cx+1]==5)
                        {

                        }*/
                    }
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (dir == true)
                {
                    pictureBox4.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    dir = false;
                }
                if ((Map[cy, cx + 1] == 1 || Map[cy, cx + 1] == 5) && cx <= col-1)
                {
                    cx = cx + 1;
                    pictureBox4.Location = new Point((cx - 1) * 40, (cy - 1) * 40 + 25);
                }
                else if (Map[cy, cx + 1] ==-5 && Map[cy, cx + 2] == 1 && cx <= col-2)
                {
                    Map[cy, cx + 1] = 1;
                    Map[cy, cx + 2] =-5;
                    drawMap(cy, cx + 2, cy * col + cx + 2);
                    drawMap(cy, cx + 1, cy * col + cx + 1);
                    cx = cx + 1;
                    pictureBox4.Location = new Point((cx - 1) * 40, (cy - 1) * 40 + 25);
                    int dy = cy, dx = cx+1;
                    while (Map[dy + 1, dx] == 1 && isreverse == false)
                    {
                        if (Map[dy + 1, dx] == 1)
                        {
                            Map[dy + 1, dx] = -5;
                            Map[dy, dx] = 1;
                            drawMap(dy + 1, dx, (dy + 1) * col + dx);
                            drawMap(dy, dx, dy * col + dx);
                            dy = dy + 1;
                        }
                        /*else if(Map[cy+1,cx+1]==5)
                        {

                        }*/
                    }
                    while (Map[dy - 1, dx] == 1 && isreverse == true)
                    {
                        if (Map[dy - 1, dx] == 1)
                        {
                            Map[dy - 1, dx] = -5;
                            Map[dy, dx] = 1;
                            drawMap(dy - 1, dx, (dy - 1) * col + dx);
                            drawMap(dy, dx, dy * col + dx);
                            dy = dy - 1;
                        }
                        /*else if(Map[cy+1,cx+1]==5)
                        {

                        }*/
                    }
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.SetBounds(0, 0, 740, 590);
            pictureBox1.Top = -100;
            pictureBox5.Top = -100;
            pictureBox6.Top = -100;
            pictureBox7.Top = -100;
            
        }

        private void 重新開始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            SetUp();
        }

        private void 一ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stage = 1;
            SetUp();
        }

        private void 二ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stage = 2;
            SetUp();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (unlock == true)
            {
                timer1.Stop();
                stage = 4;
                SetUp();
            }
        }

        private void 三ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stage = 3;
            SetUp();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < col * row; i++)
            {
                y = i / col;
                x = i % col;
                mpblk[i] = new PictureBox();
            }
            wp.URL = "backgroundMusic.mp3";
            wp.controls.play();
            wp.settings.playCount = 100;
            SetUp();
        }

        public void SetUp()
        {
            timer1.Stop();
            label1.Visible = false;
            if (isreverse == true)
            {
                this.BackgroundImage = Properties.Resources._2d_Wallpaper___WallpaperSafari;
                pictureBox4.Image = Properties.Resources.green_slime;
                pictureBox5.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                if (dir == false)
                { pictureBox4.Image.RotateFlip(RotateFlipType.Rotate180FlipY); }
            }
            isreverse = false;
            Map = new int[row ,col ];
            for(int i = 0; i < col * row; i++)
            {
                y = i / col;
                x = i % col;
                Map[y, x] = LoadMap[stage - 1, y, x];
            }
            for (int i = 0; i < col * row; i++)
            {
                y = i / col;
                x = i % col;
                mpblk[i].Width = 40;
                mpblk[i].Height = 40;
                drawMap(y, x, i);
            }
            timer1.Start();
        }


        public void reverse()
        {
            int oy=cy;
            if(isreverse==false)
            {
                oy = cy + 1;
            }
            else if (isreverse == true)
            {
                oy = cy - 1;
            }

            if (Map[oy, cx] < 0)
            {
                for (int m = 0; m < col*row; m++)
                {
                    y = m / col;
                    x = m % col;
                    Map[y, x] *= -1;
                    drawMap(y, x, m);
                    if (cx == x && oy == y)
                    {
                        isreverse = !isreverse;
                        if (isreverse == false)
                        {
                            this.BackgroundImage = Properties.Resources._2d_Wallpaper___WallpaperSafari;
                            pictureBox4.Image = Properties.Resources.green_slime;
                            if (dir == false)
                            { pictureBox4.Image.RotateFlip(RotateFlipType.Rotate180FlipY); }
                        }
                        if (isreverse == true)
                        {
                            this.BackgroundImage = Properties.Resources.The_Legend_of_Smurfy_Hollow___Cartoon_Brew;
                            pictureBox4.Image = Properties.Resources.yellow_slime;
                            pictureBox4.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                            if(dir==false)
                            { pictureBox4.Image.RotateFlip(RotateFlipType.Rotate180FlipY); }
                        }
                        pictureBox4.Location = new Point((cx - 1) * 40, (oy - 1) * 40 + 25);
                        //pictureBox4.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                        pictureBox4.BringToFront();
                        cy = oy;
                    }

                }
            }
        }

        public void drawMap(int y,int x, int m)
        {
            if (Map[y, x] == 1) { mpblk[m].Image = pictureBox1.Image; }
            if (Map[y, x] ==-5) { mpblk[m].Image = pictureBox6.Image; }
            if (Map[y, x] ==-1) { mpblk[m].Image = pictureBox5.Image; }
            if (Map[y, x] == 5) { mpblk[m].Image = pictureBox7.Image; }
            if (Map[y, x] == 4)
            {
                Map[y, x] = 1;
                mpblk[m].Image = pictureBox1.Image;
                pictureBox4.Width = 40;
                pictureBox4.Height = 40;
                cx = x;
                cy = y;
                pictureBox4.Location = new Point((cx - 1) * 40, (cy - 1) * 40 + 25);
            }
            if (Map[y, x] == 8)
            {
                mpblk[m].Image = pictureBox1.Image;
                pictureBox2.Width = 40;
                pictureBox2.Height = 40;
                pictureBox2.BackgroundImage = null;
                pictureBox2.Location = new Point((x - 1) * 40, (y - 1) * 40 + 25);
            }
            if (Map[y, x] == -8)
            {
                pictureBox2.Width = 40;
                pictureBox2.Height = 40;
                pictureBox2.BackgroundImage = Properties.Resources.rock123;
                pictureBox2.Location = new Point((x - 1) * 40, (y - 1) * 40 + 25);
            }
            mpblk[m].SizeMode = PictureBoxSizeMode.StretchImage;
            mpblk[m].BackColor = Color.Transparent;
            mpblk[m].Location = new Point((x - 1) * 40, (y - 1) * 40 + 25);
            Controls.Add(mpblk[m]);
        }
    }
}
