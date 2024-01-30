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

namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Supplier
{
    public partial class frmSupplierUpdateDelete : Form
    {
        public frmSupplierUpdateDelete()
        {
            InitializeComponent();
        }
        //int SupplierID = 0;
        //private void btn_Update_Click(object sender, EventArgs e)
        //{
        //    string CompanyName = txt_SuppliersName.Text.Trim();
        //    bool answer = cls_Suppliers.update(CompanyName, SupplierID );

        //    if (answer == true)
        //    {
        //        txt_SuppliersName.Text = "";
        //        listviewFill();
        //        MessageBox.Show(cls_common.messages("Marka ", "update", true));

        //    }
        //    else
        //    {
        //        MessageBox.Show(cls_common.messages("Marka ", "update", false));
        //    }
        //}

        private void frmSupplierUpdateDelete_Load(object sender, EventArgs e)
        {
            listviewFill();
        }

        void listviewFill()
        {

            lst_supplier.Items.Clear();
            SqlDataReader List = cls_Suppliers.SelectSupplierList();
            while (List.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = List[0].ToString();
                lv.SubItems.Add(List[1].ToString());
                lst_supplier.Items.Add(lv);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frm_menu f = new frm_menu();
            this.Hide();
            f.ShowDialog();
        }

        //private void lst_categoy_Click(object sender, EventArgs e)
        //{
        //    SupplierID = Convert.ToInt32(lst_supplier.FocusedItem.SubItems[0].Text);
        //    txt_SuppliersName.Text = lst_supplier.FocusedItem.SubItems[1].Text;
        //}

        //private void btn_Delete_Click(object sender, EventArgs e)
        //{
        //    string SuppliersDelete = txt_SuppliersName.Text.Trim();
        //    bool answer = cls_Suppliers.delete(SuppliersDelete, SupplierID);

        //    if (answer == true)
        //    {
        //        txt_SuppliersName.Text = "";
        //        listviewFill();
        //        MessageBox.Show(cls_common.messages("Marka ", "delete", true));

        //    }
        //    else
        //    {
        //        MessageBox.Show(cls_common.messages("Marka ", "delete", false));
        //    }
        //}
    }
}
