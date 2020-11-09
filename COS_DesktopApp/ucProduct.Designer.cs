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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvolume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingredient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_productsType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_origin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_sugarLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldeletedAt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcarts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorder_details = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colorigin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproducts_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsugar_level = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.productsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(673, 505);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.colimage,
            this.colPicture,
            this.colcarts,
            this.colcompany,
            this.colorder_details,
            this.colorigin,
            this.colproducts_type,
            this.colsugar_level});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataSource = typeof(COS_DesktopApp.product);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            // 
            // colprice
            // 
            this.colprice.FieldName = "price";
            this.colprice.Name = "colprice";
            this.colprice.Visible = true;
            this.colprice.VisibleIndex = 2;
            // 
            // colvolume
            // 
            this.colvolume.FieldName = "volume";
            this.colvolume.Name = "colvolume";
            this.colvolume.Visible = true;
            this.colvolume.VisibleIndex = 3;
            // 
            // colingredient
            // 
            this.colingredient.FieldName = "ingredient";
            this.colingredient.Name = "colingredient";
            this.colingredient.Visible = true;
            this.colingredient.VisibleIndex = 4;
            // 
            // colid_productsType
            // 
            this.colid_productsType.FieldName = "id_productsType";
            this.colid_productsType.Name = "colid_productsType";
            this.colid_productsType.Visible = true;
            this.colid_productsType.VisibleIndex = 5;
            // 
            // colid_origin
            // 
            this.colid_origin.FieldName = "id_origin";
            this.colid_origin.Name = "colid_origin";
            this.colid_origin.Visible = true;
            this.colid_origin.VisibleIndex = 6;
            // 
            // colid_sugarLevel
            // 
            this.colid_sugarLevel.FieldName = "id_sugarLevel";
            this.colid_sugarLevel.Name = "colid_sugarLevel";
            this.colid_sugarLevel.Visible = true;
            this.colid_sugarLevel.VisibleIndex = 7;
            // 
            // colid_company
            // 
            this.colid_company.FieldName = "id_company";
            this.colid_company.Name = "colid_company";
            this.colid_company.Visible = true;
            this.colid_company.VisibleIndex = 8;
            // 
            // coldeletedAt
            // 
            this.coldeletedAt.FieldName = "deletedAt";
            this.coldeletedAt.Name = "coldeletedAt";
            this.coldeletedAt.Visible = true;
            this.coldeletedAt.VisibleIndex = 9;
            // 
            // colimage
            // 
            this.colimage.FieldName = "image";
            this.colimage.Name = "colimage";
            this.colimage.Visible = true;
            this.colimage.VisibleIndex = 10;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.OptionsColumn.ReadOnly = true;
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 11;
            // 
            // colcarts
            // 
            this.colcarts.FieldName = "carts";
            this.colcarts.Name = "colcarts";
            this.colcarts.Visible = true;
            this.colcarts.VisibleIndex = 12;
            // 
            // colcompany
            // 
            this.colcompany.FieldName = "company";
            this.colcompany.Name = "colcompany";
            this.colcompany.Visible = true;
            this.colcompany.VisibleIndex = 13;
            // 
            // colorder_details
            // 
            this.colorder_details.FieldName = "order_details";
            this.colorder_details.Name = "colorder_details";
            this.colorder_details.Visible = true;
            this.colorder_details.VisibleIndex = 14;
            // 
            // colorigin
            // 
            this.colorigin.FieldName = "origin";
            this.colorigin.Name = "colorigin";
            this.colorigin.Visible = true;
            this.colorigin.VisibleIndex = 15;
            // 
            // colproducts_type
            // 
            this.colproducts_type.FieldName = "products_type";
            this.colproducts_type.Name = "colproducts_type";
            this.colproducts_type.Visible = true;
            this.colproducts_type.VisibleIndex = 16;
            // 
            // colsugar_level
            // 
            this.colsugar_level.FieldName = "sugar_level";
            this.colsugar_level.Name = "colsugar_level";
            this.colsugar_level.Visible = true;
            this.colsugar_level.VisibleIndex = 17;
            // 
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(673, 505);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraGrid.Columns.GridColumn colcarts;
        private DevExpress.XtraGrid.Columns.GridColumn colcompany;
        private DevExpress.XtraGrid.Columns.GridColumn colorder_details;
        private DevExpress.XtraGrid.Columns.GridColumn colorigin;
        private DevExpress.XtraGrid.Columns.GridColumn colproducts_type;
        private DevExpress.XtraGrid.Columns.GridColumn colsugar_level;
    }
}
