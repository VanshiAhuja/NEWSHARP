using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEWSHARP
{
    public partial class Form2DataMerge : Form
    {
        public Form2DataMerge()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MergeyourData_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2db og = new Form2db();
            og.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }
    }
}
