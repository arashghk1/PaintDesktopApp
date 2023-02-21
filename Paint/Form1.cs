using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Paint
{
    public partial class Paint_MainForm : Form
    {
        Bitmap _bitmap;
        Graphics _graphics;
        bool paint = false;
        Point pointX, pointY;
        Pen pen = new Pen(Color.Black);
        Pen Eraser = new Pen(Color.White , 10);
        int indexer;
        int x , y , sx , sy , cx , cy ;
        Color New_Color;

        ColorDialog colordialog = new ColorDialog();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
           (
               int nLeftRect,     // x-coordinate of upper-left corner
               int nTopRect,      // y-coordinate of upper-left corner
               int nRightRect,    // x-coordinate of lower-right corner
               int nBottomRect,   // y-coordinate of lower-right corner
               int nWidthEllipse, // width of ellipse
               int nHeightEllipse // height of ellipse
           );
        public Paint_MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            _bitmap = new Bitmap(Pic.Width, Pic.Height);
            _graphics = Graphics.FromImage(_bitmap);
            _graphics.Clear(Color.White);
            Pic.Image = _bitmap;
        }


        static Point Set_Point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));

        }

        private void Validate(Bitmap bm, Stack<Point> sp, int x, int y, Color Old_Color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == Old_Color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }

        }

        public void Fill(Bitmap bm, int x, int y, Color New_clr)
        {
            Color Old_Color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, New_clr);
            if (Old_Color == New_clr)
            {
                return;
            }
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, Old_Color, New_clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, Old_Color, New_clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, Old_Color, New_clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, Old_Color, New_clr);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Would you like to save your file?" , "Paint Save" , MessageBoxButtons.YesNo , MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var savefileDialog = new SaveFileDialog();
                savefileDialog.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
                savefileDialog.Title = "Please Select a Location For Saving the Image!!!";
                if (savefileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap btm = _bitmap.Clone(new Rectangle(0, 0, Pic.Width, Pic.Height), _bitmap.PixelFormat);
                    btm.Save(savefileDialog.FileName  , ImageFormat.Jpeg);

                    if (MessageBox.Show("Are you sure you'd like to exit the application?", "Paint Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Application.Exit();
                    }                   
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }
            
        }

        private void btn_RoundedSquare_Click(object sender, EventArgs e)
        {
            indexer = 4;
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            indexer = 5;
        }

        private void Pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (indexer == 3)
                {
                    g.DrawEllipse(pen, cx, cy, sx, sy);
                }
                if (indexer == 4)
                {
                    g.DrawRectangle(pen, cx, cy, sx, sy);
                }
                if (indexer == 5)
                {
                    g.DrawLine(pen, cx, cy, x, y);
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            _graphics.Clear(Color.White);
            Pic.Image = _bitmap;
            indexer = 0;
        }

        private void btn_FillColor_Click(object sender, EventArgs e)
        {
            indexer = 6;
        }

        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {

            if (indexer == 6)
            {
                Point point = Set_Point(Pic, e.Location);
                Fill(_bitmap, point.X, point.Y, New_Color);
            }
        }

        private void btn_ColorPicker_Click(object sender, EventArgs e)
        {
            colordialog.ShowDialog();
            New_Color  = colordialog.Color;
            Pic.BackColor = colordialog.Color;
            pen.Color = colordialog.Color;
        }

        private void PanelHeader_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            //dragging = false;
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            pointY = e.Location;


            cx = e.X;
            cy = e.Y;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (indexer == 1)
                {
                    pointX = e.Location;
                    _graphics.DrawLine(pen, pointX, pointY);
                    pointY = pointX;
                }
                if (indexer == 2)
                {
                    pointX = e.Location;
                    _graphics.DrawLine(Eraser, pointX, pointY);
                    pointY = pointX;
                }
            }
            Pic.Refresh();

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sx = x - cx;
            sy = y - cy;
            if (indexer == 3)
            {
                _graphics.DrawEllipse(pen, cx, cy, sx, sy);
            }
            if (indexer == 4)
            {
                _graphics.DrawRectangle(pen , cx , cy , sx , sy);
            }
            if (indexer == 5)
            {
                _graphics.DrawLine(pen, cx, cy, x, y);
            }
        }

        private void btn_Eraiser_Click(object sender, EventArgs e)
        {
            indexer = 2;
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            indexer = 3;
        }

        private void btn_Pencil_Click(object sender, EventArgs e)
        {
            indexer = 1;
        }
    }
}
