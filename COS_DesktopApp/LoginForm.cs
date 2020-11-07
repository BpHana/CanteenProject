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
                                where account.email == txtEmail.Text && account.password == pass
                                select account;

                    if(query.SingleOrDefault() != null)
                    {
                        MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
