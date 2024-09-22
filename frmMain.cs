using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameLibrary_RDR_2353FA21
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuMainItmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMainItmAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutFormVar = new frmAbout();
            aboutFormVar.ShowDialog();
        }

        private void mnuMainItmShopVideoGames_Click(object sender, EventArgs e)
        {
            frmShopNow shopNowForm = new frmShopNow();
            shopNowForm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
    }
}
