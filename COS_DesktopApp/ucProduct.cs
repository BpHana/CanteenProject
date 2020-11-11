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
using System.Data.Entity;

namespace COS_DesktopApp
{
    public partial class ucProduct : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucProduct _instance;
        public static ucProduct Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucProduct();

                }
                return _instance;
            }
        }

        public ucProduct()
        {
            InitializeComponent();
        }
    }
}
