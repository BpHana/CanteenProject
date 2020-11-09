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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions4 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.accountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(COS_DesktopApp.account);
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackgroundImage = global::COS_DesktopApp.Properties.Resources.Screenshot_2020_11_07_143737;
            this.windowsUIButtonPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            windowsUIButtonImageOptions3.Image = global::COS_DesktopApp.Properties.Resources.add;
            windowsUIButtonImageOptions4.Image = global::COS_DesktopApp.Properties.Resources.trash;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Add", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(824, 63);
            this.windowsUIButtonPanel1.TabIndex = 1;
            this.windowsUIButtonPanel1.Click += new System.EventHandler(this.windowsUIButtonPanel1_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.accountsBindingSource1;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 63);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(824, 497);
            this.gridControl2.TabIndex = 2;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // accountsBindingSource1
            // 
            this.accountsBindingSource1.DataSource = typeof(COS_DesktopApp.account);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
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
            this.colbirthday.Caption = "Birthday";
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
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Name = "ucAccountDetails";
            this.Size = new System.Drawing.Size(824, 560);
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource accountsBindingSource1;
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
