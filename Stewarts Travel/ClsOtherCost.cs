using System;

namespace Stewarts_Travel
{
    [Serializable]
    class ClsOtherCost : ClsCosts
    {
        private static FrmOtherCosts _Form = new FrmOtherCosts();

        //methods overriding superclass
        //true or false depending on button clicked to close form
        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        //type of cost
        public override string typeOfCost()
        {
            return "Other";
        }

        //string to diplay in listbox
        public override string ToString()
        {
            return typeOfCost().PadRight(10) + Name.PadRight(30) + Price; 
        }

        //calclate per tour cost
        public override decimal CalculatePerTourCost(ClsTour prTour)
        {
            PerTourCost = Price * prTour.MaxPassenger;//per person
            return PerTourCost;
        }
    }
}
