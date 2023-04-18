using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionCompany1
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }

        private void chartControl2_DoubleClick(object sender, EventArgs e)
        {
            XtraForm2 f2 = new XtraForm2();
            f2.Show();
        }
    }
}