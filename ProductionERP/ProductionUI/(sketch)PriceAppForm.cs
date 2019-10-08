using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionUI
{
    public partial class PriceAppForm : Form
    {
        private List<Label> label2 = new List<Label>();
        
        private void InitList(int l)
        {
            Label a = new Label();
            Label b = new Label();
            Label c = new Label();
            Label d = new Label();

            if (label2.Count <5)
            {
                for (int j = 0; j < 5; j++)
                {
                    label2.Add(new Label());
                }
            }
            
            
            
            int i = 0;
            int loc = 150;
            foreach (var item in label2)
            {
                
                item.AutoSize = true;
                item.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(155)))), ((int)(((byte)(253)))));
                item.Location = new System.Drawing.Point(l, loc);
                
                item.Name = string.Concat("label", i);
                
                item.Size = new System.Drawing.Size(150, 30);
                item.TabIndex = i;
                item.Text = string.Concat("Part description",i);
                this.Controls.Add(item);
                i += 1;
                loc +=  40;
            }
        }

        public PriceAppForm()
        {            InitializeComponent();
            //InitList();
        }


        int l = 10;
        private void Button1_Click(object sender, EventArgs e)
        {
            
            InitList(l);
            l += 200;
            
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
