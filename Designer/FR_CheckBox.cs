using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designer
{
    [DefaultEvent("_CheckedChanged")]
    public partial class FR_CheckBox : UserControl
    {
        public FR_CheckBox()
        {
            InitializeComponent();
        }

        public event EventHandler _CheckedChanged;


        private void _checkedChanged(object sender, EventArgs e)
        {
            if (_CheckedChanged != null)
            {
                _CheckedChanged.Invoke(sender, e);
            }
        }
    }
}
