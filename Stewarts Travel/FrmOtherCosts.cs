namespace Stewarts_Travel
{
    public partial class FrmOtherCosts : FrmCosts
    {
        public FrmOtherCosts()
        {
            InitializeComponent();
        }

        //send data to variables, overrides super class
        protected override void pushData()
        {
            base.pushData();
            ClsOtherCost lcCost = (ClsOtherCost)_Costs;
        }

        //update form, overrides super class
        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsOtherCost lcCost = (ClsOtherCost)_Costs;
        }
    }
}
