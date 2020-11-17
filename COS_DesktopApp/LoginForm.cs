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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string pass = Utils.Utils.GetHash(txtPassword.Text);
                using (CanteenOrderingSystemEntities db = new CanteenOrderingSystemEntities())
                {
                    var query = from account in db.accounts
                                where account.email == txtEmail.Text && account.password == pass && account.id_role == 1 && account.deletedAt == null
                                select account;

                    if (query.SingleOrDefault() != null)
                    {
                        MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var ManagementForm = new ManagementForm();
                        ManagementForm.Closed += (s, args) => this.Close();
                        ManagementForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Select(txtPassword.Text.Length, 0);
            }
        }
    }
}
