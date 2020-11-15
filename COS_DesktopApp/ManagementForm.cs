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
        }

        private void eAccountDetails_Click(object sender, EventArgs e)
        {

            fdfContainer.Controls.Clear();
            ucAccountDetails obj = new ucAccountDetails();
            fdfContainer.Controls.Add(obj.Instance);
            obj.Instance.Dock = DockStyle.Fill;
            obj.Instance.BringToFront();
        }

        private void eRoles_Click(object sender, EventArgs e)
        {
            fdfContainer.Controls.Clear();
            ucAccountRole obj = new ucAccountRole();
            fdfContainer.Controls.Add(obj.Instance);
            obj.Instance.Dock = DockStyle.Fill;
            obj.Instance.BringToFront();
        }

        private void eProductTypes_Click(object sender, EventArgs e)
        {
            fdfContainer.Controls.Clear();
            ucProductType obj = new ucProductType();
            fdfContainer.Controls.Add(obj.Instance);
            obj.Instance.Dock = DockStyle.Fill;
            obj.Instance.BringToFront();
        }

        private void eOrigins_Click(object sender, EventArgs e)
        {
            fdfContainer.Controls.Clear();
            ucOrigin obj = new ucOrigin();
            fdfContainer.Controls.Add(obj.Instance);
            obj.Instance.Dock = DockStyle.Fill;
            obj.Instance.BringToFront();
        }

        private void eCompanies_Click(object sender, EventArgs e)
        {
            fdfContainer.Controls.Clear();
            ucCompany obj = new ucCompany();
            fdfContainer.Controls.Add(obj.Instance);
            obj.Instance.Dock = DockStyle.Fill;
            obj.Instance.BringToFront();
        }

        private void eSugarLevel_Click(object sender, EventArgs e)
        {
            fdfContainer.Controls.Clear();
            ucSugarLevel obj = new ucSugarLevel();
            fdfContainer.Controls.Add(obj.Instance);
            obj.Instance.Dock = DockStyle.Fill;
            obj.Instance.BringToFront();
        }
    }
}
