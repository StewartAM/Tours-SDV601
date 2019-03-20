using System;
using System.Windows.Forms;

namespace Stewarts_Travel
{
    public partial class FrmTour : Form
    {

        private ClsTour _Tour;
        private FrmCostsList _formCosts;

        //start the form
        public FrmTour()
        {
            InitializeComponent();
        }

        //showdialog updates display, parameter from previous form
        public DialogResult ShowDialog(ClsTour prTourDetails)
        {
            _Tour = prTourDetails;
            updateDisplay();
            return ShowDialog();
        }

        //updates displayed values on the form
        private void updateDisplay()
        {
            //insert values into textboxes
            //calculate total days 
            TotalTourDays();
            lblTourDays.Text = Convert.ToString(_Tour.TotalTourDays);
            //total costs 
            lblTotalCosts.Text = Convert.ToString(_Tour.TotalCosts); 
            //update components
            txtTourCode.Text = _Tour.TourCode;
            txtTourName.Text = _Tour.TourName;
            dtpStartDate.Value = _Tour.TourStartDate;
            dtpEndDate.Value = _Tour.TourEndDate;
            numMaxPassenger.Value = _Tour.MaxPassenger;
            numDistance.Value = _Tour.Distance;
            numMarkUp.Value = _Tour.MarkUp;
            lblTotalCosts.Text = Convert.ToString(_Tour.TotalCosts);
            lblTotalPrice.Text = Convert.ToString(_Tour.TotalPrice);
            lblPricePassenger.Text = Convert.ToString(_Tour.PricePerPassenger);
            //makes tour code textbox enabled  
            txtTourCode.Enabled = String.IsNullOrEmpty(_Tour.TourCode);
         }

        //sends data to new Tour object and saves the tour
        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if tour code exists
            if (txtTourCode.Enabled && ClsCompany.TourList.ContainsKey(txtTourCode.Text))
                MessageBox.Show("A Tour with that Code already exists", "Duplicate Code");
            else
            {
                pushData();
                DialogResult = DialogResult.OK;//returns result of 1 or true
                //save
                try
                {
                    ClsCompany.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetBaseException().Message);
                }
            }
        }

        //sends data to new tour object
        private void pushData()
        {
            //sends values to the variables
            _Tour.TourCode = txtTourCode.Text;
            _Tour.TourName = txtTourName.Text;
            _Tour.TourStartDate = dtpStartDate.Value;
            _Tour.TourEndDate = dtpEndDate.Value;
            _Tour.TotalTourDays = Convert.ToDouble(lblTourDays.Text); //TotalTourDays();
            _Tour.MaxPassenger = Convert.ToInt32(numMaxPassenger.Value);
            _Tour.Distance = Convert.ToInt32(numDistance.Value);
            _Tour.MarkUp = Convert.ToInt32(numMarkUp.Value);
            _Tour.TotalCosts = Convert.ToDecimal(lblTotalCosts.Text); //CalculateTotalCosts();
            _Tour.TotalPrice = Convert.ToDecimal(lblTotalPrice.Text);
            _Tour.PricePerPassenger = Convert.ToDecimal(lblPricePassenger.Text);
        }

        //calculate total tour days
        public double TotalTourDays()
        {
            //calculates tourdays from start and end, including start and end date (+1)
            _Tour.TotalTourDays = ((_Tour.TourEndDate - _Tour.TourStartDate).TotalDays + 1);
            return _Tour.TotalTourDays;
        }

        //calculate total costs and total price
        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            pushData();

            lblTotalCosts.Text = Convert.ToString(_Tour.CalculateTotalCosts());
            _Tour.TotalCosts = Convert.ToDecimal(lblTotalCosts.Text);

            lblTotalPrice.Text = Convert.ToString(_Tour.CalculateTotalPrice());
            _Tour.TotalPrice = Convert.ToDecimal(lblTotalPrice.Text);

            _Tour.PricePerPassenger = _Tour.CalculatePricePerPassenger();
            lblPricePassenger.Text = string.Format("{0:0.00}", _Tour.PricePerPassenger);

            updateDisplay();
        }

        // checks and validates dates when user leaves this field
        private void dtpEndDate_Leave(object sender, EventArgs e)
        {
            pushData();
            if (_Tour.TourEndDate < _Tour.TourStartDate)
                MessageBox.Show("A tour cannot end before the Start date", "Please check the End date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                lblTourDays.Text = Convert.ToString(TotalTourDays());
                _Tour.TotalTourDays = Convert.ToInt32(lblTourDays.Text);
        }

        // checks and validates dates when user leaves this field
        private void dtpStartDate_Leave(object sender, EventArgs e)
        {
            pushData();
            if (_Tour.TourStartDate < DateTime.Today)
            MessageBox.Show("A Tour cannot start before Today", "Please check the Start Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } 
        
        //open the next form, showdialog sends parameter to next form
        private void btnEnterEditCosts_Click(object sender, EventArgs e)
        {
            //open next form and send tour name
            _formCosts = new FrmCostsList();
            _formCosts.ShowDialog(txtTourName.Text, _Tour);
        }
      
         //validates tour code, checks for duplicate
        private void txtTourCode_Leave(object sender, EventArgs e)
        {
            //check if tour code exists
            if (txtTourCode.Enabled && ClsCompany.TourList.ContainsKey(txtTourCode.Text))
            {
                txtTourCode.Text = "";
                MessageBox.Show("A Tour with that Code already exists", "Duplicate Code");
            }
        }

       //close the form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
