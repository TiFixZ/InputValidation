using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ConstraitByWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbTT01.Checked = true;
        }

        private void tbUserInput_TextChanged(object sender, EventArgs e)
        {
            this.Text = tbUserInput.Text;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (rbTT01.Checked)
            {
                tbUserInput.Text = Validation.TechnicalTask01(tbUserInput.Text);
            }
            if (rbTT02.Checked)
            {
                tbUserInput.Text = Validation.TechnicalTask02(tbUserInput.Text);
            }
        }
    }
}
