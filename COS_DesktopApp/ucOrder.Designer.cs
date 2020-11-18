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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_products = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcreatedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.order_detailsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemPictureEdit1});
            this.gridControl1.Size = new System.Drawing.Size(730, 608);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // order_detailsBindingSource
            // 
            this.order_detailsBindingSource.DataSource = typeof(COS_DesktopApp.order_details);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTotalPrice,
            this.colid_order,
            this.colid_products,
            this.colAddress,
            this.colquantity,
            this.colprice,
            this.colcreatedAt,
            this.coldeletedAt,
            this.colorder,
            this.colproduct,
            this.colUser,
            this.colImage});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.RowHeight = 123;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridMergedColumnSortInfo(new DevExpress.XtraGrid.Columns.GridColumn[] {
                        this.colid_order,
                        this.colUser,
                        this.colAddress,
                        this.colTotalPrice}, new DevExpress.Data.ColumnSortOrder[] {
                        DevExpress.Data.ColumnSortOrder.Ascending,
                        DevExpress.Data.ColumnSortOrder.Ascending,
                        DevExpress.Data.ColumnSortOrder.Ascending,
                        DevExpress.Data.ColumnSortOrder.Ascending})});
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "Total Price";
            this.colTotalPrice.FieldName = "order.totalprice";
            this.colTotalPrice.MinWidth = 23;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.OptionsColumn.AllowMove = false;
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 0;
            this.colTotalPrice.Width = 87;
            // 
            // colid_order
            // 
            this.colid_order.Caption = "ID Order";
            this.colid_order.FieldName = "id_order";
            this.colid_order.MinWidth = 23;
            this.colid_order.Name = "colid_order";
            this.colid_order.OptionsColumn.AllowMove = false;
            this.colid_order.Visible = true;
            this.colid_order.VisibleIndex = 0;
            this.colid_order.Width = 87;
            // 
            // colid_products
            // 
            this.colid_products.Caption = "Product";
            this.colid_products.FieldName = "product.name";
            this.colid_products.MinWidth = 23;
            this.colid_products.Name = "colid_products";
            this.colid_products.Visible = true;
            this.colid_products.VisibleIndex = 0;
            this.colid_products.Width = 87;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "order.address";
            this.colAddress.MinWidth = 23;
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowMove = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 0;
            this.colAddress.Width = 87;
            // 
            // colquantity
            // 
            this.colquantity.Caption = "Quantity";
            this.colquantity.FieldName = "quantity";
            this.colquantity.MinWidth = 23;
            this.colquantity.Name = "colquantity";
            this.colquantity.Visible = true;
            this.colquantity.VisibleIndex = 2;
            this.colquantity.Width = 87;
            // 
            // colprice
            // 
            this.colprice.Caption = "Price";
            this.colprice.FieldName = "price";
            this.colprice.MinWidth = 23;
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 3;
            this.colprice.Width = 87;
            // 
            // colcreatedAt
            // 
            this.colcreatedAt.Caption = "Created At";
            this.colcreatedAt.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colcreatedAt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colcreatedAt.FieldName = "order.createdAt";
            this.colcreatedAt.MinWidth = 23;
            this.colcreatedAt.Name = "colcreatedAt";
            this.colcreatedAt.Visible = true;
            this.colcreatedAt.VisibleIndex = 4;
            this.colcreatedAt.Width = 87;
            // 
            // coldeletedAt
            // 
            this.coldeletedAt.FieldName = "deletedAt";
            this.coldeletedAt.MinWidth = 23;
            this.coldeletedAt.Name = "coldeletedAt";
            this.coldeletedAt.Width = 87;
            // 
            // colorder
            // 
            this.colorder.FieldName = "order";
            this.colorder.MinWidth = 23;
            this.colorder.Name = "colorder";
            this.colorder.Width = 87;
            // 
            // colproduct
            // 
            this.colproduct.FieldName = "product";
            this.colproduct.MinWidth = 23;
            this.colproduct.Name = "colproduct";
            this.colproduct.Width = 87;
            // 
            // colUser
            // 
            this.colUser.Caption = "User Fullname";
            this.colUser.FieldName = "order.account.fullname";
            this.colUser.MinWidth = 23;
            this.colUser.Name = "colUser";
            this.colUser.OptionsColumn.AllowMove = false;
            this.colUser.Visible = true;
            this.colUser.VisibleIndex = 0;
            this.colUser.Width = 87;
            // 
            // colImage
            // 
            this.colImage.Caption = "Product Image";
            this.colImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colImage.FieldName = "product.image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 1;
            this.colImage.Width = 87;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.PopupView = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.DetailHeight = 431;
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataSource = typeof(COS_DesktopApp.order);
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataSource = typeof(COS_DesktopApp.account);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(COS_DesktopApp.product);
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(730, 608);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource order_detailsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid_order;
        private DevExpress.XtraGrid.Columns.GridColumn colid_products;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colcreatedAt;
        private DevExpress.XtraGrid.Columns.GridColumn coldeletedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colorder;
        private DevExpress.XtraGrid.Columns.GridColumn colproduct;
        private DevExpress.XtraGrid.Columns.GridColumn colUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}
