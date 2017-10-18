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
    public partial class frmEmphiricalConstants : Form
    {
        public frmEmphiricalConstants()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (this.txtEmphiricalConstanta.Text != "" && this.txtEmphiricalConstantb.Text != "" && this.txtRockTransFactor.Text != "" && this.txtDistanceFromBlastToMeasurePoint.Text != "")
            {
                using (SQLiteConnection c = new SQLiteConnection(dbConnection.sConnectingString))
                {
                    string s="INSERT INTO ";
                    
                    using (SQLiteCommand cmd=new SQLiteCommand(s,c)){
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                
            }
        }
    }
}
