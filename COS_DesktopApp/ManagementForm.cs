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
            if (!fdfContainer.Controls.Contains(ucAccountDetails.Instance))
            {

                fdfContainer.Controls.Add(ucAccountDetails.Instance);
                ucAccountDetails.Instance.Dock = DockStyle.Fill;
                ucAccountDetails.Instance.BringToFront();
            }
            ucAccountDetails.Instance.BringToFront();
        }
    }
}
