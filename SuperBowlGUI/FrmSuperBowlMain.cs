using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperBowlGUI
{
    public partial class FrmSuperBowlMain : Form
    {
        public FrmSuperBowlMain()
        {
            InitializeComponent();
            btnNyil.Click += BtnNyil_Click;
        }

        private void BtnNyil_Click(object sender, EventArgs e)
        {
            tbxArab.Clear();
            tbxRomai.Clear();
            btnNyil.Text = btnNyil.Text == "--->" ? "<---" : "--->";
            tbxArab.Enabled = !tbxArab.Enabled;
            tbxRomai.Enabled = !tbxRomai.Enabled;
        }
    }
}
