using System;

namespace Stewarts_Travel
{
    [Serializable]
    public abstract class ClsCosts
    {
        public static readonly string[] _CostList = { "New Staff Cost", "New Vehicle Cost", "New Other Cost" };
        public  ClsCosts _Cost;
        private string _Name;
        private decimal _Price;
        private decimal _PerTourCost;

        //public properties
        public string Name
        {
            get{return _Name;}
            set{_Name = value;}
        }

        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public decimal PerTourCost
        {
            get { return _PerTourCost; }
            set { _PerTourCost = value; }
        }

        //chooses the selected cost
        public static ClsCosts NewCost(int prChoice)
        {
            if (prChoice == 0)
                return new ClsStaffCost();
            if (prChoice == 1)
                return new ClsVehicleCost();
            else
                return new ClsOtherCost();
        }

        //abstract methods overridden by sub-class
        public abstract override string ToString();

        public abstract bool ViewEdit();

        public abstract string typeOfCost();

        public abstract decimal CalculatePerTourCost(ClsTour prTour);
    }
}
