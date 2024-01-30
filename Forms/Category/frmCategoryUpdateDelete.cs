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

namespace ders9_NTie_Desing_Katmanli_Mimari_calisma.Forms.Category
{
    public partial class frmCategoryUpdateDelete : Form
    {
        public frmCategoryUpdateDelete()
        {
            InitializeComponent();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           
            string categoryupdate= thx_categoryName.Text.Trim();

            bool answer=cls_Category.update(categoryupdate, CategoryID);

            if (answer == true)
            {
                thx_categoryName.Text = "";
                listviewFill();
                MessageBox.Show(cls_common.messages("CategoryUpdate", "update", true));
                
            }
            else
            {
                MessageBox.Show(cls_common.messages("CategoryUpdate", "update", false));
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (CategoryID>0)
            {
                string categorydelete = thx_categoryName.Text.Trim(); ;
                bool answer = cls_Category.delete(categorydelete, CategoryID);

                if (answer == true)
                {
                    thx_categoryName.Text = "";
                    listviewFill();
                    MessageBox.Show(cls_common.messages("CategoryDelete ", "delete", true));
                }
                else
                {
                    MessageBox.Show(cls_common.messages("CategoryDelete ", "delete", false));
                }
            }
            else
            {
                MessageBox.Show("Listeden kayıt seçmediniz.");
            }
        }

         void frmCategoryUpdateDelete_Load(object sender, EventArgs e)
        {
            listviewFill();
        }

        void listviewFill()
        {
            lst_categoy.Items.Clear();
            SqlDataReader List = cls_Category.SelectCategoryList();
            while (List.Read())
            {
                ListViewItem lv = new ListViewItem();
                lv.Text = List[0].ToString();
                lv.SubItems.Add(List[1].ToString());
                lst_categoy.Items.Add(lv);

            }

        }

        int CategoryID = 0;
        private void lst_categoy_Click(object sender, EventArgs e)
        {
            CategoryID = Convert.ToInt32(lst_categoy.FocusedItem.SubItems[0].Text);
            thx_categoryName.Text = lst_categoy.FocusedItem.SubItems[1].Text;
           // thx_categoryName.Text = listviewID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_menu f = new frm_menu();
            this.Hide();
            f.ShowDialog();
        }
    }
}
