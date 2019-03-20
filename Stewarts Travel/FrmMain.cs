using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Stewarts_Travel
{
    public partial class FrmMain : Form
    {
        //Ascending date compare
        class ClsStartDateAscComparer : IComparer<ClsTour>
        {
            public int Compare(ClsTour prTourX, ClsTour prTourY)
            {
                return prTourX.TourStartDate.Date.CompareTo(prTourY.TourStartDate.Date);
            }
        }

        //Descending date compare
        class ClsStartDateDesComparer : IComparer<ClsTour>
        {
            public int Compare(ClsTour prTourY, ClsTour prTourX)
            {
                return prTourX.TourStartDate.Date.CompareTo(prTourY.TourStartDate.Date);
            }
        }

        //Ascending name compare
        class ClsNameAscComparer : IComparer<ClsTour>
        {
            public int Compare(ClsTour prTourX, ClsTour prTourY)
            {
                return prTourX.TourName.CompareTo(prTourY.TourName);
            }
        }

        //Descending name compare
        class ClsNameDesComparer : IComparer<ClsTour>
        {
            public int Compare(ClsTour prTourY, ClsTour prTourX)
            {
                return prTourX.TourName.CompareTo(prTourY.TourName);
            }
        }

        //variables
        private IComparer<ClsTour>[] _Comparer = { new ClsNameAscComparer(), new ClsNameDesComparer(), new ClsStartDateAscComparer(), new ClsStartDateDesComparer() };
        private string[] _SortByList = { "Name A-Z", "Name Z-A", "Date Asc ", "Date Desc"};
        private FrmTour _TourForm = new FrmTour();
        private ClsTour _Tour;

        //Initialize form and load saved data
        public FrmMain()
        {
            InitializeComponent();
            cboSortBy.DataSource = _SortByList;
            cboSortBy.SelectedIndex = 0;
            //retrive saved stuff
            try
            {
                ClsCompany.Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
        }

        //update saved data  to listbox when form opens
        private void FrmMain_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }

        //Add new tour
        private void btnAddTour_Click(object sender, EventArgs e)
        {
            _Tour = new ClsTour();
            if (_Tour != null && _TourForm.ShowDialog(_Tour) == DialogResult.OK)
            {
                ClsCompany.TourList.Add(_Tour.TourCode, _Tour);
                updateDisplay();
            }
        }

        //edit existing tour
        private void editTour()
        {
            ClsTour _Tour = (ClsTour)lstTourList.SelectedItem;
            if (_Tour == null)
            {
                MessageBox.Show("There are no Tours to modify. Create one first", "Confirm", MessageBoxButtons.OK);
            }
            if (_Tour != null && _TourForm.ShowDialog(_Tour) == DialogResult.OK)
            {
                updateDisplay();
            }
        }

        //edit existing tour with button click
        private void btnEditTour_Click(object sender, EventArgs e)
        {
             editTour();
        }

        //edit existing tour with double click
        private void lstTourList_DoubleClick(object sender, EventArgs e)
        {
            editTour();
        }

        //delete a tour
        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            ClsTour _Tour = (ClsTour)lstTourList.SelectedItem;
            if (_Tour == null)
            {
                MessageBox.Show("There are no Tours to delete. Create one first", "Confirm", MessageBoxButtons.OK);
            }

            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    ClsCompany.TourList.Remove(_Tour.TourCode);
                updateDisplay();
        }

        //update the Tour Listbox
        private void updateDisplay()
        {
            List<ClsTour> lcTourList = ClsCompany.TourList.Values.ToList();
            lcTourList.Sort(_Comparer[cboSortBy.SelectedIndex]);
            lstTourList.DataSource = lcTourList;
        }

        //Exit and save
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCompany.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            Close();
        }

        //update if list order is changed
        private void cboSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }

    }
}