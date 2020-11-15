namespace COS_DesktopApp
{
    partial class ucOrder
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
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_user = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_details = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.windowsUIButtonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(626, 120);
            this.windowsUIButtonPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ordersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 120);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(626, 374);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colid_user,
            this.coltotalprice,
            this.colcreatedAt,
            this.coldeletedAt,
            this.colaccount,
            this.colorder_details});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(COS_DesktopApp.order);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colid_user
            // 
            this.colid_user.FieldName = "id_user";
            this.colid_user.Name = "colid_user";
            this.colid_user.Visible = true;
            this.colid_user.VisibleIndex = 1;
            // 
            // coltotalprice
            // 
            this.coltotalprice.FieldName = "totalprice";
            this.coltotalprice.Name = "coltotalprice";
            this.coltotalprice.Visible = true;
            this.coltotalprice.VisibleIndex = 2;
            // 
            // colcreatedAt
            // 
            this.colcreatedAt.FieldName = "createdAt";
            this.colcreatedAt.Name = "colcreatedAt";
            this.colcreatedAt.Visible = true;
            this.colcreatedAt.VisibleIndex = 3;
            // 
            // coldeletedAt
            // 
            this.coldeletedAt.FieldName = "deletedAt";
            this.coldeletedAt.Name = "coldeletedAt";
            this.coldeletedAt.Visible = true;
            this.coldeletedAt.VisibleIndex = 4;
            // 
            // colaccount
            // 
            this.colaccount.FieldName = "account";
            this.colaccount.Name = "colaccount";
            this.colaccount.Visible = true;
            this.colaccount.VisibleIndex = 5;
            // 
            // colorder_details
            // 
            this.colorder_details.FieldName = "order_details";
            this.colorder_details.Name = "colorder_details";
            this.colorder_details.Visible = true;
            this.colorder_details.VisibleIndex = 6;
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(626, 494);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colid_user;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalprice;
        private DevExpress.XtraGrid.Columns.GridColumn colcreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn coldeletedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colaccount;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_details;
    }
}
