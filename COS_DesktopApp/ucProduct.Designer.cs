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
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducts_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorigin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsugar_level = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_productsType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_origin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_sugarLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcarts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_details = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(COS_DesktopApp.product);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataSource = typeof(COS_DesktopApp.product);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colname,
            this.colprice,
            this.colvolume,
            this.colingredient,
            this.colproducts_type,
            this.colcompany,
            this.colorigin,
            this.colsugar_level,
            this.colid_productsType,
            this.colid_origin,
            this.colid_sugarLevel,
            this.colid_company,
            this.coldeletedAt,
            this.colcarts,
            this.colorder_details,
            this.colimage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colid
            // 
            this.colid.Caption = "ID";
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
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
            // colcompany
            // 
            this.colcompany.Caption = "Company";
            this.colcompany.FieldName = "company.name";
            this.colcompany.MinWidth = 25;
            this.colcompany.Name = "colcompany";
            this.colcompany.Visible = true;
            this.colcompany.VisibleIndex = 6;
            this.colcompany.Width = 94;
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
            // colsugar_level
            // 
            this.colsugar_level.Caption = "Sugar Level";
            this.colsugar_level.FieldName = "sugar_level.name";
            this.colsugar_level.MinWidth = 25;
            this.colsugar_level.Name = "colsugar_level";
            this.colsugar_level.Visible = true;
            this.colsugar_level.VisibleIndex = 8;
            this.colsugar_level.Width = 94;
            // 
            // colid_productsType
            // 
            this.colid_productsType.Caption = "Type";
            this.colid_productsType.FieldName = "products_type.name";
            this.colid_productsType.MinWidth = 25;
            this.colid_productsType.Name = "colid_productsType";
            this.colid_productsType.Width = 94;
            // 
            // colid_origin
            // 
            this.colid_origin.Caption = "Origin";
            this.colid_origin.FieldName = "origin.name";
            this.colid_origin.MinWidth = 25;
            this.colid_origin.Name = "colid_origin";
            this.colid_origin.Width = 94;
            // 
            // colid_sugarLevel
            // 
            this.colid_sugarLevel.FieldName = "sugar_level.name";
            this.colid_sugarLevel.MinWidth = 25;
            this.colid_sugarLevel.Name = "colid_sugarLevel";
            this.colid_sugarLevel.Width = 94;
            // 
            // colid_company
            // 
            this.colid_company.Caption = "Company";
            this.colid_company.FieldName = "company.name";
            this.colid_company.MinWidth = 25;
            this.colid_company.Name = "colid_company";
            this.colid_company.Width = 94;
            // 
            // coldeletedAt
            // 
            this.coldeletedAt.FieldName = "deletedAt";
            this.coldeletedAt.MinWidth = 25;
            this.coldeletedAt.Name = "coldeletedAt";
            this.coldeletedAt.Width = 94;
            // 
            // colcarts
            // 
            this.colcarts.FieldName = "carts";
            this.colcarts.MinWidth = 25;
            this.colcarts.Name = "colcarts";
            this.colcarts.Width = 94;
            // 
            // colorder_details
            // 
            this.colorder_details.FieldName = "order_details";
            this.colorder_details.MinWidth = 25;
            this.colorder_details.Name = "colorder_details";
            this.colorder_details.Width = 94;
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.gridControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(556, 312);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(556, 622);
            this.Load += new System.EventHandler(this.ucProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colvolume;
        private DevExpress.XtraGrid.Columns.GridColumn colingredient;
        private DevExpress.XtraGrid.Columns.GridColumn colproducts_type;
        private DevExpress.XtraGrid.Columns.GridColumn colcompany;
        private DevExpress.XtraGrid.Columns.GridColumn colorigin;
        private DevExpress.XtraGrid.Columns.GridColumn colsugar_level;
        private DevExpress.XtraGrid.Columns.GridColumn colid_productsType;
        private DevExpress.XtraGrid.Columns.GridColumn colid_origin;
        private DevExpress.XtraGrid.Columns.GridColumn colid_sugarLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colid_company;
        private DevExpress.XtraGrid.Columns.GridColumn coldeletedAt;
        private DevExpress.XtraGrid.Columns.GridColumn colcarts;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_details;
        private DevExpress.XtraGrid.Columns.GridColumn colimage;
        private DevExpress.XtraGrid.GridControl gridControl1;
    }
}
