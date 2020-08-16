using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpen2ndForm_Click(object sender, EventArgs e)
        {
            SecondForm oSF = new SecondForm();
            oSF.ShowDialog();
        }

        private void buttonShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
