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
            fdfContainer.Controls.Clear();
            ucProduct obj = new ucProduct();
           
               fdfContainer.Controls.Add(obj.Instance);
                obj.Instance.Dock = DockStyle.Fill;
              obj.Instance.BringToFront();
           
           obj.Instance.BringToFront();
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

        private void eProductTypes_Click(object sender, EventArgs e)
        {
            
         
            if (!fdfContainer.Controls.Contains(ucProductType.Instance))
            {
                fdfContainer.Controls.Add(ucProductType.Instance);
                ucProductType.Instance.Dock = DockStyle.Fill;
                ucProductType.Instance.BringToFront();
            }
            ucProductType.Instance.BringToFront();
        }

        private void eOrigins_Click(object sender, EventArgs e)
        {
            if (!fdfContainer.Controls.Contains(ucOrigin.Instance))
            {
                fdfContainer.Controls.Add(ucOrigin.Instance);
                ucOrigin.Instance.Dock = DockStyle.Fill;
                ucOrigin.Instance.BringToFront();
            }
            ucOrigin.Instance.BringToFront();
        }

        private void eCompanies_Click(object sender, EventArgs e)
        {
            if (!fdfContainer.Controls.Contains(ucCompany.Instance))
            {
                fdfContainer.Controls.Add(ucCompany.Instance);
                ucCompany.Instance.Dock = DockStyle.Fill;
                ucCompany.Instance.BringToFront();
            }
            ucCompany.Instance.BringToFront();
        }

        private void eSugarLevel_Click(object sender, EventArgs e)
        {
            if (!fdfContainer.Controls.Contains(ucSugarLevel.Instance))
            {
                fdfContainer.Controls.Add(ucSugarLevel.Instance);
                ucSugarLevel.Instance.Dock = DockStyle.Fill;
                ucSugarLevel.Instance.BringToFront();
            }
            ucSugarLevel.Instance.BringToFront();
        }
    }
}
