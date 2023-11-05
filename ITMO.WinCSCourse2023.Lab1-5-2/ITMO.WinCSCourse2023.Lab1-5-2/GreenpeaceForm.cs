using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.WinCSCourse2023.Lab1_5_2
{
    public partial class GreenpeaceForm : Form
    {
        public GreenpeaceForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GreenpeaceForm_Load(object sender, EventArgs e)
        {
            using (GraphicsPath myPath = new GraphicsPath())
            {
                myPath.AddLines(new[]
                    {
                new Point(0, Height / 2),
                new Point(Width / 2, 0),
                new Point(Width, Height / 2),
                new Point(Width / 2, Height)
            });
                Region = new Region(myPath);
            }
        }
    }
}
