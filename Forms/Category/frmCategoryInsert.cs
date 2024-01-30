using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ders9_NTierDesing_Katmanli_Mimari.BusinessLayer;
using Ders9_NTierDesing_Katmanli_Mimari.TypeLayer;

namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Category
{
    public partial class frmCategoryInsert : Form
    {
        public frmCategoryInsert()
        {
            InitializeComponent();
        }

        private void frmCategoryInsert_Load(object sender, EventArgs e)
        {
            btn_Save.Visible= false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            string categoryname =thx_categoryName.Text.Trim();
            bool answer= cls_Category.insert(categoryname);
            if (answer==true) 
            {
                thx_categoryName.Text = "";
                MessageBox.Show(cls_common.messages("Category","insert",true));
            }
            else 
            {
                MessageBox.Show(cls_common.messages("Category","insert",false));
            
            }


        }

        private void thx_categoryName_TextChanged(object sender, EventArgs e)
        {

            if (thx_categoryName.Text.Trim().Length>0)
            {
                btn_Save.Visible = true;
            }
            else
            {
                btn_Save.Visible=false;
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
