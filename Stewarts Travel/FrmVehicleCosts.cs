

namespace Stewarts_Travel
{
    public partial class FrmVehicleCosts : FrmCosts
    {
        public FrmVehicleCosts()
        {
            InitializeComponent();
        }

        //send data to variables, overrides super class
        protected override void pushData()
        {
            base.pushData();
            ClsVehicleCost lcCost = (ClsVehicleCost)_Costs;
        }

        //update form, overrides super class
        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsVehicleCost lcCost = (ClsVehicleCost)_Costs;
        }
    }
}
