using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKy_ProjectSort
{
    public partial class frm_Control : Form
    {
        public frm_Control()
        {
            InitializeComponent();
        }

        private void btn_interchange_Click(object sender, EventArgs e)
        {
            frm_Main f = new frm_Main("Interchange Sort");
            f.Show();
        }

        private void btn_selection_Click(object sender, EventArgs e)
        {
            frm_Main f = new frm_Main("Selection Sort");
            f.Show();
        }

        private void btn_bubble_Click(object sender, EventArgs e)
        {
            frm_Main f = new frm_Main("Bubble Sort");
            f.Show();
        }

        private void btn_insertion_Click(object sender, EventArgs e)
        {
            frm_Main f = new frm_Main("Insertion Sort");
            f.Show();
        }
    }
}
