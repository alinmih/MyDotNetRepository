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
using ProductionUI.Forms.Home;
using ProductionUI.Forms.Products;
using ProductionUI.Forms.ProductionOrders;
using ProductionUI.Forms.SalesOrders;
using ProductionUI.Forms.Offers;
using ProductionUI.Forms.WarehouseManagement;
using ProductionUI.Forms.ManufacturingCosts;

namespace ProductionUI.Forms
{
    public partial class MainForm : Form
    {
        //vars for menu minimize
        private int panelWidth;
        private bool isColapsed;

        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            //side menu variables
            panelWidth = panelMenuItems.Width;
            isColapsed = false;

            clockTimer.Start();
        }

        #region Form Behaviour

        #region Minimize Menu Sidebar
        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            timerForMinimizeBar.Start();
        }

        private void TimerForMinimizeBar_Tick(object sender, EventArgs e)
        {
            if (isColapsed)
            {
                //iconPanel.Hide();
                panelMenuItems.Width = panelMenuItems.Width + 10;
                if (panelMenuItems.Width >= panelWidth)
                {
                    timerForMinimizeBar.Stop();
                    isColapsed = false;
                    this.Refresh();

                }
            }
            else
            {
                panelMenuItems.Width = panelMenuItems.Width - 10;
                if (panelMenuItems.Width <= 56)
                {
                    timerForMinimizeBar.Stop();
                    isColapsed = true;
                    this.Refresh(); ;
                }
            }
        }


        #endregion

        #region Resize window

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
            this.panelContainer.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Transparent);
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        #endregion

        #region Drag Window

        //get the user32dll for dragging the form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion

        #region Window control

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            if (MessageBox.Show("Are you sure you want to close?", $"{Application.ProductName}", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //variables to get the postion of the form before maximize
        private int lenghtX, lenghtY;
        private int startX, startY;
        private int initialSizeX, initialSizeY;

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            ////sets the windows size
            ////sets the window size to maximum screen size
            //this.WindowState = FormWindowState.Maximized;

            //gets the initial position
            this.StartPosition = FormStartPosition.CenterScreen;
            lenghtX = this.Location.X;
            lenghtY = this.Location.Y;
            initialSizeX = this.Size.Width;
            initialSizeY = this.Size.Height;

            //sets the window size to working area size
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            normalViewButton.Visible = true;
            maximizeButton.Visible = false;
        }

        private void normalViewButton_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(initialSizeX, initialSizeY);
            this.Location = new Point(lenghtX, lenghtY);
            normalViewButton.Visible = false;
            maximizeButton.Visible = true;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
        #endregion

        private void MovePanelSide(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void OpenFormInPanel<MyForm>() where MyForm : Form, new()
        {
            Form currentForm;
            currentForm = panelMain.Controls.OfType<MyForm>().FirstOrDefault();

            if (currentForm == null)
            {
                currentForm = new MyForm();
                currentForm.TopLevel = false;
                currentForm.Dock = DockStyle.Fill;
                panelMain.Controls.Add(currentForm);
                currentForm.Tag = currentForm;
                currentForm.Show();
                currentForm.BringToFront();
                currentForm.FormClosed += new FormClosedEventHandler(CloseForms);
            }

            //if (this.panelMain.Controls.Count > 0)
            //{
            //    this.panelMain.Controls.RemoveAt(0);
            //}
            //Form frm = form as Form;
            //frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            //this.panelMain.Controls.Add(frm);
            //this.panelMain.Tag = frm;
            //frm.Show();
        }



        #region Button Events

        private void homeButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(homeButton);
            OpenFormInPanel<HomeForm>();
            homeButton.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void productsButon_Click(object sender, EventArgs e)
        {
            MovePanelSide(productsButon);
            OpenFormInPanel<ProductsForm>();
            productsButon.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void productionOrdersButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(productionOrdersButton);
            OpenFormInPanel<ProductionOrdersForm>();
            productionOrdersButton.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void salesOrdersButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(salesOrdersButton);
            OpenFormInPanel<SalesOrdersForm>();
            salesOrdersButton.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void offersButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(offersButton);
            OpenFormInPanel<OffersForm>();
            offersButton.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenFormInPanel<HomeForm>();
        }

        private void warehouseManagementButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(warehouseManagementButton);
            OpenFormInPanel<WarehouseManagementForm>();
            warehouseManagementButton.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void manufacturingCostButton_Click(object sender, EventArgs e)
        {
            MovePanelSide(manufacturingCostButton);
            OpenFormInPanel<ManufacturingCostDashboard>();
            manufacturingCostButton.BackColor = Color.FromArgb(229, 229, 229);
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["HomeForm"] == null)
            {
                homeButton.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (Application.OpenForms["ProductsForm"] == null)
            {
                productsButon.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (Application.OpenForms["ProductionOrdersForm"] == null)
            {
                productionOrdersButton.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (Application.OpenForms["SalesOrdersForm"] == null)
            {
                salesOrdersButton.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (Application.OpenForms["OffersForm"] == null)
            {
                offersButton.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (Application.OpenForms["WarehouseManagementForm"] == null)
            {
                warehouseManagementButton.BackColor = Color.FromArgb(255, 255, 255);
            }
            if (Application.OpenForms["ManufacturingCostDashboard"] == null)
            {
                manufacturingCostButton.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        #endregion

    }
}
