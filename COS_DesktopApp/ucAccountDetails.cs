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
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;

namespace COS_DesktopApp
{
    public partial class ucAccountDetails : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucAccountDetails _instance;

        public static ucAccountDetails Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucAccountDetails();
                }

                return _instance;
            }
        }
        public ucAccountDetails()
        {
            InitializeComponent();
        }

        private void ucAccountDetails_Load(object sender, EventArgs e)
        {
            CanteenOrderingSystemEntities db = new CanteenOrderingSystemEntities();
            var result = from c in db.accounts select new { Id = c.id, Email = c.email, Fullname = c.fullname, Birthday = c.birthday, Phonenumber = c.phonenumber, Role = c.account_role.name };
            gcAccountDetails.DataSource = result.ToList();



        }

        
        
    }
}
