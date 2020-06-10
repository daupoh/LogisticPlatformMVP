using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticPlatformMVP
{
    public partial class FormOrderOperate : Form
    {
        public FormOrderOperate()
        {
            InitializeComponent();
            clbxOrders.SetItemChecked(clbxOrders.Items.Count - 1, true);
        }
    }
}
