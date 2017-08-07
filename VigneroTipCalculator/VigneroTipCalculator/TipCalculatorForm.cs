/*
 * Tip Calculator
 * David Vignero
 * POS/409
 * John Becton
 * February 27, 2017
 * 
 * This application is designed to allow the user to enter a restaurant bill amount not including taxes. After the
 * user inputs the value the applicaiton will give the totals for the amount of taxes based on a fixed charge of 5.75% 
 * in which Ohio charges. The user will also be presented weith the tip amounts for a 15% tip and a 20% tip. The applicaiton
 * will also display the total bill which will include taxes and the tip amount for each persentage of tip. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VigneroTipCalculator
{
    public partial class TipCalcForm : Form
    {
        //declaring variables
        double tax = .0575;
        double billAmount = 0;
        double tip15 = .15;
        double tip20 = .20;
        double tipTotal = 0;
        double totalBill = 0;
        double totalTaxes;
        
        bool isNumeric;

        public TipCalcForm()
        {
            InitializeComponent();




        }

        //button to exit application
        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes application
            Close();
        }
        //button to perform calculation
        private void btnCalculate_Click(object sender, EventArgs e)
        {
          
            //attempts to parse value entered
            isNumeric = double.TryParse(txtBillAmount.Text, out billAmount);
            //if value can be parsed to double this executes
            if (isNumeric)
            {
                //calls this method
                calculateTotals();

            }
            else
            {
                //displays this message if the value entered can not be parsed to double
                MessageBox.Show("Please enter a numeric value");
                txtBillAmount.Clear();
            }
            
        }
        //calculate method
        public void calculateTotals()
        {

            //calculates totals for 15% tip
            totalTaxes = billAmount * tax;
            txtTaxes.Text = totalTaxes.ToString("C2");
            tipTotal = billAmount * tip15;
            txtTip15.Text = tipTotal.ToString("C2");
            totalBill = billAmount + tipTotal + totalTaxes;
            txtTotal15.Text = totalBill.ToString("C2");
            //calculates totals for 20% tip
            totalTaxes = billAmount * tax;
            txtTaxes.Text = totalTaxes.ToString("C2");
            tipTotal = billAmount * tip20;
            txtTip20.Text = tipTotal.ToString("C2");
            totalBill = billAmount + tipTotal + totalTaxes;
            txtTotal20.Text = totalBill.ToString("C2");



        }
        //method to reset form to default
        private void btnClear_Click(object sender, EventArgs e)
        {
            
            //clears all text box values
            txtBillAmount.Clear();
            txtTip15.Clear();
            txtTip20.Clear();
            txtTaxes.Clear();
            txtTotal15.Clear();
            txtTotal20.Clear();
        }

       
    }
}
