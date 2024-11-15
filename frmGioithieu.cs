using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChuongtrinhQLDiemTHPT
{
    public partial class frmGioithieu : Form
    {
        public frmGioithieu()
        {
            InitializeComponent();
        }

        private void frmGioithieu_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          // this.label9.Top==this.Top-1;
           if (this.label9.Top < this.label9.Height)
           { this.label9.Top = this.label9.Height + 2; }
        }
    }
}
