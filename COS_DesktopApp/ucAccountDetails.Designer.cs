namespace COS_DesktopApp
{
    partial class ucAccountDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphonenumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccount_role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcarts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorders = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.accountsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(824, 560);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(COS_DesktopApp.account);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colemail,
            this.colpassword,
            this.colfullname,
            this.colbirthday,
            this.colphonenumber,
            this.colid_role,
            this.coldeletedAt,
            this.colaccount_role,
            this.colcarts,
            this.colorders});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 1;
            // 
            // colpassword
            // 
            this.colpassword.Caption = "Password";
            this.colpassword.FieldName = "password";
            this.colpassword.Name = "colpassword";
            // 
            // colfullname
            // 
            this.colfullname.Caption = "Fullname";
            this.colfullname.FieldName = "fullname";
            this.colfullname.Name = "colfullname";
            this.colfullname.Visible = true;
            this.colfullname.VisibleIndex = 2;
            // 
            // colbirthday
            // 
            this.colbirthday.Caption = "Birthdate";
            this.colbirthday.FieldName = "birthday";
            this.colbirthday.Name = "colbirthday";
            this.colbirthday.Visible = true;
            this.colbirthday.VisibleIndex = 3;
            // 
            // colphonenumber
            // 
            this.colphonenumber.Caption = "Phonenumber";
            this.colphonenumber.FieldName = "phonenumber";
            this.colphonenumber.Name = "colphonenumber";
            this.colphonenumber.Visible = true;
            this.colphonenumber.VisibleIndex = 4;
            // 
            // colid_role
            // 
            this.colid_role.Caption = "Role";
            this.colid_role.FieldName = "account_role.name";
            this.colid_role.Name = "colid_role";
            this.colid_role.Visible = true;
            this.colid_role.VisibleIndex = 5;
            // 
            // coldeletedAt
            // 
            this.coldeletedAt.FieldName = "deletedAt";
            this.coldeletedAt.Name = "coldeletedAt";
            // 
            // colaccount_role
            // 
            this.colaccount_role.FieldName = "account_role";
            this.colaccount_role.Name = "colaccount_role";
            // 
            // colcarts
            // 
            this.colcarts.FieldName = "carts";
            this.colcarts.Name = "colcarts";
            // 
            // colorders
            // 
            this.colorders.FieldName = "orders";
            this.colorders.Name = "colorders";
            // 
            // ucAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ucAccountDetails";
            this.Size = new System.Drawing.Size(824, 560);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraGrid.Columns.GridColumn colfullname;
        private DevExpress.XtraGrid.Columns.GridColumn colbirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colphonenumber;
        private DevExpress.XtraGrid.Columns.GridColumn colid_role;
        private DevExpress.XtraGrid.Columns.GridColumn coldeletedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colaccount_role;
        private DevExpress.XtraGrid.Columns.GridColumn colcarts;
        private DevExpress.XtraGrid.Columns.GridColumn colorders;
    }
}
