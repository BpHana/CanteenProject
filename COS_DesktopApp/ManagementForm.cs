using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace COS_DesktopApp
{
    public partial class ManagementForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void eOrderManagement_Click(object sender, EventArgs e)
        {

        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void eProducts_Click(object sender, EventArgs e)
        {
            if (!fdfContainer.Controls.Contains(ucProduct.Instance))
            {
                fdfContainer.Controls.Add(ucProduct.Instance);
                ucProduct.Instance.Dock = DockStyle.Fill;
                ucProduct.Instance.BringToFront();
            }
            ucProduct.Instance.BringToFront();
        }

        private void eAccountDetails_Click(object sender, EventArgs e)
        {
            ucAccountDetails ucAccountDetails = ucAccountDetails.Instance;
            if (!fdfContainer.Controls.Contains(ucAccountDetails))
            {

                fdfContainer.Controls.Add(ucAccountDetails);
                ucAccountDetails.Dock = DockStyle.Fill;
                ucAccountDetails.BringToFront();
            }
            ucAccountDetails.ucAccountRefresh();
            ucAccountDetails.BringToFront();


        }

        private void eRoles_Click(object sender, EventArgs e)
        {
            if (!fdfContainer.Controls.Contains(ucAccountRole.Instance))
            {
                fdfContainer.Controls.Add(ucAccountRole.Instance);
                ucAccountRole.Instance.Dock = DockStyle.Fill;
                ucAccountRole.Instance.BringToFront();
            }
            ucAccountRole.Instance.BringToFront();
        }
    }
}
