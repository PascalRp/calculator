using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Bug fixing with euqal icon without variable
namespace calculator
{
    public partial class Form1 : Form
    {



        // 2 variables, one before clicking an operator, one after
        // function defined as char
        // userInput to temporally holding the variables which are going to pass through to firstvarb & secondvarb

        string firstvarb = "";
        string secondvarb = "";
        char function;
        string userInput = "";

        // a third variable for holding the result and further calculation
        string thirdvarb = "";

        // an extra variable for square calculation. Reason: no square function
        string squareVarb = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Numb0_Click(object sender, EventArgs e)
        {
            userInput += "0";
            display.Text = userInput;
        }

        private void Numb1_Click(object sender, EventArgs e)
        {
            userInput += "1";
            display.Text = userInput;

        }

        private void numb2_Click(object sender, EventArgs e)
        {
            userInput += "2";
            display.Text = userInput;
        }

        private void numb3_Click(object sender, EventArgs e)
        {
            userInput += "3";
            display.Text = userInput;
        }

        private void numb4_Click(object sender, EventArgs e)
        {

            userInput += "4";
            display.Text = userInput;
        }

        private void numb5_Click(object sender, EventArgs e)
        {
            userInput += "5";
            display.Text = userInput;
        }

        private void numb6_Click(object sender, EventArgs e)
        {


            userInput += "6";
            display.Text = userInput;
        }

        private void numb7_Click(object sender, EventArgs e)
        {
            userInput += "7";
            display.Text = userInput;
        }

        private void numb8_Click(object sender, EventArgs e)
        {
            userInput += "8";
            display.Text = userInput;
        }

        private void numb9_Click(object sender, EventArgs e)
        {
            userInput += "9";
            display.Text = userInput;

        }

        private void comma_Click(object sender, EventArgs e)
        {
            userInput += ",";
            display.Text = userInput;
        }

        // main calculation below, after clicking result (equal icon)

        private void finalanswer_Click(object sender, EventArgs e)
        {

            // saving the second userinput in the second variable

            secondvarb = userInput;

            // converting strings to double and saving them as a new variable for calculation

            double new1, new2, new3;

            // check if first variable is empty to take the correct calculation for the first round

            if (firstvarb == "")
            {
                display.Text = "firstvarb empty";
                firstvarb = userInput;
                new1 = Convert.ToDouble(firstvarb);
                new2 = Convert.ToDouble(secondvarb);

            }

            else
            {
                new1 = Convert.ToDouble(firstvarb);
                new2 = Convert.ToDouble(secondvarb);
                display.Text = "firstvarb NOT empty";
            }



            if (function == '+')

            {

                if (thirdvarb == "")
                {
                    new3 = new1 + new2;
                    display.Text = new3.ToString();
                    userInput = "";

                    // saving the result
                    thirdvarb = Convert.ToString(new3);

                    firstvarb = "";


                }
                else
                {
                    new3 = Convert.ToDouble(thirdvarb);
                    new3 = new3 + new2;
                    display.Text = new3.ToString();
                    userInput = "";

                    // saving the result
                    thirdvarb = Convert.ToString(new3);

                    firstvarb = "";


                }



            }
            else if (function == '-')
            {

                if (thirdvarb == "")
                {
                    new3 = new1 - new2;
                    display.Text = new3.ToString();
                    userInput = "";

                    // saving the result
                    thirdvarb = Convert.ToString(new3);

                    firstvarb = "";

                }
                else
                {
                    new3 = Convert.ToDouble(thirdvarb);
                    new3 = new3 - new2;
                    display.Text = new3.ToString();
                    userInput = "";

                    // saving the result
                    thirdvarb = Convert.ToString(new3);

                    firstvarb = "";

                }
            }
            else if (function == '*')
            {

                if (thirdvarb == "")
                {
                    new3 = new1 * new2;
                    display.Text = new3.ToString();
                    userInput = "";

                    // saving the result
                    thirdvarb = Convert.ToString(new3);

                    firstvarb = "";


                }
                else
                {
                    new3 = Convert.ToDouble(thirdvarb);
                    new3 = new3 * new2;
                    display.Text = new3.ToString();
                    userInput = "";

                    // saving the result
                    thirdvarb = Convert.ToString(new3);

                    firstvarb = "";

                }

            }

            else if (function == '/')
            {
                if (new2 == 0)
                {
                    display.Text = "can't devide through 0";
                }

                else
                {
                    if (thirdvarb == "")
                    {
                        new3 = new1 / new2;
                        display.Text = new3.ToString();
                        userInput = "";

                        // saving the result
                        thirdvarb = Convert.ToString(new3);

                        firstvarb = "";

                    }
                    else
                    {
                        new3 = Convert.ToDouble(thirdvarb);
                        new3 = new3 / new2;
                        display.Text = new3.ToString();
                        userInput = "";

                        // saving the result
                        thirdvarb = Convert.ToString(new3);

                        firstvarb = "";
                    }

                }


            }


        }

        // advanced operator
        // square-calculation right by clicking the button, cause it's inefficient to have to click the equal after the square.
        private void square_Click(object sender, EventArgs e)
        {
            double newSquare, newSquareResult;


            if (squareVarb == "")
            {
                //  display.Text = "firstvarb empty";

                firstvarb = userInput;
                newSquare = Convert.ToDouble(firstvarb);

                newSquareResult = newSquare * newSquare;
                display.Text = newSquareResult.ToString();


                squareVarb = Convert.ToString(newSquareResult);

            }

            else
            {
                display.Text = "firstvarb NOT empty";

                firstvarb = userInput;
                newSquare = Convert.ToDouble(squareVarb);

                newSquareResult = newSquare * newSquare;

                newSquareResult = newSquareResult * newSquareResult;
                display.Text = newSquareResult.ToString();

                squareVarb = Convert.ToString(newSquareResult);



            }

        }

        private void plus_Click(object sender, EventArgs e)
        {


            function = '+';
            firstvarb = userInput;
            userInput = "";



        }

        private void minus_Click(object sender, EventArgs e)
        {


            function = '-';
            firstvarb = userInput;
            userInput = "";

        }

        private void multiply_Click(object sender, EventArgs e)
        {

            function = '*';
            firstvarb = userInput;
            userInput = "";
        }

        private void divided_Click(object sender, EventArgs e)
        {

            function = '/';
            firstvarb = userInput;
            userInput = "";

        }

        private void delete_Click(object sender, EventArgs e)
        {
            firstvarb = "";
            secondvarb = "";
            thirdvarb = "";
            squareVarb = "";
            userInput = "";
            display.Text = "0";
            function = ' ';
        }

        private void deleteLastStep_Click(object sender, EventArgs e)
        {
            if (firstvarb != "")
            {
                secondvarb = "";
                userInput = "";
                display.Text = "0";

            }

            else
            {
                firstvarb = "";
                userInput = "";
                display.Text = "0";

            }


        }
        private void display_Click(object sender, EventArgs e)
        {

        }


    }
}