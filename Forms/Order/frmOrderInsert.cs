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

namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Order
{
    public partial class frmOrderInsert : Form
    {
        public frmOrderInsert()
        {
            InitializeComponent();
        }

        private void frmOrderInsert_Load(object sender, EventArgs e)
        {
            ProductFill();
            EmployeeFill();
        }

        void ProductFill()
        {
            cmb_product.Items.Clear();
            SqlDataReader Liste = cls_Product.SelectProductList();
            while (Liste.Read())
            {
                cmb_product.Items.Add(Liste[1]);
            }
        }

        void EmployeeFill()
        {
            cmb_users.Items.Clear();
            SqlDataReader Liste = cls_Emplooye.SelectEmployeeList();
            while (Liste.Read())
            {
                cmb_users.Items.Add(Liste[1]);
            }
        }
        void temizle()
        {
            txt_adet.Text = "";
            cmb_product.SelectedIndex = -1;
            cmb_users.SelectedIndex = -1;

        }
       
        private void btn_save_Click(object sender, EventArgs e)
        {
           string ProductName =cmb_product.SelectedItem.ToString();
           int ProductID = cls_Product.SelectProductID(ProductName);
           
           string LastName= cmb_users.SelectedItem.ToString();
           int EmployeeID = cls_Emplooye.SelectEmployeeID(LastName);
           string Quantity = txt_adet.Text.Trim();

           
           
            bool answer = cls_Emplooye.insert(ProductID,EmployeeID, Quantity);
           

            if (answer == true)
            {
                temizle();
                MessageBox.Show(cls_common.messages("Order", "insert", true));
            }
            else
            {
                MessageBox.Show(cls_common.messages("Order", "insert", false));

            }

        }
    }
}
