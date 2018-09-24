using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itse1430.MovieLib.UI
{
    public partial class _txtDescription : Form
    {
        public _txtDescription()
        {
            InitializeComponent();
        }

        private void MovieForm_Load( object sender, EventArgs e )
        {

        }

        private void label5_Click( object sender, EventArgs e )
        {

        }

        private void label4_Click( object sender, EventArgs e )
        {

        }

        private void _btnCancel_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void _btnSave_Click( object sender, EventArgs e )
        {
            DialogResult = DialogResult.OK;
            Close`();
        }
    }
}
