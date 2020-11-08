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
            this.canteenOrderingSystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.canteenOrderingSystemDataSet = new COS_DesktopApp.CanteenOrderingSystemDataSet();
            this.productsTableAdapter = new COS_DesktopApp.CanteenOrderingSystemDataSetTableAdapters.productsTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_productsType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_origin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_sugarLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.canteenOrderingSystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenOrderingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.canteenOrderingSystemDataSetBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(707, 466);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.canteenOrderingSystemDataSet;
            // 
            // canteenOrderingSystemDataSet
            // 
            this.canteenOrderingSystemDataSet.DataSetName = "CanteenOrderingSystemDataSet";
            this.canteenOrderingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
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
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 94;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.MinWidth = 25;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 94;
            // 
            // colprice
            // 
            this.colprice.FieldName = "price";
            this.colprice.MinWidth = 25;
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 2;
            this.colprice.Width = 94;
            // 
            // colvolume
            // 
            this.colvolume.FieldName = "volume";
            this.colvolume.MinWidth = 25;
            this.colvolume.Name = "colvolume";
            this.colvolume.Visible = true;
            this.colvolume.VisibleIndex = 3;
            this.colvolume.Width = 94;
            // 
            // colingredient
            // 
            this.colingredient.FieldName = "ingredient";
            this.colingredient.MinWidth = 25;
            this.colingredient.Name = "colingredient";
            this.colingredient.Visible = true;
            this.colingredient.VisibleIndex = 4;
            this.colingredient.Width = 94;
            // 
            // colid_productsType
            // 
            this.colid_productsType.FieldName = "type";
            this.colid_productsType.MinWidth = 25;
            this.colid_productsType.Name = "colid_productsType";
            this.colid_productsType.Visible = true;
            this.colid_productsType.VisibleIndex = 5;
            this.colid_productsType.Width = 94;
            // 
            // colid_origin
            // 
            this.colid_origin.FieldName = "origin";
            this.colid_origin.MinWidth = 25;
            this.colid_origin.Name = "colid_origin";
            this.colid_origin.Visible = true;
            this.colid_origin.VisibleIndex = 6;
            this.colid_origin.Width = 94;
            // 
            // colid_sugarLevel
            // 
            this.colid_sugarLevel.FieldName = "sugar";
            this.colid_sugarLevel.MinWidth = 25;
            this.colid_sugarLevel.Name = "colid_sugarLevel";
            this.colid_sugarLevel.Visible = true;
            this.colid_sugarLevel.VisibleIndex = 7;
            this.colid_sugarLevel.Width = 94;
            // 
            // colid_company
            // 
            this.colid_company.FieldName = "company";
            this.colid_company.MinWidth = 25;
            this.colid_company.Name = "colid_company";
            this.colid_company.Visible = true;
            this.colid_company.VisibleIndex = 8;
            this.colid_company.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "image";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 9;
            this.gridColumn1.Width = 94;
            // 
            // ucProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(707, 466);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canteenOrderingSystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canteenOrderingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource canteenOrderingSystemDataSetBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private CanteenOrderingSystemDataSet canteenOrderingSystemDataSet;
        private CanteenOrderingSystemDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colprice;
        private DevExpress.XtraGrid.Columns.GridColumn colvolume;
        private DevExpress.XtraGrid.Columns.GridColumn colingredient;
        private DevExpress.XtraGrid.Columns.GridColumn colid_productsType;
        private DevExpress.XtraGrid.Columns.GridColumn colid_origin;
        private DevExpress.XtraGrid.Columns.GridColumn colid_sugarLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colid_company;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
