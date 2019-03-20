using System;

namespace Stewarts_Travel
{
    [Serializable]
    public class ClsStaffCost : ClsCosts
    {
        private string _StaffType;
        private static FrmStaffCosts _Form = new FrmStaffCosts();

        //public property from variable
        public string StaffType
        {
            get { return _StaffType; }
            set { _StaffType = value; }
        }

        //methods overriding superclass
        //true or false depending on button clicked to close form
        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        //type of cost
        public override string typeOfCost()
        {
            return "Staff";
        }

        //string to diplay in listbox
        public override string ToString()
        {
            return typeOfCost().PadRight(10) + Name.PadRight(20) + StaffType.PadRight(10) + Price;
        }

        //calclate per tour cost
        public override decimal CalculatePerTourCost(ClsTour prTour)
        {

            PerTourCost = Price * (Convert.ToDecimal(prTour.TotalTourDays));
            return PerTourCost;
        }

    }
}
