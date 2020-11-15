using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace COS_DesktopApp
{
    public partial class ucOrder : DevExpress.XtraEditors.XtraUserControl
    {
        private ucOrder _instance;
        public ucOrder Instance
        {
            get
            {

                if (_instance == null)
                {
                    _instance = new ucOrder();

                }
                return _instance;
            }
        }
        public ucOrder()
        {
            InitializeComponent();
        }
    }
}
