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
    public partial class ucAccountRole : DevExpress.XtraEditors.XtraUserControl
    {
        COS_DesktopApp.CanteenOrderingSystemEntities dbContext;
        private static ucAccountRole _instance;
        public static ucAccountRole Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucAccountRole();

                }
                return _instance;
            }
        }

        public ucAccountRole()
        {
            InitializeComponent();
        }

    }
}
