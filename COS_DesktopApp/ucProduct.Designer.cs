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
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btn = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorigin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducts_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsugar_level = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            windowsUIButtonImageOptions1.Image = global::COS_DesktopApp.Properties.Resources.add;
            windowsUIButtonImageOptions2.Image = global::COS_DesktopApp.Properties.Resources.trash;
            this.btn.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Add", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.btn.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btn.Size = new System.Drawing.Size(700, 87);
            this.btn.TabIndex = 0;
            this.btn.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.btn_ButtonClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 87);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(700, 535);
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
            this.colcompany,
            this.colorigin,
            this.colproducts_type,
            this.colsugar_level,
            this.colimage,
            this.coldeletedAt});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 94;
            // 
            // colname
            // 
            this.colname.Caption = "Name";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 25;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 94;
            // 
            // colprice
            // 
            this.colprice.Caption = "Price";
            this.colprice.FieldName = "price";
            this.colprice.MinWidth = 25;
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 2;
            this.colprice.Width = 94;
            // 
            // colvolume
            // 
            this.colvolume.Caption = "Volume";
            this.colvolume.FieldName = "volume";
            this.colvolume.MinWidth = 25;
            this.colvolume.Name = "colvolume";
            this.colvolume.Visible = true;
            this.colvolume.VisibleIndex = 4;
            this.colvolume.Width = 94;
            // 
            // colingredient
            // 
            this.colingredient.Caption = "Ingredient";
            this.colingredient.FieldName = "ingredient";
            this.colingredient.MinWidth = 25;
            this.colingredient.Name = "colingredient";
            this.colingredient.Visible = true;
            this.colingredient.VisibleIndex = 5;
            this.colingredient.Width = 94;
            // 
            // colcompany
            // 
            this.colcompany.Caption = "Company";
            this.colcompany.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colcompany.FieldName = "company";
            this.colcompany.MinWidth = 25;
            this.colcompany.Name = "colcompany";
            this.colcompany.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colcompany.Visible = true;
            this.colcompany.VisibleIndex = 6;
            this.colcompany.Width = 94;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.productsBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "company";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataSource = typeof(COS_DesktopApp.company);
            // 
            // colorigin
            // 
            this.colorigin.Caption = "Origin";
            this.colorigin.FieldName = "origin.name";
            this.colorigin.MinWidth = 25;
            this.colorigin.Name = "colorigin";
            this.colorigin.Visible = true;
            this.colorigin.VisibleIndex = 7;
            this.colorigin.Width = 94;
            // 
            // colproducts_type
            // 
            this.colproducts_type.Caption = "Type";
            this.colproducts_type.FieldName = "products_type.name";
            this.colproducts_type.MinWidth = 25;
            this.colproducts_type.Name = "colproducts_type";
            this.colproducts_type.Visible = true;
            this.colproducts_type.VisibleIndex = 3;
            this.colproducts_type.Width = 94;
            // 
            // colsugar_level
            // 
            this.colsugar_level.Caption = "Sugar";
            this.colsugar_level.FieldName = "sugar_level.name";
            this.colsugar_level.MinWidth = 25;
            this.colsugar_level.Name = "colsugar_level";
            this.colsugar_level.Visible = true;
            this.colsugar_level.VisibleIndex = 8;
            this.colsugar_level.Width = 94;
            // 
            // colimage
            // 
            this.colimage.Caption = "Image";
            this.colimage.FieldName = "image";
            this.colimage.MinWidth = 25;
            this.colimage.Name = "colimage";
            this.colimage.Visible = true;
            this.colimage.VisibleIndex = 9;
            this.colimage.Width = 94;
            // 
            // coldeletedAt
            // 
            this.coldeletedAt.Caption = "deleteAt";
            this.coldeletedAt.FieldName = "deletedAt";
            this.coldeletedAt.MinWidth = 25;
            this.coldeletedAt.Name = "coldeletedAt";
            this.coldeletedAt.Width = 94;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(700, 622);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colvolume;
        private DevExpress.XtraGrid.Columns.GridColumn colingredient;
        private DevExpress.XtraGrid.Columns.GridColumn colimage;
        private DevExpress.XtraGrid.Columns.GridColumn colcompany;
        private DevExpress.XtraGrid.Columns.GridColumn colorigin;
        private DevExpress.XtraGrid.Columns.GridColumn colproducts_type;
        private DevExpress.XtraGrid.Columns.GridColumn colsugar_level;
        private DevExpress.XtraGrid.Columns.GridColumn coldeletedAt;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private System.Windows.Forms.BindingSource companiesBindingSource;
    }
}
