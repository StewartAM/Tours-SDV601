using System;
using System.Windows.Forms;

namespace Stewarts_Travel
{
    public partial class FrmCostsList : Form
    {
        private FrmOtherCosts _OtherCostsForm = new FrmOtherCosts();
        private FrmStaffCosts _StaffCostsForm = new FrmStaffCosts();
        private FrmVehicleCosts _VehicleCostsForm = new FrmVehicleCosts();
        private ClsCosts _Costs;
        private string _TourName;
        private ClsTour _Tour ;

        //update label and combobox
        public FrmCostsList()
        {
            InitializeComponent();
            cbCostType.DataSource = ClsCosts._CostList;
            cbCostType.SelectedIndex = 0;
            lblTourName.Text = _TourName;
        }

        //update display from retrieved data when form loads
        private void FrmCostsList_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }

        //add tour name to a label
        public DialogResult ShowDialog(string prTourName, ClsTour prTour)
        {
            _TourName = prTourName;
            _Tour = prTour;
            lblTourName.Text = _TourName;
            return ShowDialog();
        }

        //update listbox
        private void updateDisplay()
        {
            lbCosts.DataSource = null;
            lbCosts.DataSource = _Tour.CostList;
        }

        //enter new cost
        private void btnEnterNewCosts_Click(object sender, EventArgs e)
        {
            ClsCosts lcCost = ClsCosts.NewCost(cbCostType.SelectedIndex);
            
            if (lcCost != null && lcCost.ViewEdit())
            {
                _Costs = lcCost;
                _Tour.CostList.Add(_Costs);
                updateDisplay();
            }
        }

        //edit an existing cost
        private void btnEditCosts_Click(object sender, EventArgs e)
        {
            ClsCosts lcCost = (ClsCosts)lbCosts.SelectedItem;
            if (lcCost == null)
            {
                MessageBox.Show("There are no Costs to modify. Create one first", "Confirm", MessageBoxButtons.OK);
            }
            if (lcCost != null && lcCost.ViewEdit())
            {
                updateDisplay();
            }
        }

        //submit and save cost
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ClsCompany.Save();
            Close();
        }

        //delete a cost
        private void btnDeleteCosts_Click(object sender, EventArgs e)
        {
            ClsCosts _Cost = (ClsCosts)lbCosts.SelectedItem;
            if (_Cost == null)
            {
                MessageBox.Show("There are no Tours to delete. Create one first", "Confirm", MessageBoxButtons.OK);
            }
            if (MessageBox.Show("Are you sure?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                _Tour.CostList.Remove(_Cost);
                updateDisplay();
        }

        //just close form
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
