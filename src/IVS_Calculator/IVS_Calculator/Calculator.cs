using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P_Math;

namespace IVS_Calculator
{
    public partial class Calculator : Form
    {
        enum Operators { add, sub, mul, div }
        //used for CalculationBox
        Double result = 0;
        String operation = "";
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Constructor
        public Calculator()
        {
            InitializeComponent();
        }

        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Operators

        private void ButtonDivision_Click(object sender, EventArgs e)
        {
            InsertText("÷");
        }

        private void ButtonRoot_Click(object sender, EventArgs e)
        {
            InsertText("ⁿ√x");
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            InsertText("^");
        }

        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            InsertText("!");
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            InsertText("×");
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            InsertText("-");
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            InsertText("+");
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text.Contains("-")) {
                this.UserInput.Text = this.UserInput.Text.Remove(0, 1);
            }
            else
            {
                this.UserInput.Text = "-" + this.UserInput.Text;
            }
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {

            if (!this.UserInput.Text.Contains(".")) { 
                this.UserInput.Text = this.UserInput.Text + ".";
            }
            else
            {
                this.UserInput.Text = this.UserInput.Text;
            }
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            CalculateEqutation();
        }
        #endregion


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Numbers

        private void Button0_Click(object sender, EventArgs e)
        {
            InsertText("0");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            InsertText("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InsertText("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            InsertText("3");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InsertText("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            InsertText("5");
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            InsertText("6");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            InsertText("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            InsertText("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            InsertText("9");
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Clear_Buttons

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            //Deletes always last char
            DeleteLast();  
        }

        /// <summary>
        /// Clears user input
        /// </summary>
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            //Clears the input box
            DeleteText();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {

        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Input_and_Output
        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }

        //after clicking operation the value and operator is transfered to CalculationBox
        //after clicking operation the value and operator is transfered to CalculationBox
        private void OperationsOnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (UserInput.Text == string.Empty)
            {
                operation = b.Text;
                CalculationBox.Text = result + " " + operation;
            }
            else
            {
                operation = b.Text;
                result = Double.Parse(UserInput.Text);
                UserInput.Text = string.Empty;
                CalculationBox.Text = System.Convert.ToString(result) + " " + operation;
            }
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Memory_Buttons
        private void ButtonMC_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonMR_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonMemoryPlus_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonMemoryminus_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonMS_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Options

        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Help Functions

        /// <summary>
        /// Takes string and places it on position of cursor
        /// </summary>
        private void InsertText(string value)
        {
            //input new text
            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.Text.Length, value);
        }

        private void InsertOperator(Operators value)
        {
            InsertText(value.ToString());
        }

        private void DeleteText()
        {
            this.UserInput.Text = string.Empty;
        }

        private void DeleteLast()
        {
            //if theres no input, do nothing
            if (UserInput.Text.Length == 0)
                return;
            //Delete last character
            UserInput.Text = UserInput.Text.Remove(UserInput.Text.Length - 1, 1);
        }

        #endregion

        private void CalculateEqutation()
        {

        }

        private void UserInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyValue)
            {
                case 8:
                    DeleteLast();
                    break;
                case 46:
                    DeleteText();
                    break;
                case 96:
                    InsertText("0");
                    break;
                case 97:
                    InsertText("1");
                    break;
                case 98:
                    InsertText("2");
                    break;
                case 99:
                    InsertText("3");
                    break;
                case 100:
                    InsertText("4");
                    break;
                case 101:
                    InsertText("5");
                    break;
                case 102:
                    InsertText("6");
                    break;
                case 103:
                    InsertText("7");
                    break;
                case 104:
                    InsertText("8");
                    break;
                case 105:
                    InsertText("9");
                    break;
                case 111:
                    InsertOperator(Operators.div);
                    break;
                case 106:
                    InsertOperator(Operators.mul);
                    break;
                case 109:
                    InsertOperator(Operators.sub);
                    break;
                case 107:
                    InsertOperator(Operators.add);
                    break;
                default:
                    InsertText(e.KeyValue.ToString());
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var help = new Help();
            help.Show();
        }

        private void coloursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var colours = new Colours();
            colours.Show();
        }
    }
}