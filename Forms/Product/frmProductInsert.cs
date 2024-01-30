using Ders9_NTierDesing_Katmanli_Mimari.BusinessLayer;
using Ders9_NTierDesing_Katmanli_Mimari.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Product
{
    public partial class frmProductInsert : Form
    {
        public frmProductInsert()
        {
            InitializeComponent();
        }

     

      

        private void btn_Save_TextChanged(object sender, EventArgs e)
        {
            if (thx_ProductName.Text.Trim().Length > 0)
            {
                btn_Save.Visible = true;
            }
            else
            {
                btn_Save.Visible = false;
            }
        }
        
        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            string productname = thx_ProductName.Text.Trim();

            string CompanyName= cmb_markalar.SelectedItem.ToString();
            int supplierID = cls_Suppliers.SelectSupplierID(CompanyName);

            string CategoryName=cmb_kategoriler.SelectedItem.ToString();
            int CategoryID = cls_Category.SelectCategoryID(CategoryName);

            decimal price = Convert.ToDecimal(txt_Price.Text);
            int UnitsInStock = Convert.ToInt32(txt_stok.Text);
            
            
            cls_Product cp= new cls_Product();
            cp.Productname = productname;
            cp.SupplierID= supplierID;
            cp.CategoryID = CategoryID;
            cp.Price = price;
            cp.UnitsInStock = UnitsInStock;
            bool answer = cp.insert();

            if (answer == true)
            {
                temizle();
                MessageBox.Show(cls_common.messages("Product","insert",true));
            }
            else
            {
                MessageBox.Show(cls_common.messages("Product", "insert", false));

            }
        }
        void temizle()
        {
            txt_Price.Text = txt_stok.Text = thx_ProductName.Text="";
            cmb_kategoriler.SelectedIndex = -1;
            cmb_markalar.SelectedIndex = -1;

        }
        private void frmProductInsert_Load(object sender, EventArgs e)
        {
            SupplierFill();
            CategoryFill();
            
        }

        void SupplierFill()
        {
            cmb_markalar.Items.Clear();
            SqlDataReader List = cls_Suppliers.SelectSupplierList();
            while (List.Read())
            {

                cmb_markalar.Items.Add(List[1]);

            }
        }
        void CategoryFill()
        {
            cmb_kategoriler.Items.Clear();
            SqlDataReader List = cls_Category.SelectCategoryList();
            while (List.Read())
            {

                cmb_kategoriler.Items.Add(List[1]);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm_menu f = new frm_menu();
            this.Hide();
            f.ShowDialog();
        }
    }
}

