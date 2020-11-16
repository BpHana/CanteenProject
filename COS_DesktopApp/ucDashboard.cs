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
    public partial class ucDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        private ucDashboard _instance;
        public ucDashboard Instance
        {
            get
            {

                if (_instance == null)
                {
                    _instance = new ucDashboard();

                }
                return _instance;
            }
        }
        public ucDashboard()
        {
            InitializeComponent();
        }
    }
}
