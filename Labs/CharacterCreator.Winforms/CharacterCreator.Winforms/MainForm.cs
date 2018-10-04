using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class    MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
       

        private void ExitFile (object sender , EventArgs e)
        {
            if (MessageBox.Show("you want to exit ?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }

        private void CreatrorHelp ( object sender, EventArgs e )
        {
            MessageBox.Show(this, "Axel Bendo\n ITSE 1430\n Character Creator ", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
           
        }


    }
}
