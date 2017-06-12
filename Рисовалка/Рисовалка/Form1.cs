//переделать кисть
//сделать откат через битмап и стек
//сделать так же возврат шага


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;

namespace Рисовалка
{
    public partial class Form1 : Form
    {
        Color paintcolor = Color.Black;
        bool draw = false;
        //bool choose = false;
        int x, y, lx, ly = 0;
        int xi, yi=0;
     
        Item currItem;

        public enum Item
        {
            Rectangle, Ellipse, Brush, Eraser
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {

                xi = e.X;
                yi = e.Y;
                Graphics g = pictureBox1.CreateGraphics();
                switch (currItem)
                {
                    case Item.Rectangle:
                        g.FillRectangle(new SolidBrush(paintcolor), x, y, e.X - x, e.Y - y);
                        break;
                    case Item.Ellipse:
                        g.FillEllipse(new SolidBrush(paintcolor), x, y, e.X - x, e.Y - y);
                        break;
                    case Item.Brush:
                        if (textBox1.Text == "Толщина кисти" || textBox1.Text == "")
                        {
                            g.FillEllipse(new SolidBrush(paintcolor), e.X - x + x, e.Y - y + y, 10, 10);
                        }
                        else
                        {
                            g.FillEllipse(new SolidBrush(paintcolor), e.X - x + x, e.Y - y + y, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                        }
                        break;
                    case Item.Eraser:
                        if (textBox2.Text == "Толщина ластика" || textBox2.Text == "")
                        {
                            g.FillEllipse(new SolidBrush(pictureBox1.BackColor), e.X - x + x, e.Y - y + y, 10, 10);
                        }
                        else
                        {
                            g.FillEllipse(new SolidBrush(pictureBox1.BackColor), e.X - x + x, e.Y - y + y, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox2.Text));
                        }
                        break;
                }
                g.Dispose();
                }
            }
        

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            lx = e.X;
            ly = e.Y;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
        }

        private void brush_Click(object sender, EventArgs e)
        {
            currItem = Item.Brush;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            currItem = Item.Rectangle;
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            currItem = Item.Ellipse;
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            currItem = Item.Eraser;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = "";
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox2.Image.Clone();
            paintcolor = bmp.GetPixel(e.X, e.Y);
        }

        private void New_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Сохранить перед закрытием? ", "Message", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.No)
            save_Click(sender, e);
            pictureBox1.Refresh();
            pictureBox1.Image = null;

        }

        private void open_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Сохранить перед закрытием? ", "Message", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.No)
                save_Click(sender, e);
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = (Image)Image.FromFile(o.FileName).Clone();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = pictureBox1.RectangleToScreen(pictureBox1.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, pictureBox1.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = ".png|*.png|.jpeg|*jpg|.bmp|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
            }
        }

        private void step_back_Click(object sender, EventArgs e)
        {
                Graphics g = pictureBox1.CreateGraphics();
                switch (currItem)
                {
                    case Item.Rectangle:
                        g.FillRectangle(new SolidBrush(pictureBox1.BackColor), x, y, xi - x, yi - y);
                        break;
                    case Item.Ellipse:
                        g.FillEllipse(new SolidBrush(pictureBox1.BackColor), x, y, xi - x, yi - y);
                        break;
                    case Item.Brush:
                        if (textBox1.Text == "Толщина кисти" || textBox1.Text == "")
                        {
                            g.FillEllipse(new SolidBrush(pictureBox1.BackColor), xi - x + x, yi - y + y, 10, 10);
                        }
                        else
                        {
                            g.FillEllipse(new SolidBrush(pictureBox1.BackColor), xi - x + x, yi - y + y, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                        }
                        break;
                    case Item.Eraser:
                        if (textBox2.Text == "Толщина ластика" || textBox2.Text == "")
                        {
                            g.FillEllipse(new SolidBrush(paintcolor), xi - x + x, yi - y + y, 10, 10);
                        }
                        else
                        {
                            g.FillEllipse(new SolidBrush(paintcolor), xi - x + x, yi - y + y, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox2.Text));
                        }
                        break;
                }
                g.Dispose();
        }

        private void step_forward_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            switch (currItem)
            {
                case Item.Rectangle:
                    g.FillRectangle(new SolidBrush(paintcolor), x, y, xi - x, yi - y);
                    break;
                case Item.Ellipse:
                    g.FillEllipse(new SolidBrush(paintcolor), x, y, xi - x, yi - y);
                    break;
                case Item.Brush:
                    if (textBox1.Text == "Толщина кисти" || textBox1.Text == "")
                    {
                        g.FillEllipse(new SolidBrush(paintcolor), xi - x + x, yi - y + y, 10, 10);
                    }
                    else
                    {
                        g.FillEllipse(new SolidBrush(paintcolor), xi - x + x, yi - y + y, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox1.Text));
                    }
                    break;
                case Item.Eraser:
                    if (textBox2.Text == "Толщина ластика" || textBox2.Text == "")
                    {
                        g.FillEllipse(new SolidBrush(pictureBox1.BackColor), xi - x + x, yi - y + y, 10, 10);
                    }
                    else
                    {
                        g.FillEllipse(new SolidBrush(pictureBox1.BackColor), xi - x + x, yi - y + y, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox2.Text));
                    }
                    break;
            }
            g.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // if (MessageBox.Show("Сохранить перед закрытием? ", "Message", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.No)
               save_Click(sender, e);
                e.Cancel = false;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
    }

    
}
