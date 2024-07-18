using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Designer
{

    public partial class texc : UserControl
    {
        public texc()
        {
            InitializeComponent();
        }

        public event EventHandler ComboBox_SelectedIndexChanged;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_SelectedIndexChanged != null)
            {
                ComboBox_SelectedIndexChanged.Invoke(sender, e);
            }
        }

        



        private void texc_Load(object sender, EventArgs e)
        {

        }

        public void AddCombo(string text)
        {
            comboBox1.Items.Add(text);
        }
    }
}
