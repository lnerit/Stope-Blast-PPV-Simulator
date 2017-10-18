using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
namespace WindowsFormsApplication1
{
    public partial class frmSimulationCalculator : Form
    {
        public frmSimulationCalculator()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHP_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtUSBM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtLK_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCMRI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtRT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtK.Text == "")
            {
                MessageBox.Show("Please enter Rock Transmission Factor (K)", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txta.Text == "")
            {
                MessageBox.Show("Please enter Emphirical Constant (a)", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtb.Text == "")
            {
                MessageBox.Show("Please enter Emphirical Constant (b)", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SQLiteConnection c = new SQLiteConnection(dbConnection.sConnectingString))
                {
                    string s = @"DELETE FROM Constants;
                         INSERT INTO Constants VALUES(" + txtK.Text + "," + txta.Text + "," + txtb.Text + ")";
                    using (SQLiteCommand cmd = new SQLiteCommand(s, c))
                    {
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        this.txta.Enabled = false;
                        this.txtb.Enabled = false;
                        this.txtK.Enabled = false;
                        this.cmdSave.Enabled = false;

                        this.cmdModify.Enabled = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while saving record...Please try again!"+ex.Message);
            }
        }

        private void frmSimulationCalculator_Load(object sender, EventArgs e)
        {
            this.cmdSave.Enabled = false;
            this.cmdModify.Enabled = true;
            foreach (Control control in this.Controls)
            {
                if(control is GroupBox){
                    foreach (Control c in control.Controls)
                    {
                        if (c is GroupBox && c.Name == "groupBox7")
                        {                  
                                foreach (Control cx in c.Controls)
                                {
                                    if (cx.Name != cmdModify.Name)
                                    {
                                        cx.Enabled = false;
                                    }
                                }
                        }
                    }
                }
            }
            this.txtR.Text = "0";
            this.txtL.Text = "0";
            this.txtq.Text = "0";
            this.txtQx.Text="0";
            this.txtHP.Text = "0";
            this.txtLK.Text = "0";
            this.txtCMRI.Text = "0";
            this.txtUSBM.Text = "0";
            this.txtK.Text = clsFormula.getk().ToString();
            this.txta.Text = clsFormula.geta().ToString();
            this.txtb.Text = clsFormula.getb().ToString();


        }

        private void cmdModify_Click(object sender, EventArgs e)
        {
            this.txta.Enabled = true;
            this.txtb.Enabled = true;
            this.txtK.Enabled = true;
            this.lblA.Enabled = true;
            this.lblB.Enabled = true;
            this.lblK.Enabled = true;
            this.cmdSave.Enabled = true;
            this.cmdModify.Enabled = false;
        }

        private void txtQx_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtR.Text != "" && txtL.Text != "" && txtq.Text != "")
                {
                    //Show the results on console;
                    double L, R, q;
                    L = double.Parse(txtL.Text);
                    R = double.Parse(txtR.Text);
                    q = double.Parse(txtq.Text);
                    this.txtHP.Text = Math.Round(clsFormula.Holmberg_Persson(R, L, q), 2) + " mm/s";
                    this.txtUSBM.Text = Math.Round(clsFormula.USBM(R, L, q), 2) + " mm/s";
                    this.txtLK.Text = Math.Round(clsFormula.Langefors_Kihlstrom(R, L, q), 2) + " mm/s";
                    this.txtCMRI.Text = Math.Round(clsFormula.Ambraseys_Hendron(R, L, q), 2) + " mm/s";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtR.Text != "" && txtL.Text != "" && txtq.Text != "")
                {
                    //Show the results on console;
                    double L, R, q;
                    L = double.Parse(txtL.Text);
                    R = double.Parse(txtR.Text);
                    q = double.Parse(txtq.Text);
                    this.txtHP.Text = Math.Round(clsFormula.Holmberg_Persson(R, L, q), 2) + " mm/s";
                    this.txtUSBM.Text = Math.Round(clsFormula.USBM(R, L, q), 2) + " mm/s";
                    this.txtLK.Text = Math.Round(clsFormula.Langefors_Kihlstrom(R, L, q), 2) + " mm/s";
                    this.txtCMRI.Text = Math.Round(clsFormula.Ambraseys_Hendron(R, L, q), 2) + " mm/s";
                    this.txtQx.Text = clsFormula.getQ(L, q).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtq_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtR.Text != "" && txtL.Text != "" && txtq.Text != "")
                {
                    //Show the results on console;
                    double L, R, q;
                    L = double.Parse(txtL.Text);
                    R = double.Parse(txtR.Text);
                    q = double.Parse(txtq.Text);
                    this.txtHP.Text = Math.Round(clsFormula.Holmberg_Persson(R, L, q), 2) + " mm/s";
                    this.txtUSBM.Text = Math.Round(clsFormula.USBM(R, L, q), 2) + " mm/s";
                    this.txtLK.Text = Math.Round(clsFormula.Langefors_Kihlstrom(R, L, q), 2) + " mm/s";
                    this.txtCMRI.Text = Math.Round(clsFormula.Ambraseys_Hendron(R, L, q), 2) + " mm/s";
                    this.txtQx.Text = clsFormula.getQ(L, q).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
