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
            FocusInputText();
        }

        private void ButtonRoot_Click(object sender, EventArgs e)
        {
            InsertText("ⁿ√x");
            FocusInputText();
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            InsertText("^");
            FocusInputText();
        }

        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            InsertText("!");
            FocusInputText();
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            InsertText("×");
            FocusInputText();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            InsertText("-");
            FocusInputText();
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            InsertText("+");
            FocusInputText();
        }

        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            this.UserInput.Text = this.UserInput.Text.Insert(0, "-");
            FocusInputText();
        }

        private void ButtonEqual_Click(object sender, EventArgs e)
        {
            CalculateEqutation();
        }
        #endregion


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Numbers

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            InsertText(".");
            FocusInputText();
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            InsertText("0");
            FocusInputText();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            InsertText("1");
            FocusInputText();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InsertText("2");
            FocusInputText();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            InsertText("3");
            FocusInputText();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InsertText("4");
            FocusInputText();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            InsertText("5");
            FocusInputText();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            InsertText("6");
            FocusInputText();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            InsertText("7");
            FocusInputText();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            InsertText("8");
            FocusInputText();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            InsertText("9");
            FocusInputText();
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Clear_Buttons

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            //Deletes alwazs last char
            DeleteLast();

            //Focus to UserInput
            FocusInputText();
        }

        /// <summary>
        /// Clears user input
        /// </summary>
        private void ButtonCE_Click(object sender, EventArgs e)
        {
            //Clears the input box
            DeleteText();
            FocusInputText();
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

        private void CalculationBox_Click(object sender, EventArgs e)
        {

        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Memory_Buttons
        private void ButtonMC_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }

        private void ButtonMR_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }

        private void ButtonMemoryPlus_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }

        private void ButtonMemoryminus_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }

        private void ButtonMS_Click(object sender, EventArgs e)
        {
            FocusInputText();
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Options
        private void ButtonOptions_Click(object sender, EventArgs e)
        {

        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Help Functions

        /// <summary>
        /// After using button focus goes to Input
        /// </summary>
        private void FocusInputText()
        {
            this.UserInput.Focus();
        }

        /// <summary>
        /// Takes string and places it on position of cursor
        /// </summary>
        private void InsertText(string value)
        {
            //remember selection start
            var selectionStart = this.UserInput.SelectionStart;

            //input new tetx
            this.UserInput.Text = this.UserInput.Text.Insert(this.UserInput.SelectionStart, value);

            //restore position of cursor
            this.UserInput.SelectionStart = selectionStart + value.Length;

            //selection lenght set to 0
            this.UserInput.SelectionLength = 0;
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
            if (UserInput.TextLength == 0)
                return;

            //remember selection start
            var selectionStart = this.UserInput.SelectionStart;

            //Delete last character
            UserInput.Text = UserInput.Text.Remove(UserInput.Text.Length - 1, 1);

            //restore position of cursor
            this.UserInput.SelectionStart = selectionStart;

            //selection lenght set to 0
            this.UserInput.SelectionLength = 0;
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

        private void Manual_Click(object sender, EventArgs e)
        {

        }

        private void Colours_Click(object sender, EventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {

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
    }
}