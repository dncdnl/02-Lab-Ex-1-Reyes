using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        //declaring variables for num1 and num2
        double num1 = 0;
        double num2 = 0;

        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }
        // declaring and initializing the CalculatorClass
        CalculatorClass cal = new CalculatorClass();

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //getting the values
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            // validating selected arithmitic operation
            if (comboBox1.SelectedItem.ToString() == "+")
            {
                cal.CalculateEvent += CalculatorClass.getSum;
            }
            else if (comboBox1.SelectedItem.ToString() == "-")
            {
                cal.CalculateEvent += CalculatorClass.getDifference;
            }
            else if (comboBox1.SelectedItem.ToString() == "*")
            {
                cal.CalculateEvent += CalculatorClass.getProduct;
            }
            else if (comboBox1.SelectedItem.ToString() == "/")
            {
                cal.CalculateEvent += CalculatorClass.getQuotient;
            }
            //displaying the result :)
            lblDisplayTotal.Text = cal.formula(num1, num2).ToString();
        }

    }
}
