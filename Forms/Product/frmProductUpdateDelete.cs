using Ders9_NTierDesing_Katmanli_Mimari.BusinessLayer;
using Ders9_NTierDesing_Katmanli_Mimari.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Product
{
    public partial class frmProductUpdateDelete : Form
    {
        public frmProductUpdateDelete()
        {
            InitializeComponent();
        }
        int ProductID = 0;
       
        //private void btn_product_update_Click(object sender, EventArgs e)
        //{
        //    string productname = txt_productname.Text.Trim();

        //    string CompanyName = cmb_markalar.SelectedItem.ToString();
        //    int supplierID = cls_Suppliers.SelectSupplierID(CompanyName);

        //    string CategoryName = cmb_kategoriler.SelectedItem.ToString();
        //    int CategoryID = cls_Category.SelectCategoryID(CategoryName);

        //    decimal Price = Convert.ToDecimal(txt_Price.Text);
        //    int UnitsInStock = Convert.ToInt32(txt_stok.Text);


        //    cls_Product cp = new cls_Product();
        //    cp.ProductID = ProductID;
        //    cp.Productname = productname;
        //    cp.SupplierID = supplierID;
        //    cp.CategoryID = CategoryID;
        //    cp.Price = Price;
        //    cp.UnitsInStock = UnitsInStock;
            
        //    bool answer = cp.update();
        //    if (answer == true)
        //    {
        //        listviewFill();
        //        MessageBox.Show(cls_common.messages("Product", "update", true));
        //    }
        //    else
        //    {
        //        MessageBox.Show(cls_common.messages("Product", "update", false));
        //    }

        //}

        //private void btn_product_delete_Click(object sender, EventArgs e)
        //{
        //    if (ProductID>0)
        //    {
        //        string productname = txt_productname.Text.Trim();

        //        string CompanyName = cmb_markalar.SelectedItem.ToString();
        //        int supplierID = cls_Suppliers.SelectSupplierID(CompanyName);

        //        string CategoryName = cmb_kategoriler.SelectedItem.ToString();
        //        int CategoryID = cls_Category.SelectCategoryID(CategoryName);

        //        decimal Price = Convert.ToDecimal(txt_Price.Text);
        //        int UnitsInStock = Convert.ToInt32(txt_stok.Text);

        //        cls_Product cp = new cls_Product();
        //        cp.ProductID = ProductID;
        //        cp.Productname = productname;
        //        cp.SupplierID = supplierID;
        //        cp.CategoryID = CategoryID;
        //        cp.Price = Price;
        //        cp.UnitsInStock = UnitsInStock;

        //        bool answer = cp.delete();
        //        if (answer == true)
        //        {
        //            listviewFill();
        //            MessageBox.Show(cls_common.messages("Product", "delete", true));
        //        }
        //        else
        //        {
        //            MessageBox.Show(cls_common.messages("Product", "delete", false));

        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Listeden kayıt seçmediniz.");
        //    }

        //}

        void listviewFill()
        {
            lst_product.Items.Clear();
            SqlDataReader List = cls_Product.SelectProductList();
            while (List.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = List[0].ToString();
                lv.SubItems.Add(List[1].ToString());
                lv.SubItems.Add(List[2].ToString());
                lv.SubItems.Add(List[3].ToString());
                lv.SubItems.Add(List[4].ToString());
                lv.SubItems.Add(List[5].ToString());
                lst_product.Items.Add(lv);

            }

        }

        private void frmProductUpdateDelete_Load(object sender, EventArgs e)
        {
            //SupplierFill();
            //CategoryFill();
            listviewFill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_menu f = new frm_menu();
            this.Hide();
            f.ShowDialog();
        }

        //private void lst_product_Click(object sender, EventArgs e)
        //{
        //    ProductID = Convert.ToInt32(lst_product.FocusedItem.SubItems[0].Text);
        //    txt_productname.Text = lst_product.FocusedItem.SubItems[1].Text;
        //    cmb_markalar.Text = lst_product.FocusedItem.SubItems[2].Text;
        //    cmb_kategoriler.Text = lst_product.FocusedItem.SubItems[3].Text;
        //    txt_Price.Text = lst_product.FocusedItem.SubItems[4].Text;
        //    txt_stok.Text = lst_product.FocusedItem.SubItems[5].Text;

        //}


        //void SupplierFill()
        //{
        //    cmb_markalar.Items.Clear();
        //    SqlDataReader List = cls_Suppliers.SelectSupplierList();
        //    while (List.Read())
        //    {

        //        cmb_markalar.Items.Add(List[1]);

        //    }
        //}
        //void CategoryFill()
        //{
        //    cmb_kategoriler.Items.Clear();
        //    SqlDataReader List = cls_Category.SelectCategoryList();
        //    while (List.Read())
        //    {

        //        cmb_kategoriler.Items.Add(List[1]);

        //    }
        //}

    }
}
