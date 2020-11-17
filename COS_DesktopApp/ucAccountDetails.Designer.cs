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
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ritEmail = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphonenumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ritPhone = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colid_role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.account_roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRoleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoleDeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccount_role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcarts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorders = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountroleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountroleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions3.Image = global::COS_DesktopApp.Properties.Resources.add;
            windowsUIButtonImageOptions4.Image = global::COS_DesktopApp.Properties.Resources.trash;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Add", true, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", true, windowsUIButtonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowsUIButtonPanel1.ForeColor = System.Drawing.Color.Black;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(686, 77);
            this.windowsUIButtonPanel1.TabIndex = 0;
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.accountsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 77);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.ritEmail,
            this.ritPhone});
            this.gridControl1.Size = new System.Drawing.Size(686, 500);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(COS_DesktopApp.account);
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterString = "[deletedAt] Is Null";
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
            this.gridView1.DetailHeight = 431;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colid, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.MinWidth = 23;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 72;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.ColumnEdit = this.ritEmail;
            this.colemail.FieldName = "email";
            this.colemail.MinWidth = 23;
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 1;
            this.colemail.Width = 72;
            // 
            // ritEmail
            // 
            this.ritEmail.AutoHeight = false;
            this.ritEmail.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.ritEmail.Mask.EditMask = "\\w+([-+.\']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            this.ritEmail.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.ritEmail.Name = "ritEmail";
            // 
            // colpassword
            // 
            this.colpassword.Caption = "Password";
            this.colpassword.FieldName = "password";
            this.colpassword.MinWidth = 23;
            this.colpassword.Name = "colpassword";
            this.colpassword.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colpassword.Width = 72;
            // 
            // colfullname
            // 
            this.colfullname.Caption = "Fullname";
            this.colfullname.FieldName = "fullname";
            this.colfullname.MinWidth = 23;
            this.colfullname.Name = "colfullname";
            this.colfullname.Visible = true;
            this.colfullname.VisibleIndex = 2;
            this.colfullname.Width = 72;
            // 
            // colbirthday
            // 
            this.colbirthday.Caption = "Birthday";
            this.colbirthday.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colbirthday.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbirthday.FieldName = "birthday";
            this.colbirthday.MinWidth = 23;
            this.colbirthday.Name = "colbirthday";
            this.colbirthday.Visible = true;
            this.colbirthday.VisibleIndex = 3;
            this.colbirthday.Width = 72;
            // 
            // colphonenumber
            // 
            this.colphonenumber.Caption = "Phonenumber";
            this.colphonenumber.ColumnEdit = this.ritPhone;
            this.colphonenumber.FieldName = "phonenumber";
            this.colphonenumber.MinWidth = 23;
            this.colphonenumber.Name = "colphonenumber";
            this.colphonenumber.Visible = true;
            this.colphonenumber.VisibleIndex = 4;
            this.colphonenumber.Width = 72;
            // 
            // ritPhone
            // 
            this.ritPhone.AutoHeight = false;
            this.ritPhone.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.ritPhone.Mask.EditMask = "((\\+84)|(0))[1-9][0-9]{8}";
            this.ritPhone.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.ritPhone.Name = "ritPhone";
            // 
            // colid_role
            // 
            this.colid_role.Caption = "Role";
            this.colid_role.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colid_role.FieldName = "id_role";
            this.colid_role.MinWidth = 23;
            this.colid_role.Name = "colid_role";
            this.colid_role.Visible = true;
            this.colid_role.VisibleIndex = 5;
            this.colid_role.Width = 73;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.DataSource = this.account_roleBindingSource;
            this.repositoryItemGridLookUpEdit1.DisplayMember = "name";
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEdit1.ValueMember = "id";
            // 
            // account_roleBindingSource
            // 
            this.account_roleBindingSource.DataSource = typeof(COS_DesktopApp.account_role);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.ActiveFilterString = "[deletedAt] Is Null";
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRoleId,
            this.colRoleName,
            this.colRoleDeletedAt});
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 431;
            this.repositoryItemGridLookUpEdit1View.FixedLineWidth = 3;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colRoleId
            // 
            this.colRoleId.Caption = "Role ID";
            this.colRoleId.FieldName = "id";
            this.colRoleId.MinWidth = 23;
            this.colRoleId.Name = "colRoleId";
            this.colRoleId.Visible = true;
            this.colRoleId.VisibleIndex = 0;
            this.colRoleId.Width = 87;
            // 
            // colRoleName
            // 
            this.colRoleName.Caption = "Role Name";
            this.colRoleName.FieldName = "name";
            this.colRoleName.MinWidth = 23;
            this.colRoleName.Name = "colRoleName";
            this.colRoleName.Visible = true;
            this.colRoleName.VisibleIndex = 1;
            this.colRoleName.Width = 87;
            // 
            // colRoleDeletedAt
            // 
            this.colRoleDeletedAt.Caption = "Deleted At";
            this.colRoleDeletedAt.FieldName = "deletedAt";
            this.colRoleDeletedAt.MinWidth = 23;
            this.colRoleDeletedAt.Name = "colRoleDeletedAt";
            this.colRoleDeletedAt.Width = 87;
            // 
            // coldeletedAt
            // 
            this.coldeletedAt.FieldName = "deletedAt";
            this.coldeletedAt.MinWidth = 23;
            this.coldeletedAt.Name = "coldeletedAt";
            this.coldeletedAt.Width = 87;
            // 
            // colaccount_role
            // 
            this.colaccount_role.FieldName = "account_role";
            this.colaccount_role.MinWidth = 23;
            this.colaccount_role.Name = "colaccount_role";
            this.colaccount_role.Width = 87;
            // 
            // colcarts
            // 
            this.colcarts.FieldName = "carts";
            this.colcarts.MinWidth = 23;
            this.colcarts.Name = "colcarts";
            this.colcarts.Width = 71;
            // 
            // colorders
            // 
            this.colorders.FieldName = "orders";
            this.colorders.MinWidth = 23;
            this.colorders.Name = "colorders";
            // 
            // accountroleBindingSource
            // 
            this.accountroleBindingSource.DataSource = typeof(COS_DesktopApp.account_role);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // ucAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Name = "ucAccountDetails";
            this.Size = new System.Drawing.Size(686, 577);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.account_roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountroleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private System.Windows.Forms.BindingSource accountroleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleId;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn colRoleDeletedAt;
        private System.Windows.Forms.BindingSource account_roleBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritEmail;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritPhone;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}
