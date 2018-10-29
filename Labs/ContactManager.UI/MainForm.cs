using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Onexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void Onabout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Axel G Bendo\n ITSE 1430\n Contact Manager", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}
