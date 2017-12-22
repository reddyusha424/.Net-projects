using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           tbtResult.Text = Convert.ToString(Convert.ToInt32(tbtFirstNumber.Text) + Convert.ToInt32(tbtSecondNumber.Text));
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            tbtResult.Text = Convert.ToString(Convert.ToInt32(tbtFirstNumber.Text) - Convert.ToInt32(tbtSecondNumber.Text));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            tbtResult.Text = Convert.ToString(Convert.ToInt32(tbtFirstNumber.Text) * Convert.ToInt32(tbtSecondNumber.Text));
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            tbtResult.Text = Convert.ToString(Convert.ToInt32(tbtFirstNumber.Text) / Convert.ToInt32(tbtSecondNumber.Text));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbtFirstNumber.Clear();
            tbtSecondNumber.Clear();
            tbtResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
