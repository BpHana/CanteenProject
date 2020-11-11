﻿using System;
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
using DevExpress.XtraGrid.Columns;

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


            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
 dbContext = new COS_DesktopApp.CanteenOrderingSystemEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.account_role.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                account_roleBindingSource.DataSource = dbContext.account_role.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button == windowsUIButtonPanel1.Buttons[0])
            {
                gridView1.AddNewRow();
            }
            else if (e.Button == windowsUIButtonPanel1.Buttons[1])
            {
                gridView1.SetFocusedRowCellValue(gridView1.Columns[coldeletedAt.FieldName], DateTime.Now);

                if (gridView1.FocusedRowHandle != 0)
                {
                    gridView1.FocusedRowHandle = 0;
                }
                else
                {
                    gridView1.FocusedRowHandle = 1;
                }

            }
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dbContext.SaveChanges();
        }
    }
}
