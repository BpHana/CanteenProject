using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using DevExpress.XtraEditors.Repository;

namespace COS_DesktopApp
{
    public partial class ucProduct : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucProduct _instance;
        public static ucProduct Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucProduct();

                }
                return _instance;
            }
        }

        public ucProduct()
        {
            InitializeComponent();

        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public RepositoryItemTextEdit getImage(string image)
        {
            RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
            Image obj = Image.FromFile(@"..\..\..\img\" + image);
            obj = resizeImage(obj, new Size(50, 50));
            textEdit.ContextImageOptions.Image = obj;

            return textEdit;
        }
        private void ProductControl_Load(object sender, EventArgs e)
        {

            // RepositoryItemTextEdit textEdit = new RepositoryItemTextEdit();
            // Image obj = Image.FromFile(@"..\..\..\img\goodmood.jpg");
            //obj= resizeImage(obj, new Size(50, 50));
            // textEdit.ContextImageOptions.Image = obj;

            // gridView1.Columns["gridColumn1"].ColumnEdit = textEdit;
            // gridControl1.RepositoryItems.Add(textEdit);
            CanteenOrderingSystemEntities db = new CanteenOrderingSystemEntities();

            var result = from c in db.products select new { id = c.id, name = c.name, price = c.price, volume = c.volume, ingredient = c.ingredient, type = c.products_type.name, origin = c.origin.name, sugar = c.sugar_level.name, company = c.company.name, image = c.image };
            gridControl1.DataSource = result.ToList();

        }
    }
}
