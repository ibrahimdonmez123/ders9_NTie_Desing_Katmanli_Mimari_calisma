using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Category;
using ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Product;
using ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Supplier;
//using ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.User;
using ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Order;

namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void kATEGORİGİRİŞFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoryInsert frmInsert = new frmCategoryInsert();
            frmInsert.ShowDialog();

        }

        private void gÜNCELLESİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoryUpdateDelete frmUpdateDelete = new frmCategoryUpdateDelete();
            frmUpdateDelete.ShowDialog();
        }

        private void mARKAGİRİŞFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierInsert frmInsert = new frmSupplierInsert();
            frmInsert.ShowDialog();

        }

        private void gÜNCELLESİLFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplierUpdateDelete frmUpdateDelete = new frmSupplierUpdateDelete();
            frmUpdateDelete.ShowDialog();

        }

        private void üRÜNGİRİŞFORMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductInsert frmInsert = new frmProductInsert();
            frmInsert.ShowDialog();

        }

        private void gÜNCELLESİLFORMUToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProductUpdateDelete frmUpdateDelete = new frmProductUpdateDelete();
            frmUpdateDelete.ShowDialog();

        }

        //private void lİSTELEToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    frmUserInsert frmInsert = new frmUserInsert();
        //    frmInsert.ShowDialog();
        //}

        //private void lİSTELEToolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //    frmUserUpdateDelete frmUpdateDelete =new frmUserUpdateDelete();
        //    frmUpdateDelete.ShowDialog();
        //}

        private void sİPARİŞLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderInsert frmInsert = new frmOrderInsert();
            frmInsert.ShowDialog();
        }

        private void sİPARİŞLİSTESİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderList frmOrderList = new frmOrderList();
            frmOrderList.ShowDialog();

        }
    }
    
}
