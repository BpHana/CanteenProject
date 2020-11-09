namespace COS_DesktopApp
{
    partial class ManagementForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fdfContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.eDashboard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eGroupAccountManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eAccountDetails = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eRoles = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eProductManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eProducts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eProductTypes = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eOrigins = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eCompanies = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eSugarLevel = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.eOrderManagement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fdfContainer
            // 
            this.fdfContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fdfContainer.Location = new System.Drawing.Point(232, 30);
            this.fdfContainer.Name = "fdfContainer";
            this.fdfContainer.Size = new System.Drawing.Size(916, 614);
            this.fdfContainer.TabIndex = 0;
            this.fdfContainer.Click += new System.EventHandler(this.fluentDesignFormContainer1_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseImage = true;
            this.accordionControl1.Appearance.Group.Hovered.ForeColor = System.Drawing.Color.Black;
            this.accordionControl1.Appearance.Group.Hovered.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Group.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Normal.ForeColor = System.Drawing.Color.Black;
            this.accordionControl1.Appearance.Group.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Normal.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Group.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Group.Pressed.ForeColor = System.Drawing.Color.Black;
            this.accordionControl1.Appearance.Group.Pressed.Options.UseFont = true;
            this.accordionControl1.Appearance.Group.Pressed.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.Appearance.ItemWithContainer.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.ItemWithContainer.Hovered.Options.UseFont = true;
            this.accordionControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.eDashboard,
            this.eGroupAccountManagement,
            this.eProductManagement,
            this.eOrderManagement});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(232, 614);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // eDashboard
            // 
            this.eDashboard.Appearance.Disabled.Options.UseTextOptions = true;
            this.eDashboard.Appearance.Disabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.eDashboard.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDashboard.Appearance.Normal.Options.UseFont = true;
            this.eDashboard.ImageOptions.Image = global::COS_DesktopApp.Properties.Resources.dashboard16;
            this.eDashboard.Name = "eDashboard";
            this.eDashboard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.eDashboard.Text = "Dashboard";
            // 
            // eGroupAccountManagement
            // 
            this.eGroupAccountManagement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.eAccountDetails,
            this.eRoles});
            this.eGroupAccountManagement.ImageOptions.Image = global::COS_DesktopApp.Properties.Resources.user;
            this.eGroupAccountManagement.Name = "eGroupAccountManagement";
            this.eGroupAccountManagement.Text = "Account Management";
            // 
            // eAccountDetails
            // 
            this.eAccountDetails.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.eAccountDetails.Name = "eAccountDetails";
            this.eAccountDetails.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.eAccountDetails.Text = "Account Details";
            this.eAccountDetails.Click += new System.EventHandler(this.eAccountDetails_Click);
            // 
            // eRoles
            // 
            this.eRoles.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.eRoles.Name = "eRoles";
            this.eRoles.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.eRoles.Text = "Roles";
            // 
            // eProductManagement
            // 
            this.eProductManagement.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.eProducts,
            this.eProductTypes,
            this.eOrigins,
            this.eCompanies,
            this.eSugarLevel});
            this.eProductManagement.ImageOptions.Image = global::COS_DesktopApp.Properties.Resources.archive_filled_box;
            this.eProductManagement.Name = "eProductManagement";
            this.eProductManagement.Text = "Products Management";
            // 
            // eProducts
            // 
            this.eProducts.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.eProducts.Name = "eProducts";
            this.eProducts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.eProducts.Text = "Products";
            this.eProducts.Click += new System.EventHandler(this.eProducts_Click);
            // 
            // eProductTypes
            // 
            this.eProductTypes.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.eProductTypes.Name = "eProductTypes";
            this.eProductTypes.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.eProductTypes.Text = "Product Types";
            // 
            // eOrigins
            // 
            this.eOrigins.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.eOrigins.Name = "eOrigins";
            this.eOrigins.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.eOrigins.Text = "Origins";
            // 
            // eCompanies
            // 
            this.eCompanies.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.eCompanies.Name = "eCompanies";
            this.eCompanies.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.eCompanies.Text = "Companies";
            // 
            // eSugarLevel
            // 
            this.eSugarLevel.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text, DevExpress.XtraBars.Navigation.HeaderElementAlignment.Right)});
            this.eSugarLevel.Name = "eSugarLevel";
            this.eSugarLevel.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.eSugarLevel.Text = "Sugar Level";
            // 
            // eOrderManagement
            // 
            this.eOrderManagement.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eOrderManagement.Appearance.Normal.Options.UseFont = true;
            this.eOrderManagement.Expanded = true;
            this.eOrderManagement.ImageOptions.Image = global::COS_DesktopApp.Properties.Resources.list;
            this.eOrderManagement.Name = "eOrderManagement";
            this.eOrderManagement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.eOrderManagement.Text = "Order";
            this.eOrderManagement.Click += new System.EventHandler(this.eOrderManagement_Click);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinDropDownButtonItem1.Id = 0;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 1;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.skinPaletteDropDownButtonItem1.Id = 2;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.DockingEnabled = false;
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1,
            this.skinBarSubItem1,
            this.skinPaletteDropDownButtonItem1});
            this.fluentFormDefaultManager1.MaxItemId = 3;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1148, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 644);
            this.ControlContainer = this.fdfContainer;
            this.Controls.Add(this.fdfContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Image = global::COS_DesktopApp.Properties.Resources.chef512;
            this.Name = "ManagementForm";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fdfContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eDashboard;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eGroupAccountManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eAccountDetails;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eRoles;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eProductManagement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eProducts;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eProductTypes;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eOrigins;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eCompanies;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eSugarLevel;
        private DevExpress.XtraBars.Navigation.AccordionControlElement eOrderManagement;
    }
}