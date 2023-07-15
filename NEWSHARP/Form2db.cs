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
    public partial class Form2db : Form
    {
        public Form2db()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDbExportwithiID_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2Export ed = new Form2Export();
            ed.ShowDialog();
        }

        private void BtnDbClearData_MouseHover(object sender, EventArgs e)
        {
            BtnDbClearData.BackColor = Color.DarkBlue;
        }
    }
}
