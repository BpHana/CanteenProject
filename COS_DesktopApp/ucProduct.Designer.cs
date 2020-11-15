namespace COS_DesktopApp
{
    partial class ucProduct
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.btn = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ritePrice = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colvolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riteVolume = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colingredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_productsType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riglueProductsType = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.products_typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypedeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_origin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riglueOrigin = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.originsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOriginID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginDeleteAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_sugarLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riglueSugarLevel = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.sugar_levelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSugarId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSugarName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSugarDeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.riglueCompany = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldCompDeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueProductsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueSugarLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sugar_levelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.White;
            windowsUIButtonImageOptions1.Image = global::COS_DesktopApp.Properties.Resources.add;
            windowsUIButtonImageOptions2.Image = global::COS_DesktopApp.Properties.Resources.trash;
            this.btn.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Add", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.btn.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn.ForeColor = System.Drawing.Color.Black;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn.Size = new System.Drawing.Size(754, 63);
            this.btn.TabIndex = 0;
            this.btn.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.btn_ButtonClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 63);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.ritePrice,
            this.riteVolume,
            this.riglueProductsType,
            this.riglueOrigin,
            this.riglueSugarLevel,
            this.riglueCompany});
            this.gridControl1.Size = new System.Drawing.Size(754, 468);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(COS_DesktopApp.product);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colprice,
            this.colvolume,
            this.colingredient,
            this.colid_productsType,
            this.colid_origin,
            this.colid_sugarLevel,
            this.colid_company,
            this.coldeletedAt,
            this.colimage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridView1.RowHeight = 100;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.Caption = "Name";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // colprice
            // 
            this.colprice.Caption = "Price";
            this.colprice.ColumnEdit = this.ritePrice;
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 2;
            // 
            // ritePrice
            // 
            this.ritePrice.AutoHeight = false;
            this.ritePrice.Mask.EditMask = "[1-9][0-9]{3,19}";
            this.ritePrice.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.ritePrice.Name = "ritePrice";
            // 
            // colvolume
            // 
            this.colvolume.Caption = "Volume";
            this.colvolume.ColumnEdit = this.riteVolume;
            this.colvolume.FieldName = "volume";
            this.colvolume.Name = "colvolume";
            this.colvolume.Visible = true;
            this.colvolume.VisibleIndex = 3;
            // 
            // riteVolume
            // 
            this.riteVolume.AutoHeight = false;
            this.riteVolume.Mask.EditMask = "\\d{1,10}";
            this.riteVolume.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.riteVolume.Name = "riteVolume";
            // 
            // colingredient
            // 
            this.colingredient.Caption = "Ingredient";
            this.colingredient.FieldName = "ingredient";
            this.colingredient.Name = "colingredient";
            this.colingredient.Visible = true;
            this.colingredient.VisibleIndex = 4;
            // 
            // colid_productsType
            // 
            this.colid_productsType.Caption = "Products Type";
            this.colid_productsType.ColumnEdit = this.riglueProductsType;
            this.colid_productsType.FieldName = "id_productsType";
            this.colid_productsType.Name = "colid_productsType";
            this.colid_productsType.Visible = true;
            this.colid_productsType.VisibleIndex = 5;
            // 
            // riglueProductsType
            // 
            this.riglueProductsType.AutoHeight = false;
            this.riglueProductsType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riglueProductsType.DataSource = this.products_typeBindingSource;
            this.riglueProductsType.DisplayMember = "name";
            this.riglueProductsType.Name = "riglueProductsType";
            this.riglueProductsType.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.riglueProductsType.ValueMember = "id";
            // 
            // products_typeBindingSource
            // 
            this.products_typeBindingSource.DataSource = typeof(COS_DesktopApp.products_type);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.ActiveFilterString = "[deletedAt] Is Null";
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltypeId,
            this.colTypeName,
            this.colTypedeletedAt});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coltypeId
            // 
            this.coltypeId.Caption = "Type ID";
            this.coltypeId.FieldName = "id";
            this.coltypeId.Name = "coltypeId";
            this.coltypeId.Visible = true;
            this.coltypeId.VisibleIndex = 0;
            // 
            // colTypeName
            // 
            this.colTypeName.Caption = "Type Name";
            this.colTypeName.FieldName = "name";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 1;
            // 
            // colTypedeletedAt
            // 
            this.colTypedeletedAt.FieldName = "deletedAt";
            this.colTypedeletedAt.Name = "colTypedeletedAt";
            // 
            // colid_origin
            // 
            this.colid_origin.Caption = "Origin";
            this.colid_origin.ColumnEdit = this.riglueOrigin;
            this.colid_origin.FieldName = "id_origin";
            this.colid_origin.Name = "colid_origin";
            this.colid_origin.Visible = true;
            this.colid_origin.VisibleIndex = 6;
            // 
            // riglueOrigin
            // 
            this.riglueOrigin.AutoHeight = false;
            this.riglueOrigin.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riglueOrigin.DataSource = this.originsBindingSource;
            this.riglueOrigin.DisplayMember = "name";
            this.riglueOrigin.Name = "riglueOrigin";
            this.riglueOrigin.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.riglueOrigin.ValueMember = "id";
            // 
            // originsBindingSource
            // 
            this.originsBindingSource.DataSource = typeof(COS_DesktopApp.origin);
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.ActiveFilterString = "[deletedAt] Is Null";
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOriginID,
            this.colOriginName,
            this.colOriginDeleteAt});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colOriginID
            // 
            this.colOriginID.Caption = "Origin ID";
            this.colOriginID.FieldName = "id";
            this.colOriginID.Name = "colOriginID";
            this.colOriginID.Visible = true;
            this.colOriginID.VisibleIndex = 0;
            // 
            // colOriginName
            // 
            this.colOriginName.Caption = "Origin Name";
            this.colOriginName.FieldName = "name";
            this.colOriginName.Name = "colOriginName";
            this.colOriginName.Visible = true;
            this.colOriginName.VisibleIndex = 1;
            // 
            // colOriginDeleteAt
            // 
            this.colOriginDeleteAt.FieldName = "deletedAt";
            this.colOriginDeleteAt.Name = "colOriginDeleteAt";
            // 
            // colid_sugarLevel
            // 
            this.colid_sugarLevel.Caption = "Sugar Level";
            this.colid_sugarLevel.ColumnEdit = this.riglueSugarLevel;
            this.colid_sugarLevel.FieldName = "id_sugarLevel";
            this.colid_sugarLevel.Name = "colid_sugarLevel";
            this.colid_sugarLevel.Visible = true;
            this.colid_sugarLevel.VisibleIndex = 7;
            // 
            // riglueSugarLevel
            // 
            this.riglueSugarLevel.AutoHeight = false;
            this.riglueSugarLevel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riglueSugarLevel.DataSource = this.sugar_levelBindingSource;
            this.riglueSugarLevel.DisplayMember = "name";
            this.riglueSugarLevel.Name = "riglueSugarLevel";
            this.riglueSugarLevel.PopupView = this.repositoryItemGridLookUpEdit3View;
            this.riglueSugarLevel.ValueMember = "id";
            // 
            // sugar_levelBindingSource
            // 
            this.sugar_levelBindingSource.DataSource = typeof(COS_DesktopApp.sugar_level);
            // 
            // repositoryItemGridLookUpEdit3View
            // 
            this.repositoryItemGridLookUpEdit3View.ActiveFilterString = "[deletedAt] Is Null";
            this.repositoryItemGridLookUpEdit3View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSugarId,
            this.colSugarName,
            this.colSugarDeletedAt});
            this.repositoryItemGridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit3View.Name = "repositoryItemGridLookUpEdit3View";
            this.repositoryItemGridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.repositoryItemGridLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // colSugarId
            // 
            this.colSugarId.Caption = "Sugar Level ID";
            this.colSugarId.FieldName = "id";
            this.colSugarId.Name = "colSugarId";
            this.colSugarId.Visible = true;
            this.colSugarId.VisibleIndex = 0;
            // 
            // colSugarName
            // 
            this.colSugarName.Caption = "Sugar Level Name";
            this.colSugarName.FieldName = "name";
            this.colSugarName.Name = "colSugarName";
            this.colSugarName.Visible = true;
            this.colSugarName.VisibleIndex = 1;
            // 
            // colSugarDeletedAt
            // 
            this.colSugarDeletedAt.FieldName = "deletedAt";
            this.colSugarDeletedAt.Name = "colSugarDeletedAt";
            // 
            // colid_company
            // 
            this.colid_company.Caption = "Company";
            this.colid_company.ColumnEdit = this.riglueCompany;
            this.colid_company.FieldName = "id_company";
            this.colid_company.Name = "colid_company";
            this.colid_company.Visible = true;
            this.colid_company.VisibleIndex = 8;
            // 
            // riglueCompany
            // 
            this.riglueCompany.AutoHeight = false;
            this.riglueCompany.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riglueCompany.DataSource = this.companiesBindingSource;
            this.riglueCompany.DisplayMember = "name";
            this.riglueCompany.Name = "riglueCompany";
            this.riglueCompany.PopupView = this.repositoryItemGridLookUpEdit4View;
            this.riglueCompany.ValueMember = "id";
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataSource = typeof(COS_DesktopApp.company);
            // 
            // repositoryItemGridLookUpEdit4View
            // 
            this.repositoryItemGridLookUpEdit4View.ActiveFilterString = "[deletedAt] Is Null";
            this.repositoryItemGridLookUpEdit4View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompID,
            this.colCompName,
            this.coldCompDeletedAt});
            this.repositoryItemGridLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit4View.Name = "repositoryItemGridLookUpEdit4View";
            this.repositoryItemGridLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit4View.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.repositoryItemGridLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // colCompID
            // 
            this.colCompID.Caption = "Company ID";
            this.colCompID.FieldName = "id";
            this.colCompID.Name = "colCompID";
            this.colCompID.Visible = true;
            this.colCompID.VisibleIndex = 0;
            // 
            // colCompName
            // 
            this.colCompName.Caption = "Company Name";
            this.colCompName.FieldName = "name";
            this.colCompName.Name = "colCompName";
            this.colCompName.Visible = true;
            this.colCompName.VisibleIndex = 1;
            // 
            // coldCompDeletedAt
            // 
            this.coldCompDeletedAt.FieldName = "deletedAt";
            this.coldCompDeletedAt.Name = "coldCompDeletedAt";
            // 
            // coldeletedAt
            // 
            this.coldeletedAt.FieldName = "deletedAt";
            this.coldeletedAt.Name = "coldeletedAt";
            // 
            // colimage
            // 
            this.colimage.Caption = "Image";
            this.colimage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colimage.FieldName = "image";
            this.colimage.Name = "colimage";
            this.colimage.Visible = true;
            this.colimage.VisibleIndex = 9;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.NullText = "Right Click To Add Image";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(754, 531);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riteVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueProductsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueSugarLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sugar_levelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riglueCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colvolume;
        private DevExpress.XtraGrid.Columns.GridColumn colingredient;
        private DevExpress.XtraGrid.Columns.GridColumn colid_productsType;
        private DevExpress.XtraGrid.Columns.GridColumn colid_origin;
        private DevExpress.XtraGrid.Columns.GridColumn colid_sugarLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colid_company;
        private DevExpress.XtraGrid.Columns.GridColumn coldeletedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colimage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.BindingSource products_typeBindingSource;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private System.Windows.Forms.BindingSource sugar_levelBindingSource;
        private System.Windows.Forms.BindingSource originsBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit ritePrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riteVolume;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit riglueProductsType;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coltypeId;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colTypedeletedAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit riglueOrigin;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginID;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginName;
        private DevExpress.XtraGrid.Columns.GridColumn colOriginDeleteAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit riglueSugarLevel;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit3View;
        private DevExpress.XtraGrid.Columns.GridColumn colSugarId;
        private DevExpress.XtraGrid.Columns.GridColumn colSugarName;
        private DevExpress.XtraGrid.Columns.GridColumn colSugarDeletedAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit riglueCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit4View;
        private DevExpress.XtraGrid.Columns.GridColumn colCompID;
        private DevExpress.XtraGrid.Columns.GridColumn colCompName;
        private DevExpress.XtraGrid.Columns.GridColumn coldCompDeletedAt;
    }
}
