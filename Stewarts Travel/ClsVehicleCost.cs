using System;

namespace Stewarts_Travel
{
    [Serializable]
    class ClsVehicleCost : ClsCosts
    {
        private static FrmVehicleCosts _Form = new FrmVehicleCosts();

        //methods overriding superclass
        //true or false depending on button clicked to close form
        public override bool ViewEdit()
        {
            return _Form.ShowDialog(this);
        }

        //type of cost
        public override string typeOfCost()
        {
            return "Vehicle";
        }

        //string to diplay in listbox
        public override string ToString()
        {
            return typeOfCost().PadRight(10) + Name.PadRight(30) + Price;
        }

        //calclate per tour cost
        public override decimal CalculatePerTourCost(ClsTour prTour)
        {
            PerTourCost = Price * prTour.Distance;
            return PerTourCost;
        }

    }
}
