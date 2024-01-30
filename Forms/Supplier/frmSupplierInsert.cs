using ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Product;
using Ders9_NTierDesing_Katmanli_Mimari.BusinessLayer;
using Ders9_NTierDesing_Katmanli_Mimari.TypeLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Supplier
{
    public partial class frmSupplierInsert : Form
    {
        public frmSupplierInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string suppliersname = txt_suppliers.Text.Trim();
            bool answer = cls_Suppliers.insert(suppliersname);
            if (answer == true)
            {
                txt_suppliers.Text = "";
                MessageBox.Show(cls_common.messages("Category", "insert", true));
            }
            else
            {
                MessageBox.Show(cls_common.messages("Category", "insert", false));

            }
        }

        private void txt_suppliers_TextChanged(object sender, EventArgs e)
        {

            if (txt_suppliers.Text.Trim().Length > 0)
            {
                btn_save.Visible = true;
            }
            else
            {
                btn_save.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            frm_menu f = new frm_menu();
            this.Hide();
            f.ShowDialog();
        }
    }
}
