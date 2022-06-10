using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsController
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }
        public void ws(string s)
        {
            this.label1.Text = s;
        }
        private void frm_Load(object sender, EventArgs e)
        {

        }
    }
}
