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

namespace ResizeWindow
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.principalPanel.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //get the user32dll for dragging the form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);




        private void menuMinButton_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 100;
            }
            else
            {
                menuVertical.Width = 250;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            if (MessageBox.Show("Are you sure you want to close?", $"{Application.ProductName}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //variables to get the postion of the form before maximize
        private int lX, lY;

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            ////sets the windows size
            ////sets the window size to maximum screen size
            //this.WindowState = FormWindowState.Maximized;

            //gets the initial position
            this.StartPosition = FormStartPosition.CenterScreen;
            lX = this.Location.X;
            lY = this.Location.Y;
            //sets the window size to working area size
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            normalViewButton.Visible = true;
            maximizeButton.Visible = false;
        }

        private void normalViewButton_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1050, 600);
            this.Location = new Point(lX, lY);
            normalViewButton.Visible = false;
            maximizeButton.Visible = true;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void OpenFormInPanel(object form)
        {
            if (this.panelContent.Controls.Count > 0)
            {
                this.panelContent.Controls.RemoveAt(0);
            }
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(frm);
            this.panelContent.Tag = frm;
            frm.Show();

        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Products());
        }
    }
}
