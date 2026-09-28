using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        private InvItemList invItems = new InvItemList();


        // Lekish Sai Podili
        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems.Changed += new InvItemList.ChangeHandler(HandleChange);
            invItems.Fill();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            InvItem item;
            lstItems.Items.Clear();
            for (int i = 0; i < invItems.Count; i++)
            {
                item = invItems[i];
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        // Lekish Sai Podili
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem invItem = newItemForm.GetNewItem();



            Debug.WriteLine($"Item type: {invItem.GetType()}");
            Debug.WriteLine($"Item is InvItem: {invItem is InvItem}");
            Debug.WriteLine($"Item is IDisplayable: {invItem is IDisplayable}");

            if (invItem != null)
            {
                invItems += invItem;
            }
        }

        // Lekish Sai Podili
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                InvItem invItem = invItems[i];
                string message = "Are you sure you want to delete "
                    + invItem.Description + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    invItems -= invItem;
                }
            }
        }


        // Lekish Sai Podili
        private void HandleChange(InvItemList invItems)
        {
            invItems.Save();
            FillItemListBox();
        }

        // Lekish Sai Podili
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
