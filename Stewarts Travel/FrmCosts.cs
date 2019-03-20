using System;
using System.Windows.Forms;

namespace Stewarts_Travel
{
    public partial class FrmCosts : Form
    {
        public ClsCosts _Costs;

        public FrmCosts()
        {
            InitializeComponent();
        }

        //update display when form opens
        public bool ShowDialog(ClsCosts prCost)
        {
            _Costs = prCost;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        //update form
        protected virtual void updateDisplay()
        {
            txtCostName.Text = _Costs.Name;
            numCostPrice.Value = _Costs.Price;
        }

        //send data to variables and close form
        private void btnOK_Click(object sender, EventArgs e)
        {
           pushData();
           DialogResult = DialogResult.OK;
        }

        //send data to variables
        protected virtual void pushData()
        {
            _Costs.Name = txtCostName.Text;
            _Costs.Price = Convert.ToDecimal(numCostPrice.Value);
        }

        //close form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
