using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCalculator
{
    public partial class Result : Form
    {
        private TextBox tb;

        public Result()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(700, 100);
            tb = this.textBox1;
        }

        // tb property
        public TextBox Tb
        {
            get { return tb; }
            set { tb = value; }
        }

        private void Result_FormClosing(object sender, FormClosingEventArgs e)
        {
            // The form cannot be closed
            e.Cancel = true;
            // Instead make it invisible
            this.Visible = false;
        }

    }
}
