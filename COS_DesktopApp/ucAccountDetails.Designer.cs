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
            this.gcAccountDetails = new DevExpress.XtraGrid.GridControl();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canteenOrderingSystemDataSet = new COS_DesktopApp.CanteenOrderingSystemDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colphonenumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_role = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accountTableAdapter = new COS_DesktopApp.CanteenOrderingSystemDataSetTableAdapters.accountTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gcAccountDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenOrderingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcAccountDetails
            // 
            this.gcAccountDetails.DataSource = this.accountBindingSource;
            this.gcAccountDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAccountDetails.Location = new System.Drawing.Point(0, 0);
            this.gcAccountDetails.MainView = this.gridView1;
            this.gcAccountDetails.Name = "gcAccountDetails";
            this.gcAccountDetails.Size = new System.Drawing.Size(608, 574);
            this.gcAccountDetails.TabIndex = 0;
            this.gcAccountDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcAccountDetails.Load += new System.EventHandler(this.ucAccountDetails_Load);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.canteenOrderingSystemDataSet;
            // 
            // canteenOrderingSystemDataSet
            // 
            this.canteenOrderingSystemDataSet.DataSetName = "CanteenOrderingSystemDataSet";
            this.canteenOrderingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.colImage});
            this.gridView1.GridControl = this.gcAccountDetails;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "Id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colemail
            // 
            this.colemail.FieldName = "Email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 1;
            // 
            // colpassword
            // 
            this.colpassword.FieldName = "Password";
            this.colpassword.Name = "colpassword";
            // 
            // colfullname
            // 
            this.colfullname.FieldName = "Fullname";
            this.colfullname.Name = "colfullname";
            this.colfullname.Visible = true;
            this.colfullname.VisibleIndex = 2;
            // 
            // colbirthday
            // 
            this.colbirthday.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colbirthday.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbirthday.FieldName = "Birthday";
            this.colbirthday.GroupFormat.FormatString = "dd/MM/yyyy";
            this.colbirthday.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbirthday.Name = "colbirthday";
            this.colbirthday.Visible = true;
            this.colbirthday.VisibleIndex = 3;
            // 
            // colphonenumber
            // 
            this.colphonenumber.FieldName = "Phonenumber";
            this.colphonenumber.Name = "colphonenumber";
            this.colphonenumber.Visible = true;
            this.colphonenumber.VisibleIndex = 4;
            // 
            // colid_role
            // 
            this.colid_role.FieldName = "Role";
            this.colid_role.Name = "colid_role";
            this.colid_role.Visible = true;
            this.colid_role.VisibleIndex = 5;
            // 
            // coldeletedAt
            // 
            this.coldeletedAt.FieldName = "deletedAt";
            this.coldeletedAt.Name = "coldeletedAt";
            // 
            // colImage
            // 
            this.colImage.Caption = "Image";
            this.colImage.FieldName = "colImage";
            this.colImage.Name = "colImage";
            this.colImage.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 6;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // ucAccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcAccountDetails);
            this.Name = "ucAccountDetails";
            this.Size = new System.Drawing.Size(608, 574);
            ((System.ComponentModel.ISupportInitialize)(this.gcAccountDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenOrderingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcAccountDetails;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private CanteenOrderingSystemDataSet canteenOrderingSystemDataSet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colpassword;
        private DevExpress.XtraGrid.Columns.GridColumn colfullname;
        private DevExpress.XtraGrid.Columns.GridColumn colbirthday;
        private DevExpress.XtraGrid.Columns.GridColumn colphonenumber;
        private DevExpress.XtraGrid.Columns.GridColumn colid_role;
        private DevExpress.XtraGrid.Columns.GridColumn coldeletedAt;
        private CanteenOrderingSystemDataSetTableAdapters.accountTableAdapter accountTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
    }
}
