using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class processandocs : Form
    {
        public processandocs()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 162;
            timer1.Start();

            if (panel2.Width >= 1153)
            {

                timer1.Stop();

                login lg = new login();
                lg.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
