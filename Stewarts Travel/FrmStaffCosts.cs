namespace Stewarts_Travel
{
    public partial class FrmStaffCosts : FrmCosts
    {
        public FrmStaffCosts()
        {
            InitializeComponent();
        }

        //send data to variables, overrides super class
        protected override void pushData()
        {
            base.pushData();
            ClsStaffCost lcCost = (ClsStaffCost)_Costs;
            lcCost.StaffType = txtStaffType.Text;
        }

        //update form, overrides super class
        protected override void updateDisplay()
        {
            base.updateDisplay();
            ClsStaffCost lcCost = (ClsStaffCost)_Costs;
            txtStaffType.Text = lcCost.StaffType;
        }

    }
}
