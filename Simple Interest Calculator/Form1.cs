using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Interest_Calculator
{
    public partial class peryear2Label : Form
    {


        double first;
        double second;
        double third;
        double res;
       

        public peryear2Label()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCountryComboBox();
            
        }

        private void loadCountryComboBox()
        {
            
            solveForcomboBox.Items.Add("Total P+I(A)");
            solveForcomboBox.Items.Add("Principal(P)");
            solveForcomboBox.Items.Add("Rate(R)");
            solveForcomboBox.Items.Add("Time Period (t)");


            timeComboBox.Items.Add("days (365/yr)");
            timeComboBox.Items.Add("days (360/yr)");
            timeComboBox.Items.Add("weeks");
            timeComboBox.Items.Add("months");
            timeComboBox.Items.Add("quarters");
            timeComboBox.Items.Add("years");


        }

        private void SolveForcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = solveForcomboBox.Text;

            if (solveForcomboBox.SelectedItem == "Total P+I(A)" || solveForcomboBox.SelectedItem== "Principal(P)"||solveForcomboBox.SelectedItem == "Rate(R)") 
            {
                timeComboBox.Visible = true;
            }
            else
            {
                timeComboBox.Visible = false;
            }


            if (country== "Total P+I(A)")
            {
                showlabel.Text = "Where: A = P(1 + rt)";
                Firstlabel.Text = "Principal (P): $";
                secondLabel.Text = "Rate (R): %";
                thirdLabel.Text = "Time (t):";
                perYearLabel.Text = "per year";
                perYearUnderLabel.Text = "";
            }
            else if (country == "Principal(P)")
            {
                showlabel.Text = "Where: P = A / (1 + rt)";
                Firstlabel.Text = "Total P+I (A): $";
                secondLabel.Text = "Rate (R): %";
                thirdLabel.Text = "Time (t):";
                perYearLabel.Text = "per year";
                perYearUnderLabel.Text = "";


            }
            else if (country == "Rate(R)")
            {
                showlabel.Text = "Where: r = (1/t)(A/P - 1)";
                Firstlabel.Text = "Total P+I (A): $";
                secondLabel.Text = "Principal (P): $";
                thirdLabel.Text = "Time (t):";
                perYearLabel.Text = "";
                perYearUnderLabel.Text = "";
            }
            else if (country == "Time Period (t)")
            {
                showlabel.Text = "Where: t = (1/r)(A/P - 1)";
                Firstlabel.Text = "Total P+I (A): $";
                secondLabel.Text = "Principal (P): $";
                thirdLabel.Text = "Rate (R): %";
                perYearLabel.Text = "";
                perYearUnderLabel.Text = "per year";

            }
            else
            {

            }



        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(firstTextBox.Text) || string.IsNullOrWhiteSpace(secondTextBox.Text) || string.IsNullOrWhiteSpace(thirdTextBox.Text))
            {
                MessageBox.Show("Please Enter valid value");
            }
            else
            {
                first = Convert.ToInt32(firstTextBox.Text);
                    second = Convert.ToInt32(secondTextBox.Text);
                    third = Convert.ToInt32(thirdTextBox.Text);



                if (solveForcomboBox.Text == "Total P+I(A)")
                {
                    


                    if (timeComboBox.Text == "days (365/yr)")
                    {
                       

                        res = first * (1 + ((second / 100) * (third / 365)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "days (360/yr)")
                    {
                        

                        res = first * (1 + ((second / 100) * (third / 360)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "weeks")
                    {
                        

                        res = first * (1 + ((second / 100) * (third / 52)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "months")
                    {
               

                        res = first * (1 + ((second / 100) * (third / 12)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "quarters")
                    {
                       

                        res = first * (1 + ((second / 100) * (third / 4)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "years")
                    {
                        

                        res = first * (1 + ((second / 100) * (third / 1)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }

                    


                }
                else if (solveForcomboBox.Text == "Principal(P)")
                {
                   
                    if (timeComboBox.Text == "days (365/yr)")
                    {


                        res = first / (1 + ((second / 100) * (third / 365)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "days (360/yr)")
                    {


                        res = first / (1 + ((second / 100) * (third / 360)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "weeks")
                    {


                        res = first / (1 + ((second / 100) * (third / 52)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "months")
                    {


                        res = first / (1 + ((second / 100) * (third / 12)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "quarters")
                    {


                        res = first / (1 + ((second / 100) * (third / 4)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }
                    else if (timeComboBox.Text == "years")
                    {


                        res = first / (1 + ((second / 100) * (third / 1)));

                        resultTextBox.Text = Convert.ToString("$" + res);

                    }



                   


                }
                else if (solveForcomboBox.Text == "Rate(R)")
                {
                    


                    if (first>second)
                    {
                        res = 100*(1 / third)*((first / second) - 1);
                        if (timeComboBox.Text== "days (365/yr)")
                        {
                            resultTextBox.Text = Convert.ToString(res+"%/day");
                        }
                        else if (timeComboBox.Text == "days (360/yr)")
                        {
                            resultTextBox.Text = Convert.ToString(res + "%/day");
                        }
                        else if (timeComboBox.Text == "weeks")
                        {
                            resultTextBox.Text = Convert.ToString(res + "%/weeks");
                        }
                        else if (timeComboBox.Text == "months")
                        {
                            resultTextBox.Text = Convert.ToString(res + "%/months");
                        }
                        else if (timeComboBox.Text == "quarters")
                        {
                            resultTextBox.Text = Convert.ToString(res + "%/quarters");

                        }
                      else if (timeComboBox.Text == "years")
                        {
                            resultTextBox.Text = Convert.ToString(res + "%/years");
                        }


                    }
                    else
                    {
                        MessageBox.Show("A must be greater than P");
                    }



                    

                }
                else if (solveForcomboBox.Text == "Time Period (t)")
                {
                    
                  

                    if (first > second)
                    {
                        res = (1 / (third / 100)) * ((first / second) - 1);

                        resultTextBox.Text = Convert.ToString(res+" years");

                    }
                    else
                    {
                        MessageBox.Show("A must be greater than P");
                    }
                   


                }
                void cv()
                {
                    timeComboBox.Items.Clear();
                }

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = " ";

            firstTextBox.Text = " ";
            secondTextBox.Text = " ";
            thirdTextBox.Text = " ";

           

        }

        private void ClearBox()
        {
            firstTextBox.Clear();
            secondTextBox.Clear();
            thirdTextBox.Clear();
        }

     

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
