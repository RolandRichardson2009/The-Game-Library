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
    public partial class frmShopNow : Form
    {
        public frmShopNow()
        {
            InitializeComponent();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.clearCart();
            }
            catch { }
            ProgOps.DatabaseCommandTheGameLibraryVideoGameList(dgvGamesList);
            this.Close();
        }
        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            frmShoppingCart shoppingCartForm = new frmShoppingCart();
            shoppingCartForm.ShowDialog();
        }
        private void frmShopNow_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabaseTheGameLibrary();
            ProgOps.DatabaseCommandTheGameLibraryVideoGameList(dgvGamesList);
            ProgOps.selectNewOrderID();
            //ProgOps.clearOrderID1();
        }
        private void frmShopNow_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Properly Close database
            ProgOps.CloseDisposeDatabaseTheGameLibrary();
        }
        private void dgvGamesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get RowIndex of selected Cell
            int selectedRowVar = dgvGamesList.CurrentCell.RowIndex;
            string upcVar = dgvGamesList.Rows[selectedRowVar].Cells[5].Value.ToString();
            switch (upcVar.Substring(0, (upcVar.Length - 2)))
            {
                case "812872017150":
                    {
                        cbxQuantity.Items.Clear();
                        cbxQuantity.Text = "";
                        for (int x = 0; x < ProgOps.getQuantity(upcVar)+1; x++)
                        {
                            cbxQuantity.Items.Add((x).ToString());
                        }
                        pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.Terraria;
                        rtbDescription.Text = ProgOps.getDescription(upcVar);
                        break;
                    }
                case "711719549208":
                    cbxQuantity.Items.Clear();
                    cbxQuantity.Text = "";
                    for (int x = 0; x < ProgOps.getQuantity(upcVar) + 1; x++)
                    {
                        cbxQuantity.Items.Add((x).ToString());
                    }
                    pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.Minecraft;
                    rtbDescription.Text = ProgOps.getDescription(upcVar);
                    break;
                case "850055007994":
                    cbxQuantity.Items.Clear();
                    cbxQuantity.Text = "";
                    for (int x = 0; x < ProgOps.getQuantity(upcVar) + 1; x++)
                    {
                        cbxQuantity.Items.Add((x).ToString());
                    }
                    pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.StardewValley;
                    rtbDescription.Text = ProgOps.getDescription(upcVar);
                    break;
                case "850942007847":
                    cbxQuantity.Items.Clear();
                    cbxQuantity.Text = "";
                    for (int x = 0; x < ProgOps.getQuantity(upcVar) + 1; x++)
                    {
                        cbxQuantity.Items.Add((x).ToString());
                    }
                    pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.RiskofRain2;
                    rtbDescription.Text = ProgOps.getDescription(upcVar);
                    break;
                case "850055007420":
                    cbxQuantity.Items.Clear();
                    cbxQuantity.Text = "";
                    for (int x = 0; x < ProgOps.getQuantity(upcVar) + 1; x++)
                    {
                        cbxQuantity.Items.Add((x).ToString());
                    }
                    pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.Undertale;
                    rtbDescription.Text = ProgOps.getDescription(upcVar);
                    break;
                case "812303015472":
                    cbxQuantity.Items.Clear();
                    cbxQuantity.Text = "";
                    for (int x = 0; x < ProgOps.getQuantity(upcVar) + 1; x++)
                    {
                        cbxQuantity.Items.Add((x).ToString());
                    }
                    pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.CryptoftheNecrodancer;
                    rtbDescription.Text = ProgOps.getDescription(upcVar);
                    break;
                case "45496592998":
                    cbxQuantity.Items.Clear();
                    cbxQuantity.Text = "";
                    for (int x = 0; x < ProgOps.getQuantity(upcVar) + 1; x++)
                    {
                        cbxQuantity.Items.Add((x).ToString());
                    }
                    pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.SuperSmashBrosUltimate;
                    rtbDescription.Text = ProgOps.getDescription(upcVar);
                    break;
                case "45496596545":
                    cbxQuantity.Items.Clear();
                    cbxQuantity.Text = "";
                    for (int x = 0; x < ProgOps.getQuantity(upcVar) + 1; x++)
                    {
                        cbxQuantity.Items.Add((x).ToString());
                    }
                    pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.ZeldaLinksAwakening;
                    rtbDescription.Text = ProgOps.getDescription(upcVar);
                    break;
                case "859716006420":
                    cbxQuantity.Items.Clear();
                    cbxQuantity.Text = "";
                    for (int x = 0; x < ProgOps.getQuantity(upcVar) + 1; x++)
                    {
                        cbxQuantity.Items.Add((x).ToString());
                    }
                    pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.StoryofSeasonsFriendsofMineralTown;
                    rtbDescription.Text = ProgOps.getDescription(upcVar);
                    break;
                case "662248922553":
                    cbxQuantity.Items.Clear();
                    cbxQuantity.Text = "";
                    for (int x = 0; x < ProgOps.getQuantity(upcVar) + 1; x++)
                    {
                        cbxQuantity.Items.Add((x).ToString());
                    }
                    pbxShopNow.Image = TheGameLibrary_RDR_2353FA21.Properties.Resources.CollectionofMana;
                    rtbDescription.Text = ProgOps.getDescription(upcVar);
                    break;
            }
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (ProgOps.checkNewOrderBool())
            {
                ProgOps.setNewOrderBool();
                //ProgOps.increaseNewOrderID();
            }            
            try
            {
                if (cbxQuantity.SelectedItem.ToString() != null)
                {
                    //Get RowIndex of selected Cell
                    int selectedRowVar = dgvGamesList.CurrentCell.RowIndex;
                    //Get Video_Game_UPCVar of selected row
                    string Video_Game_UPCVar = dgvGamesList.Rows[selectedRowVar].Cells[5].Value.ToString();
                    //Get Order_QuantityVar of selected row from combo box
                    int Order_QuantityVar = int.Parse(cbxQuantity.SelectedItem.ToString());
                    //Get listed Quantity from table
                    int currentTableQuantity = ProgOps.getQuantity(Video_Game_UPCVar);
                    //get from assigned value stored at beginning of program
                    int OrderIDvar = ProgOps.getNewOrderID();
                    //customer ID used for testing purposes
                    int CustomerIDVar = 1;
                    //Get pricePerUnit of selected row
                    double pricePerUnitVar = double.Parse(dgvGamesList.Rows[selectedRowVar].Cells[1].Value.ToString());
                    //add order using given info
                    ProgOps.updateVideoGamesTable(Order_QuantityVar, Video_Game_UPCVar, currentTableQuantity);
                    //currentTableQuantity = ProgOps.getQuantity(Video_Game_UPCVar);
                    ProgOps.addOrder(Video_Game_UPCVar, Order_QuantityVar, CustomerIDVar, pricePerUnitVar, currentTableQuantity);




                    //ProgOps.copyCurrentOrderToOrder1(Video_Game_UPCVar, Order_QuantityVar, CustomerIDVar, pricePerUnitVar, currentTableQuantity);
                    
                    
                    
                    
                    
                    
                    //Message box
                    DialogResult dialogResult = MessageBox.Show("Would you like to continue shopping(Yes) or go to Shopping Cart(No)?",
                        "Continue Shopping?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        frmShoppingCart shoppingCartFormVar = new frmShoppingCart();
                        shoppingCartFormVar.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("You must select a quantity.");
                }
            dgvGamesList.Refresh();
            cbxQuantity.Items.Clear();
            cbxQuantity.Text = "";
            for (int x = 0; x < ProgOps.getQuantity(dgvGamesList.Rows[dgvGamesList.CurrentCell.RowIndex].Cells[5].Value.ToString()) + 1; x++)
            {
                cbxQuantity.Items.Add((x).ToString());
            }
            cbxQuantity.Refresh();
            }
            catch
            {
                MessageBox.Show("Add to cart failed");
            }
        }
        private void cbxQuantity_Click(object sender, EventArgs e)
        {
            cbxQuantity.Items.Clear();
            cbxQuantity.Text = "";
            for (int x = 0; x < ProgOps.getQuantity(dgvGamesList.Rows[dgvGamesList.CurrentCell.RowIndex].Cells[5].Value.ToString()) + 1; x++)
            {
                cbxQuantity.Items.Add((x).ToString());
            }
            cbxQuantity.Refresh();
        }
    }
}
