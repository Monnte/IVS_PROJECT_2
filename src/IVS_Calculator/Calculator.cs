/**
 * @file Calculator.cs
 * @author Peter Zdravecký
 * @author Eduard Frlička
 * @author Daniel Fajmon
 * @brief The main code of calculator , handling input , output and operations
 * @version 0.1
 * @date 2020-04-29
 * 
 * @copyright Copyright (c) 2020
 * 
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
using P_Math;
using System.IO;
using System.Globalization;

namespace IVS_Calculator
{
    public partial class Calculator : Form
    {
        public class Operation
        {
            public Operation(Keys Key, string buttonChar, string outchar, Func<double, double, double> function)
            {
                this.Key = Key;
                this.buttonChar = buttonChar;
                this.outchar = outchar;
                this.function = function;
            }
            public Keys Key;
            public string buttonChar;
            public string outchar;
            public Func<double, double, double> function;
        }

        public class InstantOperation
        {
            public InstantOperation(Keys Key, string buttonChar, Func<double, double> function)
            {
                this.Key = Key;
                this.buttonChar = buttonChar;
                this.function = function;
            }
            public Keys Key;
            public string buttonChar;
            public Func<double, double> function;
        }

        InstantOperation[] definedInsantOperations = new InstantOperation[]{
            new InstantOperation(Keys.None,"x!",OwnMath.Factorial),
            new InstantOperation(Keys.None,"|x|",OwnMath.Abs),
            new InstantOperation(Keys.None,"1/x",OwnMath.reverse),
            new InstantOperation(Keys.None,"x²",OwnMath.square),
            new InstantOperation(Keys.None,"²√x",OwnMath.sqrt),
        };

        Operation[] definedOperations = new Operation[] {
        new Operation(Keys.Add,"+","+",OwnMath.add),
        new Operation(Keys.Subtract,"—","-",OwnMath.sub),
        new Operation(Keys.Multiply,"×","*",OwnMath.mul),
        new Operation(Keys.Divide,"÷","/",OwnMath.div),
        new Operation(Keys.None,"xⁿ","^",OwnMath.pow),
        new Operation(Keys.None,"ⁿ√x","√",OwnMath.root),
        };
        enum Operators { add, sub, mul, div, pow, root }
        //string[] instantOperatorsChars = new string[] { "x!", "xⁿ", "|x|", "1/x", "x²", "²√x", };
        string configfile = ".conf";
        List<double> numbers = new List<double>();
        List<Operators> operations = new List<Operators>();
        bool calculated = false;
        char carka = '.';
        bool showErrorDialogs = false;

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Constructor
        public Calculator()
        {


            //functions.Add(OwnMath.add);
            //functions.Add(OwnMath.sub);
            //functions.Add(OwnMath.mul);
            //functions.Add(OwnMath.div);
            //functions.Add(OwnMath.pow);
            //functions.Add(OwnMath.root);


            InitializeComponent();
            //File.WriteAllText(configfile, "\"  \" pako :D\"");
            if (File.Exists(configfile))
                loadConfig();
            //InsertText(((Button)Controls.Find("Button1", true).First<Control>()).BackColor.ToString());
        }

        public void loadConfig()
        {
            //File.WriteAllText(configfile, "button_num: = ");
            if (!File.Exists(configfile)) return;
            string[] configLines = File.ReadAllLines(configfile);
            foreach (string line in configLines)
            {
                //InsertText(line.Trim(' ', '"'));
                if (!line.Contains(":")) continue;
                List<string> config = line.Split(':').ToList<string>();
                if (!config[1].Contains("=")) continue;
                config.AddRange(config[1].Split('='));
                config.RemoveAt(1);
                // Control[] found = FindControls(Controls.Cast<Control>(),config[0].Trim(' ', '"'));
                IEnumerable<Control> found = GetAll(this, config[0].Trim(' ', '"'));
                //InsertText(found.Count().ToString()); 
                if (found.Count() == 0) continue;
                foreach (Control con in found)
                {
                    if (config[1].Trim(' ', '"') == "backColor")
                        con.BackColor = Color.FromArgb(int.Parse(config[2].Trim(' ', '"')));
                    if (config[1].Trim(' ', '"') == "fontColor")
                        con.ForeColor = Color.FromArgb(int.Parse(config[2].Trim(' ', '"')));
                }

            }
        }

        public IEnumerable<Control> GetAll(Control control, string name)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, name))
                                      .Concat(controls)
                                      .Where(c => c.Name.Contains(name));
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Return)
            {
                CalculateEqutation();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Operators

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    if ((this.ActiveControl == myTextBox) && (keyData == Keys.Return))
        //    {
        //        //do something
        //        return true;
        //    }
        //    else
        //    {
        //        return base.ProcessCmdKey(ref msg, keyData);
        //    }
        //}
        private void ButtonRoot_Click(object sender, EventArgs e)
        {
            InsertOperator(Operators.root);
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            InsertOperator(Operators.pow);
        }

        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            InsertText("!");
        }


        private void ButtonPercent_Click(object sender, EventArgs e)
        {
            ///TODO
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (this.UserInput.Text.Contains("-"))
            {
                this.UserInput.Text = this.UserInput.Text.Remove(0, 1);
            }
            else
            {
                this.UserInput.Text = "-" + this.UserInput.Text;
            }
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (!this.UserInput.Text.Contains(carka)||calculated)
            {
                InsertText(carka.ToString());
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
            numbers.Clear();
            operations.Clear();
            Rewrite();
            DeleteText();
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            //Clears the input box
            DeleteText();
        }
        #endregion

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Input_and_Output
        private void UserInput_TextChanged(object sender, EventArgs e)
        {

        }

        //after clicking operation the value and operator is transfered to CalculationBox
        private void OperationsOnClick(object sender, EventArgs e)
        {
            string operationClicked = ((Button)sender).Text;
            for (int i = 0; i < definedOperations.Length; i++)
            {
                if (definedOperations[i].buttonChar == operationClicked)
                    InsertOperator((Operators)i);
            }
            for (int i = 0; i < definedInsantOperations.Length; i++)
            {
                if (definedInsantOperations[i].buttonChar == operationClicked)
                {
                    if (UserInput.Text != string.Empty)
                        UserInput.Text = definedInsantOperations[i].function(Double.Parse(UserInput.Text)).ToString();
                    else
                        UserInput.Text = definedInsantOperations[i].function(0).ToString();
                    calculated = true;
                }

            }

            //Button b = (Button)sender;



            //if (UserInput.Text == string.Empty)
            //{
            //    operation = b.Text;
            //    CalculationBox.Text = result + " " + operation;
            //}
            //else
            //{
            //    operation = b.Text;
            //    result = Double.Parse(UserInput.Text);
            //    UserInput.Text = string.Empty;
            //    CalculationBox.Text = System.Convert.ToString(result) + " " + operation;
            //}
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
            if (calculated)
            {
                this.UserInput.Text = string.Empty;
                calculated = false;
            }
            this.UserInput.Text = UserInput.Text + value;
        }

        private void Rewrite()
        {
            CalculationBox.Text = string.Empty;
            for (int i = 0; i < operations.Count; i++)
            {
                switch (operations[i])
                {
                    case Operators.root:
                        if (i + 1 < numbers.Count)
                        {
                            CalculationBox.Text += numbers[i + 1] + " √ " + numbers[i];
                            if (++i < operations.Count)
                                CalculationBox.Text += " " + definedOperations[(int)operations[i]].outchar + " ";
                        }
                        else
                            CalculationBox.Text += "√" + numbers[i];
                        break;
                    default:
                        CalculationBox.Text += numbers[i].ToString() + " " + definedOperations[(int)operations[i]].outchar + " ";
                        break;
                }
            }
        }

        double ParseNumber(string number)
        {
            if (number.Last<char>() == carka) number.Trim(carka);
            double result;
            if (!double.TryParse(number, NumberStyles.Any, new CultureInfo("en-US"), out result))
                return 0;
            return result;
        }
        private void InsertOperator(Operators value)
        {
            if (UserInput.Text != string.Empty)
                numbers.Add(ParseNumber(UserInput.Text));
            else
            {
                if (operations.Count > 0)
                    operations.RemoveAt(operations.Count - 1);
                else
                    numbers.Add(0);
            }
            operations.Add(value);
            Rewrite();
            UserInput.Text = string.Empty;
            //InsertText(value.ToString());
        }

        private void Calculate()
        {
            int index = operations.IndexOf(operations.Max<Operators>());
            numbers[index] = definedOperations[(int)operations[index]].function(numbers[index], numbers[index + 1]);
            operations.RemoveAt(index);
            numbers.RemoveAt(index + 1);
            //fact, sqr, sqrt, %, 1/x, 
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
            if (UserInput.Text != string.Empty)
                numbers.Add(ParseNumber(UserInput.Text));
            else
            {
                if (operations.Count > 0)
                    operations.RemoveAt(operations.Count - 1);
                else
                    numbers.Add(0);
            }
            try
            {
                while (operations.Count > 0)
                    Calculate();
            }
            catch (Exception e)
            {
                DeleteText();
                operations.Clear();
                numbers.Clear();
                Rewrite();
                if (showErrorDialogs)
                    MessageBox.Show(e.Message, "MathError", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    InsertText("MathError");
                calculated = true;
                return;
            }

            
            DeleteText();
            Rewrite();
            InsertText(numbers[0].ToString(new CultureInfo("en-US")));
            calculated = true;
            operations.Clear();
            numbers.Clear();
        }

        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    DeleteLast();
                    break;
                case Keys.Delete:
                    DeleteText();
                    break;
                case Keys.D0:
                    InsertText("0");
                    break;
                case Keys.D1:
                    InsertText("1");
                    break;
                case Keys.D2:
                    InsertText("2");
                    break;
                case Keys.D3:
                    InsertText("3");
                    break;
                case Keys.D4:
                    InsertText("4");
                    break;
                case Keys.D5:
                    InsertText("5");
                    break;
                case Keys.D6:
                    InsertText("6");
                    break;
                case Keys.D7:
                    InsertText("7");
                    break;
                case Keys.D8:
                    InsertText("8");
                    break;
                case Keys.D9:
                    InsertText("9");
                    break;
                case Keys.NumPad0:
                    InsertText("0");
                    break;
                case Keys.NumPad1:
                    InsertText("1");
                    break;
                case Keys.NumPad2:
                    InsertText("2");
                    break;
                case Keys.NumPad3:
                    InsertText("3");
                    break;
                case Keys.NumPad4:
                    InsertText("4");
                    break;
                case Keys.NumPad5:
                    InsertText("5");
                    break;
                case Keys.NumPad6:
                    InsertText("6");
                    break;
                case Keys.NumPad7:
                    InsertText("7");
                    break;
                case Keys.NumPad8:
                    InsertText("8");
                    break;
                case Keys.NumPad9:
                    InsertText("9");
                    break;
                case Keys.Divide:
                    InsertOperator(Operators.div);
                    break;
                case Keys.Multiply:
                    InsertOperator(Operators.mul);
                    break;
                case Keys.Subtract:
                    InsertOperator(Operators.sub);
                    break;
                case Keys.Add:
                    InsertOperator(Operators.add);
                    break;
                case Keys.Decimal:
                    if (!this.UserInput.Text.Contains(carka)||calculated)
                    {
                        InsertText(carka.ToString());
                    }
                    break;
                default:
                    //InsertText(e.KeyCode.ToString());
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void coloursToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var colours = new Colours(configfile);
            colours.configfile = configfile;

            colours.ShowDialog();
            loadConfig();

        }
    
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var help = new Help();
            help.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("dokumentace.pdf");
        }
    }
}