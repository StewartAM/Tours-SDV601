using System;
using System.Collections.Generic;

namespace Stewarts_Travel
{
    [Serializable]
    public class ClsTour
    {
        //tour detail variables
        //private tour variables
        private string _TourCode;
        private string _TourName;
        private DateTime _TourStartDate = DateTime.Today;
        private DateTime _TourEndDate = DateTime.Today;
        private double _TotalTourDays;
        private int _MaxPassenger = 1;
        private int _Distance = 10;
        private int _MarkUp = 100;
        private decimal _TotalCosts;
        private decimal _TotalPrice;
        private decimal _PricePerPassenger;
        
        private List<ClsCosts> _CostList = new List<ClsCosts>();

        //create public property variables 
        public List<ClsCosts> CostList
        {
            get { return _CostList; }
            set{_CostList = value;}
        }

        public string TourCode
        {
            get { return _TourCode; }
            set { _TourCode = value; }
        }

        public string TourName
        {
            get { return _TourName; }
            set { _TourName = value; }
        }

        public DateTime TourStartDate
        {
            get { return _TourStartDate; }
            set { _TourStartDate = value; }
        }

        public DateTime TourEndDate
        {
            get { return _TourEndDate; }
            set { _TourEndDate = value; }
        }

        public decimal PricePerPassenger
        {
            get { return _PricePerPassenger; }
            set { _PricePerPassenger = value; }
        }

        public int MaxPassenger
        {
            get { return _MaxPassenger; }
            set { _MaxPassenger = value; }
        }

        public int Distance
        {
            get { return _Distance; }
            set { _Distance = value; }
        }

        public int MarkUp
        {
            get { return _MarkUp; }
            set { _MarkUp = value; }
        }

        public double TotalTourDays
        {
            get{return _TotalTourDays;}
            set{_TotalTourDays = value;}
        }

        public decimal TotalCosts
        {
            get { return _TotalCosts; }
            set { _TotalCosts = value; }
        }

        public decimal TotalPrice
        { 
            get{ return _TotalPrice; }
            set{ _TotalPrice = value;}
        }

        //overides defaultvalue of ToString method
        public override string ToString()
        {
            return _TourName.PadRight(25) + _TourCode.PadRight(7) + _TourStartDate.ToShortDateString().PadRight(12) + _TotalTourDays.ToString().PadRight(4) + "$ " + String.Format("{0:0.00}", _PricePerPassenger);
        }

        //calculation for total costs
        public decimal CalculateTotalCosts()
        {
            decimal lcTotalCost = 0;

            foreach (ClsCosts lcCost in _CostList)
                lcTotalCost += lcCost.CalculatePerTourCost(this);
            return lcTotalCost;
        }

        //calculation for total price
        public decimal CalculateTotalPrice()
        {
            decimal lcTotalPrice;
            lcTotalPrice = _TotalCosts * (_MarkUp / 100);
            return lcTotalPrice;
        }

        //calculation price per passenger
        public decimal CalculatePricePerPassenger()
        {
            decimal lcPricePerPassenger;
            lcPricePerPassenger = _TotalPrice / _MaxPassenger;
            return lcPricePerPassenger;
        }
    }
}
