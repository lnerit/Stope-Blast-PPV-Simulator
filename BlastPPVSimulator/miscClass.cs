using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class miscClass
    {
        public static void LoadForm(Form childForm, Form mdiParentForm, String formCaption)
        {
            try
            {
                //childForm = new Form();
                childForm.MdiParent = mdiParentForm;
                childForm.Show();
                childForm.Text = formCaption;
            }
            catch (ArgumentException a)
            {
                MessageBox.Show(a.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
